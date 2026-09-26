using Grandia.Sdk;

namespace GrandiaReduxComplete.Enemies;

internal static class Ids001
{
    internal static readonly EnemyEdit[] All =
    [
        new()
        {
            Species = Species.RockMan,
            Note = "RockMan",
            Str = 88, // vanilla 72
            Vit = 30, // vanilla 50
            Exp = 61, // vanilla 42
            DropRate1 = 2, // vanilla 5
            DropItem1 = Item.LaunchFireworks, // vanilla 117
        },
        new()
        {
            Species = Species.MagmaMan,
            Note = "MagmaMan",
            Level = 19, // vanilla 22
            MaxHp = 810, // vanilla 211
            Str = 124, // vanilla 80
            Vit = 68, // vanilla 66
            Wit = 105, // vanilla 43
            Agi = 35, // vanilla 16
            Exp = 125, // vanilla 75
            Gold = 104, // vanilla 40
            FireResist = 10, // vanilla 13
            WaterResist = 4, // vanilla 0
            WindResist = 6, // vanilla 3
            EarthResist = 5, // vanilla 9
            DropRate0 = 15, // vanilla 10
            DropRate1 = 5, // vanilla 0
            DropItem0 = Item.SmarnaWeed, // vanilla 113
            DropItem1 = Item.RaincloudStaff, // vanilla 0
        },
        new()
        {
            Species = Species.MedusaDancer,
            Note = "MedusaDancer",
            MaxHp = 499, // vanilla 256
            Str = 103, // vanilla 80
            Vit = 100, // vanilla 72
            Wit = 225, // vanilla 105
            Agi = 100, // vanilla 70
            Exp = 180, // vanilla 75
            AttackCount = 3, // vanilla 1
            FireResist = 11, // vanilla 4
            WaterResist = 9, // vanilla 6
            WindResist = 11, // vanilla 6
            EarthResist = 11, // vanilla 4
            DropRate0 = 20, // vanilla 10
            DropRate1 = 7, // vanilla 0
            DropItem0 = Item.SpellBreaker, // vanilla 309
            DropItem1 = Item.MagicBlockCharm, // vanilla 0
        },
        new()
        {
            Species = Species.RedDevil,
            Note = "RedDevil",
            Level = 14, // vanilla 18
            MaxHp = 666, // vanilla 87
            Str = 88, // vanilla 62
            Vit = 40, // vanilla 45
            Wit = 135, // vanilla 35
            Agi = 40, // vanilla 17
            Exp = 70, // vanilla 20
            Gold = 90, // vanilla 32
            FireResist = 11, // vanilla 9
            WaterResist = 7, // vanilla 8
            EarthResist = 9, // vanilla 8
        },
        new()
        {
            Species = Species.BlueDevil,
            Note = "BlueDevil",
            MaxHp = 746, // vanilla 145
            Str = 111, // vanilla 75
            Vit = 65, // vanilla 50
            Wit = 150, // vanilla 64
            Agi = 30, // vanilla 20
            Exp = 142, // vanilla 70
            Gold = 127, // vanilla 50
            FireResist = 5, // vanilla 8
            WaterResist = 11, // vanilla 8
            DropRate0 = 10, // vanilla 1
            DropRate1 = 4, // vanilla 0
            DropItem0 = Item.GaleScroll, // vanilla 282
            DropItem1 = Item.TitansRing, // vanilla 0
        },
        new()
        {
            Species = Species.Nyalmot,
            Note = "Nyalmot",
            MaxHp = 777, // vanilla 225
            Str = 121, // vanilla 105
            Wit = 155, // vanilla 65
            Agi = 40, // vanilla 23
            Exp = 189, // vanilla 53
            WaterResist = 7, // vanilla 8
            WindResist = 7, // vanilla 8
            EarthResist = 7, // vanilla 8
            DropRate0 = 10, // vanilla 0
            DropItem0 = Item.MikeromaScroll, // vanilla 0
        },
        new()
        {
            Species = Species.Ghostoid,
            Note = "Ghostoid",
            Level = 4, // vanilla 6
            MaxHp = 133, // vanilla 62
            Str = 33, // vanilla 27
            Vit = 12, // vanilla 11
            Wit = 70, // vanilla 45
            Agi = 32, // vanilla 35
            Exp = 8, // vanilla 4
            Gold = 5, // vanilla 1
            FireResist = 8, // vanilla 5
            WaterResist = 8, // vanilla 7
            WindResist = 8, // vanilla 4
            EarthResist = 10, // vanilla 11
            DropRate0 = 15, // vanilla 0
            DropRate1 = 1, // vanilla 0
            DropItem0 = Item.WouldSalve, // vanilla 0
            DropItem1 = Item.PhantomSilk, // vanilla 0
        },
        new()
        {
            Species = Species.VengefulSpirit,
            Note = "VengefulSpirit",
            Level = 8, // vanilla 10
            MaxHp = 60, // vanilla 35
            Str = 43, // vanilla 40
            Vit = 5, // vanilla 100
            Wit = 55, // vanilla 15
            Agi = 16, // vanilla 14
            Exp = 17, // vanilla 18
            Gold = 9, // vanilla 12
            FireResist = 13, // vanilla 4
            WaterResist = 13, // vanilla 7
            WindResist = 13, // vanilla 4
            EarthResist = 13, // vanilla 14
            DropRate0 = 2, // vanilla 10
            DropRate1 = 7, // vanilla 0
            DropItem0 = Item.PhantomSilk, // vanilla 329
            DropItem1 = Item.BlueMedicine, // vanilla 0
        },
        new()
        {
            Species = Species.LostSoul,
            Note = "LostSoul",
            MaxHp = 498, // vanilla 75
            Str = 115, // vanilla 70
            Vit = 110, // vanilla 100
            Wit = 180, // vanilla 68
            Agi = 35, // vanilla 25
            Exp = 135, // vanilla 40
            Gold = 91, // vanilla 20
            AttackRange = 4, // vanilla 3
            WaterResist = 13, // vanilla 4
            WindResist = 13, // vanilla 4
            EarthResist = 13, // vanilla 11
            DropRate0 = 10, // vanilla 5
            DropRate1 = 22, // vanilla 0
            DropItem0 = Item.ResurrectPotion, // vanilla 284
            DropItem1 = Item.KnifeOfJudgment, // vanilla 0
        },
        new()
        {
            Species = Species.HotDog,
            Note = "HotDog",
            MaxHp = 791, // vanilla 164
            Str = 112, // vanilla 75
            Vit = 25, // vanilla 35
            Wit = 160, // vanilla 90
            Agi = 85, // vanilla 28
            Exp = 112, // vanilla 45
            Gold = 100, // vanilla 5
            WaterResist = 4, // vanilla 1
            WindResist = 7, // vanilla 3
            DropRate0 = 12, // vanilla 10
            DropRate1 = 5, // vanilla 0
            DropItem0 = Item.HealthWeed, // vanilla 113
            DropItem1 = Item.RaincloudStaff, // vanilla 0
        },
        new()
        {
            Species = Species.GlugBird,
            Note = "GlugBird",
            Level = 5, // vanilla 8
            MaxHp = 156, // vanilla 65
            Str = 36, // vanilla 35
            Vit = 15, // vanilla 16
            Wit = 20, // vanilla 26
            Agi = 24, // vanilla 41
            Exp = 5, // vanilla 7
            Gold = 8, // vanilla 16
            FireResist = 6, // vanilla 7
            WaterResist = 6, // vanilla 7
            WindResist = 6, // vanilla 3
            EarthResist = 6, // vanilla 7
            DropRate0 = 20, // vanilla 0
            DropRate1 = 1, // vanilla 0
            DropItem0 = Item.WouldSalve, // vanilla 0
            DropItem1 = Item.Spectacles, // vanilla 0
        },
        new()
        {
            Species = Species.BabyBat,
            Note = "BabyBat",
            Level = 1, // vanilla 3
            MaxHp = 28, // vanilla 18
            Str = 17, // vanilla 20
            Vit = 5, // vanilla 6
            Wit = 17, // vanilla 19
            Agi = 30, // vanilla 33
            Exp = 2, // vanilla 1
            AttackCount = 2, // vanilla 1
            EarthResist = 7, // vanilla 11
            DropRate0 = 13, // vanilla 0
            DropRate1 = 2, // vanilla 0
            DropItem0 = Item.Herbs, // vanilla 0
            DropItem1 = Item.Telescope, // vanilla 0
        },
        new()
        {
            Species = Species.VampireBat,
            Note = "VampireBat",
            Level = 7, // vanilla 10
            MaxHp = 193, // vanilla 45
            Str = 39, // vanilla 37
            Vit = 12, // vanilla 25
            Wit = 60, // vanilla 64
            Agi = 34, // vanilla 17
            Exp = 13, // vanilla 10
            Gold = 14, // vanilla 19
            FireResist = 9, // vanilla 5
            WaterResist = 10, // vanilla 5
            WindResist = 9, // vanilla 7
            EarthResist = 7, // vanilla 11
            DropRate0 = 12, // vanilla 0
            DropRate1 = 2, // vanilla 0
            DropItem0 = Item.ResurrectPotion441, // vanilla 0
            DropItem1 = Item.OverflowingWalnut, // vanilla 0
        },
        new()
        {
            Species = Species.SonicBat,
            Note = "SonicBat",
            Level = 11, // vanilla 15
            MaxHp = 312, // vanilla 81
            Str = 59, // vanilla 47
            Wit = 90, // vanilla 70
            Agi = 60, // vanilla 25
            Exp = 37, // vanilla 25
            Gold = 16, // vanilla 12
            FireResist = 9, // vanilla 5
            WaterResist = 9, // vanilla 5
            WindResist = 14, // vanilla 7
            EarthResist = 8, // vanilla 7
            DropRate0 = 12, // vanilla 0
            DropRate1 = 4, // vanilla 0
            DropItem0 = Item.HealthWeed, // vanilla 0
            DropItem1 = Item.RescueSet, // vanilla 0
        },
    ];
}
