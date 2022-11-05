using Hazel;
using System;
using System.Linq;
using TownOfUs.Extensions;

namespace TownOfUs.Roles
{
    public class Pestilence : Role
    {
        public Pestilence(PlayerControl owner) : base(owner)
        {
            Name = "万疫之神";
            Color = Patches.Colors.Pestilence;
            LastKill = DateTime.UtcNow;
            RoleType = RoleEnum.万疫之神;
            AddToRoleHistory(RoleType);
            ImpostorText = () => "";
            TaskText = () => "用你无人能挡的能力杀死所有人!\n假任务:";
            Faction = Faction.Neutral;
        }

        public PlayerControl ClosestPlayer;
        public DateTime LastKill { get; set; }
        public bool PestilenceWins { get; set; }

        internal override bool EABBNOODFGL(ShipStatus __instance)
        {
            if (Player.Data.IsDead || Player.Data.Disconnected) return true;

            if (PlayerControl.AllPlayerControls.ToArray().Count(x => !x.Data.IsDead && !x.Data.Disconnected) <= 2 &&
                    PlayerControl.AllPlayerControls.ToArray().Count(x => !x.Data.IsDead && !x.Data.Disconnected &&
                    (x.Data.IsImpostor() || x.Is(RoleEnum.混沌) || x.Is(RoleEnum.纵火狂) ||
                    x.Is(RoleEnum.天启) || x.Is(RoleEnum.月下狼人) || x.Is(RoleEnum.瘟疫之源))) == 0)
            {
                var writer = AmongUsClient.Instance.StartRpcImmediately(
                    PlayerControl.LocalPlayer.NetId,
                    (byte)CustomRPC.PestilenceWin,
                    SendOption.Reliable,
                    -1
                );
                writer.Write(Player.PlayerId);
                Wins();
                AmongUsClient.Instance.FinishRpcImmediately(writer);
                Utils.EndGame();
                return false;
            }

            return false;
        }

        public void Wins()
        {
            PestilenceWins = true;
        }

        public void Loses()
        {
            LostByRPC = true;
        }

        public float KillTimer()
        {
            var utcNow = DateTime.UtcNow;
            var timeSpan = utcNow - LastKill;
            var num = CustomGameOptions.PestKillCd * 1000f;
            var flag2 = num - (float)timeSpan.TotalMilliseconds < 0f;
            if (flag2) return 0;
            return (num - (float)timeSpan.TotalMilliseconds) / 1000f;
        }
    }
}