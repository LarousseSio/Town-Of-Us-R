using System.Collections.Generic;
using TownOfUs.CrewmateRoles.InvestigatorMod;

namespace TownOfUs.Roles
{
    public class Investigator : Role
    {
        public readonly List<Footprint> AllPrints = new List<Footprint>();


        public Investigator(PlayerControl player) : base(player)
        {
            Name = "调查员";
            ImpostorText = () => "真相只有一个!";
            TaskText = () => "你可以看到所有人的足迹。";
            Color = Patches.Colors.Investigator;
            RoleType = RoleEnum.调查员;
            AddToRoleHistory(RoleType);
            Scale = 1.4f;
        }
    }
}