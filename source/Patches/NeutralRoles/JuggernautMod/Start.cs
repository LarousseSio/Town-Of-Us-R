using System;
using HarmonyLib;
using TownOfUs.Roles;

namespace TownOfUs.NeutralRoles.JuggernautMod
{
    [HarmonyPatch(typeof(IntroCutscene._CoBegin_d__19), nameof(IntroCutscene._CoBegin_d__19.MoveNext))]
    public static class Start
    {
        public static void Postfix(IntroCutscene._CoBegin_d__19 __instance)
        {
            foreach (var role in Role.GetRoles(RoleEnum.天启))
            {
                var juggernaut = (Juggernaut)role;
                juggernaut.LastKill = DateTime.UtcNow;
                juggernaut.LastKill = juggernaut.LastKill.AddSeconds(CustomGameOptions.InitialCooldowns - 5.0f - CustomGameOptions.GlitchKillCooldown);
            }
        }
    }
}