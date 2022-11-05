using System.Linq;
using HarmonyLib;
using TownOfUs.Extensions;
using TownOfUs.Roles;
using UnityEngine;

namespace TownOfUs.CrewmateRoles.SeerMod
{
    [HarmonyPatch(typeof(HudManager), nameof(HudManager.Update))]
    public class Update
    {
        public static string NameText(PlayerControl player, string str = "", bool meeting = false)
        {
            if (CamouflageUnCamouflage.IsCamoed)
            {
                if (meeting) return player.name + str;

                return "";
            }

            return player.name + str;
        }

        private static void UpdateMeeting(MeetingHud __instance, Seer seer)
        {
            foreach (var player in PlayerControl.AllPlayerControls)
            {
                if (!seer.Investigated.Contains(player.PlayerId)) continue;
                foreach (var state in __instance.playerStates)
                {
                    if (player.PlayerId != state.TargetPlayerId) continue;
                    var roleType = Utils.GetRole(player);
                    switch (roleType)
                    {
                        default:
                            if ((player.Is(Faction.Crewmates) && !(player.Is(RoleEnum.警长) || player.Is(RoleEnum.老兵) || player.Is(RoleEnum.侠客))) ||
                            ((player.Is(RoleEnum.警长) || player.Is(RoleEnum.老兵) || player.Is(RoleEnum.侠客)) && !CustomGameOptions.CrewKillingRed) ||
                            ((player.Is(RoleEnum.失忆者) || player.Is(RoleEnum.幸存者) || player.Is(RoleEnum.守护天使)) && !CustomGameOptions.NeutBenignRed) ||
                            ((player.Is(RoleEnum.行刑者) || player.Is(RoleEnum.小丑) || player.Is(RoleEnum.幻影)) && !CustomGameOptions.NeutEvilRed) ||
                            ((player.Is(RoleEnum.纵火狂) || player.Is(RoleEnum.混沌) || player.Is(RoleEnum.天启) ||
                            player.Is(RoleEnum.瘟疫之源) || player.Is(RoleEnum.万疫之神) || player.Is(RoleEnum.月下狼人)) && !CustomGameOptions.NeutKillingRed))
                            {
                                state.NameText.color = Color.green;
                            }
                            else if (player.Is(RoleEnum.背叛者) && CustomGameOptions.TraitorColourSwap)
                            {
                                foreach (var role in Role.GetRoles(RoleEnum.背叛者))
                                {
                                    var traitor = (Traitor)role;
                                    if (traitor.formerRole == RoleEnum.警长 || traitor.formerRole == RoleEnum.侠客 ||
                                        traitor.formerRole == RoleEnum.老兵) state.NameText.color = Color.red;
                                    else state.NameText.color = Color.green;
                                }
                            }
                            else
                            {
                                state.NameText.color = Color.red;
                            }
                            break;
                    }
                }
            }
        }

        [HarmonyPriority(Priority.Last)]
        private static void Postfix(HudManager __instance)

        {
            if (PlayerControl.AllPlayerControls.Count <= 1) return;
            if (PlayerControl.LocalPlayer == null) return;
            if (PlayerControl.LocalPlayer.Data == null) return;
            if (PlayerControl.LocalPlayer.Data.IsDead) return;

            if (!PlayerControl.LocalPlayer.Is(RoleEnum.预言家)) return;
            var seer = Role.GetRole<Seer>(PlayerControl.LocalPlayer);
            if (MeetingHud.Instance != null) UpdateMeeting(MeetingHud.Instance, seer);


            foreach (var player in PlayerControl.AllPlayerControls)
            {
                if (!seer.Investigated.Contains(player.PlayerId)) continue;
                var roleType = Utils.GetRole(player);
                player.nameText().transform.localPosition = new Vector3(0f, 2f, -0.5f);
                switch (roleType)
                {
                    default:
                        if ((player.Is(Faction.Crewmates) && !(player.Is(RoleEnum.警长) || player.Is(RoleEnum.老兵) || player.Is(RoleEnum.侠客))) ||
                            ((player.Is(RoleEnum.警长) || player.Is(RoleEnum.老兵) || player.Is(RoleEnum.侠客)) && !CustomGameOptions.CrewKillingRed) ||
                            ((player.Is(RoleEnum.失忆者) || player.Is(RoleEnum.幸存者) || player.Is(RoleEnum.守护天使)) && !CustomGameOptions.NeutBenignRed) ||
                            ((player.Is(RoleEnum.行刑者) || player.Is(RoleEnum.小丑) || player.Is(RoleEnum.幻影)) && !CustomGameOptions.NeutEvilRed) ||
                            ((player.Is(RoleEnum.纵火狂) || player.Is(RoleEnum.混沌) || player.Is(RoleEnum.天启) ||
                            player.Is(RoleEnum.瘟疫之源) || player.Is(RoleEnum.万疫之神) || player.Is(RoleEnum.月下狼人)) && !CustomGameOptions.NeutKillingRed))
                        {
                            player.nameText().color = Color.green;
                        }
                        else if (player.Is(RoleEnum.背叛者) && CustomGameOptions.TraitorColourSwap)
                        {
                            foreach (var role in Role.GetRoles(RoleEnum.背叛者))
                            {
                                var traitor = (Traitor)role;
                                if (traitor.formerRole == RoleEnum.警长 || traitor.formerRole == RoleEnum.侠客 ||
                                    traitor.formerRole == RoleEnum.老兵) player.nameText().color = Color.red;
                                else player.nameText().color = Color.green;
                            }
                        }
                        else
                        {
                            player.nameText().color = Color.red;
                        }
                        break;
                }
            }
        }
    }
}