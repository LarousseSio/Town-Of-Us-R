using UnityEngine;

namespace TownOfUs.Roles.Modifiers
{
    public class Blind : Modifier
    {
        public Blind(PlayerControl player) : base(player)
        {
            Name = "胆小鬼";
            TaskText = () => "你的报告按钮无法亮起";
            Color = Patches.Colors.Blind;
            ModifierType = ModifierEnum.Blind;
        }
    }
}