using System.Linq;
using HarmonyLib;
using TownOfUs.Roles;
using UnityEngine;
using Hazel;
using TownOfUs.Extensions;

namespace TownOfUs.NeutralRoles.PlaguebearerMod
{
    [HarmonyPatch(typeof(HudManager), nameof(HudManager.Update))]
    public static class HudManagerUpdate
    {
        public static void Postfix(HudManager __instance)
        {
            if (PlayerControl.AllPlayerControls.Count <= 1) return;
            if (PlayerControl.LocalPlayer == null) return;
            if (PlayerControl.LocalPlayer.Data == null) return;
            if (!PlayerControl.LocalPlayer.Is(RoleEnum.瘟疫之源)) return;
            var isDead = PlayerControl.LocalPlayer.Data.IsDead;
            var infectButton = DestroyableSingleton<HudManager>.Instance.KillButton;
            var role = Role.GetRole<Plaguebearer>(PlayerControl.LocalPlayer);

            foreach (var playerId in role.InfectedPlayers)
            {
                var player = Utils.PlayerById(playerId);
                var data = player?.Data;
                if (data == null || data.Disconnected || data.IsDead || PlayerControl.LocalPlayer.Data.IsDead || playerId == PlayerControl.LocalPlayer.PlayerId)
                    continue;

                player.myRend().material.SetColor("_VisorColor", role.Color);
                player.nameText().color = Color.black;
            }

            if (isDead)
            {
                infectButton.gameObject.SetActive(false);
            }
            else
            {
                infectButton.gameObject.SetActive(!MeetingHud.Instance);
                infectButton.SetCoolDown(role.InfectTimer(), CustomGameOptions.InfectCd);

                var notInfected = PlayerControl.AllPlayerControls.ToArray().Where(
                    player => !role.InfectedPlayers.Contains(player.PlayerId)
                ).ToList();

                Utils.SetTarget(ref role.ClosestPlayer, __instance.KillButton, float.NaN, notInfected);
            }

            if (role.CanTransform && (PlayerControl.AllPlayerControls.ToArray().Where(x => !x.Data.IsDead && !x.Data.Disconnected).ToList().Count > 1) && !isDead)
            {
                var transform = false;
                var alives = PlayerControl.AllPlayerControls.ToArray().Where(x => !x.Data.IsDead && !x.Data.Disconnected).ToList();
                if (alives.Count == 2)
                {
                    foreach (var player in alives)
                    {
                        if (player.Data.IsImpostor() || player.Is(RoleEnum.混沌) || player.Is(RoleEnum.天启)
                            || player.Is(RoleEnum.纵火狂) || player.Is(RoleEnum.月下狼人))
                        {
                            transform = true;
                        }
                    }
                }
                else transform = true;
                if (transform)
                {
                    role.TurnPestilence();
                    var writer = AmongUsClient.Instance.StartRpcImmediately(PlayerControl.LocalPlayer.NetId,
                        (byte)CustomRPC.TurnPestilence, SendOption.Reliable, -1);
                    writer.Write(PlayerControl.LocalPlayer.PlayerId);
                    AmongUsClient.Instance.FinishRpcImmediately(writer);
                }
            }
        }
    }
}