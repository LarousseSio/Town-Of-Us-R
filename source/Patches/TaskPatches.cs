using HarmonyLib;
using TownOfUs.Extensions;
using UnityEngine;

namespace TownOfUs
{
    internal static class TaskPatches
    {
        [HarmonyPatch(typeof(GameData), nameof(GameData.RecomputeTaskCounts))]
        private class GameData_RecomputeTaskCounts
        {
            private static bool Prefix(GameData __instance)
            {
                __instance.TotalTasks = 0;
                __instance.CompletedTasks = 0;
                for (var i = 0; i < __instance.AllPlayers.Count; i++)
                {
                    var playerInfo = __instance.AllPlayers.ToArray()[i];
                    if (!playerInfo.Disconnected && playerInfo.Tasks != null && playerInfo.Object &&
                        (PlayerControl.GameOptions.GhostsDoTasks || !playerInfo.IsDead) && !playerInfo.IsImpostor() &&
                        !(
                            playerInfo._object.Is(RoleEnum.小丑) || playerInfo._object.Is(RoleEnum.失忆者) ||
                            playerInfo._object.Is(RoleEnum.幸存者) || playerInfo._object.Is(RoleEnum.守护天使) ||
                            playerInfo._object.Is(RoleEnum.混沌) || playerInfo._object.Is(RoleEnum.行刑者) ||
                            playerInfo._object.Is(RoleEnum.纵火狂) || playerInfo._object.Is(RoleEnum.天启) ||
                            playerInfo._object.Is(RoleEnum.瘟疫之源) || playerInfo._object.Is(RoleEnum.万疫之神) ||
                            playerInfo._object.Is(RoleEnum.月下狼人) ||
                            playerInfo._object.Is(RoleEnum.幻影) || playerInfo._object.Is(RoleEnum.冤魂)
                        ))
                        for (var j = 0; j < playerInfo.Tasks.Count; j++)
                        {
                            __instance.TotalTasks++;
                            if (playerInfo.Tasks.ToArray()[j].Complete) __instance.CompletedTasks++;
                        }
                }

                return false;
            }
        }

        [HarmonyPatch(typeof(Console), nameof(Console.CanUse))]
        private class Console_CanUse
        {
            private static bool Prefix(Console __instance, [HarmonyArgument(0)] GameData.PlayerInfo playerInfo, ref float __result)
            {
                var playerControl = playerInfo.Object;

                var flag = playerControl.Is(RoleEnum.混沌)
                           || playerControl.Is(RoleEnum.小丑)
                           || playerControl.Is(RoleEnum.行刑者)
                           || playerControl.Is(RoleEnum.天启)
                           || playerControl.Is(RoleEnum.纵火狂)
                           || playerControl.Is(RoleEnum.瘟疫之源)
                           || playerControl.Is(RoleEnum.万疫之神)
                           || playerControl.Is(RoleEnum.月下狼人);

                // If the console is not a sabotage repair console
                if (flag && !__instance.AllowImpostor)
                {
                    __result = float.MaxValue;
                    return false;
                }

                return true;
            }
        }
    }
}