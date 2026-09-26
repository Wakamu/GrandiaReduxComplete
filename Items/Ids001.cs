using Grandia.Sdk;



namespace GrandiaReduxComplete.Items;



/// <summary>WINDT sec3 rows 1–127 that differ from vanilla USA Disc 1.</summary>

internal static class Ids001

{

    internal static readonly ItemEdit[] All =

    [

        new()

        {

            Id = Item.LifeJewel,

            Note = "LifeJewel",

            Cost = 10000, // vanilla 0

            Icon = 46, // vanilla 0

            UseStatus = 34934, // vanilla 0

            Unknown7 = 255, // vanilla 0

            Unknown13 = 7, // vanilla 0

            Unknown14 = 20, // vanilla 0

            Para4Post = 512, // vanilla 0

            ShortName = "LIF JEWL",

            Name = "Life Jewel",

            Description = "20HP w att",

        },

        new()

        {

            Id = Item.MageHat,

            Note = "MageHat",

            Cost = 8000, // vanilla 0

            Icon = 41, // vanilla 0

            UseStatus = 34931, // vanilla 0

            Unknown7 = 166, // vanilla 0

            Para2 = 2, // vanilla 0

            Para3 = 19, // vanilla 0

            Para1Post = 2560, // vanilla 0

            Para2Post = 256, // vanilla 0

            Para4Post = 6656, // vanilla 0

            ShortName = "MAGE HAT",

            Name = "Mage Hat",

            Description = "+10 defense +1 magic  Bright pink     ",

        },

        new()

        {

            Id = Item.Yoyo,

            Note = "Yoyo",

            Cost = 40, // vanilla 0

            Icon = 31, // vanilla 0

            UseStatus = 34929, // vanilla 0

            Unknown7 = 2, // vanilla 0

            Unknown8 = 5, // vanilla 0

            Unknown13 = 1, // vanilla 0

            Unknown14 = 175, // vanilla 0

            Para2 = 1, // vanilla 0

            Para3 = 13, // vanilla 0

            Para1Post = 2825, // vanilla 0

            Para2Post = 3072, // vanilla 0

            Para4Post = 5122, // vanilla 0

            Unknown27 = 7, // vanilla 0

            ShortName = "YO-YO",

            Name = "Yo-yo",

        },

        new()

        {

            Id = Item.BasicWand,

            Note = "BasicWand",

            Cost = 850, // vanilla 0

            Icon = 26, // vanilla 0

            UseStatus = 34929, // vanilla 0

            Unknown7 = 129, // vanilla 0

            Unknown8 = 3, // vanilla 0

            Unknown13 = 5, // vanilla 0

            Unknown14 = 6, // vanilla 0

            Para1Pre = 8, // vanilla 0

            Para2 = 1, // vanilla 0

            Para3 = 4, // vanilla 0

            Para4 = 13, // vanilla 0

            Para1Post = 2825, // vanilla 0

            Para2Post = 64768, // vanilla 0

            Para3Post = 3327, // vanilla 0

            Para4Post = 1793, // vanilla 0

            Unknown27 = 4, // vanilla 0

            ShortName = "IRON MACE",

            Name = "Iron Mace",

            Description = "[+11 ATK] [-3 MOVE] [Stun]",

        },

        new()

        {

            Id = Item.ReduxWand,

            Note = "ReduxWand",

            Cost = 2800, // vanilla 0

            Icon = 30, // vanilla 0

            UseStatus = 34929, // vanilla 0

            Unknown7 = 133, // vanilla 0

            Unknown8 = 3, // vanilla 0

            Unknown12 = 128, // vanilla 0

            Para2 = 1, // vanilla 0

            Para3 = 19, // vanilla 0

            Para4 = 13, // vanilla 0

            Para1Post = 5129, // vanilla 0

            Para2Post = 256, // vanilla 0

            Para3Post = 4096, // vanilla 0

            Para4Post = 2561, // vanilla 0

            Unknown27 = 5, // vanilla 0

            ShortName = "MAGESTAFF",

            Name = "Mage's Staff ",

            Description = "[+20 ATK] [Magic+]  An old essential",

        },

        new()

        {

            Id = Item.LordsWand,

            Note = "LordsWand",

            Cost = 12500, // vanilla 0

            Icon = 26, // vanilla 0

            UseStatus = 34929, // vanilla 0

            Unknown7 = 133, // vanilla 0

            Unknown8 = 3, // vanilla 0

            Unknown12 = 11, // vanilla 0

            Para2 = 1, // vanilla 0

            Para3 = 19, // vanilla 0

            Para4 = 13, // vanilla 0

            Para1Post = 7177, // vanilla 0

            Para2Post = 768, // vanilla 0

            Para3Post = 5120, // vanilla 0

            Para4Post = 2561, // vanilla 0

            Unknown27 = 5, // vanilla 0

            ShortName = "LORD WAND",

            Name = "Lord's Wand",

            Description = "[+23 ATK]  +3 magic",

        },

        new()

        {

            Id = Item.MagicRope,

            Note = "MagicRope",

            Cost = 880, // vanilla 0

            Icon = 28, // vanilla 0

            UseStatus = 34929, // vanilla 0

            Unknown7 = 36, // vanilla 0

            Unknown8 = 3, // vanilla 0

            Para2 = 1, // vanilla 0

            Para3 = 13, // vanilla 0

            Para4 = 36, // vanilla 0

            Para1Post = 2569, // vanilla 0

            Para2Post = 3072, // vanilla 0

            Para3Post = 256, // vanilla 0

            Para4Post = 1793, // vanilla 0

            Unknown27 = 4, // vanilla 0

            ShortName = "IN MALLET",

            Name = "Iron Mallet",

            Description = "[+10 ATK] [Skill+]  Strong iron",

        },

        new()

        {

            Id = Item.LuresHeart,

            Note = "LuresHeart",

            Cost = 2000, // vanilla 0

            Icon = 31, // vanilla 0

            UseStatus = 34929, // vanilla 0

            Unknown7 = 2, // vanilla 0

            Unknown8 = 5, // vanilla 0

            Para2 = 3, // vanilla 0

            Para3 = 19, // vanilla 0

            Para4 = 13, // vanilla 0

            Para1Post = 5129, // vanilla 0

            Para2Post = 512, // vanilla 0

            Para3Post = 3584, // vanilla 0

            Para4Post = 5122, // vanilla 0

            Unknown27 = 7, // vanilla 0

            ShortName = "LURE HART",

            Name = "Lure's Heart",

            Description = "+20 action  +2 magic  Soft",

        },

        new()

        {

            Id = Item.EnchantedWhip,

            Note = "EnchantedWhip",

            Cost = 30000, // vanilla 0

            Icon = 31, // vanilla 0

            UseStatus = 34929, // vanilla 0

            Unknown7 = 2, // vanilla 0

            Unknown8 = 5, // vanilla 0

            Para2 = 3, // vanilla 0

            Para3 = 19, // vanilla 0

            Para4 = 13, // vanilla 0

            Para1Post = 8201, // vanilla 0

            Para2Post = 768, // vanilla 0

            Para3Post = 5120, // vanilla 0

            Para4Post = 5122, // vanilla 0

            Unknown27 = 7, // vanilla 0

            ShortName = "CHANTWHIP",

            Name = "Enchanted Whip",

            Description = "+32 action  +3 magic  Fascinating  ",

        },

        new()

        {

            Id = Item.SpiritStone,

            Note = "SpiritStone",

            EffectValue = 3, // vanilla 1

        },

        new()

        {

            Id = Item.Apron,

            Note = "Apron",

            Unknown7 = 117, // vanilla 255

            Para3 = 4, // vanilla 0

            Para4 = 14, // vanilla 0

            Para1Post = 512, // vanilla 256

            Para2Post = 65024, // vanilla 0

            Para3Post = 767, // vanilla 0

        },

        new()

        {

            Id = Item.PotLid,

            Note = "PotLid",

            Unknown7 = 185, // vanilla 255

            Para3 = 4, // vanilla 0

            Para1Post = 512, // vanilla 256

            Para2Post = 64768, // vanilla 0

            Para3Post = 255, // vanilla 0

        },

        new()

        {

            Id = Item.IronPot,

            Note = "IronPot",

            Unknown7 = 57, // vanilla 255

            Para3 = 4, // vanilla 0

            Para1Post = 512, // vanilla 256

            Para2Post = 64768, // vanilla 0

            Para3Post = 255, // vanilla 0

        },

        new()

        {

            Id = Item.WoodenSword,

            Note = "WoodenSword",

            Para3 = 13, // vanilla 0

            Para1Post = 777, // vanilla 1801

            Para2Post = 1792, // vanilla 0

        },

        new()

        {

            Id = Item.SpiritSword,

            Note = "SpiritSword",

            Para1Post = 23049, // vanilla 17929

            Para2Post = 2048, // vanilla 1280

        },

        new()

        {

            Id = Item.Biscuits,

            Note = "Biscuits",

            Effect = (Skill)0, // vanilla 5

            Cost = 1000, // vanilla 25

            Icon = 26, // vanilla 51

            UseStatus = 34929, // vanilla 57600

            Unknown7 = 129, // vanilla 0

            Unknown8 = 3, // vanilla 0

            EffectValue = 0, // vanilla 25

            Unknown12 = 131, // vanilla 0

            Unknown13 = 5, // vanilla 0

            Unknown14 = 30, // vanilla 0

            Para1Pre = 1, // vanilla 0

            Para2 = 1, // vanilla 0

            Para4 = 13, // vanilla 0

            Para1Post = 4105, // vanilla 0

            Para3Post = 3584, // vanilla 0

            Para4Post = 1793, // vanilla 0

            Unknown27 = 4, // vanilla 0

            ShortName = "FR DUSTER",

            Name = "Feather Duster",

            Description = "[+16 ATK] [Stun] [Bird slayer]   ",

        },

        new()

        {

            Id = Item.CoalCandy,

            Note = "CoalCandy",

            Cost = 1000, // vanilla 50

            EffectValue = 6, // vanilla 2

        },

        new()

        {

            Id = Item.Pearl,

            Note = "Pearl",

            Effect = (Skill)0, // vanilla 100

            Cost = 10000, // vanilla 2000

            Icon = 4, // vanilla 46

            UseStatus = 34934, // vanilla 57632

            Unknown7 = 255, // vanilla 0

            EffectValue = 0, // vanilla 2

            Unknown12 = 0, // vanilla 32

            Unknown13 = 23, // vanilla 0

            Unknown14 = 25, // vanilla 0

            Para2 = 28, // vanilla 0

            Para3 = 33, // vanilla 0

            Para4 = 34, // vanilla 0

            Para1Post = 256, // vanilla 0

            Para2Post = 256, // vanilla 0

            Para3Post = 256, // vanilla 0

            Para4Post = 512, // vanilla 256

            ShortName = "MEDALLION",

            Name = "Adventurer's Medal    ",

            Description = "[+1 status/magic/crit resist] [Gold+]",

        },

        new()

        {

            Id = Item.BoiledEgg,

            Note = "BoiledEgg",

            Effect = (Skill)0, // vanilla 5

            Cost = 1800, // vanilla 200

            Icon = 6, // vanilla 52

            UseStatus = 34929, // vanilla 57600

            Unknown7 = 132, // vanilla 255

            Unknown8 = 3, // vanilla 0

            EffectValue = 0, // vanilla 65

            Unknown12 = 160, // vanilla 0

            Unknown13 = 6, // vanilla 0

            Para2 = 1, // vanilla 0

            Para3 = 13, // vanilla 0

            Para1Post = 1545, // vanilla 0

            Para2Post = 3584, // vanilla 0

            Para4Post = 2305, // vanilla 0

            Unknown27 = 5, // vanilla 0

            ShortName = "LT FLORET",

            Name = "God Light Floret",

            Description = "[+6 ATK] [Ignore defense] [Forest]",

        },

        new()

        {

            Id = Item.Chocolate,

            Note = "Chocolate",

            Effect = (Skill)0, // vanilla 5

            Cost = 400, // vanilla 120

            Icon = 35, // vanilla 51

            UseStatus = 34932, // vanilla 57600

            Unknown7 = 117, // vanilla 255

            EffectValue = 0, // vanilla 40

            Para2 = 2, // vanilla 0

            Para3 = 14, // vanilla 0

            Para1Post = 1280, // vanilla 0

            Para2Post = 512, // vanilla 0

            Para4Post = 5376, // vanilla 0

            ShortName = "FN JACKET",

            Name = "Fine Jacket",

            Description = "[+5 DEF]  New Parm's most popular",

        },

        new()

        {

            Id = Item.Jawbreaker,

            Note = "Jawbreaker",

            Effect = (Skill)0, // vanilla 5

            Cost = 1100, // vanilla 250

            Icon = 40, // vanilla 51

            UseStatus = 34931, // vanilla 57600

            Unknown7 = 230, // vanilla 255

            EffectValue = 0, // vanilla 100

            Para2 = 1, // vanilla 0

            Para3 = 14, // vanilla 0

            Para1Post = 3584, // vanilla 0

            Para2Post = 512, // vanilla 0

            Para4Post = 6400, // vanilla 0

            ShortName = "KITEWING ",

            Name = "Kitewing Hairbow",

            Description = "[+14 ATK] [Temper]  Clipped off   ",

        },

        new()

        {

            Id = Item.FrostHerb,

            Note = "FrostHerb",

            Effect = (Skill)0, // vanilla 37

            Cost = 800, // vanilla 600

            Icon = 42, // vanilla 50

            UseStatus = 34931, // vanilla 49408

            Unknown7 = 57, // vanilla 255

            EffectValue = 0, // vanilla 251

            Unknown11 = 0, // vanilla 255

            Unknown12 = 0, // vanilla 96

            Para2 = 2, // vanilla 0

            Para3 = 4, // vanilla 0

            Para4 = 16, // vanilla 0

            Para1Post = 1536, // vanilla 0

            Para2Post = 63488, // vanilla 0

            Para3Post = 767, // vanilla 0

            Para4Post = 6656, // vanilla 0

            ShortName = "ARMY HELM",

            Name = "Army Helmet",

            Description = "[+6 DEF] [-8 MOVE] [Sturdiness]   ",

        },

        new()

        {

            Id = Item.AmuletOfRelief,

            Note = "AmuletOfRelief",

            Cost = 15000, // vanilla 7000

            Unknown14 = 6, // vanilla 2

        },

        new()

        {

            Id = Item.GaiaWand,

            Note = "GaiaWand",

            Cost = 23000, // vanilla 0

            Icon = 27, // vanilla 0

            UseStatus = 34929, // vanilla 0

            Unknown7 = 128, // vanilla 0

            Unknown8 = 3, // vanilla 0

            Para2 = 2, // vanilla 0

            Para3 = 19, // vanilla 0

            Para4 = 13, // vanilla 0

            Para1Post = 2569, // vanilla 0

            Para2Post = 1024, // vanilla 0

            Para3Post = 7680, // vanilla 0

            Para4Post = 2561, // vanilla 0

            Unknown27 = 5, // vanilla 0

            ShortName = "GAIA WAND",

            Name = "Gaia Wand",

            Description = "+10 defense  +4 magic",

        },

        new()

        {

            Id = Item.AgileShoes,

            Note = "AgileShoes",

            Cost = 1350, // vanilla 0

            Icon = 48, // vanilla 0

            UseStatus = 34932, // vanilla 0

            Unknown7 = 198, // vanilla 0

            Unknown13 = 31, // vanilla 0

            Unknown14 = 3, // vanilla 0

            Para2 = 2, // vanilla 0

            Para3 = 14, // vanilla 0

            Para4 = 33, // vanilla 0

            Para1Post = 1536, // vanilla 0

            Para2Post = 768, // vanilla 0

            Para3Post = 256, // vanilla 0

            Para4Post = 5376, // vanilla 0

            ShortName = "FARY ROBE",

            Name = "Fairy Robe ",

            Description = "[+6 DEF] [+1 magic resist] [Regen-]",

        },

        new()

        {

            Id = Item.AgileHat,

            Note = "AgileHat",

            Cost = 950, // vanilla 0

            Icon = 7, // vanilla 0

            UseStatus = 34930, // vanilla 0

            Unknown7 = 123, // vanilla 0

            Para2 = 1, // vanilla 0

            Para3 = 4, // vanilla 0

            Para4 = 9, // vanilla 0

            Para1Post = 2816, // vanilla 0

            Para2Post = 60672, // vanilla 0

            Para3Post = 767, // vanilla 0

            Para4Post = 6656, // vanilla 0

            ShortName = "HUNTSPEAR",

            Name = "Hunting Spear",

            Description = "[+11 ATK] [-19 MOVE] [Range+]",

        },

        new()

        {

            Id = Item.CampingTent,

            Note = "CampingTent",

            Effect = (Skill)48, // vanilla 0

            Cost = 300, // vanilla 0

            Icon = 62, // vanilla 0

            UseStatus = 57631, // vanilla 0

            Unknown7 = 255, // vanilla 0

            EffectValue = 1, // vanilla 0

            ShortName = "TENT",

            Name = "Camping Tent",

            Description = "Restores all HP and status to party",

        },

        new()

        {

            Id = (Item)52,

            Note = "52",

            ShortName = "PPHIT",

            Name = " ted",

            Description = " ",

        },

        new()

        {

            Id = (Item)53,

            Note = "53",

            ShortName = "PRIT",

            Name = "Pibited",

            Description = " ",

        },

        new()

        {

            Id = (Item)61,

            Note = "61",

            ShortName = "PROHIBI",

            Name = "P",

            Description = "h",

        },

        new()

        {

            Id = Item.AdventureBow,

            Note = "AdventureBow",

            Cost = 6000, // vanilla 0

            Icon = 34, // vanilla 0

            UseStatus = 34929, // vanilla 0

            Unknown7 = 68, // vanilla 0

            Unknown8 = 6, // vanilla 0

            Para2 = 1, // vanilla 0

            Para3 = 36, // vanilla 0

            Para4 = 13, // vanilla 0

            Para1Post = 8713, // vanilla 0

            Para2Post = 256, // vanilla 0

            Para3Post = 6144, // vanilla 0

            Para4Post = 3348, // vanilla 0

            Unknown27 = 88, // vanilla 0

            ShortName = "ADVEN BOW",

            Name = "Adventure Bow",

            Description = "[+34 ATK] [Skill+]  ",

        },

        new()

        {

            Id = Item.KnifeOfJudgment,

            Note = "KnifeOfJudgment",

            Cost = 400, // vanilla 10000

            Para3 = 10, // vanilla 0

            Para4 = 13, // vanilla 0

            Para1Post = 5641, // vanilla 9737

            Para2Post = 256, // vanilla 0

            Para3Post = 3072, // vanilla 0

            ShortName = "GLADIUS  ",

            Name = "Gladius",

            Description = "+22 attack  Effective on ghosts",

        },

        new()

        {

            Id = Item.RustyKnife,

            Note = "RustyKnife",

            Cost = 300, // vanilla 1000

            Icon = 62, // vanilla 21

            UseStatus = 34934, // vanilla 34929

            Unknown7 = 0, // vanilla 82

            Unknown8 = 0, // vanilla 1

            Unknown13 = 0, // vanilla 7

            Unknown14 = 0, // vanilla 1

            Para2 = 0, // vanilla 1

            Para1Post = 0, // vanilla 3849

            Para4Post = 0, // vanilla 768

            ShortName = "LUMP COAL",

            Name = "Lump of Coal",

            Description = "A common mineral with little value  ",

        },

        new()

        {

            Id = Item.ParingKnife,

            Note = "ParingKnife",

            Cost = 60, // vanilla 250

            Para3 = 10, // vanilla 0

            Para4 = 13, // vanilla 0

            Para1Post = 521, // vanilla 2313

            Para2Post = 256, // vanilla 0

            Para3Post = 3072, // vanilla 0

        },

        new()

        {

            Id = Item.HuntersKnife,

            Note = "HuntersKnife",

            Cost = 700, // vanilla 1000

            Unknown12 = 3, // vanilla 0

            Para3 = 10, // vanilla 0

            Para4 = 13, // vanilla 0

            Para1Post = 2057, // vanilla 4617

            Para2Post = 256, // vanilla 0

            Para3Post = 3072, // vanilla 0

        },

        new()

        {

            Id = Item.FlintKnife,

            Note = "FlintKnife",

            Cost = 1300, // vanilla 2000

            Unknown7 = 18, // vanilla 82

            Para3 = 19, // vanilla 0

            Para4 = 13, // vanilla 0

            Para1Post = 3081, // vanilla 5129

            Para2Post = 256, // vanilla 0

            Para3Post = 3584, // vanilla 0

            ShortName = "RUNIKARD ",

            Name = "Bread of Damnation        ",

            Description = "[+12 ATK] [Magic+]  Crooked  ",

        },

        new()

        {

            Id = Item.AzureKnife,

            Note = "AzureKnife",

            Effect = Skill.Heal, // vanilla 0

            UseStatus = 51569, // vanilla 34929

            EffectValue = 30, // vanilla 0

            Para3 = 10, // vanilla 0

            Para4 = 13, // vanilla 0

            Para1Post = 7433, // vanilla 6409

            Para2Post = 256, // vanilla 0

            Para3Post = 3840, // vanilla 0

        },

        new()

        {

            Id = Item.ShockingKnife,

            Note = "ShockingKnife",

            Cost = 10000, // vanilla 6500

            Para1Pre = 1, // vanilla 2

            Para3 = 10, // vanilla 0

            Para4 = 13, // vanilla 0

            Para2Post = 256, // vanilla 0

            Para3Post = 3840, // vanilla 0

        },

        new()

        {

            Id = Item.PoisonedKnife,

            Note = "PoisonedKnife",

            Para1Pre = 3, // vanilla 7

            Para3 = 10, // vanilla 0

            Para4 = 13, // vanilla 0

            Para1Post = 10249, // vanilla 8969

            Para2Post = 256, // vanilla 0

            Para3Post = 3840, // vanilla 0

        },

        new()

        {

            Id = Item.AssassinsDagger,

            Note = "AssassinsDagger",

            Unknown14 = 8, // vanilla 10

            Para1Pre = 3, // vanilla 7

            Para3 = 10, // vanilla 0

            Para4 = 13, // vanilla 0

            Para1Post = 13321, // vanilla 12809

            Para2Post = 256, // vanilla 0

            Para3Post = 3840, // vanilla 0

        },

        new()

        {

            Id = Item.BloodyKnife,

            Note = "BloodyKnife",

            Para3 = 10, // vanilla 0

            Para4 = 13, // vanilla 0

            Para1Post = 11273, // vanilla 14089

            Para2Post = 256, // vanilla 0

            Para3Post = 3840, // vanilla 0

        },

        new()

        {

            Id = Item.IcePick,

            Note = "IcePick",

            Effect = Skill.Crackle, // vanilla 0

            UseStatus = 26993, // vanilla 34929

            EffectValue = 120, // vanilla 0

            Para3 = 10, // vanilla 0

            Para4 = 13, // vanilla 0

            Para1Post = 11529, // vanilla 9737

            Para2Post = 256, // vanilla 0

            Para3Post = 3840, // vanilla 0

        },

        new()

        {

            Id = Item.ForceKnife,

            Note = "ForceKnife",

            Para3 = 10, // vanilla 0

            Para4 = 13, // vanilla 0

            Para1Post = 17929, // vanilla 16649

            Para2Post = 256, // vanilla 0

            Para3Post = 5120, // vanilla 0

        },

        new()

        {

            Id = Item.GodspeedKnife,

            Note = "GodspeedKnife",

            Para3 = 10, // vanilla 3

            Para4 = 13, // vanilla 0

            Para1Post = 20489, // vanilla 15369

            Para2Post = 256, // vanilla 7680

            Para3Post = 5120, // vanilla 0

            ShortName = "SP DAGGER",

            Name = "Spirit Dagger ",

            Description = "+80 attack  Best dagger [Mirage]",

        },

        new()

        {

            Id = Item.GustKnife,

            Note = "GustKnife",

            Cost = 1300, // vanilla 2800

            Icon = 22, // vanilla 21

            Unknown7 = 18, // vanilla 82

            Unknown12 = 0, // vanilla 64

            Para3 = 19, // vanilla 0

            Para4 = 13, // vanilla 0

            Para1Post = 3081, // vanilla 6153

            Para2Post = 256, // vanilla 0

            Para3Post = 3584, // vanilla 0

            ShortName = "RUNIKARD ",

            Name = "Runikard  ",

            Description = "[+12 ATK] [Magic+]  Crooked edge",

        },

        new()

        {

            Id = Item.RuinationKnife,

            Note = "RuinationKnife",

            Para2 = 10, // vanilla 2

            Para3 = 11, // vanilla 10

            Para4 = 13, // vanilla 0

            Para1Post = 521, // vanilla 55305

            Para2Post = 256, // vanilla 1023

            Para3Post = 5120, // vanilla 0

        },

        new()

        {

            Id = Item.ThiefCutter,

            Note = "ThiefCutter",

            Cost = 2400, // vanilla 30000

            Unknown12 = 128, // vanilla 0

            Unknown13 = 0, // vanilla 20

            Para3 = 10, // vanilla 0

            Para4 = 13, // vanilla 0

            Para1Post = 6153, // vanilla 8969

            Para2Post = 256, // vanilla 0

            Para3Post = 4096, // vanilla 0

            Para4Post = 1025, // vanilla 1024

            ShortName = "SLV DAGGR",

            Name = "Silver Dagger",

            Description = "[+24 ATK] [Combo+]  Polished dagger",

        },

        new()

        {

            Id = Item.ZeroKnife,

            Note = "ZeroKnife",

            Para3 = 10, // vanilla 0

            Para4 = 13, // vanilla 0

            Para2Post = 256, // vanilla 0

            Para3Post = 7680, // vanilla 0

        },

        new()

        {

            Id = Item.CeramicSword,

            Note = "CeramicSword",

            Cost = 200, // vanilla 500

            Icon = 42, // vanilla 23

            UseStatus = 34931, // vanilla 34929

            Unknown7 = 57, // vanilla 121

            Unknown8 = 0, // vanilla 2

            Para2 = 2, // vanilla 1

            Para3 = 4, // vanilla 0

            Para4 = 16, // vanilla 0

            Para1Post = 1024, // vanilla 3081

            Para2Post = 64256, // vanilla 0

            Para3Post = 767, // vanilla 0

            Para4Post = 6656, // vanilla 1281

            Unknown27 = 0, // vanilla 2

            ShortName = "ROCK HELM",

            Name = "Rock Helmet ",

            Description = "[+4 DEF] [-5 MOVE] [Sturdiness]",

        },

        new()

        {

            Id = Item.AdmiralsSword,

            Note = "AdmiralsSword",

            Icon = 24, // vanilla 23

            Unknown7 = 41, // vanilla 121

            Unknown12 = 7, // vanilla 0

            Para3 = 13, // vanilla 0

            Para4 = 17, // vanilla 0

            Para1Post = 2057, // vanilla 3593

            Para2Post = 3072, // vanilla 0

            Para3Post = 1280, // vanilla 0

            Unknown27 = 2, // vanilla 1

        },

        new()

        {

            Id = Item.GreatSword,

            Note = "GreatSword",

            Unknown7 = 81, // vanilla 121

            Para3 = 13, // vanilla 0

            Para1Post = 2313, // vanilla 4105

            Para2Post = 4608, // vanilla 0

            ShortName = "GEOBLADE ",

            Name = "Geoblade   ",

            Description = "[+9 ATK] [Fury]  For Geohounds",

        },

        new()

        {

            Id = Item.ArmySaber,

            Note = "ArmySaber",

            Cost = 1200, // vanilla 1300

            Icon = 23, // vanilla 24

            Unknown7 = 81, // vanilla 121

            Para3 = 13, // vanilla 0

            Para1Post = 3337, // vanilla 5641

            Para2Post = 5120, // vanilla 0

            Unknown27 = 2, // vanilla 1

        },

        new()

        {

            Id = Item.TheSwordHimmler,

            Note = "TheSwordHimmler",

            Cost = 2000, // vanilla 2800

            Unknown7 = 41, // vanilla 121

            Unknown12 = 128, // vanilla 0

            Para3 = 13, // vanilla 0

            Para4 = 17, // vanilla 0

            Para1Post = 6409, // vanilla 6153

            Para2Post = 4096, // vanilla 0

            Para3Post = 1280, // vanilla 0

        },

        new()

        {

            Id = Item.AngelsDarts,

            Note = "AngelsDarts",

            Unknown14 = 25, // vanilla 1

            Para3 = 13, // vanilla 0

            Para2Post = 3072, // vanilla 0

        },

        new()

        {

            Id = Item.SwordfishSword,

            Note = "SwordfishSword",

            Cost = 2500, // vanilla 4500

            Icon = 23, // vanilla 24

            Unknown7 = 81, // vanilla 121

            Unknown12 = 128, // vanilla 0

            Para4 = 13, // vanilla 0

            Para1Post = 5897, // vanilla 7433

            Para3Post = 5632, // vanilla 0

            ShortName = "FSH BLADE",

            Name = "Swordfish Blade",

            Description = "[+23 ATK] [Fury]  Rapier-esque sword",

        },

        new()

        {

            Id = Item.DragonKiller,

            Note = "DragonKiller",

            Para3 = 13, // vanilla 0

            Para1Post = 8201, // vanilla 6665

            Para2Post = 3584, // vanilla 0

        },

        new()

        {

            Id = Item.FireSword,

            Note = "FireSword",

            Para3 = 13, // vanilla 0

            Para1Post = 11017, // vanilla 9737

            Para2Post = 4096, // vanilla 0

        },

        new()

        {

            Id = Item.ShadowSword,

            Note = "ShadowSword",

            Cost = 6000, // vanilla 7000

            Unknown13 = 0, // vanilla 9

            Unknown14 = 0, // vanilla 8

            Para1Pre = 0, // vanilla 3

            Para3 = 2, // vanilla 4

            Para4 = 13, // vanilla 0

            Para1Post = 9993, // vanilla 8713

            Para2Post = 64256, // vanilla 61696

            Para3Post = 3839, // vanilla 255

        },

        new()

        {

            Id = Item.GilSword,

            Note = "GilSword",

            Para3 = 13, // vanilla 0

            Para2Post = 3584, // vanilla 0

        },

        new()

        {

            Id = Item.SilenceSword,

            Note = "SilenceSword",

            Para3 = 13, // vanilla 0

            Para1Post = 11273, // vanilla 10249

            Para2Post = 4096, // vanilla 0

        },

        new()

        {

            Id = Item.WobblySword,

            Note = "WobblySword",

            Icon = 23, // vanilla 24

            Para3 = 13, // vanilla 0

            Para1Post = 1545, // vanilla 2313

            Para2Post = 2560, // vanilla 0

            ShortName = "DENTSWORD",

            Name = "Dented Sword",

            Description = "[+6 ATK]  Not very sharp ",

        },

        new()

        {

            Id = Item.MainGauche,

            Note = "MainGauche",

            Para4 = 13, // vanilla 0

            Para3Post = 3584, // vanilla 0

        },

        new()

        {

            Id = Item.HolySwordLorenzo,

            Note = "HolySwordLorenzo",

            Cost = 25000, // vanilla 40000

            Para3 = 13, // vanilla 0

            Para2Post = 3584, // vanilla 0

        },

        new()

        {

            Id = Item.IceBlade,

            Note = "IceBlade",

            Effect = (Skill)0, // vanilla 37

            UseStatus = 34929, // vanilla 51569

            EffectValue = 0, // vanilla 254

            Unknown11 = 0, // vanilla 255

            Para3 = 13, // vanilla 0

            Para1Post = 12041, // vanilla 10249

            Para2Post = 4096, // vanilla 0

        },

        new()

        {

            Id = Item.LightningSword,

            Note = "LightningSword",

            Para3 = 13, // vanilla 0

            Para1Post = 13833, // vanilla 12809

            Para2Post = 4096, // vanilla 0

        },

        new()

        {

            Id = Item.BattleSaber,

            Note = "BattleSaber",

            Cost = 30000, // vanilla 31500

            Para3 = 13, // vanilla 0

            Para1Post = 15369, // vanilla 12297

            Para2Post = 4096, // vanilla 0

        },

        new()

        {

            Id = Item.ZeroSword,

            Note = "ZeroSword",

            Para3 = 13, // vanilla 0

            Para2Post = 4608, // vanilla 0

        },

        new()

        {

            Id = Item.WoodenPole,

            Note = "WoodenPole",

            Para3 = 13, // vanilla 0

            Para1Post = 521, // vanilla 1289

            Para2Post = 2560, // vanilla 0

        },

        new()

        {

            Id = Item.MetalBat,

            Note = "MetalBat",

            Cost = 200, // vanilla 300

            Unknown7 = 129, // vanilla 37

            Para3 = 13, // vanilla 0

            Para1Post = 1289, // vanilla 2569

            Para2Post = 2560, // vanilla 0

        },

        new()

        {

            Id = Item.ZeroRod,

            Note = "ZeroRod",

            Para3 = 13, // vanilla 0

            Para2Post = 4608, // vanilla 0

            ShortName = "ROD",

            Name = "Zero Rod",

            Description = "+0 attack  A mace rod for training",

        },

        new()

        {

            Id = Item.OfficersBaton,

            Note = "OfficersBaton",

            Cost = 160, // vanilla 100

            Icon = 34, // vanilla 26

            Unknown7 = 68, // vanilla 37

            Unknown8 = 6, // vanilla 3

            Para3 = 4, // vanilla 0

            Para4 = 13, // vanilla 0

            Para1Post = 1289, // vanilla 1801

            Para2Post = 64256, // vanilla 0

            Para3Post = 2815, // vanilla 0

            Para4Post = 3346, // vanilla 1793

            Unknown27 = 88, // vanilla 4

            ShortName = "LONGBOW   ",

            Name = "Longbow",

            Description = "[+5 ATK] [-5 MOVE] [Range+]",

        },

        new()

        {

            Id = Item.MagicRod,

            Note = "MagicRod",

            Unknown7 = 128, // vanilla 165

            Para2 = 2, // vanilla 1

            Para4 = 13, // vanilla 0

            Para1Post = 5129, // vanilla 15369

            Para2Post = 1280, // vanilla 512

            Para3Post = 2560, // vanilla 0

            ShortName = "GRAND ROD",

            Name = "Grandia Rod",

            Description = "+10 def    +5 magic  Best wand",

        },

        new()

        {

            Id = Item.MinersHammer,

            Note = "MinersHammer",

            Cost = 250, // vanilla 300

            Unknown7 = 36, // vanilla 37

            Para3 = 13, // vanilla 0

            Para1Post = 1545, // vanilla 2825

            Para2Post = 2560, // vanilla 0

        },

        new()

        {

            Id = Item.IronMace,

            Note = "IronMace",

            Cost = 600, // vanilla 1200

            Icon = 30, // vanilla 26

            Unknown7 = 133, // vanilla 37

            Para3 = 19, // vanilla 3

            Para4 = 13, // vanilla 0

            Para1Post = 1545, // vanilla 4873

            Para2Post = 256, // vanilla 62976

            Para3Post = 3072, // vanilla 255

            Para4Post = 2305, // vanilla 1793

            Unknown27 = 5, // vanilla 4

            ShortName = "BSC STAFF",

            Name = "Basic Staff      ",

            Description = "[+6 ATK] [Magic+]  For casting ",

        },

        new()

        {

            Id = Item.ArmyDarts,

            Note = "ArmyDarts",

            Cost = 1000, // vanilla 1300

            Para3 = 11, // vanilla 0

            Para4 = 13, // vanilla 0

            Para1Post = 3081, // vanilla 4617

            Para2Post = 256, // vanilla 0

            Para3Post = 3584, // vanilla 0

            Para4Post = 4362, // vanilla 4364

        },

        new()

        {

            Id = Item.LassicHammer,

            Note = "LassicHammer",

            Cost = 21000, // vanilla 17500

            Para3 = 36, // vanilla 0

            Para4 = 13, // vanilla 0

            Para2Post = 256, // vanilla 0

            Para3Post = 3072, // vanilla 0

        },

        new()

        {

            Id = Item.WarHammer,

            Note = "WarHammer",

            Para4 = 13, // vanilla 0

            Para1Post = 12553, // vanilla 11017

            Para3Post = 3839, // vanilla 255

        },

        new()

        {

            Id = Item.HertzSpike,

            Note = "HertzSpike",

            Unknown13 = 0, // vanilla 9

            Unknown14 = 0, // vanilla 33

            Para1Pre = 0, // vanilla 1

            Para3 = 36, // vanilla 0

            Para4 = 13, // vanilla 0

            Para1Post = 19977, // vanilla 16649

            Para2Post = 256, // vanilla 0

            Para3Post = 4096, // vanilla 0

        },

        new()

        {

            Id = Item.OraclesStaff,

            Note = "OraclesStaff",

            Effect = (Skill)0, // vanilla 109

            Cost = 1500, // vanilla 2600

            UseStatus = 34929, // vanilla 51569

            Unknown7 = 133, // vanilla 165

            EffectValue = 0, // vanilla 7

            Para3 = 19, // vanilla 0

            Para4 = 13, // vanilla 0

            Para1Post = 3337, // vanilla 5641

            Para2Post = 256, // vanilla 0

            Para3Post = 3584, // vanilla 0

        },

        new()

        {

            Id = Item.RaincloudStaff,

            Note = "RaincloudStaff",

            Para3 = 13, // vanilla 0

            Para2Post = 3584, // vanilla 0

        },

        new()

        {

            Id = Item.StaffOfLife,

            Note = "StaffOfLife",

            Effect = (Skill)28, // vanilla 117

            EffectValue = 1, // vanilla 2

            Para3 = 19, // vanilla 0

            Para4 = 13, // vanilla 0

            Para1Post = 8969, // vanilla 14857

            Para2Post = 768, // vanilla 0

            Para3Post = 4096, // vanilla 0

            ShortName = "ANC STAFF",

            Name = "Ancient Staff",

            Description = "+35 attack  +3 magic  [Speedy]     ",

        },

        new()

        {

            Id = Item.WarpStaff,

            Note = "WarpStaff",

            Para3 = 13, // vanilla 0

            Para1Post = 11529, // vanilla 9737

            Para2Post = 4096, // vanilla 0

        },

        new()

        {

            Id = Item.HolyMace,

            Note = "HolyMace",

            Cost = 850, // vanilla 500

            Icon = 30, // vanilla 26

            Unknown7 = 133, // vanilla 37

            Para3 = 13, // vanilla 0

            Para4 = 19, // vanilla 0

            Para1Post = 1801, // vanilla 5129

            Para2Post = 3072, // vanilla 0

            Para3Post = 256, // vanilla 0

            Para4Post = 2305, // vanilla 2049

            ShortName = "HOLYSTAFF",

            Name = "Holy Staff",

            Description = "[+7 ATK] [Magic+] [Ghost slayer]",

        },

        new()

        {

            Id = Item.FireRod,

            Note = "FireRod",

            Cost = 3400, // vanilla 2900

            Icon = 26, // vanilla 27

            Unknown7 = 161, // vanilla 165

            Unknown12 = 128, // vanilla 16

            Unknown13 = 5, // vanilla 0

            Unknown14 = 30, // vanilla 0

            Para1Pre = 1, // vanilla 0

            Para3 = 4, // vanilla 0

            Para4 = 13, // vanilla 0

            Para1Post = 7433, // vanilla 6409

            Para2Post = 62976, // vanilla 0

            Para3Post = 4351, // vanilla 0

            ShortName = "PERNACH ",

            Name = "Pernach ",

            Description = "[+29 ATK] [-10 MOVE] [Stun]",

        },

        new()

        {

            Id = Item.AromaticTreeRoot,

            Note = "AromaticTreeRoot",

            Para3 = 13, // vanilla 0

            Para2Post = 4096, // vanilla 0

        },

        new()

        {

            Id = Item.SparklingRod,

            Note = "SparklingRod",

            Para2 = 19, // vanilla 1

            Para3 = 2, // vanilla 0

            Para4 = 13, // vanilla 0

            Para1Post = 777, // vanilla 10761

            Para2Post = 1280, // vanilla 0

            Para3Post = 2560, // vanilla 0

            ShortName = "MAGIC ROD",

            Name = "Magical Rod ",

            Description = "+3 magic  +5 defense  Mage's weapon",

        },

        new()

        {

            Id = Item.SpiritStaff,

            Note = "SpiritStaff",

            Effect = Skill.Protein, // vanilla 29

            EffectValue = 3, // vanilla 7

            Para3 = 13, // vanilla 0

            Para1Post = 17417, // vanilla 16137

            Para2Post = 4096, // vanilla 0

        },

        new()

        {

            Id = Item.HomeRunHammer,

            Note = "HomeRunHammer",

            Para4 = 13, // vanilla 0

            Para1Post = 10249, // vanilla 9225

            Para3Post = 4096, // vanilla 0

        },

        new()

        {

            Id = Item.RustyShovel,

            Note = "RustyShovel",

            Icon = 24, // vanilla 28

            Unknown7 = 17, // vanilla 37

            Para3 = 13, // vanilla 0

            Para1Post = 24329, // vanilla 521

            Para2Post = 4096, // vanilla 0

            ShortName = "GAIA RAGE",

            Name = "Gaia's Rage ",

            Description = "+95 attack  Enraged",

        },

        new()

        {

            Id = Item.HandAx,

            Note = "HandAx",

            Cost = 220, // vanilla 300

            Para4 = 13, // vanilla 0

            Para1Post = 1289, // vanilla 2569

            Para2Post = 0, // vanilla 64768

            Para3Post = 2560, // vanilla 255

        },

        new()

        {

            Id = Item.CeremonialRockAx,

            Note = "CeremonialRockAx",

            Unknown13 = 8, // vanilla 0

            Unknown14 = 40, // vanilla 0

            Para3 = 13, // vanilla 0

            Para1Post = 1033, // vanilla 2057

            Para2Post = 2560, // vanilla 0

        },

        new()

        {

            Id = Item.BigHatchet,

            Note = "BigHatchet",

            Cost = 900, // vanilla 1000

            Unknown13 = 8, // vanilla 0

            Unknown14 = 40, // vanilla 0

            Para3 = 13, // vanilla 0

            Para1Post = 2569, // vanilla 4617

            Para2Post = 3072, // vanilla 0

        },

        new()

        {

            Id = Item.WoodchoppersAx,

            Note = "WoodchoppersAx",

            Cost = 1600, // vanilla 2600

            Para3 = 13, // vanilla 0

            Para1Post = 4361, // vanilla 5897

            Para2Post = 3584, // vanilla 0

        },

        new()

        {

            Id = Item.DragonBoneAx,

            Note = "DragonBoneAx",

            Cost = 5000, // vanilla 10000

            Unknown12 = 128, // vanilla 0

            Unknown13 = 8, // vanilla 0

            Unknown14 = 75, // vanilla 0

            Para3 = 2, // vanilla 4

            Para4 = 13, // vanilla 0

            Para1Post = 12809, // vanilla 9737

            Para2Post = 63488, // vanilla 62976

            Para3Post = 4351, // vanilla 255

        },

    ];

}

