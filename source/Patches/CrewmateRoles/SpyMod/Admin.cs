using System.Collections.Generic;
using HarmonyLib;
using UnityEngine;

namespace TownOfUs.CrewmateRoles.SpyMod
{
    [HarmonyPatch(typeof(MapCountOverlay), nameof(MapCountOverlay.Update))]
    public static class Admin
    {
        public static void SetSabotaged(MapCountOverlay __instance, bool sabotaged)
        {
            __instance.isSab = sabotaged;
            __instance.BackgroundColor.SetColor(sabotaged ? Palette.DisabledGrey : Color.green);
            __instance.SabotageText.gameObject.SetActive(sabotaged);
            if (sabotaged)
                foreach (var area in __instance.CountAreas)
                    area.UpdateCount(0);
        }

        public static void UpdateBlips(CounterArea area, List<int> colorMapping)
        {
            area.UpdateCount(colorMapping.Count);
            var icons = area.myIcons.ToArray();
            colorMapping.Sort();
            for (var i = 0;i < colorMapping.Count;i++)
            {
                var icon = icons[i];
                var sprite = icon.GetComponent<SpriteRenderer>();
                if (Patches.SubmergedCompatibility.Loaded)
                {
                    sprite.color = new Color(1, 1, 1, 1);
                }
                if (sprite != null)
                {
                    //PlayerControl.SetPlayerMaterialColors(colorMapping[i], sprite);
                    PlayerMaterial.SetColors(colorMapping[i], sprite);
                }
            }
        }

        public static void UpdateBlips(MapCountOverlay __instance)
        {
            var rooms = ShipStatus.Instance.FastRooms;
            foreach (var area in __instance.CountAreas)
            {
                if (!rooms.ContainsKey(area.RoomType)) continue;
                var room = rooms[area.RoomType];
                if (room.roomArea == null) continue;
                var objectsInRoom = room.roomArea.OverlapCollider(__instance.filter, __instance.buffer);
                var colorMap = new List<int>();
                for (var i = 0;i < objectsInRoom;i++)
                {
                    var collider = __instance.buffer[i];
                    if (collider.tag == "DeadBody")
                    {
                        var playerId = collider.GetComponent<DeadBody>().ParentId;
                        colorMap.Add(GameData.Instance.GetPlayerById(playerId).DefaultOutfit.ColorId);
                        continue;
                    }
                    var player = collider.GetComponent<PlayerControl>();
                    var data = player?.Data;
                    if (data != null && !data.Disconnected && !data.IsDead)
                        colorMap.Add(data.DefaultOutfit.ColorId);
                }
                UpdateBlips(area, colorMap);
            }
        }

        public static bool Prefix(MapCountOverlay __instance)
        {
            var localPlayer = PlayerControl.LocalPlayer;
            if (!localPlayer.Is(RoleEnum.特工)) return true;
            __instance.timer += Time.deltaTime;
            if (__instance.timer < 0.1f) return false;

            __instance.timer = 0f;

            var sabotaged = PlayerTask.PlayerHasTaskOfType<IHudOverrideTask>(localPlayer);

            if (sabotaged != __instance.isSab)
                SetSabotaged(__instance, sabotaged);

            if (!sabotaged)
                UpdateBlips(__instance);
            return false;
        }
    }
}