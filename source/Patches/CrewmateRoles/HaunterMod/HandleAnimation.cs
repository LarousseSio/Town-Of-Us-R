using HarmonyLib;
using TownOfUs.Roles;

namespace TownOfUs.CrewmateRoles.HaunterMod
{
    [HarmonyPatch(typeof(PlayerPhysics), nameof(PlayerPhysics.HandleAnimation))]
    public class HandleAnimation
    {
        public static void Prefix(PlayerPhysics __instance, [HarmonyArgument(0)] ref bool amDead)
        {
            if (__instance.myPlayer.Is(RoleEnum.冤魂)) amDead = Role.GetRole<Haunter>(__instance.myPlayer).Caught;
        }
    }
}