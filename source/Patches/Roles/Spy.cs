namespace TownOfUs.Roles
{
    public class Spy : Role
    {
        public Spy(PlayerControl player) : base(player)
        {
            Name = "特工";
            ImpostorText = () => "我想做个好人";
            TaskText = () => "随时查看管理地图和心电图";
            Color = Patches.Colors.Spy;
            RoleType = RoleEnum.特工;
            AddToRoleHistory(RoleType);
        }
    }
}