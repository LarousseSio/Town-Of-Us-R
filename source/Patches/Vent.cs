using HarmonyLib;
using Reactor;
using System.Linq;
using TownOfUs.Extensions;
using TownOfUs.Roles;
using UnityEngine;

namespace TownOfUs
{
    [HarmonyPatch(typeof(HudManager))]
    public static class HudManagerVentPatch
    {
        [HarmonyPatch(nameof(HudManager.Update))]
        public static void Postfix(HudManager __instance)
        {
            if(__instance.ImpostorVentButton == null || __instance.ImpostorVentButton.gameObject == null || __instance.ImpostorVentButton.IsNullOrDestroyed())
                return;

            bool active = PlayerControl.LocalPlayer != null && VentPatches.CanVent(PlayerControl.LocalPlayer, PlayerControl.LocalPlayer._cachedData) && !MeetingHud.Instance;
            if(active != __instance.ImpostorVentButton.gameObject.active)
            __instance.ImpostorVentButton.gameObject.SetActive(active);
        }
    }

    [HarmonyPatch(typeof(Vent), nameof(Vent.CanUse))]
    public static class VentPatches
    {
        private static bool CheckUndertaker(PlayerControl player)
        {
            var role = Role.GetRole<Undertaker>(player);
            return player.Data.IsDead || role.CurrentlyDragging != null;
        }

        public static bool CanVent(PlayerControl player, GameData.PlayerInfo playerInfo)
        { 
            if (player.inVent)
                return true;

            if (playerInfo.IsDead)
                return false;

            if (player.Is(RoleEnum.化形者) && !CustomGameOptions.MorphlingVent
                || player.Is(RoleEnum.隐身人) && !CustomGameOptions.SwooperVent
                || player.Is(RoleEnum.掷弹兵) && !CustomGameOptions.GrenadierVent
                || player.Is(RoleEnum.送葬者) && !CustomGameOptions.UndertakerVent
                || player.Is(RoleEnum.绝命毒师) && !CustomGameOptions.PoisonerVent
                || player.Is(RoleEnum.逃逸者) && !CustomGameOptions.EscapistVent
                || (player.Is(RoleEnum.送葬者) && Role.GetRole<Undertaker>(player).CurrentlyDragging != null && !CustomGameOptions.UndertakerVentWithBody))
                return false;

            if (player.Is(RoleEnum.工程师) || (player.roleAssigned && playerInfo.Role?.Role == RoleTypes.Engineer) ||
                (player.Is(RoleEnum.混沌) && CustomGameOptions.GlitchVent) || (player.Is(RoleEnum.天启) && CustomGameOptions.GlitchVent) ||
                (player.Is(RoleEnum.万疫之神) && CustomGameOptions.PestVent) || (player.Is(RoleEnum.小丑) && CustomGameOptions.JesterVent))
                return true;

            if (player.Is(RoleEnum.月下狼人) && CustomGameOptions.WerewolfVent)
            {
                var role = Role.GetRole<Werewolf>(PlayerControl.LocalPlayer);
                if (role.Rampaged) return true;
            }

            return playerInfo.IsImpostor();
        }

        public static void Postfix(Vent __instance,
            [HarmonyArgument(0)] GameData.PlayerInfo playerInfo,
            [HarmonyArgument(1)] ref bool canUse,
            [HarmonyArgument(2)] ref bool couldUse,
            ref float __result)
        {
            float num = float.MaxValue;
            PlayerControl playerControl = playerInfo.Object;
            couldUse = CanVent(playerControl, playerInfo) && !playerControl.MustCleanVent(__instance.Id) && (!playerInfo.IsDead || playerControl.inVent) && (playerControl.CanMove || playerControl.inVent);
            var ventitaltionSystem = ShipStatus.Instance.Systems[SystemTypes.Ventilation].Cast<VentilationSystem>();
            if (ventitaltionSystem != null && ventitaltionSystem.PlayersCleaningVents != null)
            {
                foreach (var item in ventitaltionSystem.PlayersCleaningVents.Values)
                {
                    if (item == __instance.Id)
                        couldUse = false;
                }

            }
            canUse = couldUse;

            if (Patches.SubmergedCompatibility.isSubmerged())
            {
                if (Patches.SubmergedCompatibility.getInTransition())
                {
                    __result = float.MaxValue;
                    return;
                }
                switch (__instance.Id)
                {
                    case 9:  //Engine Room Exit Only Vent
                        if (PlayerControl.LocalPlayer.inVent) break;
                        __result = float.MaxValue;
                        return;
                    case 14: // Lower Central
                        __result = float.MaxValue;
                        if (canUse)
                        {
                            Vector3 center = playerControl.Collider.bounds.center;
                            Vector3 position = __instance.transform.position;
                            __result = Vector2.Distance(center, position);
                            canUse &= __result <= __instance.UsableDistance;
                        }
                        return;
                }
            }

            if (canUse)
            {
                Vector3 center = playerControl.Collider.bounds.center;
                Vector3 position = __instance.transform.position;
                num = Vector2.Distance((Vector2)center, (Vector2)position);
                canUse = ((canUse ? 1 : 0) & ((double)num > (double)__instance.UsableDistance ? 0 : (!PhysicsHelpers.AnythingBetween(playerControl.Collider, (Vector2)center, (Vector2)position, Constants.ShipOnlyMask, false) ? 1 : 0))) != 0;
            }

            __result = num;

        }
    }

    [HarmonyPatch(typeof(Vent), nameof(Vent.SetButtons))]
    public static class JesterEnterVent
    {
        public static bool Prefix(Vent __instance)
        {
            if (PlayerControl.LocalPlayer.Is(RoleEnum.小丑) && CustomGameOptions.JesterVent)
                return false;
            return true;
        }
    }
}