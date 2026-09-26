using Grandia.Sdk;

namespace GrandiaReduxComplete.Items;

/// <summary>WINDT sec3 rows 128–255 that differ from vanilla USA Disc 1.</summary>
internal static class Ids128
{
    internal static readonly ItemEdit[] All =
    [
        new()
        {
            Id = Item.KleppsSickle,
            Note = "KleppsSickle",
            Cost = 2800, // vanilla 3200
            Unknown12 = 128, // vanilla 0
            Unknown13 = 8, // vanilla 0
            Unknown14 = 60, // vanilla 0
            Para3 = 13, // vanilla 0
            Para1Post = 8201, // vanilla 6409
            Para2Post = 4096, // vanilla 0
        },
        new()
        {
            Id = Item.FrogAx,
            Note = "FrogAx",
            Effect = (Skill)0, // vanilla 12
            Cost = 6300, // vanilla 4200
            UseStatus = 34929, // vanilla 51569
            EffectValue = 0, // vanilla 50
            Para3 = 13, // vanilla 0
            Para1Post = 8969, // vanilla 7177
            Para2Post = 3584, // vanilla 0
        },
        new()
        {
            Id = Item.BoneSplitterAx,
            Note = "BoneSplitterAx",
            Cost = 16000, // vanilla 9800
            Unknown13 = 0, // vanilla 9
            Unknown14 = 0, // vanilla 33
            Para1Pre = 0, // vanilla 1
            Para3 = 13, // vanilla 0
            Para1Post = 13833, // vanilla 10505
            Para2Post = 3584, // vanilla 0
        },
        new()
        {
            Id = Item.EarthenAx,
            Note = "EarthenAx",
            Unknown12 = 0, // vanilla 144
            Para3 = 13, // vanilla 0
            Para1Post = 25609, // vanilla 17417
            Para2Post = 4096, // vanilla 0
            ShortName = "SPT AX  ",
            Name = "Spirit Ax ",
            Description = "+100 attack  Best ax                 ",
        },
        new()
        {
            Id = Item.BusterAx,
            Note = "BusterAx",
            Cost = 28000, // vanilla 32000
            Para4 = 13, // vanilla 0
            Para1Post = 16905, // vanilla 13321
            Para2Post = 60416, // vanilla 59136
            Para3Post = 4351, // vanilla 255
        },
        new()
        {
            Id = Item.WreckingAx,
            Note = "WreckingAx",
            Para3 = 13, // vanilla 0
            Para1Post = 10761, // vanilla 8969
            Para2Post = 3072, // vanilla 0
        },
        new()
        {
            Id = Item.BentMattock,
            Note = "BentMattock",
            Para3 = 13, // vanilla 0
            Para2Post = 4608, // vanilla 0
            ShortName = "MATT",
            Name = "Bent Mattock",
            Description = "+5 attack  Bent and useless",
        },
        new()
        {
            Id = Item.ZeroAx,
            Note = "ZeroAx",
            Para3 = 13, // vanilla 0
            Para2Post = 4608, // vanilla 0
        },
        new()
        {
            Id = Item.ToyBowAndArrow,
            Note = "ToyBowAndArrow",
            Para3 = 13, // vanilla 0
            Para1Post = 777, // vanilla 1289
            Para2Post = 2560, // vanilla 0
            ShortName = "TRAIN BOW",
            Name = "Training Bow",
            Description = "[+3 ATK]  For practice   ",
        },
        new()
        {
            Id = Item.HandmadeDarts,
            Note = "HandmadeDarts",
            Cost = 160, // vanilla 150
            Para3 = 4, // vanilla 0
            Para4 = 13, // vanilla 0
            Para1Post = 1033, // vanilla 1801
            Para2Post = 768, // vanilla 0
            Para3Post = 2560, // vanilla 0
        },
        new()
        {
            Id = Item.HuntersBow,
            Note = "HuntersBow",
            Cost = 660, // vanilla 850
            Para3 = 13, // vanilla 0
            Para4 = 10, // vanilla 0
            Para1Post = 1801, // vanilla 4105
            Para2Post = 3072, // vanilla 0
            Para3Post = 256, // vanilla 0
            Para4Post = 3335, // vanilla 3342
            ShortName = "SHORTBOW ",
            Name = "Shortbow",
            Description = "[+7 ATK] [Combo+]  Lower ranged bow",
        },
        new()
        {
            Id = Item.FlyingFishBow,
            Note = "FlyingFishBow",
            Unknown12 = 128, // vanilla 0
            Para3 = 4, // vanilla 0
            Para4 = 13, // vanilla 0
            Para1Post = 7177, // vanilla 6409
            Para2Post = 61952, // vanilla 0
            Para3Post = 4351, // vanilla 0
            Para4Post = 3346, // vanilla 3348
        },
        new()
        {
            Id = Item.HailBow,
            Note = "HailBow",
            Effect = (Skill)0, // vanilla 35
            Cost = 1600, // vanilla 3000
            Icon = 41, // vanilla 34
            UseStatus = 34931, // vanilla 51569
            Unknown7 = 213, // vanilla 68
            Unknown8 = 0, // vanilla 6
            EffectValue = 0, // vanilla 120
            Unknown12 = 0, // vanilla 96
            Unknown13 = 28, // vanilla 0
            Unknown14 = 6, // vanilla 0
            Para2 = 2, // vanilla 1
            Para3 = 22, // vanilla 0
            Para1Post = 1536, // vanilla 5129
            Para2Post = 768, // vanilla 0
            Para4Post = 6400, // vanilla 3600
            Unknown27 = 0, // vanilla 88
            ShortName = "GLIM CAP",
            Name = "Glimmer Cap",
            Description = "[+6 DEF] [+3 s.block resist] [Lucky]",
        },
        new()
        {
            Id = Item.FlintBow,
            Note = "FlintBow",
            Cost = 1200, // vanilla 2000
            Icon = 28, // vanilla 34
            Unknown7 = 36, // vanilla 68
            Unknown8 = 3, // vanilla 6
            Para3 = 13, // vanilla 0
            Para4 = 36, // vanilla 0
            Para1Post = 4105, // vanilla 5129
            Para2Post = 3584, // vanilla 0
            Para3Post = 256, // vanilla 0
            Para4Post = 1793, // vanilla 3350
            Unknown27 = 4, // vanilla 88
            ShortName = "SM HAMMER",
            Name = "Blacksmith's Hammer",
            Description = "[+16 ATK] [Skill+]  Forged to forge ",
        },
        new()
        {
            Id = Item.ExorcisingBow,
            Note = "ExorcisingBow",
            Para3 = 13, // vanilla 0
            Para2Post = 3584, // vanilla 0
        },
        new()
        {
            Id = Item.CafuShuriken,
            Note = "CafuShuriken",
            Para3 = 4, // vanilla 0
            Para4 = 13, // vanilla 0
            Para2Post = 3840, // vanilla 0
            Para3Post = 3072, // vanilla 0
        },
        new()
        {
            Id = Item.Boomerang,
            Note = "Boomerang",
            Cost = 2000, // vanilla 5400
            Unknown7 = 20, // vanilla 84
            Para3 = 13, // vanilla 0
            Para4 = 10, // vanilla 0
            Para1Post = 62985, // vanilla 8457
            Para2Post = 4863, // vanilla 0
            Para3Post = 768, // vanilla 0
            Para4Post = 4362, // vanilla 4370
        },
        new()
        {
            Id = Item.FireDarts,
            Note = "FireDarts",
            Para3 = 4, // vanilla 0
            Para4 = 13, // vanilla 0
            Para2Post = 5632, // vanilla 0
            Para3Post = 3584, // vanilla 0
        },
        new()
        {
            Id = Item.EvilShuriken,
            Note = "EvilShuriken",
            Para3 = 4, // vanilla 3
            Para4 = 13, // vanilla 0
            Para1Post = 19721, // vanilla 16393
            Para2Post = 10240, // vanilla 5120
            Para3Post = 3072, // vanilla 0
        },
        new()
        {
            Id = Item.DemonslayerBoomer,
            Note = "DemonslayerBoomer",
            Para3 = 13, // vanilla 0
            Para1Post = 18441, // vanilla 15369
            Para2Post = 4096, // vanilla 0
        },
        new()
        {
            Id = Item.Discus,
            Note = "Discus",
            Para3 = 13, // vanilla 0
            Para2Post = 3584, // vanilla 0
        },
        new()
        {
            Id = Item.CactusThorns,
            Note = "CactusThorns",
            Para3 = 4, // vanilla 0
            Para4 = 13, // vanilla 0
            Para2Post = 5120, // vanilla 0
            Para3Post = 3072, // vanilla 0
        },
        new()
        {
            Id = Item.IceBoomerang,
            Note = "IceBoomerang",
            Para3 = 13, // vanilla 0
            Para2Post = 4096, // vanilla 0
        },
        new()
        {
            Id = Item.ThunderArrow,
            Note = "ThunderArrow",
            Para3 = 13, // vanilla 0
            Para2Post = 4096, // vanilla 0
        },
        new()
        {
            Id = Item.ZeroShuriken,
            Note = "ZeroShuriken",
            Para3 = 13, // vanilla 0
            Para2Post = 4608, // vanilla 0
        },
        new()
        {
            Id = Item.ZeroWhip,
            Note = "ZeroWhip",
            Para3 = 13, // vanilla 0
            Para2Post = 5120, // vanilla 0
        },
        new()
        {
            Id = Item.MistCrackingWhip,
            Note = "MistCrackingWhip",
            Cost = 1300, // vanilla 1200
            Para3 = 13, // vanilla 0
            Para4 = 36, // vanilla 0
            Para1Post = 3849, // vanilla 5129
            Para2Post = 3584, // vanilla 0
            Para3Post = 256, // vanilla 0
        },
        new()
        {
            Id = Item.LeatherWhip,
            Note = "LeatherWhip",
            Cost = 60, // vanilla 240
            Para3 = 13, // vanilla 0
            Para1Post = 777, // vanilla 2313
            Para2Post = 3584, // vanilla 0
        },
        new()
        {
            Id = Item.ThornyWhip,
            Note = "ThornyWhip",
            Para3 = 36, // vanilla 0
            Para4 = 13, // vanilla 0
            Para1Post = 1801, // vanilla 3849
            Para2Post = 256, // vanilla 0
            Para3Post = 3584, // vanilla 0
            ShortName = "SILK WIRE",
            Name = "Silken Wire",
            Description = "[+7 ATK] [Skill+]  From webs",
        },
        new()
        {
            Id = Item.CatfishWhiskers,
            Note = "CatfishWhiskers",
            Para3 = 13, // vanilla 0
            Para2Post = 4096, // vanilla 0
        },
        new()
        {
            Id = Item.GiantSnakeWhip,
            Note = "GiantSnakeWhip",
            Cost = 8000, // vanilla 5400
            Para3 = 13, // vanilla 0
            Para2Post = 4096, // vanilla 0
        },
        new()
        {
            Id = Item.BindingWhip,
            Note = "BindingWhip",
            Unknown14 = 10, // vanilla 160
            Para1Pre = 3, // vanilla 0
            Para3 = 13, // vanilla 0
            Para1Post = 11529, // vanilla 14345
            Para2Post = 4096, // vanilla 0
        },
        new()
        {
            Id = Item.MorningStar,
            Note = "MorningStar",
            Cost = 13000, // vanilla 9600
            Para4 = 13, // vanilla 0
            Para1Post = 14089, // vanilla 10249
            Para3Post = 4863, // vanilla 255
        },
        new()
        {
            Id = Item.WhipOfLight,
            Note = "WhipOfLight",
            Para4 = 13, // vanilla 0
            Para1Post = 18697, // vanilla 16649
            Para2Post = 768, // vanilla 512
            Para3Post = 5120, // vanilla 0
        },
        new()
        {
            Id = Item.BurningHotWhip,
            Note = "BurningHotWhip",
            Para3 = 13, // vanilla 0
            Para2Post = 4096, // vanilla 0
        },
        new()
        {
            Id = Item.GaleWhip,
            Note = "GaleWhip",
            Effect = (Skill)0, // vanilla 18
            Cost = 3200, // vanilla 3300
            EffectValue = 0, // vanilla 1
            Unknown12 = 128, // vanilla 64
            Para3 = 13, // vanilla 0
            Para4 = 36, // vanilla 0
            Para2Post = 4096, // vanilla 0
            Para3Post = 256, // vanilla 0
            Para4Post = 5123, // vanilla 5122
            ShortName = "WHISKERS ",
            Name = "Dragon Whiskers ",
            Description = "[+27 ATK] [Skill+]  Unknown rarity  ",
        },
        new()
        {
            Id = Item.AdventureClothes,
            Note = "AdventureClothes",
            Unknown7 = 117, // vanilla 255
            Para3 = 14, // vanilla 0
            Para1Post = 256, // vanilla 512
            Para2Post = 512, // vanilla 0
        },
        new()
        {
            Id = Item.SundayBest,
            Note = "SundayBest",
            Icon = 48, // vanilla 35
            Unknown7 = 198, // vanilla 255
            Para3 = 14, // vanilla 0
            Para1Post = 256, // vanilla 512
            Para2Post = 512, // vanilla 0
        },
        new()
        {
            Id = Item.SportsWear,
            Note = "SportsWear",
            Unknown7 = 117, // vanilla 255
            Para3 = 14, // vanilla 0
            Para1Post = 768, // vanilla 1024
            Para2Post = 512, // vanilla 0
        },
        new()
        {
            Id = Item.WorkClothes,
            Note = "WorkClothes",
            Cost = 100, // vanilla 90
            Icon = 48, // vanilla 35
            Unknown7 = 198, // vanilla 255
            Para3 = 14, // vanilla 0
            Para4 = 33, // vanilla 0
            Para1Post = 512, // vanilla 768
            Para2Post = 512, // vanilla 0
            Para3Post = 256, // vanilla 0
            ShortName = "OLD ROBE ",
            Name = "Old Robe",
            Description = "[+2 DEF] [+1 magic resist]",
        },
        new()
        {
            Id = Item.CactusArmor,
            Note = "CactusArmor",
            Para4 = 14, // vanilla 0
            Para3Post = 1280, // vanilla 0
        },
        new()
        {
            Id = Item.SoldiersUniform,
            Note = "SoldiersUniform",
            Cost = 600, // vanilla 500
            Unknown7 = 117, // vanilla 255
            Para3 = 14, // vanilla 0
            Para2Post = 768, // vanilla 0
        },
        new()
        {
            Id = Item.OfficersUniform,
            Note = "OfficersUniform",
            Cost = 1400, // vanilla 800
            Icon = 21, // vanilla 35
            UseStatus = 34929, // vanilla 34932
            Unknown7 = 82, // vanilla 255
            Unknown8 = 1, // vanilla 0
            Unknown12 = 1, // vanilla 0
            Para2 = 1, // vanilla 2
            Para3 = 10, // vanilla 0
            Para4 = 13, // vanilla 0
            Para1Post = 3593, // vanilla 2304
            Para2Post = 256, // vanilla 0
            Para3Post = 3840, // vanilla 0
            Para4Post = 1024, // vanilla 5376
            ShortName = "ARMYKNIFE",
            Name = "Garlyle Army Knife",
            Description = "[+14 ATK] [Combo+] [Human slayer] ",
        },
        new()
        {
            Id = Item.FairyRobe,
            Note = "FairyRobe",
            Cost = 1600, // vanilla 1800
            Unknown7 = 117, // vanilla 255
            Para3 = 14, // vanilla 26
            Para4 = 28, // vanilla 27
            Para1Post = 1792, // vanilla 2560
            Para2Post = 768, // vanilla 512
            ShortName = "MIST COAT",
            Name = "Misty Coat",
            Description = "[+7 DEF] [+2 all status resist]     ",
        },
        new()
        {
            Id = Item.FlyingDragonVest,
            Note = "FlyingDragonVest",
            Para4 = 14, // vanilla 0
            Para2Post = 256, // vanilla 512
            Para3Post = 768, // vanilla 0
        },
        new()
        {
            Id = Item.FrogShirt,
            Note = "FrogShirt",
            Para4 = 14, // vanilla 0
            Para1Post = 3328, // vanilla 2560
            Para3Post = 768, // vanilla 0
        },
        new()
        {
            Id = Item.SpyClothes,
            Note = "SpyClothes",
            Para3 = 4, // vanilla 0
            Para4 = 14, // vanilla 0
            Para2Post = 3584, // vanilla 0
            Para3Post = 768, // vanilla 0
        },
        new()
        {
            Id = Item.ChainMail,
            Note = "ChainMail",
            Para3 = 14, // vanilla 0
            Para2Post = 768, // vanilla 0
        },
        new()
        {
            Id = Item.BattleBikini,
            Note = "BattleBikini",
            Para4 = 14, // vanilla 0
            Para2Post = 2560, // vanilla 1024
            Para3Post = 768, // vanilla 0
        },
        new()
        {
            Id = Item.MogayClothes,
            Note = "MogayClothes",
            Para3 = 14, // vanilla 0
            Para2Post = 1024, // vanilla 0
        },
        new()
        {
            Id = Item.MinkCoat,
            Note = "MinkCoat",
            Para3 = 14, // vanilla 30
            Para2Post = 768, // vanilla 1280
            Para3Post = 512, // vanilla 1280
        },
        new()
        {
            Id = Item.EnchantressRobe,
            Note = "EnchantressRobe",
            Unknown7 = 130, // vanilla 255
            Para4 = 14, // vanilla 0
            Para3Post = 768, // vanilla 0
        },
        new()
        {
            Id = Item.AngelsRobe,
            Note = "AngelsRobe",
            Unknown7 = 130, // vanilla 255
            Para3 = 14, // vanilla 0
            Para2Post = 768, // vanilla 0
        },
        new()
        {
            Id = Item.RobeOfTheSun,
            Note = "RobeOfTheSun",
            Unknown7 = 130, // vanilla 255
            Unknown12 = 0, // vanilla 16
            Unknown13 = 1, // vanilla 29
            Unknown14 = 25, // vanilla 128
            Para3 = 14, // vanilla 16
            Para1Post = 10752, // vanilla 11520
            Para2Post = 1024, // vanilla 768
        },
        new()
        {
            Id = Item.Breastplate,
            Note = "Breastplate",
            Cost = 200, // vanilla 360
            Icon = 48, // vanilla 36
            Unknown7 = 198, // vanilla 255
            Para3 = 14, // vanilla 0
            Para4 = 4, // vanilla 0
            Para1Post = 768, // vanilla 1536
            Para2Post = 768, // vanilla 0
            Para3Post = 768, // vanilla 0
            ShortName = "ROGUEGEAR",
            Name = "Rogue's Gear ",
            Description = "[+3 DEF] [+3 MOVE]  For dexterity     ",
        },
        new()
        {
            Id = Item.OutdatedArmor,
            Note = "OutdatedArmor",
            Cost = 200, // vanilla 160
            Unknown7 = 59, // vanilla 127
            Para3 = 4, // vanilla 0
            Para4 = 14, // vanilla 0
            Para1Post = 1280, // vanilla 1024
            Para2Post = 64256, // vanilla 0
            Para3Post = 767, // vanilla 0
        },
        new()
        {
            Id = Item.BambooArmor,
            Note = "BambooArmor",
            Cost = 600, // vanilla 360
            Unknown7 = 59, // vanilla 127
            Para3 = 4, // vanilla 0
            Para4 = 14, // vanilla 0
            Para1Post = 1792, // vanilla 1536
            Para2Post = 63744, // vanilla 0
            Para3Post = 767, // vanilla 0
        },
        new()
        {
            Id = Item.ShellArmor,
            Note = "ShellArmor",
            Cost = 1000, // vanilla 640
            Unknown7 = 59, // vanilla 255
            Para3 = 4, // vanilla 0
            Para4 = 14, // vanilla 0
            Para1Post = 2304, // vanilla 2048
            Para2Post = 62976, // vanilla 0
            Para3Post = 767, // vanilla 0
        },
        new()
        {
            Id = Item.ThickArmor,
            Note = "ThickArmor",
            Cost = 1800, // vanilla 1700
            Unknown7 = 59, // vanilla 57
            Para3 = 4, // vanilla 0
            Para4 = 14, // vanilla 0
            Para1Post = 3840, // vanilla 3072
            Para2Post = 60416, // vanilla 0
            Para3Post = 1279, // vanilla 0
        },
        new()
        {
            Id = Item.SwordfishArmor,
            Note = "SwordfishArmor",
            Cost = 2000, // vanilla 2100
            Icon = 35, // vanilla 36
            Unknown7 = 117, // vanilla 127
            Unknown13 = 30, // vanilla 0
            Unknown14 = 25, // vanilla 0
            Para3 = 14, // vanilla 0
            Para1Post = 2816, // vanilla 3072
            Para2Post = 768, // vanilla 0
            ShortName = "SF ATTIRE",
            Name = "Swordfish Attire",
            Description = "[+11 DEF] [Counter-]  Peculiar    ",
        },
        new()
        {
            Id = Item.SkullArmor,
            Note = "SkullArmor",
            Cost = 2400, // vanilla 3300
            Icon = 48, // vanilla 36
            Unknown7 = 198, // vanilla 123
            Para3 = 14, // vanilla 0
            Para4 = 33, // vanilla 0
            Para1Post = 2304, // vanilla 3840
            Para2Post = 768, // vanilla 0
            Para3Post = 512, // vanilla 0
            ShortName = "PRST ROBE",
            Name = "Priest's Robe",
            Description = "[+9 DEF] [+2 magic resist]",
        },
        new()
        {
            Id = Item.ChameleonArmor,
            Note = "ChameleonArmor",
            Para4 = 14, // vanilla 0
            Para3Post = 768, // vanilla 0
        },
        new()
        {
            Id = Item.PlugSuit,
            Note = "PlugSuit",
            Para4 = 14, // vanilla 0
            Para3Post = 768, // vanilla 0
        },
        new()
        {
            Id = Item.AuraArmor,
            Note = "AuraArmor",
            Cost = 12000, // vanilla 20000
            Para4 = 14, // vanilla 0
            Para1Post = 6656, // vanilla 8960
            Para3Post = 1024, // vanilla 0
        },
        new()
        {
            Id = Item.DarkArmor,
            Note = "DarkArmor",
            Para2Post = 1536, // vanilla 768
        },
        new()
        {
            Id = Item.WarriorsMail,
            Note = "WarriorsMail",
            Para4 = 14, // vanilla 0
            Para3Post = 1024, // vanilla 0
        },
        new()
        {
            Id = Item.SpiritArmor,
            Note = "SpiritArmor",
            Unknown7 = 17, // vanilla 1
            Para3 = 14, // vanilla 0
            Para1Post = 12800, // vanilla 14080
            Para2Post = 1024, // vanilla 0
        },
        new()
        {
            Id = Item.DevilsRobe,
            Note = "DevilsRobe",
            Para4 = 14, // vanilla 0
            Para1Post = 7680, // vanilla 8192
            Para3Post = 768, // vanilla 0
        },
        new()
        {
            Id = Item.MagicRobe,
            Note = "MagicRobe",
            Para4 = 14, // vanilla 0
            Para3Post = 768, // vanilla 0
        },
        new()
        {
            Id = Item.CuttingBoard,
            Note = "CuttingBoard",
            Cost = 20, // vanilla 10
            Icon = 39, // vanilla 38
            Unknown7 = 119, // vanilla 255
        },
        new()
        {
            Id = Item.WoolenMittens,
            Note = "WoolenMittens",
            Cost = 20, // vanilla 10
            Para2 = 4, // vanilla 2
            Para1Post = 1024, // vanilla 256
        },
        new()
        {
            Id = Item.LeatherGloves,
            Note = "LeatherGloves",
            Para2 = 4, // vanilla 2
            Para1Post = 2048, // vanilla 512
        },
        new()
        {
            Id = Item.EscargotShield,
            Note = "EscargotShield",
            Cost = 900, // vanilla 750
            Unknown7 = 119, // vanilla 127
            Unknown13 = 30, // vanilla 0
            Unknown14 = 50, // vanilla 0
            Para1Post = 1280, // vanilla 1792
            ShortName = "SOL TARGE",
            Name = "Solar Targe    ",
            Description = "[+5 DEF] [Counter]  Unique design",
        },
        new()
        {
            Id = Item.OakenShield,
            Note = "OakenShield",
            Cost = 160, // vanilla 130
            Icon = 39, // vanilla 38
            Unknown7 = 119, // vanilla 255
            Unknown13 = 30, // vanilla 0
            Unknown14 = 50, // vanilla 0
            Para1Post = 512, // vanilla 768
            ShortName = "OAK TARGE",
            Name = "Oaken Targe ",
            Description = "[+2 DEF] [Counter]  Resilient ",
        },
        new()
        {
            Id = Item.ShellShield,
            Note = "ShellShield",
            Cost = 450, // vanilla 250
            Unknown7 = 119, // vanilla 127
            Unknown13 = 30, // vanilla 0
            Unknown14 = 66, // vanilla 0
            Para1Post = 768, // vanilla 1280
        },
        new()
        {
            Id = Item.SeashellShield,
            Note = "SeashellShield",
            Cost = 1400, // vanilla 960
            Icon = 44, // vanilla 39
            UseStatus = 34933, // vanilla 34930
            Unknown7 = 93, // vanilla 127
            Unknown13 = 1, // vanilla 0
            Unknown14 = 250, // vanilla 0
            Para2 = 4, // vanilla 2
            Para3 = 22, // vanilla 0
            Para4 = 35, // vanilla 0
            Para1Post = 4608, // vanilla 2048
            Para2Post = 768, // vanilla 0
            Para3Post = 768, // vanilla 0
            Para4Post = 7168, // vanilla 5888
            ShortName = "PRST SHOE",
            Name = "Priest's Shoes ",
            Description = "[+18 MOVE] [+3 plague/death resist]",
        },
        new()
        {
            Id = Item.MushroomShield,
            Note = "MushroomShield",
            Cost = 1200, // vanilla 1000
            Icon = 38, // vanilla 39
            Unknown7 = 185, // vanilla 127
            Unknown13 = 25, // vanilla 0
            Unknown14 = 6, // vanilla 0
            Para3 = 4, // vanilla 23
            Para4 = 0, // vanilla 24
            Para1Post = 2048, // vanilla 2304
            Para2Post = 61952, // vanilla 256
            Para3Post = 255, // vanilla 256
            ShortName = "KT SHIELD",
            Name = "Knight's Shield",
            Description = "[+8 DEF] [-14 MOVE] [Block]     ",
        },
        new()
        {
            Id = Item.AlligatorGauntlet,
            Note = "AlligatorGauntlet",
            Para3 = 4, // vanilla 0
            Para2Post = 2560, // vanilla 0
        },
        new()
        {
            Id = Item.LafaFlowerShield,
            Note = "LafaFlowerShield",
            Cost = 10000, // vanilla 18000
            Para1Post = 2560, // vanilla 4864
        },
        new()
        {
            Id = Item.PowerShield,
            Note = "PowerShield",
            Para2Post = 3840, // vanilla 1792
        },
        new()
        {
            Id = Item.MoonlightShield,
            Note = "MoonlightShield",
            Cost = 5000, // vanilla 5700
            Para1Post = 4352, // vanilla 5376
            Para2Post = 256, // vanilla 512
            Para3Post = 256, // vanilla 512
        },
        new()
        {
            Id = Item.Gauntlets,
            Note = "Gauntlets",
            Para1Post = 3840, // vanilla 5120
            Para2Post = 6400, // vanilla 2560
        },
        new()
        {
            Id = Item.DragonGauntlet,
            Note = "DragonGauntlet",
            Cost = 1000, // vanilla 400
            Unknown13 = 2, // vanilla 0
            Unknown14 = 85, // vanilla 0
            Para3 = 4, // vanilla 0
            Para1Post = 768, // vanilla 1280
            Para2Post = 2560, // vanilla 0
            ShortName = "GAUNTLET ",
            Name = "Dragon Gauntlet",
            Description = "[+3 DEF] [+10 MOVE] [Psyche]   ",
        },
        new()
        {
            Id = Item.HeavyShield,
            Note = "HeavyShield",
            Para1Post = 7168, // vanilla 5888
            Para2Post = 57856, // vanilla 60416
        },
        new()
        {
            Id = Item.GauntletsOfLight,
            Note = "GauntletsOfLight",
            Unknown7 = 130, // vanilla 255
            Para3 = 19, // vanilla 33
            Para1Post = 7680, // vanilla 6400
            ShortName = "L GLOVES ",
            Name = "Gloves of Light   ",
            Description = "+30 defense  +1 magic  Pure white   ",
        },
        new()
        {
            Id = Item.SpiritShield,
            Note = "SpiritShield",
            Para1Post = 10240, // vanilla 11520
            Para2Post = 512, // vanilla 1024
        },
        new()
        {
            Id = Item.MagicGloves,
            Note = "MagicGloves",
            Unknown7 = 130, // vanilla 255
            Para3 = 19, // vanilla 0
            Para2Post = 256, // vanilla 0
        },
        new()
        {
            Id = Item.Goggles,
            Note = "Goggles",
            Cost = 40, // vanilla 100
            Unknown7 = 213, // vanilla 127
            Para1Post = 256, // vanilla 512
        },
        new()
        {
            Id = Item.Ribbon,
            Note = "Ribbon",
            Cost = 20, // vanilla 10
            Unknown7 = 230, // vanilla 166
            Para2 = 1, // vanilla 2
        },
        new()
        {
            Id = Item.FluffyRibbon,
            Note = "FluffyRibbon",
            Cost = 100, // vanilla 40
            Unknown7 = 230, // vanilla 166
            Para2 = 1, // vanilla 2
            Para3 = 14, // vanilla 0
            Para2Post = 512, // vanilla 0
        },
        new()
        {
            Id = Item.Barrette,
            Note = "Barrette",
            Cost = 160, // vanilla 90
            Unknown7 = 230, // vanilla 166
            Para2 = 1, // vanilla 2
            Para3 = 14, // vanilla 0
            Para1Post = 1024, // vanilla 768
            Para2Post = 512, // vanilla 0
        },
        new()
        {
            Id = Item.PiratesHat,
            Note = "PiratesHat",
            Cost = 380, // vanilla 160
            Icon = 27, // vanilla 41
            UseStatus = 34930, // vanilla 34931
            Unknown7 = 159, // vanilla 255
            Unknown13 = 1, // vanilla 0
            Unknown14 = 200, // vanilla 0
            Para2 = 3, // vanilla 2
            Para1Post = 1280, // vanilla 1024
            Para4Post = 5888, // vanilla 6400
            ShortName = "BSC FOCUS",
            Name = "Basic Focus ",
            Description = "[+5 ACT] [20% spell haste]  Curious ",
        },
        new()
        {
            Id = Item.CowboyHat,
            Note = "CowboyHat",
            Cost = 350, // vanilla 160
            Unknown7 = 213, // vanilla 255
            Unknown13 = 28, // vanilla 0
            Unknown14 = 6, // vanilla 0
            Para1Post = 768, // vanilla 1024
        },
        new()
        {
            Id = Item.ClimbingHat,
            Note = "ClimbingHat",
            Cost = 750, // vanilla 400
            Unknown7 = 213, // vanilla 255
            Unknown13 = 28, // vanilla 0
            Unknown14 = 6, // vanilla 0
        },
        new()
        {
            Id = Item.FeatheredTurban,
            Note = "FeatheredTurban",
            Para3 = 4, // vanilla 0
            Para2Post = 6400, // vanilla 0
        },
        new()
        {
            Id = Item.SafetyHelmet,
            Note = "SafetyHelmet",
            Unknown7 = 57, // vanilla 127
            Para3 = 4, // vanilla 0
            Para2Post = 64512, // vanilla 0
            Para3Post = 255, // vanilla 0
        },
        new()
        {
            Id = Item.PearlHelmet,
            Note = "PearlHelmet",
            Cost = 1400, // vanilla 700
            Unknown7 = 57, // vanilla 127
            Para3 = 4, // vanilla 0
            Para4 = 16, // vanilla 0
            Para1Post = 2304, // vanilla 1792
            Para2Post = 61696, // vanilla 0
            Para3Post = 1023, // vanilla 0
            ShortName = "KGHT HELM",
            Name = "Knight's Helmet",
            Description = "[+9 DEF] [-15 MOVE] [Sturdiness+]    ",
        },
        new()
        {
            Id = Item.PiratesHelmet,
            Note = "PiratesHelmet",
            Cost = 1500, // vanilla 1200
            Icon = 43, // vanilla 42
            Unknown7 = 90, // vanilla 121
            Para3 = 4, // vanilla 0
            Para4 = 13, // vanilla 0
            Para1Post = 2048, // vanilla 3072
            Para2Post = 62464, // vanilla 0
            Para3Post = 1279, // vanilla 0
            ShortName = "KABUTO   ",
            Name = "Dight's Kabuto ",
            Description = "[+8 DEF] [-12 MOVE] [Fury]  Ominous",
        },
        new()
        {
            Id = Item.DeathMask,
            Note = "DeathMask",
            Para1Post = 5632, // vanilla 6656
            Para2Post = 512, // vanilla 65024
            Para3Post = 0, // vanilla 255
        },
        new()
        {
            Id = Item.CharismaHelm,
            Note = "CharismaHelm",
            Cost = 18000, // vanilla 23800
            Para2Post = 3840, // vanilla 7680
        },
        new()
        {
            Id = Item.SpiritHelmet,
            Note = "SpiritHelmet",
            Para1Post = 9728, // vanilla 10752
        },
        new()
        {
            Id = Item.HolyCrown,
            Note = "HolyCrown",
            Para1Post = 8192, // vanilla 9728
        },
        new()
        {
            Id = Item.FairyTiara,
            Note = "FairyTiara",
            Para1Post = 7680, // vanilla 8960
        },
        new()
        {
            Id = Item.MansHeadband,
            Note = "MansHeadband",
            Para1Post = 7936, // vanilla 7168
            Para2Post = 6400, // vanilla 3840
        },
        new()
        {
            Id = Item.Sneakers,
            Note = "Sneakers",
            Cost = 40, // vanilla 50
            Unknown7 = 93, // vanilla 255
            Unknown13 = 1, // vanilla 0
            Unknown14 = 250, // vanilla 0
            Para2Post = 768, // vanilla 8960
        },
        new()
        {
            Id = Item.DressShoes,
            Note = "DressShoes",
            Cost = 40, // vanilla 70
            Unknown7 = 166, // vanilla 4
            Unknown13 = 1, // vanilla 0
            Unknown14 = 250, // vanilla 0
            Para1Pre = 160, // vanilla 0
            Para2 = 4, // vanilla 2
            Para3 = 3, // vanilla 4
            Para2Post = 768, // vanilla 7680
        },
        new()
        {
            Id = Item.AirSneakers,
            Note = "AirSneakers",
            Cost = 80, // vanilla 90
            Unknown7 = 93, // vanilla 255
            Unknown13 = 1, // vanilla 0
            Unknown14 = 250, // vanilla 0
            Para2Post = 2048, // vanilla 12288
        },
        new()
        {
            Id = Item.ShinyShoes,
            Note = "ShinyShoes",
            Cost = 100, // vanilla 50
            Unknown7 = 93, // vanilla 255
            Unknown12 = 128, // vanilla 0
            Unknown13 = 1, // vanilla 0
            Unknown14 = 250, // vanilla 0
            Para2 = 4, // vanilla 2
            Para3 = 32, // vanilla 4
            Para1Post = 1024, // vanilla 0
            Para2Post = 512, // vanilla 8960
            ShortName = "ROCK SHOE",
            Name = "Rock Shoes ",
            Description = "[+4 MOVE] [+2 fire/earth resist]",
        },
        new()
        {
            Id = Item.RubberBoots,
            Note = "RubberBoots",
            Cost = 120, // vanilla 90
            Unknown7 = 107, // vanilla 255
            Unknown13 = 1, // vanilla 0
            Unknown14 = 250, // vanilla 0
            Para4 = 30, // vanilla 0
            Para2Post = 0, // vanilla 5120
            Para3Post = 512, // vanilla 0
        },
        new()
        {
            Id = Item.LeatherGreaves,
            Note = "LeatherGreaves",
            Cost = 200, // vanilla 100
            Unknown7 = 107, // vanilla 123
            Unknown13 = 1, // vanilla 0
            Unknown14 = 250, // vanilla 0
            Para2Post = 1280, // vanilla 4352
        },
        new()
        {
            Id = Item.HuntersBoots,
            Note = "HuntersBoots",
            Cost = 400, // vanilla 200
            Unknown7 = 107, // vanilla 255
            Unknown13 = 1, // vanilla 0
            Unknown14 = 250, // vanilla 0
            Para1Post = 512, // vanilla 256
            Para2Post = 1024, // vanilla 7680
        },
        new()
        {
            Id = Item.ArmyBoots,
            Note = "ArmyBoots",
            Cost = 900, // vanilla 700
            Unknown7 = 107, // vanilla 127
            Unknown13 = 1, // vanilla 0
            Unknown14 = 250, // vanilla 0
            Para1Post = 768, // vanilla 512
            Para2Post = 1536, // vanilla 3840
        },
        new()
        {
            Id = Item.CuriousClogs,
            Note = "CuriousClogs",
            Cost = 850, // vanilla 1000
            Unknown7 = 93, // vanilla 255
            Unknown12 = 192, // vanilla 0
            Unknown13 = 1, // vanilla 28
            Unknown14 = 250, // vanilla 10
            Para2 = 4, // vanilla 2
            Para3 = 31, // vanilla 0
            Para4 = 32, // vanilla 0
            Para1Post = 3840, // vanilla 768
            Para2Post = 512, // vanilla 0
            Para3Post = 512, // vanilla 0
        },
    ];
}
