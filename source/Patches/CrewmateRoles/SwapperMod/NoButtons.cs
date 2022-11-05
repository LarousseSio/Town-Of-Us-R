using HarmonyLib;

namespace TownOfUs.CrewmateRoles.SwapperMod
{
    [HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.SetRole))]
    public class NoButtons
    {
        public static void Postfix()
        {
            if (!CustomGameOptions.SwapperButton)
                if (PlayerControl.LocalPlayer.Is(RoleEnum.换票师)) PlayerControl.LocalPlayer.RemainingEmergencies = 0;
        }
    }

    [HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.Start))]
    public class NoButtonsHost
    {
        public static void Postfix()
        {
            if (!CustomGameOptions.SwapperButton)
                if (PlayerControl.LocalPlayer.Is(RoleEnum.换票师)) PlayerControl.LocalPlayer.RemainingEmergencies = 0;
        }
    }
}