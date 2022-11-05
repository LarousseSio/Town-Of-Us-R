using System.Linq;

namespace TownOfUs.Roles
{
    public class Traitor : Role
    {
        public RoleEnum formerRole = new RoleEnum();
        public Traitor(PlayerControl player) : base(player)
        {
            Name = "背叛者";
            ImpostorText = () => "";
            TaskText = () => "你背叛了船员们!";
            Color = Patches.Colors.Impostor;
            RoleType = RoleEnum.背叛者;
            AddToRoleHistory(RoleType);
            Faction = Faction.Impostors;
        }
    }
}