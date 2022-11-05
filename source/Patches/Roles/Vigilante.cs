using System.Collections.Generic;
using System.Linq;
using TMPro;
using TownOfUs.Patches;
using UnityEngine;
using TownOfUs.NeutralRoles.ExecutionerMod;
using TownOfUs.NeutralRoles.GuardianAngelMod;

namespace TownOfUs.Roles
{
    public class Vigilante : Role
    {
        public Dictionary<byte, (GameObject, GameObject, GameObject, TMP_Text)> Buttons = new Dictionary<byte, (GameObject, GameObject, GameObject, TMP_Text)>();

        private Dictionary<string, Color> ColorMapping = new Dictionary<string, Color>();

        public Dictionary<string, Color> SortedColorMapping;

        public Dictionary<byte, string> Guesses = new Dictionary<byte, string>();

        public Vigilante(PlayerControl player) : base(player)
        {
            Name = "侠客";
            ImpostorText = () => "生命就是一场豪赌";
            TaskText = () => "在会议中猜测坏人的职业来杀死他们!";
            Color = Patches.Colors.Vigilante;
            RoleType = RoleEnum.侠客;
            AddToRoleHistory(RoleType);

            RemainingKills = CustomGameOptions.VigilanteKills;

            if (CustomGameOptions.GameMode != GameMode.KillingOnly)
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

                if (CustomGameOptions.VigilanteGuessNeutralBenign)
                {
                    if (CustomGameOptions.AmnesiacOn > 0 || (CustomGameOptions.ExecutionerOn > 0 && CustomGameOptions.OnTargetDead == OnTargetDead.Amnesiac) || (CustomGameOptions.GuardianAngelOn > 0 && CustomGameOptions.GaOnTargetDeath == BecomeOptions.Amnesiac)) ColorMapping.Add("失忆者", Colors.Amnesiac);
                    if (CustomGameOptions.GuardianAngelOn > 0) ColorMapping.Add("守护天使", Colors.GuardianAngel);
                    if (CustomGameOptions.SurvivorOn > 0 || (CustomGameOptions.ExecutionerOn > 0 && CustomGameOptions.OnTargetDead == OnTargetDead.Survivor) || (CustomGameOptions.GuardianAngelOn > 0 && CustomGameOptions.GaOnTargetDeath == BecomeOptions.Survivor)) ColorMapping.Add("幸存者", Colors.Survivor);
                }
                if (CustomGameOptions.VigilanteGuessNeutralEvil)
                {
                    if (CustomGameOptions.ExecutionerOn > 0) ColorMapping.Add("行刑者", Colors.Executioner);
                    if (CustomGameOptions.JesterOn > 0 || (CustomGameOptions.ExecutionerOn > 0 && CustomGameOptions.OnTargetDead == OnTargetDead.Jester) || (CustomGameOptions.GuardianAngelOn > 0 && CustomGameOptions.GaOnTargetDeath == BecomeOptions.Jester)) ColorMapping.Add("小丑", Colors.Jester);
                }
                if (CustomGameOptions.VigilanteGuessNeutralKilling)
                {
                    if (CustomGameOptions.ArsonistOn > 0) ColorMapping.Add("纵火狂", Colors.Arsonist);
                    if (CustomGameOptions.GlitchOn > 0) ColorMapping.Add("混沌", Colors.Glitch);
                    if (CustomGameOptions.PlaguebearerOn > 0) ColorMapping.Add("瘟疫之源", Colors.Plaguebearer);
                    if (CustomGameOptions.WerewolfOn > 0) ColorMapping.Add("月下狼人", Colors.Werewolf);
                    ColorMapping.Add("天启", Colors.Juggernaut);
                }
                if (CustomGameOptions.VigilanteGuessLovers && CustomGameOptions.LoversOn > 0) ColorMapping.Add("恋人", Colors.Lovers);
            }
            else
            {
                ColorMapping.Add("化形者", Colors.Impostor);
                ColorMapping.Add("管道工", Colors.Impostor);
                ColorMapping.Add("隐身人", Colors.Impostor);
                ColorMapping.Add("送葬者", Colors.Impostor);
                ColorMapping.Add("掷弹兵", Colors.Impostor);
                ColorMapping.Add("背叛者", Colors.Impostor);
                ColorMapping.Add("逃逸者", Colors.Impostor);

                if (CustomGameOptions.VigilanteGuessNeutralKilling)
                {
                    if (CustomGameOptions.AddArsonist) ColorMapping.Add("纵火狂", Colors.Arsonist);
                    if (CustomGameOptions.AddPlaguebearer) ColorMapping.Add("瘟疫之源", Colors.Plaguebearer);
                    ColorMapping.Add("混沌", Colors.Glitch);
                    ColorMapping.Add("月下狼人", Colors.Werewolf);
                    ColorMapping.Add("天启", Colors.Juggernaut);
                }
            }

            SortedColorMapping = ColorMapping.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        }

        public bool GuessedThisMeeting { get; set; } = false;

        public int RemainingKills { get; set; }

        public List<string> PossibleGuesses => SortedColorMapping.Keys.ToList();
    }
}
