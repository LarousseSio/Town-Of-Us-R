using HarmonyLib;
using UnityEngine;

namespace HanPi.Sig
{
    [HarmonyPatch]
    public static class CredentialsPatch
    {
        public static string fullCredentials =$@"";

        public static string mainMenuCredentials =
    "<size=70%>作者:<color=#00FF00FF>eDonnes124</color>  汉化:<color=#fe0000>四个憨批汉化组</color> \n翻译:<color=#00FFFF>凌霄LX</color>、<color=#1a75ff>兰博玩对战</color>、<color=#ffff66>sxy</color>、<color=#99ff33>氢氧则名</color>\n 编译&封装:<color=#00FFFF>凌霄LX</color></size>";

        public static string contributorsCredentials =$@"";


        [HarmonyPatch(typeof(VersionShower), nameof(VersionShower.Start))]
        private static class VersionShowerPatch
        {
            static void Postfix(VersionShower __instance)
            {
                var amongUsLogo = GameObject.Find("bannerLogo_AmongUs");
                if (amongUsLogo == null) return;

                var credentials = UnityEngine.Object.Instantiate<TMPro.TextMeshPro>(__instance.text);
                credentials.transform.position = new Vector3(0, 0, 0);
                credentials.SetText($"\n<size=30f%>\n</size>{mainMenuCredentials}\n<size=30%>\n</size>{contributorsCredentials}");
                credentials.alignment = TMPro.TextAlignmentOptions.Center;
                credentials.fontSize *= 0.75f;

                credentials.transform.SetParent(amongUsLogo.transform);
            }
        }
    }
}