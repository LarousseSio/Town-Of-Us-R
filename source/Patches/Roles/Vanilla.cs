using UnityEngine;

namespace TownOfUs.Roles
{
    public class Impostor : Role
    {
        public Impostor(PlayerControl player) : base(player)
        {
            Name = "伪装者";
            Hidden = true;
            Faction = Faction.Impostors;
            RoleType = RoleEnum.伪装者;
            AddToRoleHistory(RoleType);
            Color = Palette.ImpostorRed;
        }
    }

    public class Crewmate : Role
    {
        public Crewmate(PlayerControl player) : base(player)
        {
            Name = "船员";
            Hidden = true;
            Faction = Faction.Crewmates;
            RoleType = RoleEnum.船员;
            AddToRoleHistory(RoleType);
            Color = Patches.Colors.Crewmate;
        }
    }
}