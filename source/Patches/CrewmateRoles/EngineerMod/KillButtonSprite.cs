using System.Linq;
using HarmonyLib;
using TownOfUs.Roles;
using UnityEngine;

namespace TownOfUs.CrewmateRoles.EngineerMod
{
    [HarmonyPatch(typeof(HudManager))]
    public class KillButtonSprite
    {
        private static Sprite Sprite => TownOfUs.EngineerFix;


        [HarmonyPatch(nameof(HudManager.Update))]
        public static void Postfix(HudManager __instance)
        {
            if (PlayerControl.AllPlayerControls.Count <= 1) return;
            if (PlayerControl.LocalPlayer == null) return;
            if (PlayerControl.LocalPlayer.Data == null) return;
            if (!PlayerControl.LocalPlayer.Is(RoleEnum.工程师)) return;
            if (__instance.KillButton == null) return;

            var role = Role.GetRole<Engineer>(PlayerControl.LocalPlayer);
            
            __instance.KillButton.graphic.sprite = Sprite;
            __instance.KillButton.SetCoolDown(0f, 10f);
            __instance.KillButton.gameObject.SetActive(!PlayerControl.LocalPlayer.Data.IsDead &&
                                                       __instance.UseButton.isActiveAndEnabled && !MeetingHud.Instance);
            if (PlayerControl.LocalPlayer.Data.IsDead) return;
            if (!ShipStatus.Instance) return;
            var system = ShipStatus.Instance.Systems[SystemTypes.Sabotage].Cast<SabotageSystemType>();
            if (system == null) return;
            var specials = system.specials.ToArray();
            var dummyActive = system.dummy.IsActive;
            var sabActive = specials.Any(s => s.IsActive);
            var renderer = __instance.KillButton.graphic;
            if (sabActive & !dummyActive & !role.UsedThisRound & __instance.KillButton.enabled)
            {
                renderer.color = Palette.EnabledColor;
                renderer.material.SetFloat("_Desat", 0f);
                return;
            }

            renderer.color = Palette.DisabledClear;
            renderer.material.SetFloat("_Desat", 1f);
        }
    }
}