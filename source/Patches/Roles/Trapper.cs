﻿using Reactor.Utilities.Extensions;
using System;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using TownOfUs.CrewmateRoles.TrapperMod;
using UnityEngine;

namespace TownOfUs.Roles
{
    public class Trapper : Role
    {
        public static AssetBundle bundle = loadBundle();
        public static Material trapMaterial = bundle.LoadAsset<Material>("trap").DontUnload();

        public List<Trap> traps = new List<Trap>();
        public DateTime LastTrapped { get; set; }
        public int UsesLeft;
        public TextMeshPro UsesText;

        public List<RoleEnum> trappedPlayers;

        public bool ButtonUsable => UsesLeft != 0;
        public Trapper(PlayerControl player) : base(player)
        {
            Name = "陷阱师";
            ImpostorText = () => "抓捕凶手的行动";
            TaskText = () => "在地图上放置陷阱";
            Color = Patches.Colors.Trapper;
            RoleType = RoleEnum.陷阱师;
            LastTrapped = DateTime.UtcNow;
            trappedPlayers = new List<RoleEnum>();
            AddToRoleHistory(RoleType);

            UsesLeft = CustomGameOptions.MaxTraps;
        }

        public float TrapTimer()
        {
            var utcNow = DateTime.UtcNow;
            var timeSpan = utcNow - LastTrapped;
            var num = CustomGameOptions.TrapCooldown * 1000f;
            var flag2 = num - (float)timeSpan.TotalMilliseconds < 0f;
            if (flag2) return 0;
            return (num - (float)timeSpan.TotalMilliseconds) / 1000f;
        }


        public static AssetBundle loadBundle()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var stream = assembly.GetManifestResourceStream("TownOfUs.Resources.trappershader");
            var assets = stream.ReadFully();
            return AssetBundle.LoadFromMemory(assets);
        }
    }
}
