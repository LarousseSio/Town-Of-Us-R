using UnityEngine;

namespace TownOfUs.Roles
{
    public class Engineer : Role
    {
        public Engineer(PlayerControl player) : base(player)
        {
            Name = "工程师";
            ImpostorText = () => "维护船上的重要设备";
            TaskText = () => "随时修理船上的设备破坏";
            Color = Patches.Colors.Engineer;
            RoleType = RoleEnum.工程师;
            AddToRoleHistory(RoleType);
        }

        public bool UsedThisRound { get; set; } = false;
    }
}