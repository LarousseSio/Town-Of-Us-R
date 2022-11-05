using System.Collections.Generic;
using UnityEngine;

namespace TownOfUs.Roles
{
    public class Swapper : Role
    {
        public readonly List<GameObject> Buttons = new List<GameObject>();

        public readonly List<bool> ListOfActives = new List<bool>();


        public Swapper(PlayerControl player) : base(player)
        {
            Name = "换票师";
            ImpostorText = () => "我的含金量很高哦";
            TaskText = () => "会议时可以交换两人的投票!";
            Color = Patches.Colors.Swapper;
            RoleType = RoleEnum.换票师;
            AddToRoleHistory(RoleType);
        }
    }
}