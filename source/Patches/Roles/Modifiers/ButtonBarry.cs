using UnityEngine;

namespace TownOfUs.Roles.Modifiers
{
    public class ButtonBarry : Modifier
    {
        public KillButton ButtonButton;

        public bool ButtonUsed;

        public ButtonBarry(PlayerControl player) : base(player)
        {
            Name = "执钮人";
            TaskText = () => "随时随地可以召开会议";
            Color = Patches.Colors.ButtonBarry;
            ModifierType = ModifierEnum.ButtonBarry;
        }
    }
}