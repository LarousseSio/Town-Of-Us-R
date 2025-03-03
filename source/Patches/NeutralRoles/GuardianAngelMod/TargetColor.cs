using HarmonyLib;
using Hazel;
using TownOfUs.Extensions;
using TownOfUs.Roles;
using UnityEngine;

namespace TownOfUs.NeutralRoles.GuardianAngelMod
{
    public enum BecomeOptions
    {
        Crew,
        Amnesiac,
        Survivor,
        Jester
    }

    [HarmonyPatch(typeof(HudManager), nameof(HudManager.Update))]
    public class GATargetColor
    {
        private static void UpdateMeeting(MeetingHud __instance, GuardianAngel role)
        {
            if (CustomGameOptions.GAKnowsTargetRole) return;
            foreach (var player in __instance.playerStates)
                if (player.TargetPlayerId == role.target.PlayerId)
                    player.NameText.color = new Color(1f, 0.85f, 0f, 1f);
        }

        private static void Postfix(HudManager __instance)
        {
            if (PlayerControl.AllPlayerControls.Count <= 1) return;
            if (PlayerControl.LocalPlayer == null) return;
            if (PlayerControl.LocalPlayer.Data == null) return;
            if (!PlayerControl.LocalPlayer.Is(RoleEnum.守护天使)) return;
            if (PlayerControl.LocalPlayer.Data.IsDead) return;

            var role = Role.GetRole<GuardianAngel>(PlayerControl.LocalPlayer);

            if (MeetingHud.Instance != null) UpdateMeeting(MeetingHud.Instance, role);

            if (!CustomGameOptions.GAKnowsTargetRole) role.target.nameText().color = new Color(1f, 0.85f, 0f, 1f);

            if (!role.target.Data.IsDead && !role.target.Data.Disconnected) return;

            var writer = AmongUsClient.Instance.StartRpcImmediately(PlayerControl.LocalPlayer.NetId,
                (byte) CustomRPC.GAToSurv, SendOption.Reliable, -1);
            writer.Write(PlayerControl.LocalPlayer.PlayerId);
            AmongUsClient.Instance.FinishRpcImmediately(writer);

            Object.Destroy(role.UsesText);
            DestroyableSingleton<HudManager>.Instance.KillButton.gameObject.SetActive(false);

            GAToSurv(PlayerControl.LocalPlayer);

            
        }

        public static void GAToSurv(PlayerControl player)
        {
            player.myTasks.RemoveAt(0);
            Role.RoleDictionary.Remove(player.PlayerId);

            if (CustomGameOptions.GaOnTargetDeath == BecomeOptions.Jester)
            {
                var jester = new Jester(player);
                var task = new GameObject("JesterTask").AddComponent<ImportantTextTask>();
                task.transform.SetParent(player.transform, false);
                task.Text =
                    $"{jester.ColorString}职业: {jester.Name}\n你的目标被杀了. 现在你只需被放逐!\n假任务:";
                player.myTasks.Insert(0, task);
            }
            else if (CustomGameOptions.GaOnTargetDeath == BecomeOptions.Amnesiac)
            {
                var amnesiac = new Amnesiac(player);
                var task = new GameObject("AmnesiacTask").AddComponent<ImportantTextTask>();
                task.transform.SetParent(player.transform, false);
                task.Text =
                    $"{amnesiac.ColorString}职业: {amnesiac.Name}\n你的目标被杀了. 现在你需要记住你的新职业!";
                player.myTasks.Insert(0, task);
            }
            else if (CustomGameOptions.GaOnTargetDeath == BecomeOptions.Survivor)
            {
                var surv = new Survivor(player);
                var task = new GameObject("SurvivorTask").AddComponent<ImportantTextTask>();
                task.transform.SetParent(player.transform, false);
                task.Text =
                    $"{surv.ColorString}职业: {surv.Name}\n你的目标被杀了. 现在你只需存活下去!";
                player.myTasks.Insert(0, task);
            }
            else
            {
                new Crewmate(player);
            }
        }
    }
}