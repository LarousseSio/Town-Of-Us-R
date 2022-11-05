namespace TownOfUs.Roles
{
    public class Altruist : Role
    {
        public bool CurrentlyReviving;
        public DeadBody CurrentTarget;

        public bool ReviveUsed;
        
        public Altruist(PlayerControl player) : base(player)
        {
            Name = "殉道者";
            ImpostorText = () => "舍己救人好市民";
            TaskText = () => "牺牲自己，换取他人的生命";
            Color = Patches.Colors.Altruist;
            RoleType = RoleEnum.殉道者;
            AddToRoleHistory(RoleType);
        }
    }
}