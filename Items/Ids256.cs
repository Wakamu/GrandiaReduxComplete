using Grandia.Sdk;

namespace GrandiaReduxComplete.Items;

/// <summary>WINDT sec3 rows 256–383 that differ from vanilla USA Disc 1.</summary>
internal static class Ids256
{
    internal static readonly ItemEdit[] All =
    [
        new()
        {
            Id = Item.DragonBoots,
            Note = "DragonBoots",
            Cost = 1200, // vanilla 640
            Icon = 45, // vanilla 44
            Unknown7 = 107, // vanilla 255
            Unknown13 = 1, // vanilla 0
            Unknown14 = 250, // vanilla 0
            Para1Post = 1536, // vanilla 1024
            Para2Post = 63488, // vanilla 1280
            Para3Post = 255, // vanilla 0
            ShortName = "SCALEBOOT",
            Name = "Scaled Boots",
            Description = "[+6 DEF] [-8 MOVE]  Heavy scales",
        },
        new()
        {
            Id = Item.NinjaSandals,
            Note = "NinjaSandals",
            Cost = 2400, // vanilla 700
            Unknown13 = 1, // vanilla 0
            Unknown14 = 250, // vanilla 0
            Para2Post = 12800, // vanilla 5120
        },
        new()
        {
            Id = Item.WingedBoots,
            Note = "WingedBoots",
            Unknown13 = 1, // vanilla 0
            Unknown14 = 250, // vanilla 0
        },
        new()
        {
            Id = Item.BeachSandals,
            Note = "BeachSandals",
            Unknown13 = 1, // vanilla 0
            Unknown14 = 250, // vanilla 0
        },
        new()
        {
            Id = Item.Mach1Boots,
            Note = "Mach1Boots",
            Unknown13 = 1, // vanilla 0
            Unknown14 = 250, // vanilla 0
        },
        new()
        {
            Id = Item.HeavyBoots,
            Note = "HeavyBoots",
            Unknown13 = 1, // vanilla 0
            Unknown14 = 250, // vanilla 0
            Para2Post = 62976, // vanilla 60416
        },
        new()
        {
            Id = Item.QueenHeels,
            Note = "QueenHeels",
            Cost = 9000, // vanilla 5000
            Unknown13 = 1, // vanilla 11
            Unknown14 = 250, // vanilla 10
            Para1Pre = 0, // vanilla 4
        },
        new()
        {
            Id = Item.IronClogs,
            Note = "IronClogs",
            Unknown13 = 1, // vanilla 0
            Unknown14 = 250, // vanilla 0
            Para2Post = 58624, // vanilla 60416
        },
        new()
        {
            Id = Item.OgreBoots,
            Note = "OgreBoots",
            Unknown13 = 1, // vanilla 0
            Unknown14 = 250, // vanilla 0
        },
        new()
        {
            Id = Item.RabbitShoes,
            Note = "RabbitShoes",
            Unknown13 = 1, // vanilla 0
            Unknown14 = 250, // vanilla 0
        },
        new()
        {
            Id = Item.RainbowHighHeels,
            Note = "RainbowHighHeels",
            Unknown13 = 1, // vanilla 28
            Unknown14 = 250, // vanilla 25
        },
        new()
        {
            Id = Item.WolfBoots,
            Note = "WolfBoots",
            Unknown13 = 1, // vanilla 0
            Unknown14 = 250, // vanilla 0
            Para2Post = 10240, // vanilla 2560
        },
        new()
        {
            Id = Item.LionBoots,
            Note = "LionBoots",
            Unknown13 = 1, // vanilla 0
            Unknown14 = 250, // vanilla 0
            Para1Post = 4608, // vanilla 6656
            Para2Post = 7680, // vanilla 4608
        },
        new()
        {
            Id = Item.BattleBoots,
            Note = "BattleBoots",
            Cost = 8000, // vanilla 4800
            Unknown13 = 1, // vanilla 0
            Unknown14 = 250, // vanilla 0
            Para1Post = 4096, // vanilla 5120
        },
        new()
        {
            Id = Item.SpiritShoes,
            Note = "SpiritShoes",
            Unknown13 = 1, // vanilla 0
            Unknown14 = 250, // vanilla 0
            Para1Post = 5120, // vanilla 7680
            Para2Post = 10240, // vanilla 7680
        },
        new()
        {
            Id = Item.GlassSlippers,
            Note = "GlassSlippers",
            Unknown13 = 1, // vanilla 0
            Unknown14 = 250, // vanilla 0
            Para1Post = 5120, // vanilla 7680
        },
        new()
        {
            Id = Item.WarpShoes,
            Note = "WarpShoes",
            Unknown13 = 1, // vanilla 4
            Unknown14 = 250, // vanilla 0
        },
        new()
        {
            Id = Item.Crampons,
            Note = "Crampons",
            Unknown13 = 1, // vanilla 0
            Unknown14 = 250, // vanilla 0
            Para1Post = 3584, // vanilla 4608
        },
        new()
        {
            Id = Item.ZeroBoots,
            Note = "ZeroBoots",
            Cost = 400, // vanilla 200
            Icon = 10, // vanilla 45
            Unknown7 = 166, // vanilla 255
            Unknown13 = 1, // vanilla 0
            Unknown14 = 250, // vanilla 0
            Para2 = 1, // vanilla 2
            Para4 = 3, // vanilla 0
            Para1Post = 512, // vanilla 0
            Para3Post = 1024, // vanilla 0
            ShortName = "OGREHEELS",
            Name = "Ogress Heels",
            Description = "[+2 ATK] [+4 ACT]  Alluring",
        },
        new()
        {
            Id = (Item)275,
            Note = "275",
            ShortName = "PRO",
            Name = "ohibited",
            Description = "ed",
        },
        new()
        {
            Id = Item.DianasAmulet,
            Note = "DianasAmulet",
            Effect = Skill.UnblockMagic, // vanilla 27
        },
        new()
        {
            Id = Item.HerosBadge,
            Note = "HerosBadge",
            Para1Post = 1280, // vanilla 512
        },
        new()
        {
            Id = Item.DemonSwordAmulet,
            Note = "DemonSwordAmulet",
            Unknown7 = 127, // vanilla 255
        },
        new()
        {
            Id = Item.ChainEarrings,
            Note = "ChainEarrings",
            Para1Post = 3840, // vanilla 2560
        },
        new()
        {
            Id = Item.TitansRing,
            Note = "TitansRing",
            Para1Post = 3840, // vanilla 1280
        },
        new()
        {
            Id = Item.FireproofCape,
            Note = "FireproofCape",
            Cost = 3000, // vanilla 1000
            Unknown7 = 127, // vanilla 255
            Para1Post = 1024, // vanilla 512
        },
        new()
        {
            Id = Item.FireCharm,
            Note = "FireCharm",
            Cost = 800, // vanilla 2000
            Unknown7 = 127, // vanilla 255
            Para1Post = 768, // vanilla 1024
        },
        new()
        {
            Id = Item.WaterCharm,
            Note = "WaterCharm",
            Cost = 800, // vanilla 2000
            Unknown7 = 127, // vanilla 255
            Unknown12 = 64, // vanilla 32
            Para2 = 31, // vanilla 30
            Para1Post = 768, // vanilla 1024
            ShortName = "WIND CHRM",
            Name = "Wind Charm",
            Description = "[+3 wind resist]   ",
        },
        new()
        {
            Id = Item.WindCharm,
            Note = "WindCharm",
            Cost = 800, // vanilla 2000
            Unknown7 = 127, // vanilla 255
            Unknown12 = 32, // vanilla 64
            Para2 = 30, // vanilla 31
            Para1Post = 768, // vanilla 1024
            ShortName = "WATR CHRM",
            Name = "Water Charm",
            Description = "[+3 water resist] ",
        },
        new()
        {
            Id = Item.EarthCharm,
            Note = "EarthCharm",
            Cost = 800, // vanilla 2500
            Unknown7 = 127, // vanilla 255
            Para1Post = 768, // vanilla 1024
        },
        new()
        {
            Id = Item.HurricaneBelt,
            Note = "HurricaneBelt",
            Cost = 20000, // vanilla 10000
            Para1Post = 10240, // vanilla 12800
        },
        new()
        {
            Id = Item.MamasAmulet,
            Note = "MamasAmulet",
            Para2 = 18, // vanilla 2
            Para3 = 2, // vanilla 0
            Para1Post = 1792, // vanilla 512
            Para2Post = 512, // vanilla 0
        },
        new()
        {
            Id = Item.JadeCharm,
            Note = "JadeCharm",
            Unknown13 = 1, // vanilla 0
            Unknown14 = 225, // vanilla 0
            Para2 = 33, // vanilla 1
            Para1Post = 256, // vanilla 512
        },
        new()
        {
            Id = Item.TreeGodAmulet,
            Note = "TreeGodAmulet",
            Para2 = 2, // vanilla 0
            Para3 = 4, // vanilla 0
            Para1Post = 1280, // vanilla 0
            Para2Post = 63744, // vanilla 0
            Para3Post = 255, // vanilla 0
        },
        new()
        {
            Id = Item.LightGodAmulet,
            Note = "LightGodAmulet",
            Cost = 2000, // vanilla 3000
            Unknown7 = 127, // vanilla 255
            Unknown13 = 11, // vanilla 0
            Unknown14 = 12, // vanilla 0
            Para1Pre = 7, // vanilla 0
            Para2 = 17, // vanilla 33
        },
        new()
        {
            Id = Item.AncestorsAmulet,
            Note = "AncestorsAmulet",
            Unknown7 = 8, // vanilla 255
            Para2 = 1, // vanilla 23
            Para3 = 19, // vanilla 0
            Para1Post = 2048, // vanilla 1024
            Para2Post = 256, // vanilla 0
        },
        new()
        {
            Id = Item.IridescentAmulet,
            Note = "IridescentAmulet",
            Para1Post = 2048, // vanilla 2560
        },
        new()
        {
            Id = Item.MedalOfYore,
            Note = "MedalOfYore",
            Cost = 1000, // vanilla 5000
            Para3 = 14, // vanilla 0
            Para1Post = 1024, // vanilla 256
            Para2Post = 512, // vanilla 0
            ShortName = "MEDALYORE",
            Name = "Medal of Yore",
            Description = "+2 SP when attacking/taking damage",
        },
        new()
        {
            Id = Item.SpiritCharm,
            Note = "SpiritCharm",
            Para2 = 18, // vanilla 33
            Para3 = 34, // vanilla 2
            Para4 = 16, // vanilla 0
            Para1Post = 1792, // vanilla 512
            Para2Post = 768, // vanilla 5120
            Para3Post = 512, // vanilla 0
        },
        new()
        {
            Id = Item.PhantomSilk,
            Note = "PhantomSilk",
            Cost = 200, // vanilla 7000
            Icon = 46, // vanilla 48
            Unknown13 = 28, // vanilla 0
            Unknown14 = 8, // vanilla 0
            Para2 = 4, // vanilla 30
            Para3 = 2, // vanilla 31
            Para1Post = 3840, // vanilla 1024
            Para2Post = 64768, // vanilla 1024
            Para3Post = 255, // vanilla 0
            ShortName = "PHNT RING",
            Name = "Phantom Ring",
            Description = "[+15 MOVE] [-3 DEF] [Lucky+]  Spooky",
        },
        new()
        {
            Id = Item.LightningCharm,
            Note = "LightningCharm",
            Cost = 1200, // vanilla 1500
            Unknown7 = 127, // vanilla 255
        },
        new()
        {
            Id = Item.ForestCharm,
            Note = "ForestCharm",
            Cost = 1200, // vanilla 2500
            Unknown7 = 127, // vanilla 255
        },
        new()
        {
            Id = Item.ExplosionCharm,
            Note = "ExplosionCharm",
            Cost = 1200, // vanilla 2500
            Unknown7 = 127, // vanilla 255
        },
        new()
        {
            Id = Item.BlizzardCharm,
            Note = "BlizzardCharm",
            Cost = 1200, // vanilla 2500
            Unknown7 = 127, // vanilla 255
        },
        new()
        {
            Id = Item.PoisonCharm,
            Note = "PoisonCharm",
            Cost = 800, // vanilla 1000
        },
        new()
        {
            Id = Item.SonicBelt,
            Note = "SonicBelt",
            Para1Post = 15360, // vanilla 17920
        },
        new()
        {
            Id = Item.AnkhOfTemptation,
            Note = "AnkhOfTemptation",
            Cost = 8000, // vanilla 2000
            ShortName = "MAG ICON ",
            Name = "Magical Icon",
            Description = "[Magic+]  Mysterious",
        },
        new()
        {
            Id = Item.Anklet,
            Note = "Anklet",
            Para1Post = 12800, // vanilla 7680
        },
        new()
        {
            Id = Item.EnergyRing,
            Note = "EnergyRing",
            Para1Post = 1280, // vanilla 768
        },
        new()
        {
            Id = Item.DiseaseCharm,
            Note = "DiseaseCharm",
            Cost = 2000, // vanilla 750
            Para1Post = 2048, // vanilla 768
        },
        new()
        {
            Id = Item.Paperweight,
            Note = "Paperweight",
            Cost = 1800, // vanilla 10
            Icon = 48, // vanilla 46
            UseStatus = 34932, // vanilla 34934
            Unknown7 = 198, // vanilla 255
            Para2 = 2, // vanilla 18
            Para3 = 14, // vanilla 0
            Para4 = 1, // vanilla 0
            Para1Post = 2048, // vanilla 1792
            Para2Post = 768, // vanilla 0
            Para3Post = 2048, // vanilla 0
            Para4Post = 5376, // vanilla 512
            ShortName = "PWR CLOAK",
            Name = "Cloak of Power",
            Description = "[+8 DEF] [+8 ATK]  Empowering cloak",
        },
        new()
        {
            Id = Item.CombatAnklet,
            Note = "CombatAnklet",
            Cost = 7500, // vanilla 4000
            Para1Post = 7680, // vanilla 5120
        },
        new()
        {
            Id = Item.SatisfactionGem,
            Note = "SatisfactionGem",
            Cost = 2800, // vanilla 30000
            Icon = 23, // vanilla 46
            UseStatus = 34929, // vanilla 34934
            Unknown7 = 24, // vanilla 255
            Unknown8 = 2, // vanilla 0
            Para2 = 1, // vanilla 11
            Para3 = 19, // vanilla 0
            Para1Post = 6665, // vanilla 256
            Para2Post = 512, // vanilla 0
            Para4Post = 1282, // vanilla 512
            Unknown27 = 2, // vanilla 0
            ShortName = "ANC SWORD",
            Name = "Ancestor's Sword",
            Description = "+26 attack  +2 magic     ",
        },
        new()
        {
            Id = Item.CrescentJade,
            Note = "CrescentJade",
            Cost = 400, // vanilla 500
            Icon = 37, // vanilla 46
            UseStatus = 34930, // vanilla 34934
            Unknown13 = 2, // vanilla 0
            Unknown14 = 85, // vanilla 0
            Para2 = 4, // vanilla 26
            Para3 = 0, // vanilla 27
            Para1Post = 3072, // vanilla 512
            Para2Post = 0, // vanilla 512
            Para4Post = 5888, // vanilla 512
            ShortName = "AD GLOVES",
            Name = "Adventurer's Gloves",
            Description = "[+12 MOVE] [Psyche]  Recommended",
        },
        new()
        {
            Id = Item.DragonScales,
            Note = "DragonScales",
            ShortName = "SCAL",
            Name = "Scales ",
            Description = "[Block] ",
        },
        new()
        {
            Id = Item.Spectacles,
            Note = "Spectacles",
            Cost = 1500, // vanilla 500
            Para1Post = 2048, // vanilla 512
        },
        new()
        {
            Id = Item.RuneRing,
            Note = "RuneRing",
            Para2Post = 512, // vanilla 256
        },
        new()
        {
            Id = Item.TearJewel,
            Note = "TearJewel",
            Cost = 12000, // vanilla 3000
            UseStatus = 8224, // vanilla 57632
            EffectValue = 20, // vanilla 3
        },
        new()
        {
            Id = Item.WouldSalve,
            Note = "WouldSalve",
            Cost = 50, // vanilla 40
            EffectValue = 50, // vanilla 40
        },
        new()
        {
            Id = Item.BaobabFruit,
            Note = "BaobabFruit",
            Effect = Skill.Runner, // vanilla 114
            Cost = 150, // vanilla 200
            Icon = 9, // vanilla 53
            UseStatus = 49408, // vanilla 57600
            EffectValue = 4, // vanilla 10
            ShortName = "RUN NUT  ",
            Name = "Running Walnut",
            Description = "+4 move level to allies in range",
        },
        new()
        {
            Id = Item.BoiledCoconut,
            Note = "BoiledCoconut",
            Cost = 150, // vanilla 240
        },
        new()
        {
            Id = Item.ChocolateCookies,
            Note = "ChocolateCookies",
            Cost = 300, // vanilla 400
        },
        new()
        {
            Id = Item.Honey,
            Note = "Honey",
            Cost = 400, // vanilla 500
            EffectValue = 120, // vanilla 100
        },
        new()
        {
            Id = Item.UltraDrink,
            Note = "UltraDrink",
            Cost = 800, // vanilla 200
            UseStatus = 49408, // vanilla 57600
            EffectValue = 50, // vanilla 20
        },
        new()
        {
            Id = Item.Weeds,
            Note = "Weeds",
            Cost = 500, // vanilla 2
            EffectValue = 44, // vanilla 1
            Unknown11 = 1, // vanilla 0
            ShortName = "SPT HERB",
            Name = "Spirit Herb",
            Description = "Restores 300 HP  Extremely Rare",
        },
        new()
        {
            Id = Item.DriedFish,
            Note = "DriedFish",
            Effect = (Skill)0, // vanilla 5
            Cost = 420, // vanilla 60
            Icon = 38, // vanilla 52
            UseStatus = 34930, // vanilla 57600
            Unknown7 = 185, // vanilla 255
            EffectValue = 0, // vanilla 40
            Unknown13 = 25, // vanilla 0
            Unknown14 = 5, // vanilla 0
            Para2 = 2, // vanilla 0
            Para3 = 4, // vanilla 0
            Para1Post = 1024, // vanilla 0
            Para2Post = 64512, // vanilla 0
            Para3Post = 255, // vanilla 0
            Para4Post = 5888, // vanilla 0
            ShortName = "IN SHIELD ",
            Name = "Iron Shield",
            Description = "[+4 DEF] [-4 MOVE] [Block]  Polished",
        },
        new()
        {
            Id = Item.BambooShoots,
            Note = "BambooShoots",
            Effect = (Skill)0, // vanilla 5
            Cost = 450, // vanilla 30
            Icon = 48, // vanilla 50
            UseStatus = 34932, // vanilla 57600
            Unknown7 = 198, // vanilla 255
            EffectValue = 0, // vanilla 20
            Para2 = 2, // vanilla 0
            Para3 = 14, // vanilla 0
            Para4 = 33, // vanilla 0
            Para1Post = 1024, // vanilla 0
            Para2Post = 768, // vanilla 0
            Para3Post = 256, // vanilla 0
            Para4Post = 5376, // vanilla 0
            ShortName = "CRIMSON B",
            Name = "Crimson Bolero",
            Description = "[+4 DEF] [+1 magic resist]  Modern",
        },
        new()
        {
            Id = Item.BeefJerky,
            Note = "BeefJerky",
            Effect = (Skill)0, // vanilla 5
            Cost = 550, // vanilla 90
            Icon = 44, // vanilla 52
            UseStatus = 34933, // vanilla 57600
            Unknown7 = 93, // vanilla 255
            EffectValue = 0, // vanilla 60
            Unknown13 = 1, // vanilla 0
            Unknown14 = 250, // vanilla 0
            Para2 = 26, // vanilla 0
            Para3 = 4, // vanilla 0
            Para4 = 27, // vanilla 0
            Para1Post = 512, // vanilla 0
            Para2Post = 2560, // vanilla 0
            Para3Post = 512, // vanilla 0
            Para4Post = 6912, // vanilla 0
            ShortName = "CLTY SHOE",
            Name = "Clarity Shoes",
            Description = "[+10 MOVE] [+2 confuse/sleep resist]  ",
        },
        new()
        {
            Id = Item.BoxLunch,
            Note = "BoxLunch",
            Effect = (Skill)0, // vanilla 5
            Cost = 430, // vanilla 120
            Icon = 40, // vanilla 51
            UseStatus = 34931, // vanilla 57600
            Unknown7 = 230, // vanilla 255
            EffectValue = 0, // vanilla 30
            Para2 = 1, // vanilla 0
            Para3 = 14, // vanilla 0
            Para1Post = 1792, // vanilla 0
            Para2Post = 512, // vanilla 0
            Para4Post = 6400, // vanilla 0
            ShortName = "SILK HAIR",
            Name = "Silken Hair Bow",
            Description = "[+7 ATK] [Temper]  Smooth ",
        },
        new()
        {
            Id = Item.Herbs,
            Note = "Herbs",
            Cost = 20, // vanilla 15
            EffectValue = 20, // vanilla 15
        },
        new()
        {
            Id = Item.WhiteSulfaWeed,
            Note = "WhiteSulfaWeed",
            Cost = 70, // vanilla 75
            EffectValue = 70, // vanilla 35
        },
        new()
        {
            Id = Item.SmarnaWeed,
            Note = "SmarnaWeed",
            Cost = 60, // vanilla 150
            EffectValue = 250, // vanilla 255
        },
        new()
        {
            Id = Item.ChollaFlowers,
            Note = "ChollaFlowers",
            Cost = 220, // vanilla 400
            EffectValue = 30, // vanilla 3
        },
        new()
        {
            Id = Item.BamoFruit,
            Note = "BamoFruit",
            Effect = Skill.Wow, // vanilla 101
            Cost = 150, // vanilla 600
            Icon = 9, // vanilla 53
            EffectValue = 3, // vanilla 4
            ShortName = "OVER NUT ",
            Name = "Overflowing Walnut",
            Description = "+3 attack level for one ally",
        },
        new()
        {
            Id = Item.SquidGuts,
            Note = "SquidGuts",
            Effect = (Skill)0, // vanilla 114
            Cost = 2600, // vanilla 400
            Icon = 24, // vanilla 52
            UseStatus = 34929, // vanilla 57600
            Unknown7 = 41, // vanilla 255
            Unknown8 = 2, // vanilla 0
            EffectValue = 0, // vanilla 20
            Unknown12 = 128, // vanilla 0
            Para2 = 1, // vanilla 0
            Para3 = 13, // vanilla 0
            Para4 = 17, // vanilla 0
            Para1Post = 7689, // vanilla 0
            Para2Post = 4096, // vanilla 0
            Para3Post = 1280, // vanilla 0
            Para4Post = 1282, // vanilla 0
            Unknown27 = 2, // vanilla 0
            ShortName = "STL GREAT",
            Name = "Steel Greatsword",
            Description = "[+30 ATK] [Might]  Finest steel",
        },
        new()
        {
            Id = Item.MoveMushroom,
            Note = "MoveMushroom",
            Cost = 30, // vanilla 200
        },
        new()
        {
            Id = Item.PowerMushroom,
            Note = "PowerMushroom",
            Cost = 30, // vanilla 200
            EffectValue = 2, // vanilla 3
        },
        new()
        {
            Id = Item.PoisonAntidote,
            Note = "PoisonAntidote",
            Cost = 50, // vanilla 100
        },
        new()
        {
            Id = Item.Ginseng,
            Note = "Ginseng",
            EffectValue = 60, // vanilla 40
        },
        new()
        {
            Id = Item.Banana,
            Note = "Banana",
            Effect = (Skill)0, // vanilla 5
            Cost = 50, // vanilla 25
            Icon = 28, // vanilla 53
            UseStatus = 34929, // vanilla 57600
            Unknown7 = 36, // vanilla 255
            Unknown8 = 3, // vanilla 0
            EffectValue = 0, // vanilla 12
            Para2 = 1, // vanilla 0
            Para3 = 13, // vanilla 0
            Para1Post = 777, // vanilla 0
            Para2Post = 2560, // vanilla 0
            Para4Post = 1793, // vanilla 0
            Unknown27 = 4, // vanilla 0
            ShortName = "TOYHAMMER",
            Name = "Toy Hammer",
            Description = "[+3 ATK]  Squeak squeak!",
        },
        new()
        {
            Id = Item.Bandage,
            Note = "Bandage",
            Effect = (Skill)0, // vanilla 5
            Cost = 2000, // vanilla 100
            Icon = 38, // vanilla 49
            UseStatus = 34930, // vanilla 57600
            Unknown7 = 185, // vanilla 255
            EffectValue = 0, // vanilla 50
            Unknown13 = 25, // vanilla 0
            Unknown14 = 6, // vanilla 0
            Para2 = 2, // vanilla 0
            Para3 = 4, // vanilla 0
            Para4 = 3, // vanilla 0
            Para1Post = 1792, // vanilla 0
            Para2Post = 64000, // vanilla 0
            Para3Post = 1535, // vanilla 0
            Para4Post = 5888, // vanilla 0
            ShortName = "MN SHIELD",
            Name = "Moonlight Shield",
            Description = "[+7 DEF] [+5 ACT] [-6 MOVE] [Block]",
        },
        new()
        {
            Id = Item.BoxOfSweets,
            Note = "BoxOfSweets",
            Effect = (Skill)0, // vanilla 5
            Cost = 360, // vanilla 20
            Icon = 28, // vanilla 51
            UseStatus = 34929, // vanilla 57600
            Unknown7 = 36, // vanilla 255
            Unknown8 = 3, // vanilla 0
            EffectValue = 0, // vanilla 10
            Unknown12 = 4, // vanilla 0
            Para2 = 1, // vanilla 0
            Para3 = 13, // vanilla 0
            Para1Post = 1289, // vanilla 0
            Para2Post = 2560, // vanilla 0
            Para4Post = 1793, // vanilla 0
            Unknown27 = 4, // vanilla 0
            ShortName = "SQUATTER ",
            Name = "The Bug-Squatter",
            Description = "[+5 ATK] [Insect slayer]  Swat em'!",
        },
        new()
        {
            Id = Item.FirstAidKit,
            Note = "FirstAidKit",
            Cost = 200, // vanilla 180
            EffectValue = 40, // vanilla 60
        },
        new()
        {
            Id = Item.RedMedicine,
            Note = "RedMedicine",
            EffectValue = 250, // vanilla 200
        },
        new()
        {
            Id = Item.BlueMedicine,
            Note = "BlueMedicine",
            Cost = 600, // vanilla 1600
            EffectValue = 30, // vanilla 20
        },
        new()
        {
            Id = Item.YellowMedicine,
            Note = "YellowMedicine",
            Cost = 400, // vanilla 800
            EffectValue = 100, // vanilla 30
        },
        new()
        {
            Id = Item.CrimsonPotion,
            Note = "CrimsonPotion",
            Cost = 2000, // vanilla 1500
        },
        new()
        {
            Id = Item.DeepBluePotion,
            Note = "DeepBluePotion",
            Cost = 3000, // vanilla 5000
            EffectValue = 30, // vanilla 20
        },
        new()
        {
            Id = Item.GoldenPotion,
            Note = "GoldenPotion",
            Cost = 1000, // vanilla 3000
            EffectValue = 100, // vanilla 30
        },
        new()
        {
            Id = Item.MagicLamp,
            Note = "MagicLamp",
            Effect = (Skill)0, // vanilla 112
            Cost = 900, // vanilla 7500
            Icon = 58, // vanilla 49
            UseStatus = 34931, // vanilla 57632
            Unknown7 = 210, // vanilla 255
            EffectValue = 0, // vanilla 2
            Unknown13 = 31, // vanilla 0
            Unknown14 = 5, // vanilla 0
            Para2 = 3, // vanilla 0
            Para3 = 4, // vanilla 0
            Para1Post = 1536, // vanilla 0
            Para2Post = 2048, // vanilla 0
            Para4Post = 6400, // vanilla 256
            ShortName = "SOL FETHR",
            Name = "Solace Feather",
            Description = "[+6 ACT] [+8 MOVE] [Regen]  Soothing",
        },
        new()
        {
            Id = Item.PoisonAntidote367,
            Note = "PoisonAntidote367",
            Cost = 50, // vanilla 100
        },
        new()
        {
            Id = Item.Vaccine,
            Note = "Vaccine",
            Effect = (Skill)27, // vanilla 106
            Cost = 30, // vanilla 50
        },
        new()
        {
            Id = Item.EyeDrops,
            Note = "EyeDrops",
            Effect = Skill.Heal, // vanilla 107
            Cost = 1200, // vanilla 600
            Icon = 2, // vanilla 49
            UseStatus = 34930, // vanilla 49408
            Unknown7 = 159, // vanilla 255
            EffectValue = 50, // vanilla 7
            Para2 = 3, // vanilla 0
            Para3 = 34, // vanilla 0
            Para4 = 19, // vanilla 0
            Para1Post = 1024, // vanilla 0
            Para2Post = 512, // vanilla 0
            Para3Post = 256, // vanilla 0
            Para4Post = 512, // vanilla 0
            ShortName = "WATR BAND",
            Name = "Water Band <Heal>",
            Description = "[+4 ACT] [Magic+] [+2 crit resist]",
        },
        new()
        {
            Id = Item.SmellingSalts,
            Note = "SmellingSalts",
            Effect = Skill.Craze, // vanilla 109
            Cost = 200, // vanilla 100
            Icon = 50, // vanilla 49
            UseStatus = 49440, // vanilla 49408
            EffectValue = 200, // vanilla 7
            ShortName = "LEAF SCRL",
            Name = "Leaf Scroll",
            Description = "200 HP single forest attack [Lasting]",
        },
        new()
        {
            Id = Item.ParalysisOintment,
            Note = "ParalysisOintment",
            Effect = Skill.Burn, // vanilla 105
            Cost = 1200, // vanilla 100
            Icon = 2, // vanilla 49
            UseStatus = 34930, // vanilla 49408
            Unknown7 = 159, // vanilla 255
            EffectValue = 80, // vanilla 7
            Para2 = 1, // vanilla 0
            Para3 = 34, // vanilla 0
            Para4 = 19, // vanilla 0
            Para1Post = 768, // vanilla 0
            Para2Post = 512, // vanilla 0
            Para3Post = 256, // vanilla 0
            Para4Post = 512, // vanilla 0
            ShortName = "FIRE BAND",
            Name = "Fire Band <Burn>",
            Description = "[+3 ATK] [Magic+] [+2 crit resist]",
        },
        new()
        {
            Id = Item.SpellBreaker,
            Note = "SpellBreaker",
            Effect = Skill.Howl, // vanilla 115
            Cost = 1200, // vanilla 200
            Icon = 2, // vanilla 56
            UseStatus = 34930, // vanilla 57600
            Unknown7 = 159, // vanilla 255
            EffectValue = 200, // vanilla 7
            Para2 = 4, // vanilla 0
            Para3 = 34, // vanilla 0
            Para4 = 19, // vanilla 0
            Para1Post = 1280, // vanilla 0
            Para2Post = 512, // vanilla 0
            Para3Post = 256, // vanilla 0
            Para4Post = 512, // vanilla 0
            ShortName = "WIND BAND",
            Name = "Wind Band <Howl>",
            Description = "[+5 MOVE] [Magic+] [+2 crit resist] ",
        },
        new()
        {
            Id = Item.MoveBreaker,
            Note = "MoveBreaker",
            Effect = Skill.CureParalysis, // vanilla 27
            Cost = 1200, // vanilla 200
            Icon = 2, // vanilla 56
            UseStatus = 34930, // vanilla 57600
            Unknown7 = 159, // vanilla 255
            EffectValue = 2, // vanilla 7
            Para2 = 2, // vanilla 0
            Para3 = 34, // vanilla 0
            Para4 = 19, // vanilla 0
            Para1Post = 512, // vanilla 0
            Para2Post = 512, // vanilla 0
            Para3Post = 256, // vanilla 0
            Para4Post = 512, // vanilla 0
            ShortName = "ERTH BAND",
            Name = "Earth Band <Aegis>",
            Description = "[+2 DEF] [Magic+] [+2 crit resist]",
        },
        new()
        {
            Id = Item.ResurrectPotion,
            Note = "ResurrectPotion",
            Cost = 2000, // vanilla 1000
        },
        new()
        {
            Id = Item.Panacea,
            Note = "Panacea",
            Effect = (Skill)27, // vanilla 29
            Cost = 100, // vanilla 800
        },
        new()
        {
            Id = Item.BondOfTrust,
            Note = "BondOfTrust",
            UseStatus = 49440, // vanilla 49504
            EffectValue = 16, // vanilla 192
            Unknown11 = 39, // vanilla 18
        },
    ];
}
