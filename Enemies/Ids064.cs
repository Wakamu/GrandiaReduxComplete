using Grandia.Sdk;

namespace GrandiaReduxComplete.Enemies;

internal static class Ids064
{
    internal static readonly EnemyEdit[] All =
    [
        new()
        {
            Species = Species.ClayBird,
            Note = "ClayBird",
            Level = 11, // vanilla 17
            MaxHp = 2963, // vanilla 203
            Str = 92, // vanilla 55
            Vit = 50, // vanilla 45
            Wit = 70, // vanilla 45
            Agi = 45, // vanilla 23
            Exp = 523, // vanilla 75
            Gold = 318, // vanilla 120
            FireResist = 8, // vanilla 10
            WaterResist = 8, // vanilla 10
            WindResist = 6, // vanilla 10
            EarthResist = 9, // vanilla 11
            DropRate0 = 15, // vanilla 0
            DropRate1 = 5, // vanilla 0
            DropItem0 = Item.GoldenPotion, // vanilla 0
            DropItem1 = Item.Pearl, // vanilla 0
        },
        new()
        {
            Species = Species.RockBird,
            Note = "RockBird",
            Level = 1, // vanilla 6
            MaxHp = 637, // vanilla 230
            Str = 38, // vanilla 21
            Vit = 7, // vanilla 10
            Wit = 40, // vanilla 13
            Gold = 200, // vanilla 150
            FireResist = 9, // vanilla 10
            DropRate0 = 20, // vanilla 0
            DropItem0 = Item.CeramicSword, // vanilla 0
        },
        new()
        {
            Species = Species.EmeraldBird,
            Note = "EmeraldBird",
            Level = 11, // vanilla 18
            MaxHp = 1655, // vanilla 268
            Str = 66, // vanilla 60
            Vit = 50, // vanilla 45
            Wit = 40, // vanilla 50
            Agi = 50, // vanilla 26
            Exp = 200, // vanilla 100
            Gold = 150, // vanilla 200
            FireResist = 8, // vanilla 10
            WaterResist = 8, // vanilla 10
            WindResist = 8, // vanilla 10
            EarthResist = 8, // vanilla 11
            DropRate0 = 15, // vanilla 0
            DropRate1 = 3, // vanilla 0
            DropItem0 = Item.BlueMedicine, // vanilla 0
            DropItem1 = Item.Pearl, // vanilla 0
        },
        new()
        {
            Species = Species.PlopMold,
            Note = "PlopMold",
            Level = 14, // vanilla 18
            MaxHp = 553, // vanilla 129
            Str = 85, // vanilla 62
            Vit = 50, // vanilla 30
            Wit = 105, // vanilla 25
            Agi = 50, // vanilla 25
            Exp = 67, // vanilla 15
            Gold = 68, // vanilla 24
            FireResist = 8, // vanilla 4
            WaterResist = 10, // vanilla 6
            WindResist = 10, // vanilla 5
            EarthResist = 8, // vanilla 11
            DropRate1 = 2, // vanilla 10
            DropItem1 = Item.DreamTruffle, // vanilla 439
        },
        new()
        {
            Species = Species.MoldBird,
            Note = "MoldBird",
            MaxHp = 693, // vanilla 140
            Str = 96, // vanilla 68
            Vit = 40, // vanilla 35
            Wit = 90, // vanilla 45
            Agi = 40, // vanilla 25
            Exp = 75, // vanilla 35
            Gold = 81, // vanilla 19
            FireResist = 8, // vanilla 5
            WaterResist = 9, // vanilla 10
            WindResist = 9, // vanilla 7
            EarthResist = 8, // vanilla 11
            DropRate0 = 15, // vanilla 5
            DropItem0 = Item.Panacea, // vanilla 368
        },
        new()
        {
            Species = Species.MarnaBug,
            Note = "MarnaBug",
            Level = 1, // vanilla 3
            MaxHp = 20, // vanilla 18
            Str = 16, // vanilla 18
            Vit = 3, // vanilla 5
            Wit = 16, // vanilla 13
            Agi = 36, // vanilla 30
            WindResist = 7, // vanilla 9
            EarthResist = 7, // vanilla 11
            DropRate0 = 15, // vanilla 0
            DropRate1 = 2, // vanilla 0
            DropItem0 = Item.Herbs, // vanilla 0
            DropItem1 = Item.BoxOfSweets, // vanilla 0
        },
        new()
        {
            Species = Species.Beetlebug,
            Note = "Beetlebug",
            Level = 9, // vanilla 13
            MaxHp = 496, // vanilla 108
            Str = 58, // vanilla 55
            Vit = 30, // vanilla 32
            Wit = 117, // vanilla 100
            Agi = 60, // vanilla 80
            Exp = 39, // vanilla 9
            Gold = 39, // vanilla 50
            AttackCount = 2, // vanilla 1
            FireResist = 9, // vanilla 7
            WaterResist = 9, // vanilla 7
            WindResist = 9, // vanilla 5
            EarthResist = 7, // vanilla 9
            DropRate0 = 15, // vanilla 0
            DropRate1 = 2, // vanilla 0
            DropItem0 = Item.YellowMedicine, // vanilla 0
            DropItem1 = Item.Biscuits, // vanilla 0
        },
        new()
        {
            Species = Species.MetalBeetle,
            Note = "MetalBeetle",
            Level = 10, // vanilla 13
            MaxHp = 165, // vanilla 60
            Str = 66, // vanilla 50
            Vit = 30, // vanilla 45
            Wit = 50, // vanilla 20
            Agi = 20, // vanilla 60
            Exp = 26, // vanilla 25
            Gold = 41, // vanilla 50
            AttackCount = 1, // vanilla 2
            EarthResist = 10, // vanilla 14
            DropRate0 = 15, // vanilla 0
            DropRate1 = 2, // vanilla 0
            DropItem0 = Item.WhiteSulfaWeed, // vanilla 0
            DropItem1 = Item.BoiledEgg, // vanilla 0
        },
        new()
        {
            Species = Species.Spyder,
            Note = "Spyder",
            Level = 2, // vanilla 4
            MaxHp = 67, // vanilla 36
            Str = 24, // vanilla 21
            Vit = 6, // vanilla 8
            Wit = 18, // vanilla 16
            Agi = 34, // vanilla 45
            Exp = 4, // vanilla 3
            AttackCount = 1, // vanilla 2
            DropRate0 = 18, // vanilla 0
            DropRate1 = 2, // vanilla 0
            DropItem0 = Item.Herbs, // vanilla 0
            DropItem1 = Item.BoxLunch, // vanilla 0
        },
        new()
        {
            Species = Species.BlackWidow,
            Note = "BlackWidow",
            Level = 6, // vanilla 8
            MaxHp = 139, // vanilla 53
            Str = 34, // vanilla 30
            Vit = 17, // vanilla 13
            Wit = 23, // vanilla 29
            Agi = 28, // vanilla 30
            Exp = 5, // vanilla 6
            Gold = 10, // vanilla 13
            DropRate0 = 12, // vanilla 0
            DropRate1 = 2, // vanilla 0
            DropItem0 = Item.Ginseng, // vanilla 0
            DropItem1 = Item.ThornyWhip, // vanilla 0
        },
        new()
        {
            Species = Species.Tarantula,
            Note = "Tarantula",
            Level = 10, // vanilla 11
            MaxHp = 396, // vanilla 98
            Str = 56, // vanilla 55
            Vit = 25, // vanilla 21
            Wit = 55, // vanilla 50
            Agi = 20, // vanilla 25
            AttackCount = 2, // vanilla 1
            FireResist = 8, // vanilla 7
            WaterResist = 8, // vanilla 7
            WindResist = 8, // vanilla 7
            EarthResist = 8, // vanilla 7
            DropRate1 = 2, // vanilla 0
            DropItem0 = Item.YellowMedicine, // vanilla 372
            DropItem1 = Item.BoiledEgg, // vanilla 0
        },
        new()
        {
            Species = Species.Ammonite,
            Note = "Ammonite",
            Level = 4, // vanilla 3
            MaxHp = 104, // vanilla 56
            Str = 38, // vanilla 27
            Vit = 17, // vanilla 24
            Wit = 58, // vanilla 22
            Exp = 9, // vanilla 5
            FireResist = 12, // vanilla 7
            EarthResist = 10, // vanilla 7
            DropRate1 = 3, // vanilla 0
            DropItem1 = Item.ShellShield, // vanilla 0
        },
        new()
        {
            Species = Species.MadSnail,
            Note = "MadSnail",
            Level = 6, // vanilla 7
            MaxHp = 119, // vanilla 60
            Str = 41, // vanilla 35
            Vit = 24, // vanilla 26
            Wit = 48, // vanilla 28
            Agi = 22, // vanilla 8
            Exp = 9, // vanilla 8
            Gold = 20, // vanilla 40
            FireResist = 10, // vanilla 2
            WaterResist = 10, // vanilla 7
            WindResist = 10, // vanilla 2
            EarthResist = 10, // vanilla 7
            DropRate0 = 14, // vanilla 0
            DropRate1 = 3, // vanilla 0
            DropItem0 = Item.SmarnaWeed, // vanilla 0
            DropItem1 = Item.ShellShield, // vanilla 0
        },
        new()
        {
            Species = Species.SeaJelly,
            Note = "SeaJelly",
            Level = 4, // vanilla 5
            MaxHp = 174, // vanilla 68
            Str = 37, // vanilla 29
            Vit = 12, // vanilla 8
            Wit = 48, // vanilla 28
            Exp = 6, // vanilla 5
            FireResist = 6, // vanilla 4
            WaterResist = 12, // vanilla 9
            DropRate0 = 9, // vanilla 0
            DropRate1 = 3, // vanilla 0
            DropItem0 = Item.MikeromaScroll, // vanilla 0
            DropItem1 = Item.LightningCharm, // vanilla 0
        },
        new()
        {
            Species = Species.MudJelly,
            Note = "MudJelly",
            Level = 6, // vanilla 9
            MaxHp = 153, // vanilla 73
            Str = 38, // vanilla 35
            Vit = 21, // vanilla 16
            Wit = 30, // vanilla 15
            Agi = 32, // vanilla 12
            Exp = 7, // vanilla 10
            Gold = 12, // vanilla 17
            FireResist = 8, // vanilla 0
            WaterResist = 6, // vanilla 9
            WindResist = 7, // vanilla 2
            EarthResist = 6, // vanilla 7
            DropRate0 = 8, // vanilla 0
            DropRate1 = 2, // vanilla 0
            DropItem0 = Item.FirstAidKit, // vanilla 0
            DropItem1 = Item.LightningCharm, // vanilla 0
        },
        new()
        {
            Species = Species.HermitCrab,
            Note = "HermitCrab",
            MaxHp = 545, // vanilla 94
            Str = 128, // vanilla 81
            Vit = 124, // vanilla 100
            Wit = 90, // vanilla 30
            Agi = 33, // vanilla 24
            Exp = 150, // vanilla 56
            Gold = 90, // vanilla 120
            DropRate0 = 18, // vanilla 0
            DropRate1 = 12, // vanilla 0
            DropItem0 = Item.SmarnaWeed, // vanilla 0
            DropItem1 = Item.YellowMedicine, // vanilla 0
        },
        new()
        {
            Species = Species.BlueKite,
            Note = "BlueKite",
            MaxHp = 792, // vanilla 135
            Str = 90, // vanilla 69
            Vit = 50, // vanilla 100
            Wit = 140, // vanilla 100
            Agi = 40, // vanilla 50
            Exp = 90, // vanilla 35
            Gold = 83, // vanilla 27
            AttackCount = 2, // vanilla 1
            AttackRange = 3, // vanilla 2
            FireResist = 8, // vanilla 2
            WaterResist = 8, // vanilla 2
            WindResist = 8, // vanilla 2
            EarthResist = 9, // vanilla 2
            DropRate0 = 10, // vanilla 0
            DropItem0 = Item.BlueMedicine, // vanilla 0
        },
        new()
        {
            Species = Species.MantaRay,
            Note = "MantaRay",
            MaxHp = 763, // vanilla 276
            Str = 100, // vanilla 70
            Vit = 80, // vanilla 20
            Wit = 150, // vanilla 95
            Agi = 50, // vanilla 35
            Exp = 137, // vanilla 60
            Gold = 125, // vanilla 29
            AttackCount = 2, // vanilla 1
            FireResist = 6, // vanilla 12
            WaterResist = 6, // vanilla 0
            WindResist = 6, // vanilla 0
            EarthResist = 6, // vanilla 12
        },
        new()
        {
            Species = Species.SandDiver,
            Note = "SandDiver",
            Level = 8, // vanilla 10
            MaxHp = 351, // vanilla 78
            Str = 37, // vanilla 47
            Vit = 36, // vanilla 27
            Wit = 60, // vanilla 33
            Agi = 45, // vanilla 38
            Exp = 20, // vanilla 11
            Gold = 40, // vanilla 100
            AttackCount = 4, // vanilla 1
            FireResist = 9, // vanilla 7
            WaterResist = 8, // vanilla 7
            WindResist = 10, // vanilla 12
            EarthResist = 7, // vanilla 2
            DropRate0 = 10, // vanilla 0
            DropRate1 = 2, // vanilla 0
            DropItem0 = Item.FirstAidKit, // vanilla 0
            DropItem1 = Item.EarthCharm, // vanilla 0
        },
        new()
        {
            Species = Species.GiantCentipede,
            Note = "GiantCentipede",
            Level = 1, // vanilla 4
            MaxHp = 42, // vanilla 32
            Str = 17, // vanilla 19
            Vit = 1, // vanilla 5
            Wit = 8, // vanilla 9
            Agi = 20, // vanilla 22
            DropRate0 = 16, // vanilla 0
            DropRate1 = 3, // vanilla 0
            DropItem0 = Item.Herbs, // vanilla 0
            DropItem1 = Item.BoxOfSweets, // vanilla 0
        },
        new()
        {
            Species = Species.Inchworm,
            Note = "Inchworm",
            MaxHp = 208, // vanilla 65
            Str = 45, // vanilla 41
            Vit = 22, // vanilla 20
            Wit = 40, // vanilla 25
            Agi = 30, // vanilla 10
            Gold = 12, // vanilla 20
            FireResist = 8, // vanilla 6
            WaterResist = 9, // vanilla 6
            WindResist = 9, // vanilla 6
            EarthResist = 8, // vanilla 6
            DropRate0 = 2, // vanilla 3
            DropRate1 = 14, // vanilla 0
            DropItem0 = Item.BeefJerky, // vanilla 349
            DropItem1 = Item.Panacea, // vanilla 0
        },
        new()
        {
            Species = Species.Roadcrawler,
            Note = "Roadcrawler",
            Level = 5, // vanilla 6
            MaxHp = 95, // vanilla 40
            Str = 35, // vanilla 33
            Vit = 20, // vanilla 25
            Wit = 18, // vanilla 26
            Agi = 20, // vanilla 14
            Exp = 5, // vanilla 7
            Gold = 7, // vanilla 15
            FireResist = 8, // vanilla 7
            WaterResist = 8, // vanilla 7
            WindResist = 8, // vanilla 7
            EarthResist = 9, // vanilla 7
            DropRate0 = 18, // vanilla 15
            DropRate1 = 3, // vanilla 0
            DropItem1 = Item.SnakeEarrings, // vanilla 0
        },
        new()
        {
            Species = Species.SpittingCobra,
            Note = "SpittingCobra",
            Level = 6, // vanilla 8
            MaxHp = 139, // vanilla 60
            Str = 35, // vanilla 31
            Vit = 18, // vanilla 15
            Wit = 24, // vanilla 32
            Exp = 5, // vanilla 6
            Gold = 9, // vanilla 14
            DropRate0 = 15, // vanilla 10
            DropRate1 = 3, // vanilla 0
            DropItem1 = Item.SnakeEarrings, // vanilla 0
        },
        new()
        {
            Species = Species.PitViper,
            Note = "PitViper",
            Level = 10, // vanilla 12
            MaxHp = 427, // vanilla 124
            Str = 63, // vanilla 59
            Vit = 25, // vanilla 8
            Wit = 60, // vanilla 47
            Exp = 29, // vanilla 21
            FireResist = 8, // vanilla 7
            WaterResist = 8, // vanilla 7
            WindResist = 8, // vanilla 7
            EarthResist = 8, // vanilla 7
            DropRate0 = 15, // vanilla 10
            DropRate1 = 2, // vanilla 0
            DropItem0 = Item.Panacea, // vanilla 373
            DropItem1 = Item.BoiledEgg, // vanilla 0
        },
        new()
        {
            Species = Species.HornedToad,
            Note = "HornedToad",
            MaxHp = 480, // vanilla 112
            Str = 94, // vanilla 70
            Wit = 90, // vanilla 65
            Agi = 40, // vanilla 26
            Exp = 48, // vanilla 40
            FireResist = 5, // vanilla 0
            WindResist = 5, // vanilla 7
            EarthResist = 6, // vanilla 9
            DropRate0 = 15, // vanilla 0
            DropRate1 = 8, // vanilla 0
            DropItem0 = Item.YellowMedicine, // vanilla 0
            DropItem1 = Item.Raincoat, // vanilla 0
        },
        new()
        {
            Species = Species.MadFrog,
            Note = "MadFrog",
            MaxHp = 593, // vanilla 163
            Str = 110, // vanilla 85
            Vit = 30, // vanilla 52
            Wit = 180, // vanilla 70
            Agi = 70, // vanilla 60
            Exp = 142, // vanilla 62
            Gold = 108, // vanilla 31
            FireResist = 6, // vanilla 0
            WaterResist = 9, // vanilla 7
            WindResist = 9, // vanilla 7
            EarthResist = 10, // vanilla 9
            DropRate0 = 12, // vanilla 0
            DropItem0 = Item.ChollaFlowers, // vanilla 0
        },
        new()
        {
            Species = Species.ToadKing,
            Note = "ToadKing",
            MaxHp = 660, // vanilla 236
            Str = 113, // vanilla 87
            Vit = 30, // vanilla 68
            Wit = 160, // vanilla 50
            Exp = 97, // vanilla 53
            FireResist = 6, // vanilla 5
            WaterResist = 11, // vanilla 7
            WindResist = 8, // vanilla 7
            EarthResist = 6, // vanilla 5
        },
        new()
        {
            Species = Species.Hippocamp,
            Note = "Hippocamp",
            MaxHp = 511, // vanilla 141
            Str = 116, // vanilla 84
            Vit = 100, // vanilla 67
            Wit = 190, // vanilla 85
            Agi = 40, // vanilla 25
            Exp = 127, // vanilla 59
            FireResist = 6, // vanilla 5
            WaterResist = 12, // vanilla 10
            WindResist = 12, // vanilla 10
            EarthResist = 6, // vanilla 5
        },
        new()
        {
            Species = Species.GreenSlime,
            Note = "GreenSlime",
            Level = 1, // vanilla 4
            MaxHp = 60, // vanilla 45
            Str = 24, // vanilla 20
            Vit = 3, // vanilla 2
            Agi = 3, // vanilla 16
            Exp = 3, // vanilla 2
            Gold = 5, // vanilla 4
            FireResist = 5, // vanilla 0
            WaterResist = 7, // vanilla 9
            WindResist = 7, // vanilla 4
            EarthResist = 7, // vanilla 4
            DropRate0 = 18, // vanilla 15
            DropRate1 = 3, // vanilla 0
            DropItem1 = Item.PoisonedApple, // vanilla 0
        },
    ];
}
