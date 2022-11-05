using HarmonyLib;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.Linq;
using Reactor.Utilities.Extensions;
using TownOfUs.Roles;

namespace TownOfUs.Patches {

    static class AdditionalTempData {
        public static List<PlayerRoleInfo> playerRoles = new List<PlayerRoleInfo>();

        public static void clear() {
            playerRoles.Clear();
        }

        internal class PlayerRoleInfo {
            public string PlayerName { get; set; }
            public string Role {get;set;}
        }
    }


    [HarmonyPatch(typeof(AmongUsClient), nameof(AmongUsClient.OnGameEnd))]
    public class OnGameEndPatch {

        public static void Postfix(AmongUsClient __instance, [HarmonyArgument(0)] EndGameResult endGameResult)
        {
            AdditionalTempData.clear();
            var playerRole = "";
            // Theres a better way of doing this e.g. switch statement or dictionary. But this works for now.
            foreach (var playerControl in PlayerControl.AllPlayerControls)
            {
                playerRole = "";
                foreach (var role in Role.RoleHistory.Where(x => x.Key == playerControl.PlayerId))
                {
                    if (role.Value == RoleEnum.船员) {playerRole += "<color=#"+Patches.Colors.Crewmate.ToHtmlStringRGBA()+">船员</color> > ";}
                    else if (role.Value == RoleEnum.伪装者) {playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+">伪装者</color> > ";}
                    else if (role.Value == RoleEnum.殉道者) {playerRole += "<color=#"+Patches.Colors.Altruist.ToHtmlStringRGBA()+">殉道者</color> > ";}
                    else if (role.Value == RoleEnum.工程师) {playerRole += "<color=#"+Patches.Colors.Engineer.ToHtmlStringRGBA()+">工程师</color> > ";}
                    else if (role.Value == RoleEnum.调查员) {playerRole += "<color=#"+Patches.Colors.Investigator.ToHtmlStringRGBA()+">调查员</color> > ";}
                    else if (role.Value == RoleEnum.市长) {playerRole += "<color=#"+Patches.Colors.Mayor.ToHtmlStringRGBA()+">市长</color> > ";}
                    else if (role.Value == RoleEnum.法医) {playerRole += "<color=#"+Patches.Colors.Medic.ToHtmlStringRGBA()+">法医</color> > ";}
                    else if (role.Value == RoleEnum.警长) {playerRole += "<color=#"+Patches.Colors.Sheriff.ToHtmlStringRGBA()+">警长</color> > ";}
                    else if (role.Value == RoleEnum.换票师) {playerRole += "<color=#"+Patches.Colors.Swapper.ToHtmlStringRGBA()+">换票师</color> > ";}
                    else if (role.Value == RoleEnum.时间领主) {playerRole += "<color=#"+Patches.Colors.TimeLord.ToHtmlStringRGBA()+">时间领主</color> > ";}
                    else if (role.Value == RoleEnum.预言家) {playerRole += "<color=#"+Patches.Colors.Seer.ToHtmlStringRGBA()+">预言家</color> > ";}
                    else if (role.Value == RoleEnum.告密者) {playerRole += "<color=#"+Patches.Colors.Snitch.ToHtmlStringRGBA()+">告密者</color> > ";}
                    else if (role.Value == RoleEnum.特工) {playerRole += "<color=#"+Patches.Colors.Spy.ToHtmlStringRGBA()+">特工</color> > ";}
                    else if (role.Value == RoleEnum.侠客) {playerRole += "<color=#"+Patches.Colors.Vigilante.ToHtmlStringRGBA()+">侠客</color> > "; }
                    else if (role.Value == RoleEnum.纵火狂) {playerRole += "<color=#"+Patches.Colors.Arsonist.ToHtmlStringRGBA()+">纵火狂</color> > ";}
                    else if (role.Value == RoleEnum.行刑者) {playerRole += "<color=#"+Patches.Colors.Executioner.ToHtmlStringRGBA()+">行刑者</color> > ";}
                    else if (role.Value == RoleEnum.混沌) {playerRole += "<color=#"+Patches.Colors.Glitch.ToHtmlStringRGBA()+">混沌</color> > ";}
                    else if (role.Value == RoleEnum.小丑) {playerRole += "<color=#"+Patches.Colors.Jester.ToHtmlStringRGBA()+">小丑</color> > ";}
                    else if (role.Value == RoleEnum.幻影) {playerRole += "<color=#"+Patches.Colors.Phantom.ToHtmlStringRGBA()+">幻影</color> > ";}
                    else if (role.Value == RoleEnum.掷弹兵) {playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+">掷弹兵</color> > ";}
                    else if (role.Value == RoleEnum.清理者) {playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+">清理者</color> > ";}
                    else if (role.Value == RoleEnum.管道工) {playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+">管道工</color> > ";}
                    else if (role.Value == RoleEnum.化形者) {playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+">化形者</color> > ";}
                    else if (role.Value == RoleEnum.隐身人) {playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+">隐身人</color> > ";}
                    else if (role.Value == RoleEnum.送葬者) {playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+">送葬者</color> > "; }
                    else if (role.Value == RoleEnum.冤魂) { playerRole += "<color=#"+Patches.Colors.Haunter.ToHtmlStringRGBA()+">冤魂</color> > "; }
                    //else if (role.Value == RoleEnum.掷弹兵) { playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+">掷弹兵</color> > "; } 重复的
                    else if (role.Value == RoleEnum.老兵) { playerRole += "<color=#"+Patches.Colors.Veteran.ToHtmlStringRGBA()+">老兵</color> > "; }
                    else if (role.Value == RoleEnum.失忆者) { playerRole += "<color=#"+Patches.Colors.Amnesiac.ToHtmlStringRGBA()+">失忆者</color> > "; }
                    else if (role.Value == RoleEnum.天启) { playerRole += "<color=#"+Patches.Colors.Juggernaut.ToHtmlStringRGBA()+">天启</color> > "; }
                    else if (role.Value == RoleEnum.追踪者) { playerRole += "<color=#"+Patches.Colors.Tracker.ToHtmlStringRGBA()+">追踪者</color> > "; }
                    else if (role.Value == RoleEnum.绝命毒师) { playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+">绝命毒师</color> > "; }
                    else if (role.Value == RoleEnum.传送师) { playerRole += "<color=#" + Patches.Colors.Transporter.ToHtmlStringRGBA() + ">传送师</color> > "; }
                    else if (role.Value == RoleEnum.背叛者) { playerRole += "<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">背叛者</color> > "; }
                    else if (role.Value == RoleEnum.招魂师) { playerRole += "<color=#" + Patches.Colors.Medium.ToHtmlStringRGBA() + ">招魂师</color> > "; }
                    else if (role.Value == RoleEnum.陷阱师) { playerRole += "<color=#" + Patches.Colors.Trapper.ToHtmlStringRGBA() + ">陷阱师</color> > "; }
                    else if (role.Value == RoleEnum.幸存者) { playerRole += "<color=#" + Patches.Colors.Survivor.ToHtmlStringRGBA() + ">幸存者</color> > "; }
                    else if (role.Value == RoleEnum.守护天使) { playerRole += "<color=#" + Patches.Colors.GuardianAngel.ToHtmlStringRGBA() + ">守护天使</color> > "; }
                    else if (role.Value == RoleEnum.灵媒) { playerRole += "<color=#" + Patches.Colors.Mystic.ToHtmlStringRGBA() + ">灵媒</color> > "; }
                    else if (role.Value == RoleEnum.勒索者) { playerRole += "<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">勒索者</color> > "; }
                    else if (role.Value == RoleEnum.瘟疫之源) { playerRole += "<color=#" + Patches.Colors.Plaguebearer.ToHtmlStringRGBA() + ">瘟疫之源</color> > "; }
                    else if (role.Value == RoleEnum.万疫之神) { playerRole += "<color=#" + Patches.Colors.Pestilence.ToHtmlStringRGBA() + ">万疫之神</color> > "; }
                    else if (role.Value == RoleEnum.月下狼人) { playerRole += "<color=#" + Patches.Colors.Werewolf.ToHtmlStringRGBA() + ">月下狼人</color> > "; }
                    else if (role.Value == RoleEnum.侧写师) { playerRole += "<color=#" + Patches.Colors.Detective.ToHtmlStringRGBA() + ">侧写师</color> > "; }
                    else if (role.Value == RoleEnum.逃逸者) { playerRole += "<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">逃逸者</color> > "; } 
                }
                playerRole = playerRole.Remove(playerRole.Length - 3);

                if (playerControl.Is(ModifierEnum.Giant)) 
                {
                    playerRole += " (<color=#" + Patches.Colors.Giant.ToHtmlStringRGBA() + ">巨人</color>)";
                } 
                else if (playerControl.Is(ModifierEnum.ButtonBarry)) 
                {
                    playerRole += " (<color=#" + Patches.Colors.ButtonBarry.ToHtmlStringRGBA() + ">执钮人</color>)";
                } 
                else if (playerControl.Is(ModifierEnum.Blind)) 
                {
                    playerRole += " (<color=#" + Patches.Colors.Blind.ToHtmlStringRGBA() + ">胆小鬼</color>)";
                } 
                else if (playerControl.Is(ModifierEnum.Bait))
                {
                    playerRole += " (<color=#" + Patches.Colors.Bait.ToHtmlStringRGBA() + ">诱饵</color>)";
                } 
                else if (playerControl.Is(ModifierEnum.Diseased)) 
                {
                    playerRole += " (<color=#" + Patches.Colors.Diseased.ToHtmlStringRGBA() + ">病人</color>)";
                } 
                else if (playerControl.Is(ModifierEnum.Flash)) 
                {
                    playerRole += " (<color=#" + Patches.Colors.Flash.ToHtmlStringRGBA() + ">闪电侠</color>)";
                } 
                else if (playerControl.Is(ModifierEnum.Tiebreaker)) 
                {
                    playerRole += " (<color=#" + Patches.Colors.Tiebreaker.ToHtmlStringRGBA() + ">破平者</color>)";
                } 
                else if (playerControl.Is(ModifierEnum.Torch)) 
                {
                    playerRole += " (<color=#" + Patches.Colors.Torch.ToHtmlStringRGBA() + ">火炬</color>)";
                } 
                else if (playerControl.Is(ModifierEnum.Lover)) 
                {
                    playerRole += " (<color=#" + Patches.Colors.Lovers.ToHtmlStringRGBA() + ">恋人</color>)";
                } 
                else if (playerControl.Is(ModifierEnum.Sleuth)) 
                {
                    playerRole += " (<color=#" + Patches.Colors.Sleuth.ToHtmlStringRGBA() + ">掘墓者</color>)";
                }  
                else if (playerControl.Is(ModifierEnum.Radar))
                {
                    playerRole += " (<color=#" + Patches.Colors.Radar.ToHtmlStringRGBA() + ">雷达</color>)";
                }
                else if (playerControl.Is(ModifierEnum.Disperser))
                {
                    playerRole += " (<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">分散者</color>)";
                }
                else if (playerControl.Is(ModifierEnum.Multitasker))
                {
                    playerRole += " (<color=#" + Patches.Colors.Multitasker.ToHtmlStringRGBA() + ">多线程</color>)";
                }
                else if (playerControl.Is(ModifierEnum.DoubleShot))
                {
                    playerRole += " (<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">专业刺客</color>)";
                }
                else if (playerControl.Is(ModifierEnum.Underdog))
                {
                    playerRole += " (<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">潜伏者</color>)";
                }                  
                AdditionalTempData.playerRoles.Add(new AdditionalTempData.PlayerRoleInfo() { PlayerName = playerControl.Data.PlayerName, Role = playerRole });
            }
        }
    }

    [HarmonyPatch(typeof(EndGameManager), nameof(EndGameManager.SetEverythingUp))]
    public class EndGameManagerSetUpPatch {
        public static void Postfix(EndGameManager __instance) {
            GameObject bonusText = UnityEngine.Object.Instantiate(__instance.WinText.gameObject);
            bonusText.transform.position = new Vector3(__instance.WinText.transform.position.x, __instance.WinText.transform.position.y - 0.8f, __instance.WinText.transform.position.z);
            bonusText.transform.localScale = new Vector3(0.7f, 0.7f, 1f);
            TMPro.TMP_Text textRenderer = bonusText.GetComponent<TMPro.TMP_Text>();
            textRenderer.text = "";

            var position = Camera.main.ViewportToWorldPoint(new Vector3(0f, 1f, Camera.main.nearClipPlane));
            GameObject roleSummary = UnityEngine.Object.Instantiate(__instance.WinText.gameObject);
            roleSummary.transform.position = new Vector3(__instance.Navigation.ExitButton.transform.position.x + 0.1f, position.y - 0.1f, -14f); 
            roleSummary.transform.localScale = new Vector3(1f, 1f, 1f);

            var roleSummaryText = new StringBuilder();
            roleSummaryText.AppendLine("本局结算统计:");
            foreach(var data in AdditionalTempData.playerRoles) {
                var role = string.Join(" ", data.Role);
                roleSummaryText.AppendLine($"{data.PlayerName} - {role}");
            }
            TMPro.TMP_Text roleSummaryTextMesh = roleSummary.GetComponent<TMPro.TMP_Text>();
            roleSummaryTextMesh.alignment = TMPro.TextAlignmentOptions.TopLeft;
            roleSummaryTextMesh.color = Color.white;
            roleSummaryTextMesh.fontSizeMin = 1.5f;
            roleSummaryTextMesh.fontSizeMax = 1.5f;
            roleSummaryTextMesh.fontSize = 1.5f;
             
            var roleSummaryTextMeshRectTransform = roleSummaryTextMesh.GetComponent<RectTransform>();
            roleSummaryTextMeshRectTransform.anchoredPosition = new Vector2(position.x + 3.5f, position.y - 0.1f);
            roleSummaryTextMesh.text = roleSummaryText.ToString();
            AdditionalTempData.clear();
        }
    }
}