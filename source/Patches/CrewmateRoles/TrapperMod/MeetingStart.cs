using HarmonyLib;
using System;
using System.Linq;
using TownOfUs.Roles;

namespace TownOfUs.CrewmateRoles.TrapperMod
{
    [HarmonyPatch(typeof(MeetingHud), nameof(MeetingHud.Start))]
    public class MeetingStart
    {
        public static void Postfix(MeetingHud __instance)
        {
            if (PlayerControl.LocalPlayer.Data.IsDead) return;
            if (!PlayerControl.LocalPlayer.Is(RoleEnum.陷阱师)) return;
            var trapperRole = Role.GetRole<Trapper>(PlayerControl.LocalPlayer);
            if (trapperRole.trappedPlayers.Count == 0)
            { 
                DestroyableSingleton<HudManager>.Instance.Chat.AddChat(PlayerControl.LocalPlayer, "还没有人触发你的陷阱");
                return;
            }
            if (trapperRole.trappedPlayers.Count < CustomGameOptions.MinAmountOfPlayersInTrap)
            {
                DestroyableSingleton<HudManager>.Instance.Chat.AddChat(PlayerControl.LocalPlayer, "触发陷阱的玩家数不足");
                return;
            }

            string message = "触发陷阱的职业:\n";
            foreach (RoleEnum role in trapperRole.trappedPlayers.OrderBy(x=> Guid.NewGuid()))
            {
                message += $" {role},";
            }
            message.Remove(message.Length - 1, 1);
            if (DestroyableSingleton<HudManager>.Instance)
                DestroyableSingleton<HudManager>.Instance.Chat.AddChat(PlayerControl.LocalPlayer, message);
        }
    }
}
