using System.Collections.Generic;
using System.Linq;
using TMPro;
using TownOfUs.Patches;
using UnityEngine;
using TownOfUs.NeutralRoles.ExecutionerMod;
using TownOfUs.NeutralRoles.GuardianAngelMod;

namespace TownOfUs.Roles.Modifiers
{
    public class Assassin : Ability
    {
        public Dictionary<byte, (GameObject, GameObject, GameObject, TMP_Text)> Buttons = new Dictionary<byte, (GameObject, GameObject, GameObject, TMP_Text)>();


        private Dictionary<string, Color> ColorMapping = new Dictionary<string, Color>();

        public Dictionary<string, Color> SortedColorMapping;

        public Dictionary<byte, string> Guesses = new Dictionary<byte, string>();


        public Assassin(PlayerControl player) : base(player)
        {
            Name = "刺客";
            TaskText = () => "会议中可以猜测其它玩家职业并击杀";
            Color = Patches.Colors.Impostor;
            AbilityType = AbilityEnum.刺客;

            RemainingKills = CustomGameOptions.AssassinKills;

            // Adds all the roles that have a non-zero chance of being in the game.
            if (CustomGameOptions.MayorOn > 0) ColorMapping.Add("市长", Colors.Mayor);
            if (CustomGameOptions.SheriffOn > 0) ColorMapping.Add("警长", Colors.Sheriff);
            if (CustomGameOptions.EngineerOn > 0) ColorMapping.Add("工程师", Colors.Engineer);
            if (CustomGameOptions.SwapperOn > 0) ColorMapping.Add("换票师", Colors.Swapper);
            if (CustomGameOptions.InvestigatorOn > 0) ColorMapping.Add("调查员", Colors.Investigator);
            if (CustomGameOptions.TimeLordOn > 0) ColorMapping.Add("时间领主", Colors.TimeLord);
            if (CustomGameOptions.MedicOn > 0) ColorMapping.Add("法医", Colors.Medic);
            if (CustomGameOptions.SeerOn > 0) ColorMapping.Add("预言家", Colors.Seer);
            if (CustomGameOptions.SpyOn > 0) ColorMapping.Add("特工", Colors.Spy);
            if (CustomGameOptions.SnitchOn > 0 && !CustomGameOptions.AssassinSnitchViaCrewmate) ColorMapping.Add("告密者", Colors.Snitch);
            if (CustomGameOptions.AltruistOn > 0) ColorMapping.Add("殉道者", Colors.Altruist);
            if (CustomGameOptions.VigilanteOn > 0) ColorMapping.Add("侠客", Colors.Vigilante);
            if (CustomGameOptions.VeteranOn > 0) ColorMapping.Add("老兵", Colors.Veteran);
            if (CustomGameOptions.TrackerOn > 0) ColorMapping.Add("追踪者", Colors.Tracker);
            if (CustomGameOptions.TrapperOn > 0) ColorMapping.Add("陷阱师", Colors.Trapper);
            if (CustomGameOptions.TransporterOn > 0) ColorMapping.Add("传送师", Colors.Transporter);
            if (CustomGameOptions.MediumOn > 0) ColorMapping.Add("招魂师", Colors.Medium);
            if (CustomGameOptions.MysticOn > 0) ColorMapping.Add("灵媒", Colors.Mystic);
            if (CustomGameOptions.DetectiveOn > 0) ColorMapping.Add("侧写师", Colors.Detective);

            // Add Neutral roles if enabled
            if (CustomGameOptions.AssassinGuessNeutralBenign)
            {
                if (CustomGameOptions.AmnesiacOn > 0 || (CustomGameOptions.ExecutionerOn > 0 && CustomGameOptions.OnTargetDead == OnTargetDead.Amnesiac) || (CustomGameOptions.GuardianAngelOn > 0 && CustomGameOptions.GaOnTargetDeath == BecomeOptions.Amnesiac)) ColorMapping.Add("失忆者", Colors.Amnesiac);
                if (CustomGameOptions.GuardianAngelOn > 0) ColorMapping.Add("守护天使", Colors.GuardianAngel);
                if (CustomGameOptions.SurvivorOn > 0 || (CustomGameOptions.ExecutionerOn > 0 && CustomGameOptions.OnTargetDead == OnTargetDead.Survivor) || (CustomGameOptions.GuardianAngelOn > 0 && CustomGameOptions.GaOnTargetDeath == BecomeOptions.Survivor)) ColorMapping.Add("幸存者", Colors.Survivor);
            }
            if (CustomGameOptions.AssassinGuessNeutralEvil)
            {
                if (CustomGameOptions.ExecutionerOn > 0) ColorMapping.Add("行刑者", Colors.Executioner);
                if (CustomGameOptions.JesterOn > 0 || (CustomGameOptions.ExecutionerOn > 0 && CustomGameOptions.OnTargetDead == OnTargetDead.Jester) || (CustomGameOptions.GuardianAngelOn > 0 && CustomGameOptions.GaOnTargetDeath == BecomeOptions.Jester)) ColorMapping.Add("小丑", Colors.Jester);
            }
            if (CustomGameOptions.AssassinGuessNeutralKilling)
            {
                if (CustomGameOptions.ArsonistOn > 0 && !PlayerControl.LocalPlayer.Is(RoleEnum.纵火狂)) ColorMapping.Add("纵火狂", Colors.Arsonist);
                if (CustomGameOptions.GlitchOn > 0 && !PlayerControl.LocalPlayer.Is(RoleEnum.混沌)) ColorMapping.Add("混沌", Colors.Glitch);
                if (CustomGameOptions.PlaguebearerOn > 0 && !PlayerControl.LocalPlayer.Is(RoleEnum.瘟疫之源)) ColorMapping.Add("瘟疫之源", Colors.Plaguebearer);
                if (CustomGameOptions.WerewolfOn > 0 && !PlayerControl.LocalPlayer.Is(RoleEnum.月下狼人)) ColorMapping.Add("月下狼人", Colors.Werewolf);
                if (!PlayerControl.LocalPlayer.Is(RoleEnum.天启)) ColorMapping.Add("天启", Colors.Juggernaut);
            }
            if (CustomGameOptions.AssassinGuessImpostors && !PlayerControl.LocalPlayer.Is(Faction.Impostors))
            {
                ColorMapping.Add("伪装者", Colors.Impostor);
                if (CustomGameOptions.JanitorOn > 0) ColorMapping.Add("清理者", Colors.Impostor);
                if (CustomGameOptions.MorphlingOn > 0) ColorMapping.Add("化形者", Colors.Impostor);
                if (CustomGameOptions.MinerOn > 0) ColorMapping.Add("管道工", Colors.Impostor);
                if (CustomGameOptions.SwooperOn > 0) ColorMapping.Add("隐身人", Colors.Impostor);
                if (CustomGameOptions.UndertakerOn > 0) ColorMapping.Add("送葬者", Colors.Impostor);
                if (CustomGameOptions.EscapistOn > 0) ColorMapping.Add("逃逸者", Colors.Impostor);
                if (CustomGameOptions.GrenadierOn > 0) ColorMapping.Add("掷弹兵", Colors.Impostor);
                if (CustomGameOptions.PoisonerOn > 0) ColorMapping.Add("绝命毒师", Colors.Impostor);
                if (CustomGameOptions.TraitorOn > 0) ColorMapping.Add("背叛者", Colors.Impostor);
                if (CustomGameOptions.BlackmailerOn > 0) ColorMapping.Add("勒索者", Colors.Impostor);
            }

            // Add vanilla crewmate if enabled
            if (CustomGameOptions.AssassinCrewmateGuess) ColorMapping.Add("船员", Colors.Crewmate);
            //Add modifiers if enabled
            if (CustomGameOptions.AssassinGuessModifiers && CustomGameOptions.BaitOn > 0) ColorMapping.Add("诱饵", Colors.Bait);
            if (CustomGameOptions.AssassinGuessModifiers && CustomGameOptions.BlindOn > 0) ColorMapping.Add("胆小鬼", Colors.Blind);
            if (CustomGameOptions.AssassinGuessModifiers && CustomGameOptions.DiseasedOn > 0) ColorMapping.Add("病人", Colors.Diseased);
            if (CustomGameOptions.AssassinGuessModifiers && CustomGameOptions.MultitaskerOn > 0) ColorMapping.Add("多线程", Colors.Multitasker);
            if (CustomGameOptions.AssassinGuessModifiers && CustomGameOptions.TorchOn > 0) ColorMapping.Add("火炬", Colors.Torch);
            if (CustomGameOptions.AssassinGuessLovers && CustomGameOptions.LoversOn > 0) ColorMapping.Add("恋人", Colors.Lovers);

            // Sorts the list alphabetically. 
            SortedColorMapping = ColorMapping.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        }

        public bool GuessedThisMeeting { get; set; } = false;

        public int RemainingKills { get; set; }

        public List<string> PossibleGuesses => SortedColorMapping.Keys.ToList();
    }
}
