using System;
using System.Collections.Generic;
using TownOfUs.Extensions;

namespace TownOfUs.CrewmateRoles.MedicMod
{
    public class DeadPlayer
    {
        public byte KillerId { get; set; }
        public byte PlayerId { get; set; }
        public DateTime KillTime { get; set; }
    }

    //body report class for when medic reports a body
    public class BodyReport
    {
        public PlayerControl Killer { get; set; }
        public PlayerControl Reporter { get; set; }
        public PlayerControl Body { get; set; }
        public float KillAge { get; set; }

        public static string ParseBodyReport(BodyReport br)
        {
            //System.Console.WriteLine(br.KillAge);
            if (br.KillAge > CustomGameOptions.MedicReportColorDuration * 1000)
                return
                    $"尸检报告：死亡时间过长，基本没有有效的信息了。（{Math.Round(br.KillAge / 1000)}秒前死亡）";

            if (br.Killer.PlayerId == br.Body.PlayerId)
                return
                    $"尸检报告：这人看起来是自杀的。（{Math.Round(br.KillAge / 1000)}秒前死亡）";

            if (br.KillAge < CustomGameOptions.MedicReportNameDuration * 1000)
                return
                    $"尸检报告：凶手似乎是{br.Killer.Data.PlayerName}!（{Math.Round(br.KillAge / 1000)}秒前死亡）";

            var colors = new Dictionary<int, string>
            {
                {0, "深"},// red
                {1, "深"},// blue
                {2, "深"},// green
                {3, "浅"},// pink
                {4, "浅"},// orange
                {5, "浅"},// yellow
                {6, "深"},// black
                {7, "浅"},// white
                {8, "深"},// purple
                {9, "深"},// brown
                {10, "浅"},// cyan
                {11, "浅"},// lime
                {12, "深"},// maroon
                {13, "浅"},// rose
                {14, "浅"},// banana
                {15, "深"},// gray
                {16, "深"},// tan
                {17, "浅"},// coral
                {18, "深"},// watermelon
                {19, "深"},// chocolate
                {20, "浅"},// sky blue
                {21, "深"},// beige
                {22, "浅"},// hot pink
                {23, "浅"},// turquoise
                {24, "浅"},// lilac
                {25, "深"},// olive
                {26, "浅"},// azure
                {27, "浅"},// rainbow
            };
            var typeOfColor = colors[br.Killer.GetDefaultOutfit().ColorId];
            return
                $"尸检报告：凶手似乎是{typeOfColor}色。（{Math.Round(br.KillAge / 1000)}秒前死亡）";
        }
    }
}
