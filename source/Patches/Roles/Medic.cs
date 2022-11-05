using System.Collections.Generic;
using UnityEngine;

namespace TownOfUs.Roles
{
    public class Medic : Role
    {
        public readonly List<GameObject> Buttons = new List<GameObject>();
        public Dictionary<int, string> LightDarkColors = new Dictionary<int, string>();
        public Medic(PlayerControl player) : base(player)
        {
            Name = "法医";
            ImpostorText = () => "给予你信任的人一个护盾";
            TaskText = () => "通过护盾来保护船员";
            Color = Patches.Colors.Medic;
            RoleType = RoleEnum.法医;
            AddToRoleHistory(RoleType);
            ShieldedPlayer = null;

            LightDarkColors.Add(0, "深"); //Red
            LightDarkColors.Add(1, "深"); //Blue
            LightDarkColors.Add(2, "深"); //Green
            LightDarkColors.Add(3, "浅"); //Pink
            LightDarkColors.Add(4, "浅"); //Orange
            LightDarkColors.Add(5, "浅"); //Yellow
            LightDarkColors.Add(6, "深"); //Black
            LightDarkColors.Add(7, "浅"); //White
            LightDarkColors.Add(8, "深"); //Purple
            LightDarkColors.Add(9, "深"); //Brown
            LightDarkColors.Add(10, "浅"); //Cyan
            LightDarkColors.Add(11, "浅"); //Lime
            LightDarkColors.Add(12, "深"); //Maroon
            LightDarkColors.Add(13, "浅"); //Rose
            LightDarkColors.Add(14, "浅"); //Banana
            LightDarkColors.Add(15, "深"); //Grey
            LightDarkColors.Add(16, "深"); //Tan
            LightDarkColors.Add(17, "浅"); //Coral
            LightDarkColors.Add(18, "深"); //Watermelon
            LightDarkColors.Add(19, "深"); //Chocolate
            LightDarkColors.Add(20, "浅"); //Sky Blue
            LightDarkColors.Add(21, "深"); //Biege
            LightDarkColors.Add(22, "浅"); //Hot Pink
            LightDarkColors.Add(23, "浅"); //Turquoise
            LightDarkColors.Add(24, "浅"); //Lilac
            LightDarkColors.Add(25, "深"); //Olive
            LightDarkColors.Add(26, "浅"); //Azure
            LightDarkColors.Add(27, "浅"); //Rainbow
        }

        public PlayerControl ClosestPlayer;
        public bool UsedAbility { get; set; } = false;
        public PlayerControl ShieldedPlayer { get; set; }
        public PlayerControl exShielded { get; set; }
    }
}