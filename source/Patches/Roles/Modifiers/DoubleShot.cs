namespace TownOfUs.Roles.Modifiers
{
    public class DoubleShot : Modifier
    {
        public bool LifeUsed;
        public DoubleShot(PlayerControl player) : base(player)
        {
            Name = "专业刺客";
            TaskText = () => "当你猜测时拥有额外的生命点数";
            Color = Patches.Colors.Impostor;
            ModifierType = ModifierEnum.DoubleShot;
            LifeUsed = false;
        }
    }
}