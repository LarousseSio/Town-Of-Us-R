using HarmonyLib;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace TownOfUs.RainbowMod
{
    [HarmonyPatch(typeof(TranslationController), nameof(TranslationController.GetString),
        new[] { typeof(StringNames), typeof(Il2CppReferenceArray<Il2CppSystem.Object>) })]
    public class PatchColours
    {
        public static bool Prefix(ref string __result, [HarmonyArgument(0)] StringNames name)
        {
            var newResult = (int)name switch
            {
                999990 => "西瓜红",
                999991 => "巧克力",
                999992 => "天蓝色",
                999993 => "浅褐色",
                999994 => "深粉色",
                999995 => "绿松石",
                999996 => "淡紫色",
                999997 => "橄榄色",
                999998 => "蔚蓝色",
                999999 => "彩虹色",
                _ => null
            };
            if (newResult != null)
            {
                __result = newResult;
                return false;
            }

            return true;
        }
    }
}
