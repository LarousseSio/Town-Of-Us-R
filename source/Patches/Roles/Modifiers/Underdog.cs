using TownOfUs.Modifiers.UnderdogMod;

namespace TownOfUs.Roles.Modifiers
{
    public class Underdog : Modifier
    {
        public Underdog(PlayerControl player) : base(player)
        {
            Name = "潜伏者";
            TaskText = () => PerformKill.LastImp() ? "你的击杀冷却时间大幅缩短!" : "在你的队友全部死亡前你的击杀冷却时间增加!";
            Color = Patches.Colors.Impostor;
            ModifierType = ModifierEnum.Underdog;
        }

        public float MaxTimer() => PerformKill.LastImp() ? PlayerControl.GameOptions.KillCooldown - CustomGameOptions.UnderdogKillBonus : (PerformKill.IncreasedKC() ? PlayerControl.GameOptions.KillCooldown : PlayerControl.GameOptions.KillCooldown + CustomGameOptions.UnderdogKillBonus);

        public void SetKillTimer()
        {
            Player.SetKillTimer(MaxTimer());
        }
    }
}
