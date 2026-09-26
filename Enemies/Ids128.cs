using Grandia.Sdk;

namespace GrandiaReduxComplete.Enemies;

internal static class Ids128
{
    internal static readonly EnemyEdit[] All =
    [
        new()
        {
            Species = Species.GrimHaze,
            Note = "GrimHaze",
            Level = 9, // vanilla 18
            MaxHp = 227, // vanilla 50
            Str = 58, // vanilla 60
            Vit = 35, // vanilla 1
            Wit = 80, // vanilla 90
            Agi = 30, // vanilla 25
            FireResist = 9, // vanilla 4
            WaterResist = 8, // vanilla 9
            WindResist = 13, // vanilla 4
            EarthResist = 7, // vanilla 11
            DropRate0 = 9, // vanilla 0
            DropRate1 = 1, // vanilla 0
            DropItem0 = Item.YellowMedicine, // vanilla 0
            DropItem1 = Item.SpellBreaker, // vanilla 0
        },
        new()
        {
            Species = Species.GasCloud,
            Note = "GasCloud",
            Level = 10, // vanilla 14
            MaxHp = 355, // vanilla 125
            Str = 70, // vanilla 55
            Vit = 40, // vanilla 0
            Wit = 50, // vanilla 10
            Agi = 30, // vanilla 25
            Exp = 36, // vanilla 31
            Gold = 25, // vanilla 18
            FireResist = 13, // vanilla 4
            WaterResist = 7, // vanilla 9
            WindResist = 8, // vanilla 4
            EarthResist = 8, // vanilla 11
            DropRate0 = 6, // vanilla 0
            DropRate1 = 2, // vanilla 0
            DropItem0 = Item.BlueMedicine, // vanilla 0
            DropItem1 = Item.ParalysisOintment, // vanilla 0
        },
        new()
        {
            Species = Species.MistWraith,
            Note = "MistWraith",
            Level = 11, // vanilla 20
            MaxHp = 381, // vanilla 115
            Str = 70, // vanilla 57
            Wit = 90, // vanilla 55
            Agi = 50, // vanilla 25
            Exp = 41, // vanilla 30
            FireResist = 8, // vanilla 4
            WaterResist = 13, // vanilla 9
            WindResist = 9, // vanilla 5
            EarthResist = 8, // vanilla 11
            DropRate0 = 12, // vanilla 0
            DropRate1 = 2, // vanilla 0
            DropItem0 = Item.Panacea, // vanilla 0
            DropItem1 = Item.EyeDrops, // vanilla 0
        },
        new()
        {
            Species = Species.OddBird,
            Note = "OddBird",
            Level = 6, // vanilla 10
            MaxHp = 513, // vanilla 127
            Str = 55, // vanilla 43
            Vit = 24, // vanilla 18
            Wit = 70, // vanilla 90
            Agi = 35, // vanilla 60
            Exp = 21, // vanilla 11
            Gold = 32, // vanilla 24
            AttackCount = 1, // vanilla 2
            FireResist = 10, // vanilla 5
            WaterResist = 8, // vanilla 5
            WindResist = 7, // vanilla 5
            EarthResist = 8, // vanilla 11
            DropRate0 = 15, // vanilla 5
            DropRate1 = 2, // vanilla 0
            DropItem0 = Item.Panacea, // vanilla 376
            DropItem1 = Item.ChainOfGems, // vanilla 0
        },
        new()
        {
            Species = Species.Birdrake,
            Note = "Birdrake",
            Level = 10, // vanilla 11
            MaxHp = 2361, // vanilla 80
            Str = 83, // vanilla 60
            Vit = 40, // vanilla 25
            Wit = 150, // vanilla 50
            Agi = 70, // vanilla 60
            Exp = 290, // vanilla 19
            Gold = 390, // vanilla 20
            AttackRange = 3, // vanilla 2
            FireResist = 11, // vanilla 7
            WaterResist = 8, // vanilla 5
            WindResist = 8, // vanilla 5
            EarthResist = 8, // vanilla 11
            DropRate0 = 30, // vanilla 0
            DropRate1 = 15, // vanilla 0
            DropItem0 = Item.GoldenPotion, // vanilla 0
            DropItem1 = Item.Spectacles, // vanilla 0
        },
        new()
        {
            Species = Species.Dodo,
            Note = "Dodo",
            Level = 10, // vanilla 14
            MaxHp = 2585, // vanilla 96
            Str = 86, // vanilla 52
            Vit = 30, // vanilla 15
            Wit = 150, // vanilla 65
            Agi = 50, // vanilla 40
            Exp = 393, // vanilla 25
            Gold = 247, // vanilla 27
            AttackRange = 4, // vanilla 2
            FireResist = 9, // vanilla 1
            WaterResist = 9, // vanilla 7
            WindResist = 9, // vanilla 10
            EarthResist = 9, // vanilla 11
            DropRate0 = 20, // vanilla 5
            DropRate1 = 8, // vanilla 0
            DropItem0 = Item.UltraDrink, // vanilla 370
            DropItem1 = Item.Bandage, // vanilla 0
        },
        new()
        {
            Species = Species.Slipple,
            Note = "Slipple",
            Level = 14, // vanilla 18
            MaxHp = 467, // vanilla 67
            Str = 75, // vanilla 52
            Vit = 40, // vanilla 35
            Wit = 120, // vanilla 58
            Agi = 60, // vanilla 80
            Exp = 62, // vanilla 25
            Gold = 64, // vanilla 18
            FireResist = 12, // vanilla 9
            WaterResist = 12, // vanilla 9
            WindResist = 12, // vanilla 9
            EarthResist = 8, // vanilla 10
            DropItem0 = Item.ChollaFlowers, // vanilla 439
        },
        new()
        {
            Species = Species.Gripple,
            Note = "Gripple",
            MaxHp = 642, // vanilla 155
            Str = 104, // vanilla 66
            Vit = 30, // vanilla 58
            Wit = 140, // vanilla 67
            Agi = 40, // vanilla 23
            Exp = 89, // vanilla 25
            Gold = 85, // vanilla 18
            AttackRange = 5, // vanilla 4
            FireResist = 14, // vanilla 5
            WaterResist = 14, // vanilla 5
            WindResist = 14, // vanilla 5
            EarthResist = 7, // vanilla 5
            DropRate0 = 15, // vanilla 2
            DropItem0 = Item.SquidGuts, // vanilla 359
        },
        new()
        {
            Species = Species.Ent,
            Note = "Ent",
            Level = 7, // vanilla 4
            MaxHp = 227, // vanilla 55
            Str = 49, // vanilla 45
            Vit = 28, // vanilla 60
            Wit = 55, // vanilla 30
            Agi = 24, // vanilla 11
            Gold = 22, // vanilla 40
            FireResist = 7, // vanilla 4
            WaterResist = 9, // vanilla 6
            WindResist = 8, // vanilla 5
            EarthResist = 8, // vanilla 7
            DropRate0 = 12, // vanilla 20
            DropRate1 = 1, // vanilla 0
            DropItem0 = Item.RestraintWalnut, // vanilla 349
            DropItem1 = Item.TreeGodAmulet, // vanilla 0
        },
        new()
        {
            Species = Species.MistGuard,
            Note = "MistGuard",
            Level = 10, // vanilla 12
            MaxHp = 386, // vanilla 95
            Str = 68, // vanilla 54
            Vit = 40, // vanilla 60
            Wit = 60, // vanilla 35
            Agi = 25, // vanilla 15
            Exp = 31, // vanilla 17
            AttackCount = 1, // vanilla 2
            FireResist = 8, // vanilla 1
            WaterResist = 9, // vanilla 11
            WindResist = 10, // vanilla 7
            EarthResist = 9, // vanilla 10
            DropRate0 = 10, // vanilla 5
            DropRate1 = 2, // vanilla 0
            DropItem0 = Item.BamoFruit, // vanilla 375
            DropItem1 = Item.TreeGodAmulet, // vanilla 0
        },
        new()
        {
            Species = Species.KillerTree,
            Note = "KillerTree",
            Level = 10, // vanilla 15
            MaxHp = 448, // vanilla 80
            Str = 74, // vanilla 57
            Vit = 35, // vanilla 60
            Wit = 70, // vanilla 20
            Agi = 50, // vanilla 17
            Exp = 41, // vanilla 35
            FireResist = 7, // vanilla 1
            WaterResist = 9, // vanilla 11
            WindResist = 9, // vanilla 4
            EarthResist = 9, // vanilla 5
            DropRate0 = 14, // vanilla 0
            DropRate1 = 2, // vanilla 0
            DropItem0 = Item.BaobabFruit, // vanilla 0
            DropItem1 = Item.TreeGodAmulet, // vanilla 0
        },
        new()
        {
            Species = Species.Private,
            Note = "Private",
            Level = 8, // vanilla 11
            MaxHp = 1000, // vanilla 110
            Str = 58, // vanilla 50
            Vit = 20, // vanilla 26
            Wit = 37, // vanilla 42
            Agi = 30, // vanilla 16
            Exp = 40, // vanilla 15
            Gold = 33, // vanilla 100
            FireResist = 8, // vanilla 7
            DropRate0 = 14, // vanilla 0
            DropRate1 = 3, // vanilla 0
            DropItem0 = Item.FirstAidKit, // vanilla 0
            DropItem1 = Item.FrostHerb, // vanilla 0
        },
        new()
        {
            Species = Species.Sergeant,
            Note = "Sergeant",
            Level = 10, // vanilla 12
            MaxHp = 1200, // vanilla 220
            Str = 63, // vanilla 50
            Vit = 22, // vanilla 26
            Wit = 55, // vanilla 46
            Agi = 30, // vanilla 18
            Exp = 100, // vanilla 19
            Gold = 70, // vanilla 45
            WaterResist = 9, // vanilla 7
            WindResist = 8, // vanilla 7
            DropRate0 = 20, // vanilla 0
            DropRate1 = 4, // vanilla 0
            DropItem0 = Item.FirstAidKit, // vanilla 0
            DropItem1 = Item.ResurrectPotion, // vanilla 0
        },
        new()
        {
            Species = Species.KleppSoldier,
            Note = "KleppSoldier",
            Level = 14, // vanilla 18
            MaxHp = 825, // vanilla 160
            Str = 96, // vanilla 62
            Vit = 30, // vanilla 35
            Wit = 66, // vanilla 30
            Agi = 40, // vanilla 30
            Exp = 96, // vanilla 35
            Gold = 82, // vanilla 40
            FireResist = 8, // vanilla 5
            WaterResist = 8, // vanilla 13
            WindResist = 8, // vanilla 7
            EarthResist = 8, // vanilla 7
            DropRate0 = 12, // vanilla 5
            DropRate1 = 1, // vanilla 0
            DropItem0 = Item.HealthWeed, // vanilla 368
            DropItem1 = Item.HolyFire, // vanilla 0
        },
        new()
        {
            Species = Species.EliteKlepp,
            Note = "EliteKlepp",
            MaxHp = 853, // vanilla 170
            Str = 97, // vanilla 65
            Wit = 65, // vanilla 70
            Agi = 30, // vanilla 40
            Exp = 99, // vanilla 40
            AttackCount = 1, // vanilla 2
            AttackRange = 3, // vanilla 4
            FireResist = 8, // vanilla 5
            WaterResist = 8, // vanilla 13
            WindResist = 8, // vanilla 7
            EarthResist = 8, // vanilla 10
            DropRate0 = 10, // vanilla 2
            DropItem0 = Item.BlueMedicine, // vanilla 128
        },
        new()
        {
            Species = Species.KleppKnight,
            Note = "KleppKnight",
            Level = 16, // vanilla 20
            MaxHp = 982, // vanilla 180
            Str = 102, // vanilla 70
            Wit = 100, // vanilla 58
            Exp = 122, // vanilla 45
            Gold = 91, // vanilla 90
            FireResist = 8, // vanilla 5
            WaterResist = 8, // vanilla 13
            WindResist = 8, // vanilla 7
            EarthResist = 9, // vanilla 10
            DropRate0 = 12, // vanilla 5
            DropRate1 = 2, // vanilla 0
            DropItem0 = Item.MikeromaScroll, // vanilla 284
            DropItem1 = Item.PearlHelmet, // vanilla 0
        },
        new()
        {
            Species = Species.LizardRider,
            Note = "LizardRider",
            Level = 14, // vanilla 18
            MaxHp = 2229, // vanilla 220
            Str = 82, // vanilla 68
            Vit = 40, // vanilla 50
            Wit = 10000, // vanilla 50
            Agi = 20, // vanilla 50
            Exp = 325, // vanilla 50
            Gold = 209, // vanilla 60
            FireResist = 8, // vanilla 5
            WaterResist = 8, // vanilla 13
            WindResist = 8, // vanilla 7
            EarthResist = 9, // vanilla 10
            DropRate0 = 12, // vanilla 0
            DropItem0 = Item.GoldenPotion, // vanilla 0
        },
        new()
        {
            Species = Species.MadRider,
            Note = "MadRider",
            Level = 16, // vanilla 18
            MaxHp = 1928, // vanilla 230
            Str = 83, // vanilla 70
            Vit = 40, // vanilla 55
            Wit = 10000, // vanilla 100
            Agi = 80, // vanilla 60
            Exp = 308, // vanilla 60
            Gold = 256, // vanilla 65
            AttackCount = 1, // vanilla 2
            AttackRange = 3, // vanilla 5
            FireResist = 7, // vanilla 5
            WaterResist = 7, // vanilla 13
            EarthResist = 7, // vanilla 10
            DropRate0 = 12, // vanilla 0
            DropRate1 = 2, // vanilla 0
            DropItem0 = Item.ResurrectPotion441, // vanilla 0
            DropItem1 = Item.HolyFire, // vanilla 0
        },
        new()
        {
            Species = Species.KleppRider,
            Note = "KleppRider",
            Level = 16, // vanilla 19
            MaxHp = 2477, // vanilla 216
            Str = 91, // vanilla 70
            Vit = 50, // vanilla 60
            Wit = 10000, // vanilla 50
            Agi = 8, // vanilla 40
            Exp = 357, // vanilla 70
            Gold = 225, // vanilla 70
            AttackCount = 1, // vanilla 2
            AttackRange = 3, // vanilla 5
            FireResist = 9, // vanilla 5
            WaterResist = 9, // vanilla 13
            WindResist = 9, // vanilla 7
            EarthResist = 9, // vanilla 10
            DropRate0 = 15, // vanilla 10
            DropItem0 = Item.Panacea, // vanilla 314
        },
        new()
        {
            Species = Species.SquidKing,
            Note = "SquidKing",
            Level = 5, // vanilla 10
            MaxHp = 1397, // vanilla 592
            Vit = 14, // vanilla 15
            Wit = 30, // vanilla 26
            Exp = 217, // vanilla 74
            FireResist = 9, // vanilla 5
            WaterResist = 9, // vanilla 7
            WindResist = 7, // vanilla 6
        },
        new()
        {
            Species = Species.RightTentacle151,
            Note = "RightTentacle151",
            Level = 5, // vanilla 9
            MaxHp = 977, // vanilla 356
            Str = 34, // vanilla 36
            Vit = 8, // vanilla 12
            Wit = 15, // vanilla 12
            Exp = 0, // vanilla 40
            FireResist = 9, // vanilla 4
            WaterResist = 9, // vanilla 7
            WindResist = 7, // vanilla 5
        },
        new()
        {
            Species = Species.LeftTentacle152,
            Note = "LeftTentacle152",
            Level = 5, // vanilla 9
            MaxHp = 1064, // vanilla 438
            Str = 59, // vanilla 42
            Vit = 9, // vanilla 10
            Wit = 30, // vanilla 24
            Exp = 0, // vanilla 40
            FireResist = 7, // vanilla 5
            WindResist = 7, // vanilla 5
            DropRate0 = 6, // vanilla 0
            DropItem0 = Item.ManaEgg, // vanilla 0
        },
        new()
        {
            Species = Species.RightTentacle154,
            Note = "RightTentacle154",
            DropRate0 = 6, // vanilla 0
            DropItem0 = Item.ManaEgg, // vanilla 0
        },
        new()
        {
            Species = Species.Ganymede156,
            Note = "Ganymede156",
            Level = 8, // vanilla 15
            MaxHp = 3248, // vanilla 1500
            Str = 106, // vanilla 42
            Vit = 20, // vanilla 34
            Wit = 10, // vanilla 15
            Exp = 372, // vanilla 500
            Gold = 1000, // vanilla 0
            FireResist = 10, // vanilla 8
            WaterResist = 11, // vanilla 5
            WindResist = 5, // vanilla 7
            EarthResist = 8, // vanilla 7
            DropRate0 = 0, // vanilla 100
            DropItem0 = Item.None, // vanilla 185
        },
        new()
        {
            Species = Species.Ganymede157,
            Note = "Ganymede157",
            Level = 8, // vanilla 15
            MaxHp = 3248, // vanilla 1500
            Str = 62, // vanilla 47
            Vit = 20, // vanilla 30
            Wit = 70, // vanilla 15
            Gold = 1539, // vanilla 2000
            AttackRange = 7, // vanilla 5
            FireResist = 10, // vanilla 7
            WaterResist = 11, // vanilla 3
            WindResist = 7, // vanilla 6
            EarthResist = 9, // vanilla 7
            DropRate0 = 25, // vanilla 0
            DropItem0 = Item.OrbOfSilence, // vanilla 0
        },
        new()
        {
            Species = Species.Madragon164,
            Note = "Madragon164",
            MaxHp = 5001, // vanilla 2150
            Str = 150, // vanilla 100
            Vit = 85, // vanilla 65
            Wit = 170, // vanilla 40
            Exp = 2450, // vanilla 1450
            WaterResist = 5, // vanilla 3
            WindResist = 5, // vanilla 7
            EarthResist = 13, // vanilla 7
        },
        new()
        {
            Species = Species.Madragon165,
            Note = "Madragon165",
            MaxHp = 5001, // vanilla 2150
            Str = 120, // vanilla 80
            Vit = 80, // vanilla 58
            Wit = 215, // vanilla 65
            Exp = 3350, // vanilla 1450
            WaterResist = 5, // vanilla 6
            WindResist = 5, // vanilla 7
            EarthResist = 13, // vanilla 9
        },
        new()
        {
            Species = Species.MassacreMachine170,
            Note = "MassacreMachine170",
            MaxHp = 2500, // vanilla 1800
            Str = 150, // vanilla 100
            Vit = 82, // vanilla 65
            Wit = 180, // vanilla 75
            Agi = 60, // vanilla 24
        },
        new()
        {
            Species = Species.Eye171,
            Note = "Eye171",
            MaxHp = 2500, // vanilla 1800
            Str = 107, // vanilla 82
            Vit = 82, // vanilla 45
            Wit = 122, // vanilla 45
            Agi = 50, // vanilla 24
        },
        new()
        {
            Species = Species.MassacreMachine172,
            Note = "MassacreMachine172",
            MaxHp = 3000, // vanilla 2000
            Str = 170, // vanilla 100
            Vit = 170, // vanilla 65
            Wit = 182, // vanilla 75
            Agi = 60, // vanilla 24
            FireResist = 5, // vanilla 10
            WaterResist = 5, // vanilla 10
            WindResist = 5, // vanilla 10
            EarthResist = 5, // vanilla 10
        },
        new()
        {
            Species = Species.Eye173,
            Note = "Eye173",
            MaxHp = 3000, // vanilla 2000
            Vit = 170, // vanilla 65
            Wit = 170, // vanilla 45
            Agi = 120, // vanilla 24
            FireResist = 5, // vanilla 10
            WaterResist = 5, // vanilla 10
            WindResist = 5, // vanilla 10
            EarthResist = 5, // vanilla 10
        },
        new()
        {
            Species = Species.Serpent,
            Note = "Serpent",
            Level = 18, // vanilla 20
            MaxHp = 6000, // vanilla 1071
            Str = 110, // vanilla 75
            Vit = 60, // vanilla 30
            Wit = 50, // vanilla 20
            Exp = 4463, // vanilla 1250
            Gold = 2556, // vanilla 2400
            FireResist = 9, // vanilla 10
            WaterResist = 9, // vanilla 10
            WindResist = 9, // vanilla 10
        },
        new()
        {
            Species = Species.MeanHead,
            Note = "MeanHead",
            Level = 16, // vanilla 23
            MaxHp = 4000, // vanilla 486
            Str = 108, // vanilla 70
            Vit = 50, // vanilla 30
            Wit = 90, // vanilla 30
            FireResist = 8, // vanilla 10
            WaterResist = 8, // vanilla 10
            WindResist = 12, // vanilla 10
            EarthResist = 9, // vanilla 10
        },
        new()
        {
            Species = Species.HotHead176,
            Note = "HotHead176",
            Level = 16, // vanilla 23
            MaxHp = 4500, // vanilla 516
            Vit = 50, // vanilla 30
            Wit = 75, // vanilla 100
            FireResist = 12, // vanilla 10
            WaterResist = 5, // vanilla 10
            WindResist = 8, // vanilla 10
            EarthResist = 9, // vanilla 10
        },
        new()
        {
            Species = Species.NiceHead177,
            Note = "NiceHead177",
            Level = 16, // vanilla 23
            MaxHp = 3000, // vanilla 800
            Vit = 50, // vanilla 33
            Wit = 150, // vanilla 50
            FireResist = 5, // vanilla 10
            WaterResist = 12, // vanilla 10
            WindResist = 8, // vanilla 10
            EarthResist = 8, // vanilla 10
        },
        new()
        {
            Species = Species.BadHead,
            Note = "BadHead",
            Level = 16, // vanilla 23
            MaxHp = 3500, // vanilla 600
            Str = 82, // vanilla 80
            Vit = 50, // vanilla 30
            Wit = 45, // vanilla 30
            FireResist = 7, // vanilla 10
            WaterResist = 7, // vanilla 10
            WindResist = 7, // vanilla 10
            EarthResist = 9, // vanilla 10
        },
    ];
}
