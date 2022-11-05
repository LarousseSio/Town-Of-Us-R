using UnityEngine;

namespace TownOfUs.Roles.Modifiers
{
    public class Bait : Modifier
    {
        public Bait(PlayerControl player) : base(player)
        {
            Name = "诱饵";
            TaskText = () => "击杀你的人会自己报告尸体";
            Color = Patches.Colors.Bait;
            ModifierType = ModifierEnum.Bait;
        }
    }
}