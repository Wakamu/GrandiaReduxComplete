using Grandia.Sdk;

namespace GrandiaReduxComplete.Items;

/// <summary>WINDT sec3 rows 384–511 that differ from vanilla USA Disc 1.</summary>
internal static class Ids384
{
    internal static readonly ItemEdit[] All =
    [
        new()
        {
            Id = Item.RoachBomb,
            Note = "RoachBomb",
            Effect = (Skill)0, // vanilla 12
            Cost = 750, // vanilla 90
            Icon = 27, // vanilla 55
            UseStatus = 34930, // vanilla 49408
            Unknown7 = 159, // vanilla 255
            EffectValue = 0, // vanilla 60
            Unknown12 = 0, // vanilla 4
            Unknown13 = 1, // vanilla 0
            Unknown14 = 187, // vanilla 0
            Para2 = 3, // vanilla 0
            Para1Post = 2304, // vanilla 0
            Para4Post = 5888, // vanilla 0
            ShortName = "TTM FOCUS",
            Name = "Totemic Focus  ",
            Description = "[+9 ACT] [25% spell haste] A shaman's ",
        },
        new()
        {
            Id = Item.FirewoodSparks,
            Note = "FirewoodSparks",
            Effect = (Skill)0, // vanilla 12
            Cost = 900, // vanilla 140
            Icon = 10, // vanilla 55
            UseStatus = 34933, // vanilla 49408
            Unknown7 = 166, // vanilla 255
            EffectValue = 0, // vanilla 80
            Unknown12 = 0, // vanilla 5
            Unknown13 = 1, // vanilla 0
            Unknown14 = 250, // vanilla 0
            Para2 = 1, // vanilla 0
            Para3 = 4, // vanilla 0
            Para4 = 3, // vanilla 0
            Para1Post = 1536, // vanilla 0
            Para3Post = 1536, // vanilla 0
            Para4Post = 6912, // vanilla 0
            ShortName = "STILETTOS",
            Name = "Stilettos",
            Description = "[+6 ATK] [+6 ACT]  Bladed heels",
        },
        new()
        {
            Id = Item.ManaEgg,
            Note = "ManaEgg",
            Cost = 8000, // vanilla 3000
        },
        new()
        {
            Id = Item.HolyFire,
            Note = "HolyFire",
            Effect = (Skill)0, // vanilla 17
            Cost = 2500, // vanilla 150
            Icon = 27, // vanilla 55
            UseStatus = 34930, // vanilla 49408
            Unknown7 = 159, // vanilla 255
            EffectValue = 0, // vanilla 30
            Unknown12 = 0, // vanilla 10
            Unknown13 = 1, // vanilla 0
            Unknown14 = 163, // vanilla 0
            Para2 = 3, // vanilla 0
            Para1Post = 4608, // vanilla 0
            Para4Post = 2304, // vanilla 0
            ShortName = "KLEPP ROD",
            Name = "Klepp-o-rod",
            Description = "[+18 ACT] [35% spell haste]  Odd  ",
        },
        new()
        {
            Id = Item.HandGrenade,
            Note = "HandGrenade",
            Cost = 120, // vanilla 200
            EffectValue = 60, // vanilla 30
        },
        new()
        {
            Id = Item.Dynamite,
            Note = "Dynamite",
            Cost = 240, // vanilla 280
            EffectValue = 120, // vanilla 70
        },
        new()
        {
            Id = Item.RocketFireworks,
            Note = "RocketFireworks",
            Effect = (Skill)0, // vanilla 14
            Cost = 3600, // vanilla 300
            Icon = 28, // vanilla 55
            UseStatus = 34929, // vanilla 49408
            Unknown7 = 36, // vanilla 255
            Unknown8 = 3, // vanilla 0
            EffectValue = 0, // vanilla 100
            Unknown12 = 128, // vanilla 0
            Para2 = 1, // vanilla 0
            Para3 = 13, // vanilla 0
            Para4 = 36, // vanilla 0
            Para1Post = 6409, // vanilla 0
            Para2Post = 4096, // vanilla 0
            Para3Post = 256, // vanilla 0
            Para4Post = 1793, // vanilla 0
            Unknown27 = 4, // vanilla 0
            ShortName = "GAVEL    ",
            Name = "Judgement Gavel",
            Description = "[+25 ATK] [Skill+] [Demon slayer]",
        },
        new()
        {
            Id = Item.LaunchFireworks,
            Note = "LaunchFireworks",
            Effect = (Skill)0, // vanilla 13
            Cost = 4000, // vanilla 1200
            Icon = 31, // vanilla 55
            UseStatus = 34929, // vanilla 49408
            Unknown7 = 2, // vanilla 255
            Unknown8 = 5, // vanilla 0
            EffectValue = 0, // vanilla 120
            Unknown12 = 128, // vanilla 0
            Unknown13 = 6, // vanilla 0
            Para2 = 1, // vanilla 0
            Para3 = 4, // vanilla 0
            Para4 = 13, // vanilla 0
            Para1Post = 7945, // vanilla 0
            Para2Post = 61184, // vanilla 0
            Para3Post = 4863, // vanilla 0
            Para4Post = 4867, // vanilla 0
            Unknown27 = 7, // vanilla 0
            ShortName = "FLAIL    ",
            Name = "Heavy Flail ",
            Description = "[+32 ATK] [-17 MOVE] [Ignore def]",
        },
        new()
        {
            Id = Item.GaleScroll,
            Note = "GaleScroll",
            Cost = 350, // vanilla 480
        },
        new()
        {
            Id = Item.OverflowingWalnut,
            Note = "OverflowingWalnut",
            Effect = (Skill)0, // vanilla 31
            Cost = 800, // vanilla 3000
            Icon = 3, // vanilla 53
            UseStatus = 34931, // vanilla 49408
            Unknown7 = 25, // vanilla 255
            EffectValue = 0, // vanilla 2
            Unknown13 = 7, // vanilla 0
            Unknown14 = 5, // vanilla 0
            Para2 = 1, // vanilla 0
            Para1Post = 2048, // vanilla 0
            Para4Post = 512, // vanilla 0
            ShortName = "VAMP HORN",
            Name = "Vampiric Horn",
            Description = "[+8 ATK] [Absorb]  Large horn",
        },
        new()
        {
            Id = Item.RestraintWalnut,
            Note = "RestraintWalnut",
            Cost = 150, // vanilla 2800
            Icon = 9, // vanilla 53
            EffectValue = 1, // vanilla 2
        },
        new()
        {
            Id = Item.SonicWalnut,
            Note = "SonicWalnut",
            Cost = 600, // vanilla 1400
            EffectValue = 1, // vanilla 2
        },
        new()
        {
            Id = Item.RunningWalnut,
            Note = "RunningWalnut",
            Effect = (Skill)0, // vanilla 18
            Cost = 1300, // vanilla 700
            Icon = 58, // vanilla 53
            UseStatus = 34931, // vanilla 49408
            Unknown7 = 210, // vanilla 255
            EffectValue = 0, // vanilla 2
            Unknown13 = 31, // vanilla 0
            Unknown14 = 5, // vanilla 0
            Para2 = 3, // vanilla 0
            Para3 = 4, // vanilla 0
            Para1Post = 2816, // vanilla 0
            Para2Post = 3328, // vanilla 0
            Para4Post = 512, // vanilla 0
            ShortName = "SLV FETHR",
            Name = "Silver Feather",
            Description = "[+11 ACT] [+13 MOVE] [Regen]    ",
        },
        new()
        {
            Id = Item.PoisonedApple,
            Note = "PoisonedApple",
            Cost = 200, // vanilla 50
            Icon = 62, // vanilla 53
            UseStatus = 49440, // vanilla 49408
            EffectValue = 5, // vanilla 6
            Para4Post = 256, // vanilla 0
            ShortName = "SLIMEBALL",
            Name = "Slimeball ",
            Description = "Poisons enemies [Area] [Lasting]",
        },
        new()
        {
            Id = Item.DreamTruffle,
            Note = "DreamTruffle",
            Effect = (Skill)0, // vanilla 26
            Cost = 1800, // vanilla 50
            UseStatus = 34930, // vanilla 49408
            EffectValue = 0, // vanilla 4
            Unknown13 = 13, // vanilla 0
            Unknown14 = 33, // vanilla 0
            Para1Pre = 2, // vanilla 0
            Para2 = 1, // vanilla 0
            Para3 = 19, // vanilla 0
            Para1Post = 1280, // vanilla 0
            Para2Post = 256, // vanilla 0
            Para4Post = 256, // vanilla 0
            ShortName = "MG SHROOM",
            Name = "Magic Mushroom",
            Description = "[+5 ATK] [Magic+] [Poison attack]",
        },
        new()
        {
            Id = Item.ParalyzeMushroom,
            Note = "ParalyzeMushroom",
            ShortName = "RA SHRM",
            Name = "Shock Mushroom  ",
            Description = "paralyze en",
        },
        new()
        {
            Id = Item.OrbOfSilence,
            Note = "OrbOfSilence",
            Effect = (Skill)0, // vanilla 21
            Cost = 2000, // vanilla 500
            Icon = 46, // vanilla 62
            UseStatus = 34934, // vanilla 49408
            EffectValue = 0, // vanilla 4
            Unknown13 = 25, // vanilla 0
            Unknown14 = 5, // vanilla 0
            Para2 = 1, // vanilla 0
            Para3 = 2, // vanilla 0
            Para4 = 3, // vanilla 0
            Para1Post = 768, // vanilla 0
            Para2Post = 768, // vanilla 0
            Para3Post = 768, // vanilla 0
            Para4Post = 512, // vanilla 0
            ShortName = "RUBY RING",
            Name = "Ruby Ring ",
            Description = "[+3 ATK/DEF/ACT] [Block]  Pretty  ",
        },
        new()
        {
            Id = Item.TrudgeWeed,
            Note = "TrudgeWeed",
            EffectValue = 254, // vanilla 253
        },
        new()
        {
            Id = Item.TortesWhistle,
            Note = "TortesWhistle",
            ShortName = "WSTLE",
            Name = "Torte's Whistle",
            Description = "Awaken entire party from sleep",
        },
        new()
        {
            Id = Item.FreesiaFlowers,
            Note = "FreesiaFlowers",
            Cost = 300, // vanilla 500
            UseStatus = 49408, // vanilla 57600
            EffectValue = 18, // vanilla 8
            ShortName = "FREE",
            Name = "Freesia Flowers",
            Description = "Restores 20 lv 3 MP  Combat only ",
        },
        new()
        {
            Id = Item.ConeOfLight,
            Note = "ConeOfLight",
            Cost = 12000, // vanilla 4000
        },
        new()
        {
            Id = Item.MikeromaScroll,
            Note = "MikeromaScroll",
            Cost = 400, // vanilla 450
            EffectValue = 60, // vanilla 50
        },
        new()
        {
            Id = Item.MiracleDrink,
            Note = "MiracleDrink",
            Effect = (Skill)0, // vanilla 113
            Cost = 800, // vanilla 500
            Icon = 47, // vanilla 49
            UseStatus = 34934, // vanilla 57600
            EffectValue = 0, // vanilla 5
            Para2 = 24, // vanilla 0
            Para1Post = 1792, // vanilla 0
            Para4Post = 512, // vanilla 256
            ShortName = "POIS CHRM ",
            Name = "Poison Charm ",
            Description = "Gives complete immunity to poison  ",
        },
        new()
        {
            Id = Item.HealthWeed,
            Note = "HealthWeed",
            Cost = 120, // vanilla 160
            EffectValue = 100, // vanilla 80
        },
        new()
        {
            Id = Item.SnakeEarrings,
            Note = "SnakeEarrings",
            Para4 = 25, // vanilla 0
            Para3Post = 512, // vanilla 0
        },
        new()
        {
            Id = Item.ResurrectPotion441,
            Note = "ResurrectPotion441",
            Cost = 80, // vanilla 3000
        },
        new()
        {
            Id = Item.SmokedSalmon,
            Note = "SmokedSalmon",
            EffectValue = 150, // vanilla 75
        },
        new()
        {
            Id = Item.PrimeRib,
            Note = "PrimeRib",
            Cost = 600, // vanilla 1000
            Icon = 50, // vanilla 52
            EffectValue = 200, // vanilla 150
            ShortName = "SUPERB",
            Name = "Superb",
            Description = "Restores 200 HP  Super Herb",
        },
        new()
        {
            Id = Item.RescueSet,
            Note = "RescueSet",
            EffectValue = 80, // vanilla 120
        },
        new()
        {
            Id = Item.BlackNailPolish,
            Note = "BlackNailPolish",
            EffectValue = 5, // vanilla 7
        },
        new()
        {
            Id = Item.SpiritWhip,
            Note = "SpiritWhip",
            Cost = 50000, // vanilla 0
            Icon = 31, // vanilla 0
            UseStatus = 34929, // vanilla 0
            Unknown7 = 2, // vanilla 0
            Unknown8 = 5, // vanilla 0
            Para2 = 3, // vanilla 0
            Para3 = 19, // vanilla 0
            Para4 = 13, // vanilla 0
            Para1Post = 12809, // vanilla 0
            Para2Post = 1024, // vanilla 0
            Para3Post = 5120, // vanilla 0
            Para4Post = 5122, // vanilla 0
            Unknown27 = 7, // vanilla 0
            ShortName = "SPT WHIP",
            Name = "Spirit Whip",
            Description = "+50 action  +4 magic  Blessed",
        },
        new()
        {
            Id = Item.MagicLipstick,
            Note = "MagicLipstick",
            EffectValue = 5, // vanilla 7
        },
        new()
        {
            Id = Item.EliteBadge,
            Note = "EliteBadge",
            Cost = 13000, // vanilla 15000
            Para1Post = 8960, // vanilla 8448
        },
        new()
        {
            Id = Item.RingOfRage,
            Note = "RingOfRage",
            Para1Post = 1024, // vanilla 768
        },
        new()
        {
            Id = Item.HolyRing,
            Note = "HolyRing",
            Unknown7 = 128, // vanilla 255
            Unknown13 = 22, // vanilla 0
            Para2 = 0, // vanilla 2
            Para3 = 0, // vanilla 33
            Para1Post = 0, // vanilla 2560
            Para2Post = 0, // vanilla 512
        },
        new()
        {
            Id = Item.MysteriousVeil,
            Note = "MysteriousVeil",
            Cost = 20000, // vanilla 10000
        },
        new()
        {
            Id = Item.BlizzardScroll,
            Note = "BlizzardScroll",
            Cost = 2000, // vanilla 1600
            EffectValue = 215, // vanilla 24
            Unknown11 = 0, // vanilla 1
        },
        new()
        {
            Id = Item.Telescope,
            Note = "Telescope",
            Cost = 400, // vanilla 2000
            Para3 = 4, // vanilla 0
            Para1Post = 1024, // vanilla 32768
            Para2Post = 768, // vanilla 0
            ShortName = "MONOCLE  ",
            Name = "Monocle",
            Description = "[+3 MOVE] [Range+]  Reach further",
        },
        new()
        {
            Id = Item.EnergyCharm,
            Note = "EnergyCharm",
            Unknown14 = 65, // vanilla 50
        },
        new()
        {
            Id = Item.DevilsAnklet,
            Note = "DevilsAnklet",
            Icon = 47, // vanilla 46
            Unknown7 = 128, // vanilla 255
            Unknown13 = 28, // vanilla 0
            Unknown14 = 25, // vanilla 0
            Para1Post = 512, // vanilla 1792
            ShortName = "TABLET  ",
            Name = "Ancient Tablet",
            Description = "+2 magic  Shining",
        },
        new()
        {
            Id = Item.MiraculousScales,
            Note = "MiraculousScales",
            Cost = 30000, // vanilla 60000
        },
        new()
        {
            Id = Item.GeneralsStaff,
            Note = "GeneralsStaff",
            Para3 = 13, // vanilla 0
            Para1Post = 14857, // vanilla 14089
            Para2Post = 4096, // vanilla 0
        },
        new()
        {
            Id = Item.EmperorsWhip,
            Note = "EmperorsWhip",
            Para4 = 13, // vanilla 0
            Para1Post = 15625, // vanilla 13577
            Para3Post = 4608, // vanilla 0
        },
        new()
        {
            Id = Item.PoisonOfPower,
            Note = "PoisonOfPower",
            Cost = 300, // vanilla 3000
            Icon = 28, // vanilla 53
            UseStatus = 34929, // vanilla 40960
            Unknown7 = 36, // vanilla 255
            Unknown8 = 3, // vanilla 0
            EffectValue = 0, // vanilla 255
            Unknown11 = 0, // vanilla 255
            Para2 = 1, // vanilla 0
            Para3 = 13, // vanilla 0
            Para1Post = 777, // vanilla 0
            Para2Post = 2560, // vanilla 0
            Para4Post = 1793, // vanilla 256
            Unknown27 = 4, // vanilla 0
            ShortName = "TOYHAMMER",
            Name = "Poison  ",
            Description = "[+3 ATK]  Squeak squeak!",
        },
        new()
        {
            Id = Item.PoisonOfDefense,
            Note = "PoisonOfDefense",
            ShortName = "DP",
            Name = "Pfense",
            Description = "lity",
        },
        new()
        {
            Id = Item.PoisonOfSpeed,
            Note = "PoisonOfSpeed",
            ShortName = "SPD PISN",
            Name = "Pof Speed",
            Description = "-1 wit",
        },
        new()
        {
            Id = Item.PoisonOfAgility,
            Note = "PoisonOfAgility",
            ShortName = "A POISN",
            Name = "Poison of Agility",
            Description = "-ty",
        },
        new()
        {
            Id = Item.PoisonOfMoves,
            Note = "PoisonOfMoves",
            ShortName = "MPOISN",
            Name = "PMoves",
            Description = "-3 MAX SP",
        },
        new()
        {
            Id = Item.Plus1DaggerSkill,
            Note = "Plus1DaggerSkill",
            ShortName = "+1 DAGGGER",
            Name = "+1 Dagger Skill",
            Description = "+1 dagger level",
        },
        new()
        {
            Id = Item.Plus5DaggerSkill,
            Note = "Plus5DaggerSkill",
            Cost = 5000, // vanilla 0
            Icon = 23, // vanilla 56
            UseStatus = 34929, // vanilla 8192
            Unknown7 = 121, // vanilla 18
            Unknown8 = 2, // vanilla 0
            EffectValue = 0, // vanilla 5
            Para2 = 1, // vanilla 0
            Para3 = 33, // vanilla 0
            Para4 = 13, // vanilla 0
            Para1Post = 9225, // vanilla 0
            Para2Post = 256, // vanilla 0
            Para3Post = 3584, // vanilla 0
            Para4Post = 1281, // vanilla 256
            Unknown27 = 2, // vanilla 0
            ShortName = "FORD",
            Name = "Forgotten Sword",
            Description = "+36 attack  +1 magic resist ",
        },
    ];
}
