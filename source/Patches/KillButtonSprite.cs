using HarmonyLib;
using UnityEngine;

namespace TownOfUs
{
    [HarmonyPatch(typeof(KillButton), nameof(KillButton.Start))]
    public static class KillButtonAwake
    {
        public static void Prefix(KillButton __instance)
        {
            __instance.transform.Find("Text_TMP").gameObject.SetActive(false);
        }
    }
    
    [HarmonyPatch(typeof(HudManager), nameof(HudManager.Update))]
    public class KillButtonSprite
    {
        private static Sprite Rewind => TownOfUs.Rewind;
        private static Sprite Medic => TownOfUs.MedicSprite;
        private static Sprite Seer => TownOfUs.SeerSprite;
        private static Sprite Douse => TownOfUs.DouseSprite;
        private static Sprite Revive => TownOfUs.ReviveSprite;
        private static Sprite Alert => TownOfUs.AlertSprite;
        private static Sprite Remember => TownOfUs.RememberSprite;
        private static Sprite Track => TownOfUs.TrackSprite;
        private static Sprite Transport => TownOfUs.TransportSprite;
        private static Sprite Mediate => TownOfUs.MediateSprite;
        private static Sprite Vest => TownOfUs.VestSprite;
        private static Sprite Protect => TownOfUs.ProtectSprite;
        private static Sprite Infect => TownOfUs.InfectSprite;
        private static Sprite Trap => TownOfUs.TrapSprite;
        private static Sprite Examine => TownOfUs.ExamineSprite;
        private static Sprite Kill;


        public static void Postfix(HudManager __instance)
        {
            if (__instance.KillButton == null) return;

            if (!Kill) Kill = __instance.KillButton.graphic.sprite;

            var flag = false;
            if (PlayerControl.LocalPlayer.Is(RoleEnum.时间领主))
            {
                __instance.KillButton.graphic.sprite = Rewind;
                flag = true;
            }
            else if (PlayerControl.LocalPlayer.Is(RoleEnum.预言家))
            {
                __instance.KillButton.graphic.sprite = Seer;
                flag = true;
            }
            else if (PlayerControl.LocalPlayer.Is(RoleEnum.法医))
            {
                __instance.KillButton.graphic.sprite = Medic;
                flag = true;
            }
            else if (PlayerControl.LocalPlayer.Is(RoleEnum.纵火狂))
            {
                __instance.KillButton.graphic.sprite = Douse;
                flag = true;
            }
            else if (PlayerControl.LocalPlayer.Is(RoleEnum.殉道者))
            {
                __instance.KillButton.graphic.sprite = Revive;
                flag = true;
            }
            else if (PlayerControl.LocalPlayer.Is(RoleEnum.老兵))
            {
                __instance.KillButton.graphic.sprite = Alert;
                flag = true;
            }
            else if (PlayerControl.LocalPlayer.Is(RoleEnum.失忆者))
            {
                __instance.KillButton.graphic.sprite = Remember;
                flag = true;
            }
            else if (PlayerControl.LocalPlayer.Is(RoleEnum.追踪者))
            {
                __instance.KillButton.graphic.sprite = Track;
                flag = true;
            }
            else if (PlayerControl.LocalPlayer.Is(RoleEnum.传送师))
            {
                __instance.KillButton.graphic.sprite = Transport;
                flag = true;
            }
            else if (PlayerControl.LocalPlayer.Is(RoleEnum.招魂师))
            {
                __instance.KillButton.graphic.sprite = Mediate;
                flag = true;
            }
            else if (PlayerControl.LocalPlayer.Is(RoleEnum.幸存者))
            {
                __instance.KillButton.graphic.sprite = Vest;
                flag = true;
            }
            else if (PlayerControl.LocalPlayer.Is(RoleEnum.守护天使))
            {
                __instance.KillButton.graphic.sprite = Protect;
                flag = true;
            }
            else if (PlayerControl.LocalPlayer.Is(RoleEnum.瘟疫之源))
            {
                __instance.KillButton.graphic.sprite = Infect;
                flag = true;
            }
            else if (PlayerControl.LocalPlayer.Is(RoleEnum.工程师))
            {
                flag = true;
            }
            else if (PlayerControl.LocalPlayer.Is(RoleEnum.陷阱师)) {
                __instance.KillButton.graphic.sprite = Trap;
                flag = true;
            }
            else if (PlayerControl.LocalPlayer.Is(RoleEnum.侧写师))
            {
                __instance.KillButton.graphic.sprite = Examine;
                flag = true;
            }
            else
            {
                __instance.KillButton.graphic.sprite = Kill;
                __instance.KillButton.buttonLabelText.gameObject.SetActive(true);
                __instance.KillButton.buttonLabelText.text = "击杀";
                flag = PlayerControl.LocalPlayer.Is(RoleEnum.警长) || PlayerControl.LocalPlayer.Is(RoleEnum.万疫之神) ||
                    PlayerControl.LocalPlayer.Is(RoleEnum.月下狼人) || PlayerControl.LocalPlayer.Is(RoleEnum.天启);
            }

            var keyInt = Input.GetKeyInt(KeyCode.Q);
            var controller = ConsoleJoystick.player.GetButtonDown(8);
            if (keyInt | controller && __instance.KillButton != null && flag && !PlayerControl.LocalPlayer.Data.IsDead)
                __instance.KillButton.DoClick();
        }
    }
}
