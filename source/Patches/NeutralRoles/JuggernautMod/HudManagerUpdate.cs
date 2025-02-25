using System.Linq;
using HarmonyLib;
using TownOfUs.Roles;
using UnityEngine;
using Hazel;

namespace TownOfUs.NeutralRoles.JuggernautMod
{
    [HarmonyPatch(typeof(HudManager), nameof(HudManager.Update))]
    public static class HudManagerUpdate
    {
        public static void Postfix(HudManager __instance)
        {
            if (PlayerControl.AllPlayerControls.Count <= 1) return;
            if (PlayerControl.LocalPlayer == null) return;
            if (PlayerControl.LocalPlayer.Data == null) return;
            if (!PlayerControl.LocalPlayer.Is(RoleEnum.天启)) return;
            var role = Role.GetRole<Juggernaut>(PlayerControl.LocalPlayer);

            __instance.KillButton.gameObject.SetActive(!PlayerControl.LocalPlayer.Data.IsDead && !MeetingHud.Instance);

            __instance.KillButton.SetCoolDown(role.KillTimer(), CustomGameOptions.GlitchKillCooldown + 5.0f - 5.0f * role.JuggKills);

            Utils.SetTarget(ref role.ClosestPlayer, __instance.KillButton);
        }
    }
}