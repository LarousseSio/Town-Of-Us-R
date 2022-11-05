using HarmonyLib;
using Reactor.Utilities;
using TownOfUs.Extensions;
using TownOfUs.Roles;
using UnityEngine;

namespace TownOfUs.CrewmateRoles.MedicMod
{
    [HarmonyPatch(typeof(KillButton), nameof(KillButton.DoClick))]
    public class StopKill
    {
        public static void BreakShield(byte medicId, byte playerId, bool flag)
        {
            if (PlayerControl.LocalPlayer.PlayerId == playerId &&
                CustomGameOptions.NotificationShield == NotificationOptions.Shielded)
                Coroutines.Start(Utils.FlashCoroutine(new Color(0f, 0.5f, 0f, 1f)));

            if (PlayerControl.LocalPlayer.PlayerId == medicId &&
                CustomGameOptions.NotificationShield == NotificationOptions.Medic)
                Coroutines.Start(Utils.FlashCoroutine(new Color(0f, 0.5f, 0f, 1f)));

            if (CustomGameOptions.NotificationShield == NotificationOptions.Everyone)
                Coroutines.Start(Utils.FlashCoroutine(new Color(0f, 0.5f, 0f, 1f)));

            if (!flag)
                return;

            var player = Utils.PlayerById(playerId);
            foreach (var role in Role.GetRoles(RoleEnum.法医))
                if (((Medic) role).ShieldedPlayer.PlayerId == playerId)
                {
                    ((Medic) role).ShieldedPlayer = null;
                    ((Medic) role).exShielded = player;
                    System.Console.WriteLine(player.name + " 的护盾消失了");
                }

            player.myRend().material.SetColor("_VisorColor", Palette.VisorColor);
            player.myRend().material.SetFloat("_Outline", 0f);
        }
    }
}