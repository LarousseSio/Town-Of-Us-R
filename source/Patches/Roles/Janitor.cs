namespace TownOfUs.Roles
{
    public class Janitor : Role
    {
        public KillButton _cleanButton;

        public Janitor(PlayerControl player) : base(player)
        {
            Name = "清理者";
            ImpostorText = () => "藏好自己 做好清理";
            TaskText = () => "清理尸体，防止它们被发现";
            Color = Patches.Colors.Impostor;
            RoleType = RoleEnum.清理者;
            AddToRoleHistory(RoleType);
            Faction = Faction.Impostors;
        }

        public DeadBody CurrentTarget { get; set; }

        public KillButton CleanButton
        {
            get => _cleanButton;
            set
            {
                _cleanButton = value;
                ExtraButtons.Clear();
                ExtraButtons.Add(value);
            }
        }
    }
}