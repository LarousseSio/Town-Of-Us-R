using HarmonyLib;
using TownOfUs.Roles;

namespace TownOfUs.NeutralRoles.PlaguebearerMod
{
    [HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.CmdReportDeadBody))]
    public class BodyReport
    {
        private static void Postfix(PlayerControl __instance, [HarmonyArgument(0)] GameData.PlayerInfo info)
        {
            if (PlayerControl.AllPlayerControls.Count <= 1) return;
            if (PlayerControl.LocalPlayer == null) return;
            if (PlayerControl.LocalPlayer.Data == null) return;

            foreach (var player in PlayerControl.AllPlayerControls)
            {
                if (player.PlayerId == info.PlayerId)
                {
                    if (PlayerControl.LocalPlayer.IsInfected() || player.IsInfected())
                    {
                        foreach (var pb in Role.GetRoles(RoleEnum.瘟疫之源)) ((Plaguebearer)pb).RpcSpreadInfection(PlayerControl.LocalPlayer, player);
                    }
                }
            }
        }
    }
}