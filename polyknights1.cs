using Enumerator;
using System.Collections.Generic;
using System.Linq;

{    public class PolyKnightsExecutor : DefaultExecutor
     { public static void Init()
   
        DecksManager.AddDeckType("PolyKnights", DuelRules.MasterDuel, (ai, duel) => new PolyKnightsExecutor(ai, duel),
                  "s+Gf02rCtK6mmEVfUokVho3NpZhguE3EnfWM7Fpm0xtnwXjxo2RWGNZc38oIwyuePmOCYakr2nC8XvkeAwjf0o1j+HVHhHHZ7C+MkdXJLLtksliOrrzFonxtLhMMx2beg2PXcjfW/Z3XmUC45uNd1k/7WxlhWGbJIZbYEzUsqwQdmR6fL2FadnY3w3TFFFaBk1eYT2tuZ/x+dw8zCC/0mc74Zl09c8x+Q5azDxQZetVnMK99xMUEw/sWVjPA8N/OOawwrDbBiRmGb0/NZoJhUFgBAA==");
     }
public class CardId
private bool TornscalesinGY = false;
private bool Rustyposition = 6 = false;
private bool wasTornScalesSummonedThisTurn = false;
private bool TornscalesHitGY = false;
private bool RaggedGlovesHitGY = false;
private bool BootsHitGY = false;
private bool AncientCloakHitGY = false;
private bool InvocationHitGY = false;
private List<int> CombosInHand;
private bool ROTAinhand = false;

{
      //main deck
           //monsters
      public const int DarkMagician = 36996508
      public const int RedEyes = 74677422
      public const int Aleister = 86120751
      public const int Scorpio = 35272499
      public const int StainedGreaves = 88544390
      public const int DarlingtonCobra = 61677004
      public const int RaggedGloves = 63821877
      public const int AncientCloak = 90432163
      public const int TornScales = 2538345
      public const int Lonefire = 48686504
      public const int Boots = 36426778
      public const int AshBlossom = 14558127
           //spells
      public const int REFusion = 6172122
      public const int FeatherDuster = 18144506
      public const int ROTA = 32807846
      public const int Terraforming = 73628505
      public const int Invocation = 74063034
      public const int Foolish = 81439173
      public const int TwinTwisters = 43898403
      public const int SuperPoly = 48130397
      public const int PKRankUpMagic = 88504133
      public const int MagicalMeltdown = 47679935
            //traps
      public const int PKWing = 98431356
      public const int FogBlade = 25542642
            //Extra Deck Monsters
      public const int Triphy = 79864860
      public const int Mechaba = 75286621
      public const int Dragoon = 37818794
      public const int StarvingVenom = 41209827
      public const int Purgatrio = 12307878
      public const int Zeus = 90448279
      public const int ArcRebellion = 64276752
      public const int RaidersKnight = 28781003
      public const int BreakSword =  62709239
      public const int Rusty = 26692769
      public const int Cherubini = 58699500
      public const int Verte = 70369116
      public const int SecureGardna = 2220237
      public const int Almiraj = 60303245
     
                //side deck
      public const int ArtifactLancea = 34267821
      public const int GateBlocker = 8102334
      public const int Droll = 94145021
      public const int DRNM = 54693926
      public const int SolemnStrike = 40605147
     }
            private readonly List<int> Combo_cards = new List<int>()
        {
            CardId.RaggedGloves,
            CardId.Boots,
            CardId.AncientGloves,
            CardId.TornScales,
            CardId.Alesiter,
            CardId.Foolish,
            CardId.ROTA,
            CardId.lonefire,
            CardId.Scorpio,
            CardId.DarlingtonCobra,
            CardId.StainedGreaves,

        };
private readonly List<int> normal_counter = new List<int>
        {
            53262004, 98338152, 32617464, 45041488,
            61257789, 23440231, 27354732, 12408276, 82419869, 
            49680980, 18621798, 38814750, 17266660, 94689635, 
            74762582, 75286651, 4810828,  44665365, 21123811, 50954680,
            82044279, 82044280, 79606837, 10443957, 1621413,
            90809975, 8165596,  9753964,  53347303, 88307361, 55063751,
            5818294,  2948263,  6150044,  26268488, 51447164, 63941210,
            97268402
        };
private readonly List<int> should_not_negate = new List<int>
        {
            81275020, 28985331
        };
private readonly List<int> PhantomKnight_links = new List<int>
        {
            CardId.Rusty,
            CardId.SecureGardna,
            CardId.Almiraj
        };
private readonly List<int> TornscalesTargets = new List<int>
        {
            CardId.TornScales,
            CardId.RaggedGloves,
            CardId.Boots,
            CardId.StainedGreaves
        };
private readonly List<int> PolyKnights_combopieces = new List<int>
        {
            CardId.TornScales,
            CardId.Boots,
            CardId.RaggedGloves,
            CardId.StainedGreaves,
            CardId.FogBlade,
            CardId.BreakSword,
            CardId.RaidersKnight,
            CardId.ArcRebellion
        };
private readonly List<int> RustyMaterials = new List<int>
        {
            CardId.SecureGardna,
            CardId.BreakSword,
            CardId.Tornscales,
            CardId.RaggedGloves,
            CardId.Almiraj,
            CardId.Cherubini,
            CardId.Lonefire,
            CardId.StainedGreaves,
            CardId.DarlingtonCobra,
            CardId.Almiraj,
            CardId.Scorpio,
            CardId.Aleister,

        };
private readonly List<int> PK_spellTrap = new List<int>
        {
            CardId.FogBlade,
            CardId.PKRankUpMagic,
            CardId.MagicalMeltdown,
            
        };
private bool TornScalesUsedThisTurn = false;
private bool wasBootsActivatedThisTurn = false;
private bool wasRaggedGlovesActivatedThisTurn = false;
private bool ScorpioActivatedThisTurn = false;

public PolyKnightsExecutor(GameAI ai, BotDuel duel) : base(ai, duel)
    {
    AddExecuotr(ExecutorType.Summon, CardId.Tornscales)
    AddExecutor(ExecutorType.Activate, CardId.TornScales, TornScales_activate, GY_act_eff);
    Addexecutor(ExecutorTyoe.SpSummon, CardId.Boots, BootsSummon);
    AddExecutor(ExecutorType.Activate, CardId.Boots, GY_act_eff);
    AddExecutor(ExecutorType.SPSummon, CardId.StainedGreaves. StainedGreavesSummon);
    AddExecutor(ExecutorType.Activate, CardId.Scorpio, Scorpio_activate);
    AddExecutor(executorType.SpSummon, CardId.ScorpioSummon);
    AddExecutor(ExecutoeType.Summon, CardId.LoneFire);
    AddExecutor(ExecutorType.Activate, CardId.Lonefire, Lonefire_activate);
    AddExecutor(ExecutorType.Summon, CardId.AncientCloak);
    AddExecutor(ExecutorType.Activate, CardId.AncientCloak, AncientCloak_act_eff, GY_act_eff);
    Addexecutor(ExecutorTypeS.Summon Card.Id RaggedGloves);
    AddExecutor(ExecutorType.Activate, CardId.RaggedGloves, GY_act_eff);
    AddExecutor(ExecutorType.Activate, CardId.DarkMagician);
    AddExecutor(ExecutorType.Activate, CardId.RedEyes);
    AddExecutor(ExecutorType.Summon, CardId.Aleister);
    AddExecutor(ExecutorType.Activate, CardId.Alesiter, AleisterEffect);
    AddExecutor(ExecutorType.Summon, CardId DarlingtonCobra);
    AddExecutor(ExecutorType.Activate, CardId.DarlingtonCobra, DarlingtonCobra_activate);
    AddExecutor(ExecutorType.Activate, CardId.Ashblossom, Hand_act_eff);
    AddExecutor(ExecutorType.Activate, CardId.REFusion,  REFusion_activate);
    AddExecutor(ExecutorType.Activate, CardId.FeatherDuster, HarpieFeatherDuster);
    AddExecutor(ExecutorType.Activate, CardId.ROTA, ROTA_activate);
    AddExecutor(ExecutorType.Activate, CardId.Terraforming, Terraforming_activate);
    AddExecutor(ExecutorType.Activate, CardId.Invocation, Invocation_activate, GY_act_eff);
    AddExecutor(ExecutorType.Activate, CardId.Foolish, Foolish_activate);
    AddExecutor(ExecutorType.Activate, CardId.TwinTwisters, TwinTwisters_activate);
    AddExecutor(ExecutorType.Activate, CardId.SuperPoly, Superpoly_activate);
    AddExecutor(ExecutorType.Activate, CardId.PKRankUpMagic, PKRankUpMagic_activate);
    AddExecutor(ExecutorType.Activate, CardId.MagicalMeltdown, MagicalMeltdown_activate);
    AddExecutor(ExecutorType.Activate, CardId.PKWing, PKWing_activate);
    AddExecutor(ExecutorType.Activate, CardId.FogBlade, FogBlade_activate, GY_act_eff);
    AddExecutor(ExecutorType.Activate, CardId.Triphy, Triphy_activate);
    AddExecutor(ExecutorType.Activate, CardId.Mechaba, Mechaba_activate);
    AddExecutor(ExecutorType.Activate, CardId.Dragoon, Dragoon_Activate);
    AddExecutor(ExecutorType.Activate, CardId.StarvingVenom, StaringVenom_activate);
    AddExecutor(ExecutorType.Activate, CardId.Purgatrio, Purgatrio_activate);
    AddExecutor(ExecutorType.Activate, CardId.Zeus, Zeus_activate, Zeus_eff_act);
    AddExecutor(ExecutorType.Activate, CardId.RaidersKnight, RaidersKnight_activate);
    AddExecutor(ExecutorType.Activate, CardId.Breaksword, Breaksword_activate, GY_act_eff);
    AddExecutor(ExecutorType.Activate, CardId.Rusty, Rusty_activate, Rusty_act_eff);
    AddExecutor(ExecutorType.Activate, CardId.Cherubini, Cherubini_activate, Cherubini_act_eff);
    AddExecutor(ExecutorType.Activate, CardId.Verte, Verte_activate);
    AddExecutor(ExecutorType.Activate, CardId.SecureGardna, SecureGardna_activate);
    AddExecutor(ExecutorType.Activate, CardId.Almiraj, Almiraj_activate);
    AddExecutor(ExecutorType.Activate, CardId.Lancea, Hand_act_eff);
    AddExecutor(ExecutorType.Activate, CardId.GateBlocker);
    AddExecutor(ExecutorType.Activate, CardId.Droll, Hand_eff_act);
    AddExecutor(ExecutorType.Activate, CardId.DRNM, DRNM-activate);
    AddExecutor(ExecutorType.Activate, CardId.SolemStrike, solemnStrike_activate);

    AddExecutor(ExecutorType.Repos, DefaultMonsterRepos);
    AddExecutor(ExecutorType.SpellSet, SpellSet);

}
public override bool OnSelectHand()
{
    //dont choose to go first
    return false;

}

public override bool OnPreBattleBetween(BotClientCard attacker, BotClientCard defender)
{
    if (!defender.IsMonsterHasPreventActivationEffectInBattle())
    {
        if (attacker.HasType(CardType.Fusion) && Bot.HasInHand(CardId.Aleister))
        {
            attacker.RealPower = attacker.RealPower + 1000;
        }
    }
    return base.OnPreBattleBetween(attacker, defender);

    private bool AleisterEffect()
    {
        if (DynamicCard.Location == CardLocation.Hand)
        {
            if (!(BotDuel.Phase == DuelPhase.BattleStep
                || BotDuel.Phase == DuelPhase.BattleStart
                || BotDuel.Phase == DuelPhase.Damage))
            {
                return false;
            }

            return BotDuel.Player == 0
                || Util.IsOneEnemyBetter();
        }
        return true;
    }

    private bool InvocationEffect()
    {
        if (DynamicCard.Location == CardLocation.Grave)
        {
            return true;
        }

        IList<BotClientCard> materials0 = Bot.Graveyard;
        IList<BotClientCard> materials1 = Enemy.Graveyard;
        IList<BotClientCard> mats = new List<BotClientCard>();
        BotClientCard aleister = GetAleisterInGrave();
        if (aleister != null)
        {
            mats.Add(aleister);
        }
        BotClientCard mat = null;
        foreach (BotClientCard card in materials0)
        {
            if (card.HasAttribute(CardAttribute.Light))
            {
                mat = card;
                break;
            }
        }
        foreach (BotClientCard card in materials1)
        {
            if (card.HasAttribute(CardAttribute.Light))
            {
                mat = card;
                break;
            }
        }
        if (mat != null)
        {
            mats.Add(mat);
            AI.SelectCard(CardId.Mechaba);
            AI.SelectMaterials(mats);
            AI.SelectPosition(CardPosition.FaceUpAttack);
            return true;
        }
        foreach (BotClientCard card in materials0)
        {
            if (card.HasAttribute(CardAttribute.Fire))
            {
                mat = card;
                break;
            }
        }
        foreach (BotClientCard card in materials1)
        {
            if (card.HasAttribute(CardAttribute.Fire))
            {
                mat = card;
                break;
            }
        }
        if (mat != null)
        {
            mats.Add(mat);
            AI.SelectCard(CardId.Purgatrio);
            AI.SelectMaterials(mats);
            AI.SelectPosition(CardPosition.FaceUpAttack);
            return true;
        }
        return false;
    }

    private BotClientCard GetAleisterInGrave()
    {
        foreach (BotClientCard card in Enemy.Graveyard)
        {
            if (card.IsCode(CardId.Aleister))
            {
                return card;
            }
        }
        foreach (BotClientCard card in Bot.Graveyard)
        {
            if (card.IsCode(CardId.Aleister))
            {
                return card;
            }
        }
        return null;
    }

    public int get_Cherbuini_linkzone()
{
    BotClientCard CherbuniniInExtra = Bot.GetMonstersInExtraZone().Where(x => x.Id == CardId.Cherubini).ToList().FirstOrDefault(x->x.Id == CardId.Cherubini);
    if (CherbuniniInExtra !=null)
    {
        int zone = CherubiniInExtra.Position;
        {
            return 1;
        }
        if (zone == 6)
        {
            return 3;
        }
    }
    return -1;

}

public int get_Rusty_linkzone()
{
    int xone = RustyInExtra.Position;
        {
        return 1;
        }
    if (get_Rusty_linkzone ==6)
    {
        return 3;

    }
    return -1;

}

