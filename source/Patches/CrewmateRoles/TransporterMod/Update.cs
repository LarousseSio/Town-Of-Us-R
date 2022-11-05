using System.Linq;
using HarmonyLib;
using InnerNet;
using TownOfUs.Roles;
using UnityEngine;

namespace TownOfUs.CrewmateRoles.TransporterMod
{
    [HarmonyPatch(typeof(HudManager), nameof(HudManager.Update))]
    public class Update
    {
        private static void Postfix(HudManager __instance)
        {
            if (PlayerControl.AllPlayerControls.Count <= 1) return;
            if (PlayerControl.LocalPlayer == null) return;
            if (PlayerControl.LocalPlayer.Data == null) return;
            if (!PlayerControl.LocalPlayer.Is(RoleEnum.传送师)) return;
            var role = Role.GetRole<Transporter>(PlayerControl.LocalPlayer);
            if (AmongUsClient.Instance.GameState == InnerNetClient.GameStates.Started)
                if (role != null)
                    if (PlayerControl.LocalPlayer.Is(RoleEnum.传送师))
                        Role.GetRole<Transporter>(PlayerControl.LocalPlayer).Update(__instance);
        }
    }
}