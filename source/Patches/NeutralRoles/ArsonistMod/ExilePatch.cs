using HarmonyLib;
using Hazel;
using TownOfUs.Roles;
using System.Linq;
using TownOfUs.CrewmateRoles.InvestigatorMod;
using TownOfUs.CrewmateRoles.SnitchMod;
using TownOfUs.Extensions;
using UnityEngine;
using Reactor;

namespace TownOfUs.NeutralRoles.ArsonistMod
{
    [HarmonyPatch(typeof(AirshipExileController), nameof(AirshipExileController.WrapUpAndSpawn))]
    public static class AirshipExileController_WrapUpAndSpawn
    {
        public static void Postfix(AirshipExileController __instance) => SetLastKillerBool.ExileControllerPostfix(__instance);
    }
    
    [HarmonyPatch(typeof(ExileController), nameof(ExileController.WrapUp))]
    public class SetLastKillerBool
    {

        public static void ExileControllerPostfix(ExileController __instance)
        {
            var exiled = __instance.exiled?.Object;
            if (!PlayerControl.LocalPlayer.Is(RoleEnum.纵火狂)) return;
            var alives = PlayerControl.AllPlayerControls.ToArray()
                    .Where(x => !x.Data.IsDead && !x.Data.Disconnected).ToList();
            foreach (var player in alives)
            {
                if (player.Data.IsImpostor() || player.Is(RoleEnum.混沌) || player.Is(RoleEnum.天启)
                    || player.Is(RoleEnum.瘟疫之源) || player.Is(RoleEnum.万疫之神) || player.Is(RoleEnum.月下狼人))
                {
                    return;
                }
            }
            var role = Role.GetRole<Arsonist>(PlayerControl.LocalPlayer);
            role.LastKiller = true;
            return;
        }

        public static void Postfix(ExileController __instance) => ExileControllerPostfix(__instance);
    }
}