using HarmonyLib;
using UnityEngine;

namespace TownOfUs
{
    //[HarmonyPriority(Priority.VeryHigh)] // to show this message first, or be overrided if any plugins do
    [HarmonyPatch(typeof(PingTracker), nameof(PingTracker.Update))]
    public static class PingTracker_Update
    {

        [HarmonyPostfix]
        public static void Postfix(PingTracker __instance)
        {
            var position = __instance.GetComponent<AspectPosition>();
            position.DistanceFromEdge = new Vector3(3.6f, 0.1f, 0);
            position.AdjustPosition();

            __instance.text.text =
                "<size=120%><color=#00FF00FF>我们的小镇 " + TownOfUs.VersionString + "</color></size>\n" +"<size=80%>汉化:<color=#FF0000>四个憨批汉化组</color></size>\n"+"<size=80%>amonguscn.club</size>\n"+
                $"延迟: {AmongUsClient.Instance.Ping}毫秒\n" +
                (!MeetingHud.Instance
                    ? "" : "") +
                (AmongUsClient.Instance.GameState != InnerNet.InnerNetClient.GameStates.Started
                    ? "翻译:<color=#00FFFF>凌霄LX</color>、<color=#1a75ff>兰博玩对战</color>\n作者:<color=#00FF00FF>eDonnes124</color>\n" : "");
        }
    }
}
