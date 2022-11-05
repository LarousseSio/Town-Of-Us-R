using System;

namespace TownOfUs.CustomOption
{
    public class Generate
    {
        public static CustomHeaderOption CrewInvestigativeRoles;
        public static CustomNumberOption DetectiveOn;
        public static CustomNumberOption HaunterOn;
        public static CustomNumberOption InvestigatorOn;
        public static CustomNumberOption MysticOn;
        public static CustomNumberOption SeerOn;
        public static CustomNumberOption SnitchOn;
        public static CustomNumberOption SpyOn;
        public static CustomNumberOption TrackerOn;
        public static CustomNumberOption TrapperOn;

        public static CustomHeaderOption CrewProtectiveRoles;
        public static CustomNumberOption AltruistOn;
        public static CustomNumberOption MedicOn;

        public static CustomHeaderOption CrewKillingRoles;
        public static CustomNumberOption SheriffOn;
        public static CustomNumberOption VeteranOn;
        public static CustomNumberOption VigilanteOn;

        public static CustomHeaderOption CrewSupportRoles;
        public static CustomNumberOption EngineerOn;
        public static CustomNumberOption MayorOn;
        public static CustomNumberOption MediumOn;
        public static CustomNumberOption SwapperOn;
        public static CustomNumberOption TimeLordOn;
        public static CustomNumberOption TransporterOn;

        public static CustomHeaderOption NeutralBenignRoles;
        public static CustomNumberOption AmnesiacOn;
        public static CustomNumberOption GuardianAngelOn;
        public static CustomNumberOption SurvivorOn;

        public static CustomHeaderOption NeutralEvilRoles;
        public static CustomNumberOption ExecutionerOn;
        public static CustomNumberOption JesterOn;
        public static CustomNumberOption PhantomOn;

        public static CustomHeaderOption NeutralKillingRoles;
        public static CustomNumberOption ArsonistOn;
        public static CustomNumberOption PlaguebearerOn;
        public static CustomNumberOption GlitchOn;
        public static CustomNumberOption WerewolfOn;

        public static CustomHeaderOption ImpostorConcealingRoles;
        public static CustomNumberOption EscapistOn;
        public static CustomNumberOption MorphlingOn;
        public static CustomNumberOption SwooperOn;
        public static CustomNumberOption GrenadierOn;

        public static CustomHeaderOption ImpostorKillingRoles;
        public static CustomNumberOption PoisonerOn;
        public static CustomNumberOption TraitorOn;

        public static CustomHeaderOption ImpostorSupportRoles;
        public static CustomNumberOption BlackmailerOn;
        public static CustomNumberOption JanitorOn;
        public static CustomNumberOption MinerOn;
        public static CustomNumberOption UndertakerOn;

        public static CustomHeaderOption CrewmateModifiers;
        public static CustomNumberOption BaitOn;
        public static CustomNumberOption BlindOn;
        public static CustomNumberOption DiseasedOn;
        public static CustomNumberOption MultitaskerOn;
        public static CustomNumberOption TorchOn;

        public static CustomHeaderOption GlobalModifiers;
        public static CustomNumberOption ButtonBarryOn;
        public static CustomNumberOption FlashOn;
        public static CustomNumberOption GiantOn;
        public static CustomNumberOption LoversOn;
        public static CustomNumberOption RadarOn;
        public static CustomNumberOption SleuthOn;
        public static CustomNumberOption TiebreakerOn;

         public static CustomHeaderOption ImpostorModifiers;
        public static CustomNumberOption DisperserOn;
        public static CustomNumberOption DoubleShotOn;
        public static CustomNumberOption UnderdogOn;

        public static CustomHeaderOption MapSettings;
        public static CustomToggleOption RandomMapEnabled;
        public static CustomNumberOption RandomMapSkeld;
        public static CustomNumberOption RandomMapMira;
        public static CustomNumberOption RandomMapPolus;
        public static CustomNumberOption RandomMapAirship;
        public static CustomNumberOption RandomMapSubmerged;
        public static CustomToggleOption AutoAdjustSettings;
        public static CustomToggleOption SmallMapHalfVision;
        public static CustomNumberOption SmallMapDecreasedCooldown;
        public static CustomNumberOption LargeMapIncreasedCooldown;
        public static CustomNumberOption SmallMapIncreasedShortTasks;
        public static CustomNumberOption SmallMapIncreasedLongTasks;
        public static CustomNumberOption LargeMapDecreasedShortTasks;
        public static CustomNumberOption LargeMapDecreasedLongTasks;

        public static CustomHeaderOption CustomGameSettings;
        public static CustomToggleOption ColourblindComms;
        public static CustomToggleOption ImpostorSeeRoles;
        public static CustomToggleOption DeadSeeRoles;
        public static CustomToggleOption DisableLevels;
        public static CustomToggleOption WhiteNameplates;
        public static CustomNumberOption VanillaGame;
        public static CustomNumberOption InitialCooldowns;
        public static CustomToggleOption ParallelMedScans;
        public static CustomStringOption SkipButtonDisable;

        public static CustomHeaderOption BetterPolusSettings;
        public static CustomToggleOption VentImprovements;
        public static CustomToggleOption VitalsLab;
        public static CustomToggleOption ColdTempDeathValley;
        public static CustomToggleOption WifiChartCourseSwap;

        public static CustomHeaderOption GameModeSettings;
        public static CustomStringOption GameMode;

        public static CustomHeaderOption ClassicSettings;
        public static CustomNumberOption MinNeutralNonKillingRoles;
        public static CustomNumberOption MaxNeutralNonKillingRoles;
        public static CustomNumberOption MinNeutralKillingRoles;
        public static CustomNumberOption MaxNeutralKillingRoles;

        public static CustomHeaderOption AllAnySettings;
        public static CustomToggleOption RandomNumberImps;

        public static CustomHeaderOption KillingOnlySettings;
        public static CustomNumberOption NeutralRoles;
        public static CustomNumberOption VeteranCount;
        public static CustomNumberOption VigilanteCount;
        public static CustomToggleOption AddArsonist;
        public static CustomToggleOption AddPlaguebearer;

        public static CustomHeaderOption TaskTrackingSettings;
        public static CustomToggleOption SeeTasksDuringRound;
        public static CustomToggleOption SeeTasksDuringMeeting;
        public static CustomToggleOption SeeTasksWhenDead;

        public static CustomHeaderOption Mayor;
        public static CustomNumberOption MayorVoteBank;
        public static CustomToggleOption MayorAnonymous;

        public static CustomHeaderOption Sheriff;
        public static CustomToggleOption SheriffKillOther;
        public static CustomToggleOption SheriffKillsJester;
        public static CustomToggleOption SheriffKillsGlitch;
        public static CustomToggleOption SheriffKillsExecutioner;
        public static CustomToggleOption SheriffKillsArsonist;
        public static CustomToggleOption SheriffKillsWerewolf;
        public static CustomToggleOption SheriffKillsPlaguebearer;
        public static CustomNumberOption SheriffKillCd;
        public static CustomToggleOption SheriffBodyReport;


        public static CustomHeaderOption Engineer;
        public static CustomStringOption EngineerPer;

        public static CustomHeaderOption Investigator;
        public static CustomNumberOption FootprintSize;
        public static CustomNumberOption FootprintInterval;
        public static CustomNumberOption FootprintDuration;
        public static CustomToggleOption AnonymousFootPrint;
        public static CustomToggleOption VentFootprintVisible;

        public static CustomHeaderOption TimeLord;
        public static CustomToggleOption RewindRevive;
        public static CustomNumberOption RewindDuration;
        public static CustomNumberOption RewindCooldown;
        public static CustomNumberOption RewindMaxUses;
        public static CustomToggleOption TimeLordVitals;

        public static CustomHeaderOption Medic;
        public static CustomStringOption ShowShielded;
        public static CustomStringOption WhoGetsNotification;
        public static CustomToggleOption ShieldBreaks;
        public static CustomToggleOption MedicReportSwitch;
        public static CustomNumberOption MedicReportNameDuration;
        public static CustomNumberOption MedicReportColorDuration;

        public static CustomHeaderOption Seer;
        public static CustomNumberOption SeerCooldown;
        public static CustomToggleOption CrewKillingRed;
        public static CustomToggleOption NeutBenignRed;
        public static CustomToggleOption NeutEvilRed;
        public static CustomToggleOption NeutKillingRed;
        public static CustomToggleOption TraitorColourSwap;

        public static CustomHeaderOption Swapper;
        public static CustomToggleOption SwapperButton;

        public static CustomHeaderOption Transporter;
        public static CustomNumberOption TransportCooldown;
        public static CustomNumberOption TransportMaxUses;
        public static CustomToggleOption TransporterVitals;

        public static CustomHeaderOption Jester;
        public static CustomToggleOption JesterButton;
        public static CustomToggleOption JesterVent;
        public static CustomToggleOption JesterImpVision;

        public static CustomHeaderOption TheGlitch;
        public static CustomNumberOption MimicCooldownOption;
        public static CustomNumberOption MimicDurationOption;
        public static CustomNumberOption HackCooldownOption;
        public static CustomNumberOption HackDurationOption;
        public static CustomNumberOption GlitchKillCooldownOption;
        public static CustomStringOption GlitchHackDistanceOption;
        public static CustomToggleOption GlitchVent;

        public static CustomHeaderOption Morphling;
        public static CustomNumberOption MorphlingCooldown;
        public static CustomNumberOption MorphlingDuration;
        public static CustomToggleOption MorphlingVent;

        public static CustomHeaderOption Executioner;
        public static CustomStringOption OnTargetDead;
        public static CustomToggleOption ExecutionerButton;

        public static CustomHeaderOption Phantom;
        public static CustomNumberOption PhantomTasksRemaining;

        public static CustomHeaderOption Snitch;
        public static CustomToggleOption SnitchOnLaunch;
        public static CustomToggleOption SnitchSeesNeutrals;
        public static CustomNumberOption SnitchTasksRemaining;
        public static CustomToggleOption SnitchSeesImpInMeeting;
        public static CustomToggleOption SnitchSeesTraitor;

        public static CustomHeaderOption Altruist;
        public static CustomNumberOption ReviveDuration;
        public static CustomToggleOption AltruistTargetBody;

        public static CustomHeaderOption Miner;
        public static CustomNumberOption MineCooldown;

        public static CustomHeaderOption Swooper;
        public static CustomNumberOption SwoopCooldown;
        public static CustomNumberOption SwoopDuration;
        public static CustomToggleOption SwooperVent;

        public static CustomHeaderOption Arsonist;
        public static CustomNumberOption DouseCooldown;
        public static CustomNumberOption MaxDoused;
        public static CustomToggleOption ArsoImpVision;
        public static CustomToggleOption IgniteCdRemoved;

        public static CustomHeaderOption Undertaker;
        public static CustomNumberOption DragCooldown;
        public static CustomToggleOption UndertakerVent;
        public static CustomToggleOption UndertakerVentWithBody;

        public static CustomHeaderOption Assassin;
        public static CustomNumberOption NumberOfImpostorAssassins;
        public static CustomNumberOption NumberOfNeutralAssassins;
        public static CustomToggleOption AmneTurnImpAssassin;
        public static CustomToggleOption AmneTurnNeutAssassin;
        public static CustomToggleOption TraitorCanAssassin;
        public static CustomNumberOption AssassinKills;
        public static CustomToggleOption AssassinMultiKill;
        public static CustomToggleOption AssassinCrewmateGuess;
        public static CustomToggleOption AssassinSnitchViaCrewmate;
        public static CustomToggleOption AssassinGuessNeutralBenign;
        public static CustomToggleOption AssassinGuessNeutralEvil;
        public static CustomToggleOption AssassinGuessNeutralKilling;
        public static CustomToggleOption AssassinGuessImpostors;
        public static CustomToggleOption AssassinGuessModifiers;
        public static CustomToggleOption AssassinGuessLovers;
        public static CustomToggleOption AssassinateAfterVoting;

        public static CustomHeaderOption Underdog;
        public static CustomNumberOption UnderdogKillBonus;
        public static CustomToggleOption UnderdogIncreasedKC;

        public static CustomHeaderOption Vigilante;
        public static CustomNumberOption VigilanteKills;
        public static CustomToggleOption VigilanteMultiKill;
        public static CustomToggleOption VigilanteGuessNeutralBenign;
        public static CustomToggleOption VigilanteGuessNeutralEvil;
        public static CustomToggleOption VigilanteGuessNeutralKilling;
        public static CustomToggleOption VigilanteGuessLovers;
        public static CustomToggleOption VigilanteAfterVoting;

        public static CustomHeaderOption Haunter;
        public static CustomNumberOption HaunterTasksRemainingClicked;
        public static CustomNumberOption HaunterTasksRemainingAlert;
        public static CustomToggleOption HaunterRevealsNeutrals;
        public static CustomStringOption HaunterCanBeClickedBy;

        public static CustomHeaderOption Grenadier;
        public static CustomNumberOption GrenadeCooldown;
        public static CustomNumberOption GrenadeDuration;
        public static CustomToggleOption GrenadierIndicators;
        public static CustomToggleOption GrenadierVent;
        public static CustomNumberOption FlashRadius;

        public static CustomHeaderOption Veteran;
        public static CustomToggleOption KilledOnAlert;
        public static CustomNumberOption AlertCooldown;
        public static CustomNumberOption AlertDuration;
        public static CustomNumberOption MaxAlerts;

        public static CustomHeaderOption Tracker;
        public static CustomNumberOption UpdateInterval;
        public static CustomNumberOption TrackCooldown;
        public static CustomToggleOption ResetOnNewRound;
        public static CustomNumberOption MaxTracks;

        public static CustomHeaderOption Trapper;
        public static CustomNumberOption TrapCooldown;
        public static CustomToggleOption TrapsRemoveOnNewRound;
        public static CustomNumberOption MaxTraps;
        public static CustomNumberOption MinAmountOfTimeInTrap;
        public static CustomNumberOption TrapSize;
        public static CustomNumberOption MinAmountOfPlayersInTrap;

        public static CustomHeaderOption Poisoner;
        public static CustomNumberOption PoisonCooldown;
        public static CustomNumberOption PoisonDuration;
        public static CustomToggleOption PoisonerVent;

        public static CustomHeaderOption Traitor;
        public static CustomNumberOption LatestSpawn;
        public static CustomToggleOption NeutralKillingStopsTraitor;

        public static CustomHeaderOption Amnesiac;
        public static CustomToggleOption RememberArrows;
        public static CustomNumberOption RememberArrowDelay;

        public static CustomHeaderOption Medium;
        public static CustomNumberOption MediateCooldown;
        public static CustomToggleOption ShowMediatePlayer;
        public static CustomToggleOption ShowMediumToDead;
        public static CustomStringOption DeadRevealed;

        public static CustomHeaderOption Survivor;
        public static CustomNumberOption VestCd;
        public static CustomNumberOption VestDuration;
        public static CustomNumberOption VestKCReset;
        public static CustomNumberOption MaxVests;

        public static CustomHeaderOption GuardianAngel;
        public static CustomNumberOption ProtectCd;
        public static CustomNumberOption ProtectDuration;
        public static CustomNumberOption ProtectKCReset;
        public static CustomNumberOption MaxProtects;
        public static CustomStringOption ShowProtect;
        public static CustomStringOption GaOnTargetDeath;
        public static CustomToggleOption GATargetKnows;
        public static CustomToggleOption GAKnowsTargetRole;

        public static CustomHeaderOption Mystic;
        public static CustomNumberOption MysticArrowDuration;

        public static CustomHeaderOption Blackmailer;
        public static CustomNumberOption BlackmailCooldown;

        public static CustomHeaderOption Plaguebearer;
        public static CustomNumberOption InfectCooldown;
        public static CustomNumberOption PestKillCooldown;
        public static CustomToggleOption PestVent;

        public static CustomHeaderOption Werewolf;
        public static CustomNumberOption RampageCooldown;
        public static CustomNumberOption RampageDuration;
        public static CustomNumberOption RampageKillCooldown;
        public static CustomToggleOption WerewolfVent;

        public static CustomHeaderOption Detective;
        public static CustomNumberOption InitialExamineCooldown;
        public static CustomNumberOption ExamineCooldown;
        public static CustomNumberOption RecentKill;
        public static CustomToggleOption DetectiveReportOn;
        public static CustomNumberOption DetectiveRoleDuration;
        public static CustomNumberOption DetectiveFactionDuration;

        public static CustomHeaderOption Escapist;
        public static CustomNumberOption EscapeCooldown;
        public static CustomToggleOption EscapistVent;

        public static CustomHeaderOption Giant;
        public static CustomNumberOption GiantSlow;

        public static CustomHeaderOption Flash;
        public static CustomNumberOption FlashSpeed;

        public static CustomHeaderOption Diseased;
        public static CustomNumberOption DiseasedKillMultiplier;

        public static CustomHeaderOption Bait;
        public static CustomNumberOption BaitMinDelay;
        public static CustomNumberOption BaitMaxDelay;

        public static CustomHeaderOption Lovers;
        public static CustomToggleOption BothLoversDie;
        public static CustomNumberOption LovingImpPercent;
        public static CustomToggleOption NeutralLovers;

        public static Func<object, string> PercentFormat { get; } = value => $"{value:0}%";
        private static Func<object, string> CooldownFormat { get; } = value => $"{value:0.0#}秒";
        private static Func<object, string> MultiplierFormat { get; } = value => $"{value:0.0#}倍";


        public static void GenerateAll()
        {
            var num = 0;

            Patches.ExportButton = new Export(num++);
            Patches.ImportButton = new Import(num++);


            CrewInvestigativeRoles = new CustomHeaderOption(num++, MultiMenu.crewmate, "船员 — 情报型");
            DetectiveOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#4D4DFFFF>侧写师</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            HaunterOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#D3D3D3FF>冤魂</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            InvestigatorOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#00B3B3FF>调查员</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MysticOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#4D99E6FF>灵媒</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SeerOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#FFCC80FF>预言家</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SnitchOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#D4AF37FF>告密者</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SpyOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#CCA3CCFF>特工</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TrackerOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#009900FF>追踪者</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TrapperOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#A7D1B3FF>陷阱师</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            CrewKillingRoles = new CustomHeaderOption(num++, MultiMenu.crewmate, "船员 — 击杀型");
            SheriffOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#FFFF00FF>警长</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            VeteranOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#998040FF>老兵</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            VigilanteOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#FFFF99FF>侠客</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            CrewProtectiveRoles = new CustomHeaderOption(num++, MultiMenu.crewmate, "船员 — 保护型");
            AltruistOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#660000FF>殉道者</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MedicOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#006600FF>法医</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            CrewSupportRoles = new CustomHeaderOption(num++, MultiMenu.crewmate, "船员 — 辅助型");
            EngineerOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#FFA60AFF>工程师</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MayorOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#704FA8FF>市长</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MediumOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#A680FFFF>招魂师</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SwapperOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#66E666FF>换票师</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TimeLordOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#0000FFFF>时间领主</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TransporterOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#00EEFFFF>传送师</color>", 0f, 0f, 100f, 10f,
                PercentFormat);


            NeutralBenignRoles = new CustomHeaderOption(num++, MultiMenu.neutral, "独立阵营 — 善良");
            AmnesiacOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#80B2FFFF>失忆者</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            GuardianAngelOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#B3FFFFFF>守护天使</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SurvivorOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#FFE64DFF>幸存者</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            NeutralEvilRoles = new CustomHeaderOption(num++, MultiMenu.neutral, "独立阵营 — 邪恶");
            ExecutionerOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#8C4005FF>行刑者</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            JesterOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#FFBFCCFF>小丑</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            PhantomOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#662962FF>幻影</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            NeutralKillingRoles = new CustomHeaderOption(num++, MultiMenu.neutral, "独立阵营 — 杀手");
            ArsonistOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#FF4D00FF>纵火狂</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            PlaguebearerOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#E6FFB3FF>瘟疫之源</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            GlitchOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#00FF00FF>混沌</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            WerewolfOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#A86629FF>月下狼人</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            ImpostorConcealingRoles = new CustomHeaderOption(num++, MultiMenu.imposter, "伪装者 — 干扰型");
            EscapistOn = new CustomNumberOption(true, num++, MultiMenu.imposter, "<color=#FF0000FF>逃逸者</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            GrenadierOn = new CustomNumberOption(true, num++, MultiMenu.imposter, "<color=#FF0000FF>掷弹兵</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MorphlingOn = new CustomNumberOption(true, num++, MultiMenu.imposter, "<color=#FF0000FF>化形者</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SwooperOn = new CustomNumberOption(true, num++, MultiMenu.imposter, "<color=#FF0000FF>隐身人</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            ImpostorKillingRoles = new CustomHeaderOption(num++, MultiMenu.imposter, "伪装者 — 击杀型");
            PoisonerOn = new CustomNumberOption(true, num++, MultiMenu.imposter, "<color=#FF0000FF>绝命毒师</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TraitorOn = new CustomNumberOption(true, num++, MultiMenu.imposter, "<color=#FF0000FF>背叛者</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            ImpostorSupportRoles = new CustomHeaderOption(num++, MultiMenu.imposter, "伪装者 — 辅助型");
            BlackmailerOn = new CustomNumberOption(true, num++, MultiMenu.imposter, "<color=#FF0000FF>勒索者</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            JanitorOn = new CustomNumberOption(true, num++, MultiMenu.imposter, "<color=#FF0000FF>清理者</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MinerOn = new CustomNumberOption(true, num++, MultiMenu.imposter, "<color=#FF0000FF>管道工</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            UndertakerOn = new CustomNumberOption(true, num++, MultiMenu.imposter, "<color=#FF0000FF>送葬者</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            CrewmateModifiers = new CustomHeaderOption(num++, MultiMenu.modifiers, "船员 — 附加职业");
            BaitOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#00B3B3FF>诱饵</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            BlindOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#AAAAAAFF>胆小鬼</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            DiseasedOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#808080FF>病人</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MultitaskerOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#FF804DFF>多线程</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TorchOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#FFFF99FF>火炬</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            GlobalModifiers = new CustomHeaderOption(num++, MultiMenu.modifiers, "全体 — 附加职业");
            ButtonBarryOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#E600FFFF>执钮人</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            FlashOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#FF8080FF>闪电侠</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            GiantOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#FFB34DFF>巨人</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            LoversOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#FF66CCFF>恋人</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            RadarOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#FF0080FF>雷达</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SleuthOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#803333FF>掘墓者</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TiebreakerOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#99E699FF>破平者</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            ImpostorModifiers = new CustomHeaderOption(num++, MultiMenu.modifiers, "伪装者 — 附加职业");
            DisperserOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#FF0000FF>分散者</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            DoubleShotOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#FF0000FF>专业刺客</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            UnderdogOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#FF0000FF>潜伏者</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            GameModeSettings =
                new CustomHeaderOption(num++, MultiMenu.main, "自定义游戏设置");
            GameMode = new CustomStringOption(num++, MultiMenu.main, "游戏模式", new[] {"经典", "所有随机", "仅击杀"});

            ClassicSettings =
                new CustomHeaderOption(num++, MultiMenu.main, "经典模式设置");
            MinNeutralNonKillingRoles =
                new CustomNumberOption(num++, MultiMenu.main, "最少独立阵营无击杀技能职业数量", 1f, 0f, 5f, 1f);
            MaxNeutralNonKillingRoles =
                new CustomNumberOption(num++, MultiMenu.main, "最多独立阵营无击杀技能职业数量", 1f, 0f, 5f, 1f);
            MinNeutralKillingRoles =
                new CustomNumberOption(num++, MultiMenu.main, "最少独立阵营带击杀技能职业数量", 1f, 0f, 4f, 1f);
            MaxNeutralKillingRoles =
                new CustomNumberOption(num++, MultiMenu.main, "最多独立阵营带击杀技能职业数量", 1f, 0f, 4f, 1f);

            AllAnySettings =
                new CustomHeaderOption(num++, MultiMenu.main, "所有随机模式设置");
            RandomNumberImps = new CustomToggleOption(num++, MultiMenu.main, "伪装者随机数量", true);

            KillingOnlySettings =
                new CustomHeaderOption(num++, MultiMenu.main, "仅击杀模式设置");
            NeutralRoles =
                new CustomNumberOption(num++, MultiMenu.main, "独立阵营", 1f, 0f, 5f, 1f);
            VeteranCount =
                new CustomNumberOption(num++, MultiMenu.main, "老兵数量", 1f, 0f, 5f, 1f);
            VigilanteCount =
                new CustomNumberOption(num++, MultiMenu.main, "侠客数量", 1f, 0f, 5f, 1f);
            AddArsonist = new CustomToggleOption(num++, MultiMenu.main, "添加 纵火狂", true);
            AddPlaguebearer = new CustomToggleOption(num++, MultiMenu.main, "添加 瘟疫之源", true);

            MapSettings = new CustomHeaderOption(num++, MultiMenu.main, "地图设置");
            RandomMapEnabled = new CustomToggleOption(num++, MultiMenu.main, "随机地图", false);
            RandomMapSkeld = new CustomNumberOption(num++, MultiMenu.main, "骷髅舰 概率", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapMira = new CustomNumberOption(num++, MultiMenu.main, "米拉总部 概率", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapPolus = new CustomNumberOption(num++, MultiMenu.main, "波鲁斯 概率", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapAirship = new CustomNumberOption(num++, MultiMenu.main, "飞艇 概率", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapSubmerged = new CustomNumberOption(num++, MultiMenu.main, "潜水艇 概率", 0f, 0f, 100f, 10f, PercentFormat);
            AutoAdjustSettings = new CustomToggleOption(num++, MultiMenu.main, "自动调整设置", false);
            SmallMapHalfVision = new CustomToggleOption(num++, MultiMenu.main, "骷髅舰和米拉总部视野减半", false);
            SmallMapDecreasedCooldown =
                new CustomNumberOption(num++, MultiMenu.main, "米拉总部冷却时间减少", 0f, 0f, 15f, 2.5f, CooldownFormat);
            LargeMapIncreasedCooldown =
                new CustomNumberOption(num++, MultiMenu.main, "飞艇和潜水艇冷却时间增加", 0f, 0f, 15f, 2.5f, CooldownFormat);
            SmallMapIncreasedShortTasks =
                 new CustomNumberOption(num++, MultiMenu.main, "骷髅舰和米拉总部短任务增加", 0, 0, 5, 1);
            SmallMapIncreasedLongTasks =
                 new CustomNumberOption(num++, MultiMenu.main, "骷髅舰和米拉总部长任务增加", 0, 0, 3, 1);
            LargeMapDecreasedShortTasks =
                 new CustomNumberOption(num++, MultiMenu.main, "飞艇和潜水艇短任务减少", 0, 0, 5, 1);
            LargeMapDecreasedLongTasks =
                 new CustomNumberOption(num++, MultiMenu.main, "飞艇和潜水艇长任务减少", 0, 0, 3, 1);

            BetterPolusSettings =
                new CustomHeaderOption(num++, MultiMenu.main, "波鲁斯优化设置");
            VentImprovements = new CustomToggleOption(num++, MultiMenu.main, "优化波鲁斯通风口分布", false);
            VitalsLab = new CustomToggleOption(num++, MultiMenu.main, "生命监测装置转移到实验室", false);
            ColdTempDeathValley = new CustomToggleOption(num++, MultiMenu.main, "温度调节装置(降温)移动至外部", false);
            WifiChartCourseSwap =
                new CustomToggleOption(num++, MultiMenu.main, "重启WIFI与导航位置交换", false);

            CustomGameSettings =
                new CustomHeaderOption(num++, MultiMenu.main, "自定义游戏设置");
            ColourblindComms = new CustomToggleOption(num++, MultiMenu.main, "通讯破坏时开启隐蔽效果", false);
            ImpostorSeeRoles = new CustomToggleOption(num++, MultiMenu.main, "伪装者可见队友职业", false);
            DeadSeeRoles =
                new CustomToggleOption(num++, MultiMenu.main, "灵魂可以看到玩家的职业/投票", false);
            VanillaGame = new CustomNumberOption(num++, MultiMenu.main, "随机到纯原版游戏的概率", 0f, 0f, 100f, 5f,
                PercentFormat);
            InitialCooldowns =
                new CustomNumberOption(num++, MultiMenu.main, "游戏开局冷却时间", 10f, 10f, 30f, 2.5f, CooldownFormat);
            ParallelMedScans = new CustomToggleOption(num++, MultiMenu.main, "可同时进行扫描任务（取消金水任务效果）", false);
            SkipButtonDisable = new CustomStringOption(num++, MultiMenu.main, "禁用跳过会议按钮", new[] { "关闭", "仅紧急会议", "开启" });
            DisableLevels = new CustomToggleOption(num++, MultiMenu.main, "隐藏等级图标", false);
            WhiteNameplates = new CustomToggleOption(num++, MultiMenu.main, "隐藏玩家名称", false);

            TaskTrackingSettings =
                new CustomHeaderOption(num++, MultiMenu.main, "任务追踪设置");
            SeeTasksDuringRound = new CustomToggleOption(num++, MultiMenu.main, "对局中显示任务追踪", false);
            SeeTasksDuringMeeting = new CustomToggleOption(num++, MultiMenu.main, "会议中显示任务追踪", false);
            SeeTasksWhenDead = new CustomToggleOption(num++, MultiMenu.main, "死亡后显示任务追踪", true);

            Assassin = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>刺客能力</color>");
            NumberOfImpostorAssassins = new CustomNumberOption(num++, MultiMenu.imposter, "伪装者刺客能力者数量", 1, 0, 4, 1);
            NumberOfNeutralAssassins = new CustomNumberOption(num++, MultiMenu.imposter, "独立阵营刺客能力者数量", 1, 0, 5, 1);
            AmneTurnImpAssassin = new CustomToggleOption(num++, MultiMenu.imposter, "失忆者变为伪装者阵营时获得能力", false);
            AmneTurnNeutAssassin = new CustomToggleOption(num++, MultiMenu.imposter, "失忆者变为杀手型独立阵营时获得能力", false);
            TraitorCanAssassin = new CustomToggleOption(num++, MultiMenu.imposter, "背叛者可获得刺客能力", false);
            AssassinKills = new CustomNumberOption(num++, MultiMenu.imposter, "刺客可猜测次数", 1, 1, 15, 1);
            AssassinMultiKill = new CustomToggleOption(num++, MultiMenu.imposter, "刺客可在一次会议中多次猜测", false);
            AssassinCrewmateGuess = new CustomToggleOption(num++, MultiMenu.imposter, "可猜测普通船员", false);
            AssassinSnitchViaCrewmate = new CustomToggleOption(num++, MultiMenu.imposter, "使用普通船员选项猜测告密者", false);
            AssassinGuessNeutralBenign = new CustomToggleOption(num++, MultiMenu.imposter, "可猜测独立阵营 - 善良职业", false);
            AssassinGuessNeutralEvil = new CustomToggleOption(num++, MultiMenu.imposter, "可猜测独立阵营 - 邪恶职业", false);
            AssassinGuessNeutralKilling = new CustomToggleOption(num++, MultiMenu.imposter, "可猜测独立阵营 - 杀手职业", false);
            AssassinGuessImpostors = new CustomToggleOption(num++, MultiMenu.imposter, "刺客可猜测伪装者职业", false);
            AssassinGuessModifiers = new CustomToggleOption(num++, MultiMenu.imposter, "可猜测船员 — 附加职业", false);
            AssassinGuessLovers = new CustomToggleOption(num++, MultiMenu.imposter, "可猜测恋人", false);
            AssassinateAfterVoting = new CustomToggleOption(num++, MultiMenu.imposter, "即使已投票仍然可以猜测", false);

            Detective =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#4D4DFFFF>侧写师</color>");
            InitialExamineCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "验证凶手技能初始冷却时间", 25f, 10f, 60f, 2.5f, CooldownFormat);
            ExamineCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "验证凶手技能冷却时间", 10f, 1f, 15f, 1f, CooldownFormat);
            RecentKill =
                new CustomNumberOption(num++, MultiMenu.crewmate, "玩家的血迹持续时间", 25f, 10f, 60f, 2.5f, CooldownFormat);
            DetectiveReportOn = new CustomToggleOption(num++, MultiMenu.crewmate, "查看侧写报告", true);
            DetectiveRoleDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "最大死亡时间 —— 侧写报告包含职业", 15f, 0f, 60f, 2.5f,
                    CooldownFormat);
            DetectiveFactionDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "最大死亡时间 —— 侧写报告包含阵营", 30f, 0f, 60f, 2.5f,
                    CooldownFormat);

            Haunter =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#d3d3d3FF>冤魂</color>");
            HaunterTasksRemainingClicked =
                 new CustomNumberOption(num++, MultiMenu.crewmate, "冤魂可被点击的剩余任务数", 5, 1, 15, 1);
            HaunterTasksRemainingAlert =
                 new CustomNumberOption(num++, MultiMenu.crewmate, "给被揭露人发送警报的剩余任务数", 1, 1, 5, 1);
            HaunterRevealsNeutrals = new CustomToggleOption(num++, MultiMenu.crewmate, "冤魂可揭露独立阵营职业", false);
            HaunterCanBeClickedBy = new CustomStringOption(num++, MultiMenu.crewmate, "谁可以点击冤魂", new[] { "所有人", "船员以外", "伪装者" });

            Investigator =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#00B3B3FF>调查员</color>");
            FootprintSize = new CustomNumberOption(num++, MultiMenu.crewmate, "脚印尺寸", 4f, 1f, 10f, 1f);
            FootprintInterval =
                new CustomNumberOption(num++, MultiMenu.crewmate, "脚印间隔", 0.1f, 0.05f, 1f, 0.05f, CooldownFormat);
            FootprintDuration = new CustomNumberOption(num++, MultiMenu.crewmate, "脚印持续时间", 10f, 1f, 15f, 0.5f, CooldownFormat);
            AnonymousFootPrint = new CustomToggleOption(num++, MultiMenu.crewmate, "匿名脚印", false);
            VentFootprintVisible = new CustomToggleOption(num++, MultiMenu.crewmate, "通风管道可见脚印", false);

            Mystic =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#4D99E6FF>灵媒</color>");
            MysticArrowDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "指向尸体箭头持续时间", 0.1f, 0f, 1f, 0.05f, CooldownFormat);

            Seer =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#FFCC80FF>预言家</color>");
            SeerCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "预言技能冷却时间", 25f, 10f, 60f, 2.5f, CooldownFormat);
            CrewKillingRed =
                new CustomToggleOption(num++, MultiMenu.crewmate, "击杀型船员显示红名", false);
            NeutBenignRed =
                new CustomToggleOption(num++, MultiMenu.crewmate, "善良独立阵营显示红名", false);
            NeutEvilRed =
                new CustomToggleOption(num++, MultiMenu.crewmate, "邪恶独立阵营显示红名", false);
            NeutKillingRed =
                new CustomToggleOption(num++, MultiMenu.crewmate, "杀手独立阵营显示红名", false);
            TraitorColourSwap =
                new CustomToggleOption(num++, MultiMenu.crewmate, "背叛者不变换颜色", false);

            Snitch = new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#D4AF37FF>告密者</color>");
            SnitchOnLaunch =
                new CustomToggleOption(num++, MultiMenu.crewmate, "告密者开局就显示职业", false);
            SnitchSeesNeutrals = new CustomToggleOption(num++, MultiMenu.crewmate, "告密者可显示独立阵营职业", false);
            SnitchTasksRemaining =
                 new CustomNumberOption(num++, MultiMenu.crewmate, "警告被揭露者时的剩余任务", 1, 1, 5, 1);
            SnitchSeesImpInMeeting = new CustomToggleOption(num++, MultiMenu.crewmate, "告密者在会议中显示被揭露者职业", true);
            SnitchSeesTraitor = new CustomToggleOption(num++, MultiMenu.crewmate, "告密者可以看到背叛者", true);

            Tracker =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#009900FF>追踪者</color>");
            UpdateInterval =
                new CustomNumberOption(num++, MultiMenu.crewmate, "追踪箭头更新间隔", 5f, 0.5f, 15f, 0.5f, CooldownFormat);
            TrackCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "追踪冷却", 25f, 10f, 60f, 2.5f, CooldownFormat);
            ResetOnNewRound = new CustomToggleOption(num++, MultiMenu.crewmate, "会议后重置追踪箭头", false);
            MaxTracks = new CustomNumberOption(num++, MultiMenu.crewmate, "每轮最多追踪人数", 5, 1, 15, 1);

            Trapper =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#A7D1B3FF>陷阱师</color>");
            MinAmountOfTimeInTrap =
                new CustomNumberOption(num++, MultiMenu.crewmate, "被陷阱记录的最少时间", 1f, 0f, 15f, 0.5f, CooldownFormat);
            TrapCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "陷阱放置冷却", 25f, 10f, 40f, 2.5f, CooldownFormat);
            TrapsRemoveOnNewRound =
                new CustomToggleOption(num++, MultiMenu.crewmate, "每轮结束后移除陷阱", true);
            MaxTraps =
                new CustomNumberOption(num++, MultiMenu.crewmate, "最多陷阱放置数量", 5, 1, 15, 1);
            TrapSize =
                new CustomNumberOption(num++, MultiMenu.crewmate, "陷阱尺寸", 1f, 0.5f, 5f, 0.5f, MultiplierFormat);
            MinAmountOfPlayersInTrap =
                new CustomNumberOption(num++, MultiMenu.crewmate, "触发陷阱所需的最少人数", 3, 1, 5, 1);

            Sheriff =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#FFFF00FF>警长</color>");
            SheriffKillOther =
                new CustomToggleOption(num++, MultiMenu.crewmate, "警长误杀船员也将死亡", false);
            SheriffKillsJester =
                new CustomToggleOption(num++, MultiMenu.crewmate, "警长可击杀小丑", false);
            SheriffKillsGlitch =
                new CustomToggleOption(num++, MultiMenu.crewmate, "警长可击杀混沌", false);
            SheriffKillsExecutioner =
                new CustomToggleOption(num++, MultiMenu.crewmate, "警长可击杀行刑者", false);
            SheriffKillsArsonist =
                new CustomToggleOption(num++, MultiMenu.crewmate, "警长可击杀纵火狂", false);
            SheriffKillsWerewolf =
                new CustomToggleOption(num++, MultiMenu.crewmate, "警长可击杀月下狼人", false);
            SheriffKillsPlaguebearer =
                new CustomToggleOption(num++, MultiMenu.crewmate, "警长可击杀瘟疫之源", false);
            SheriffKillCd =
                new CustomNumberOption(num++, MultiMenu.crewmate, "警长击杀冷却", 25f, 10f, 40f, 2.5f, CooldownFormat);
            SheriffBodyReport = new CustomToggleOption(num++, MultiMenu.crewmate, "警长可以报告他们所杀的人");

            Veteran =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#998040FF>老兵</color>");
            KilledOnAlert =
                new CustomToggleOption(num++, MultiMenu.crewmate, "可在警戒时被击杀", false);
            AlertCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "警戒技能冷却", 25f, 10f, 60f, 2.5f, CooldownFormat);
            AlertDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "警戒持续时间", 10f, 5f, 15f, 1f, CooldownFormat);
            MaxAlerts = new CustomNumberOption(num++, MultiMenu.crewmate, "最多可警戒次数", 5, 1, 15, 1);

            Vigilante = new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#FFFF99FF>侠客</color>");
            VigilanteKills = new CustomNumberOption(num++, MultiMenu.crewmate, "侠客最多可猜测次数", 1, 1, 15, 1);
            VigilanteMultiKill = new CustomToggleOption(num++, MultiMenu.crewmate, "同一轮会议侠客可多次猜测", false);
            VigilanteGuessNeutralBenign = new CustomToggleOption(num++, MultiMenu.crewmate, "侠客可猜测善良独立阵营", false);
            VigilanteGuessNeutralEvil = new CustomToggleOption(num++, MultiMenu.crewmate, "侠客可猜测邪恶独立阵营", false);
            VigilanteGuessNeutralKilling = new CustomToggleOption(num++, MultiMenu.crewmate, "侠客可猜测杀手独立阵营", false);
            VigilanteGuessLovers = new CustomToggleOption(num++, MultiMenu.crewmate, "侠客可猜测恋人", false);
            VigilanteAfterVoting = new CustomToggleOption(num++, MultiMenu.crewmate, "侠客可在投票后猜测", false);

            Altruist = new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#660000FF>殉道者</color>");
            ReviveDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "殉道者复活时间", 10f, 1f, 15f, 1f, CooldownFormat);
            AltruistTargetBody =
                new CustomToggleOption(num++, MultiMenu.crewmate, "开始复活时目标尸体消失", false);

            Medic =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#006600FF>法医</color>");
            ShowShielded =
                new CustomStringOption(num++, MultiMenu.crewmate, "可看见被保护玩家的人",
                    new[] {  "被保护人", "法医", "法医和被保护人", "所有人" });
            WhoGetsNotification =
                new CustomStringOption(num++, MultiMenu.crewmate, "可看见击杀尝试的人",
                    new[] { "法医", "被保护人", "所有人", "不可见" });
            ShieldBreaks = new CustomToggleOption(num++, MultiMenu.crewmate, "击杀尝试后护盾破碎", false);
            MedicReportSwitch = new CustomToggleOption(num++, MultiMenu.crewmate, "显示尸检报告");
            MedicReportNameDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "显示凶手名字的报告时间", 0f, 0f, 60f, 2.5f,
                    CooldownFormat);
            MedicReportColorDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "显示凶手颜色类型的报告时间", 15f, 0f, 60f, 2.5f,
                    CooldownFormat);

            Engineer =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#FFA60AFF>工程师</color>");
            EngineerPer =
                new CustomStringOption(num++, MultiMenu.crewmate, "工程师可修复次数", new[] { "每轮一次", "游戏中仅一次" });

            Mayor =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#704FA8FF>市长</color>");
            MayorVoteBank =
                new CustomNumberOption(num++, MultiMenu.crewmate, "市长初始票数", 1, 1, 15, 1);
            MayorAnonymous =
                new CustomToggleOption(num++, MultiMenu.crewmate, "市长匿名投票", false);

            Medium =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#A680FFFF>招魂师</color>");
            MediateCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "招魂技能冷却", 10f, 1f, 15f, 1f, CooldownFormat);
            ShowMediatePlayer =
                new CustomToggleOption(num++, MultiMenu.crewmate, "显示招魂目标外观", true);
            ShowMediumToDead =
                new CustomToggleOption(num++, MultiMenu.crewmate, "向招魂目标显示职业", true);
            DeadRevealed =
                new CustomStringOption(num++, MultiMenu.crewmate, "可被招魂及显示职业的目标", new[] { "死亡很久的人", "刚死亡的人", "所有死者" });

            Swapper =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#66E666FF>换票师</color>");
            SwapperButton =
                new CustomToggleOption(num++, MultiMenu.crewmate, "换票师可召开紧急会议", true);

            TimeLord =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#0000FFFF>时间领主</color>");
            RewindRevive = new CustomToggleOption(num++, MultiMenu.crewmate, "回溯可复活死者", false);
            RewindDuration = new CustomNumberOption(num++, MultiMenu.crewmate, "回溯持续时间", 2f, 2f, 5f, 0.5f, CooldownFormat);
            RewindCooldown = new CustomNumberOption(num++, MultiMenu.crewmate, "回溯冷却", 25f, 10f, 60f, 2.5f, CooldownFormat);
            RewindMaxUses =
                 new CustomNumberOption(num++, MultiMenu.crewmate, "最多回溯次数", 5, 1, 15, 1);
            TimeLordVitals =
                new CustomToggleOption(num++, MultiMenu.crewmate, "时间领主可使用生命监测", false);

            Transporter =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#00EEFFFF>传送师</color>");
            TransportCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "传送技能冷却", 25f, 10f, 60f, 2.5f, CooldownFormat);
            TransportMaxUses =
                new CustomNumberOption(num++, MultiMenu.crewmate, "最多可传送次数", 5, 1, 15, 1);
            TransporterVitals =
                new CustomToggleOption(num++, MultiMenu.crewmate, "传送师可使用生命监测", false);

            Amnesiac = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#80B2FFFF>失忆者</color>");
            RememberArrows =
                new CustomToggleOption(num++, MultiMenu.neutral, "失忆者显示指向尸体的箭头", false);
            RememberArrowDelay =
                new CustomNumberOption(num++, MultiMenu.neutral, "出现尸体后多久显示箭头", 5f, 0f, 15f, 1f, CooldownFormat);

            GuardianAngel =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#B3FFFFFF>守护天使</color>");
            ProtectCd =
                new CustomNumberOption(num++, MultiMenu.neutral, "守护技能冷却", 25f, 10f, 60f, 2.5f, CooldownFormat);
            ProtectDuration =
                new CustomNumberOption(num++, MultiMenu.neutral, "守护持续时间", 10f, 5f, 15f, 1f, CooldownFormat);
            ProtectKCReset =
                new CustomNumberOption(num++, MultiMenu.neutral, "击杀被守护对象时击杀重置冷却时间", 2.5f, 0f, 15f, 0.5f, CooldownFormat);
            MaxProtects =
                new CustomNumberOption(num++, MultiMenu.neutral, "最多守护次数", 5, 1, 15, 1);
            ShowProtect =
                new CustomStringOption(num++, MultiMenu.neutral, "被守护玩家可见的人员",
                    new[] { "被守护者", "守护天使", "守护双方", "所有人" });
            GaOnTargetDeath = new CustomStringOption(num++, MultiMenu.neutral, "被守护者死亡后守护天使将变成",
                new[] { "船员", "失忆者", "幸存者", "小丑" });
            GATargetKnows =
                new CustomToggleOption(num++, MultiMenu.neutral, "被守护者知道守护天使的存在", false);
            GAKnowsTargetRole =
                new CustomToggleOption(num++, MultiMenu.neutral, "守护天使知道被守护者职业", false);

            Survivor =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#FFE64DFF>幸存者</color>");
            VestCd =
                new CustomNumberOption(num++, MultiMenu.neutral, "防弹衣冷却", 25f, 10f, 60f, 2.5f, CooldownFormat);
            VestDuration =
                new CustomNumberOption(num++, MultiMenu.neutral, "防弹衣持续时间", 10f, 5f, 15f, 1f, CooldownFormat);
            VestKCReset =
                new CustomNumberOption(num++, MultiMenu.neutral, "防弹衣使用被击杀时重置击杀冷却时间", 2.5f, 0f, 15f, 0.5f, CooldownFormat);
            MaxVests =
                new CustomNumberOption(num++, MultiMenu.neutral, "防弹衣最多使用次数", 5, 1, 15, 1);

            Executioner =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#8C4005FF>行刑者</color>");
            OnTargetDead = new CustomStringOption(num++, MultiMenu.neutral, "目标死亡后职业变更为",
                new[] { "船员", "失忆者", "幸存者", "小丑" });
            ExecutionerButton =
                new CustomToggleOption(num++, MultiMenu.neutral, "行刑者可召开紧急会议", true);

            Jester =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#FFBFCCFF>小丑</color>");
            JesterButton =
                new CustomToggleOption(num++, MultiMenu.neutral, "小丑可使用紧急会议", true);
            JesterVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "小丑可使用通风管道", false);
            JesterImpVision =
                new CustomToggleOption(num++, MultiMenu.neutral, "小丑拥有伪装者视野", false);

            Phantom =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#662962FF>幻影</color>");
            PhantomTasksRemaining =
                 new CustomNumberOption(num++, MultiMenu.neutral, "幻影可被点击时的剩余任务次数", 5, 1, 15, 1);

            Arsonist = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#FF4D00FF>纵火狂</color>");
            DouseCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "浇油冷却", 25f, 10f, 60f, 2.5f, CooldownFormat);
            MaxDoused =
                new CustomNumberOption(num++, MultiMenu.neutral, "存活玩家最多可被浇油数", 5, 1, 15, 1);
            ArsoImpVision =
                new CustomToggleOption(num++, MultiMenu.neutral, "纵火狂拥有伪装者视野", false);
            IgniteCdRemoved =
                new CustomToggleOption(num++, MultiMenu.neutral, "当纵火狂为最后的击杀型职业时移除点燃冷却", false);

            Plaguebearer = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#E6FFB3FF>瘟疫之源</color>");
            InfectCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "感染技能冷却", 25f, 10f, 60f, 2.5f, CooldownFormat);
            PestKillCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "瘟疫之源击杀冷却", 25f, 10f, 60f, 2.5f, CooldownFormat);
            PestVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "瘟疫之源可使用通风管道", false);

            TheGlitch =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#00FF00FF>混沌</color>");
            MimicCooldownOption = new CustomNumberOption(num++, MultiMenu.neutral, "化形技能冷却", 25f, 10f, 60f, 2.5f, CooldownFormat);
            MimicDurationOption = new CustomNumberOption(num++, MultiMenu.neutral, "化形持续时间", 10f, 1f, 15f, 1f, CooldownFormat);
            HackCooldownOption = new CustomNumberOption(num++, MultiMenu.neutral, "骇入技能冷却", 25f, 10f, 60f, 2.5f, CooldownFormat);
            HackDurationOption = new CustomNumberOption(num++, MultiMenu.neutral, "骇入持续时间", 10f, 1f, 15f, 1f, CooldownFormat);
            GlitchKillCooldownOption =
                new CustomNumberOption(num++, MultiMenu.neutral, "击杀冷却时间", 25f, 10f, 120f, 2.5f, CooldownFormat);
            GlitchHackDistanceOption =
                new CustomStringOption(num++, MultiMenu.neutral, "混沌骇入距离", new[] { "短", "中", "长" });
            GlitchVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "混沌可以使用通风管道", false);

            Werewolf = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#A86629FF>月下狼人</color>");
            RampageCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "暴走技能冷却", 25f, 10f, 60f, 2.5f, CooldownFormat);
            RampageDuration =
                new CustomNumberOption(num++, MultiMenu.neutral, "暴走持续时间", 25f, 10f, 60f, 2.5f, CooldownFormat);
            RampageKillCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "暴走击杀冷却", 10f, 0.5f, 15f, 0.5f, CooldownFormat);
            WerewolfVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "暴走时可使用通风管道", false);

            Escapist =
                new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>逃逸者</color>");
            EscapeCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "标记冷却", 25f, 10f, 60f, 2.5f, CooldownFormat);
            EscapistVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "逃逸者可使用通风管道", false);
                
            Grenadier =
                new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>掷弹兵</color>");
            GrenadeCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "闪光弹冷却", 25f, 10f, 60f, 2.5f, CooldownFormat);
            GrenadeDuration =
                new CustomNumberOption(num++, MultiMenu.imposter, "闪光持续时间", 10f, 5f, 15f, 1f, CooldownFormat);
            FlashRadius =
                new CustomNumberOption(num++, MultiMenu.imposter, "闪光范围", 1f, 0.25f, 5f, 0.25f, MultiplierFormat);
            GrenadierIndicators =
                new CustomToggleOption(num++, MultiMenu.imposter, "闪光时显示被投掷闪光弹的玩家", false);
            GrenadierVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "可使用通风管道", false);

            Morphling =
                new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>化形者</color>");
            MorphlingCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "化形技能冷却时间", 25f, 10f, 60f, 2.5f, CooldownFormat);
            MorphlingDuration =
                new CustomNumberOption(num++, MultiMenu.imposter, "化形持续时间", 10f, 5f, 15f, 1f, CooldownFormat);
            MorphlingVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "化形者可使用通风管道", false);

            Swooper = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>隐身人</color>");

            SwoopCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "隐身技能冷却时间", 25, 10, 40, 2.5f, CooldownFormat);
            SwoopDuration =
                new CustomNumberOption(num++, MultiMenu.imposter, "隐身持续时间", 10, 5, 15, 1f, CooldownFormat);
            SwooperVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "隐身人可使用通风管道", false);

            Poisoner =
                new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>绝命毒师</color>");
            PoisonCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "下毒技能冷却时间", 25f, 10f, 60f, 2.5f, CooldownFormat);
            PoisonDuration =
                new CustomNumberOption(num++, MultiMenu.imposter, "毒杀延迟时间", 5f, 1f, 15f, 1f, CooldownFormat);
            PoisonerVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "绝命毒师可使用通风管道", false);

            Traitor = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>背叛者</color>");
            LatestSpawn = new CustomNumberOption(num++, MultiMenu.imposter, "背叛者出现时最少存活玩家数量", 5, 3, 15, 1);
            NeutralKillingStopsTraitor =
                new CustomToggleOption(num++, MultiMenu.imposter, "杀手独立阵营存活时不会出现背叛者", false);

            Blackmailer = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>勒索者</color>");
            BlackmailCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "初始勒索技能冷却时间", 10f, 1f, 15f, 1f, CooldownFormat);

            Miner = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>管道工</color>");
            MineCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "挖洞技能冷却", 25f, 10f, 60f, 2.5f, CooldownFormat);

            Undertaker = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>送葬者</color>");
            DragCooldown = new CustomNumberOption(num++, MultiMenu.imposter, "拖动尸体冷却时间", 25f, 10f, 60f, 2.5f, CooldownFormat);
            UndertakerVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "送葬者可使用通风管道", false);
            UndertakerVentWithBody =
                new CustomToggleOption(num++, MultiMenu.imposter, "送葬者可拖动尸体进入通风管道", false);

            Bait = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#00B3B3FF>诱饵</color>");
            BaitMinDelay = new CustomNumberOption(num++, MultiMenu.modifiers, "诱饵报告最小延迟时间", 0f, 0f, 15f, 0.5f, CooldownFormat);
            BaitMaxDelay = new CustomNumberOption(num++, MultiMenu.modifiers, "诱饵报告最大延迟时间", 1f, 0f, 15f, 0.5f, CooldownFormat);

            Diseased = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#808080FF>病人</color>");
            DiseasedKillMultiplier = new CustomNumberOption(num++, MultiMenu.modifiers, "杀死病人技能冷却倍率", 3f, 1.5f, 5f, 0.5f, MultiplierFormat);

            Flash = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#FF8080FF>闪电侠</color>");
            FlashSpeed = new CustomNumberOption(num++, MultiMenu.modifiers, "闪电侠速率", 1.25f, 1.05f, 2.5f, 0.05f, MultiplierFormat);

            Giant = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#FFB34DFF>巨人</color>");
            GiantSlow = new CustomNumberOption(num++, MultiMenu.modifiers, "巨人速率", 0.75f, 0.5f, 1f, 0.05f, MultiplierFormat);

            Lovers =
                new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#FF66CCFF>恋人</color>");
            BothLoversDie = new CustomToggleOption(num++, MultiMenu.modifiers, "恋人同生共死");
            LovingImpPercent = new CustomNumberOption(num++, MultiMenu.modifiers, "伪装者恋人生成概率", 20f, 0f, 100f, 10f,
                PercentFormat);
            NeutralLovers = new CustomToggleOption(num++, MultiMenu.modifiers, "独立阵营可成为恋人");

                        Underdog = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#FF0000FF>潜伏者</color>");
            UnderdogKillBonus = new CustomNumberOption(num++, MultiMenu.modifiers, "击杀冷却时间递增递减值", 5f, 2.5f, 30f, 2.5f, CooldownFormat);
            UnderdogIncreasedKC = new CustomToggleOption(num++, MultiMenu.modifiers, "伪装者存活2人以上时击杀冷却递增", true);
        }
    }
}