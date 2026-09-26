using Grandia.Sdk;

namespace GrandiaReduxComplete.Magic;

/// <summary>Spells / support that differ from vanilla USA Disc 1.</summary>
internal static class Spells
{
    internal static readonly MagicEdit[] All =
    [
        new()
        {
            Id = Skill.DefLoss,
            Note = "DefLoss",
            Power = -5, // vanilla -1
            Cost = 6, // vanilla 3
            Speed = 5, // vanilla 30
            Exp = 12, // vanilla 10
            Unknown11 = 0x60, // LV6 (vanilla LV5)
            CharacterMask = 0x1D, // vanilla 0x1C
            Requirements =
            [
                new(LearnKind.Earth, 1),
            ],
            Description = "Soul shatter  [All] [Defense-]",
        },
        new()
        {
            Id = Skill.Tremor,
            Note = "Tremor",
            Power = 140, // vanilla 70
            Cost = 16, // vanilla 3
            Speed = 25, // vanilla 60
            IpKnockback = 0, // vanilla 1500
            Exp = 12, // vanilla 10
            CancelChance = 50, // vanilla 20
            CharacterMask = 0x0D, // vanilla 0x0F
            Requirements =
            [
                new(LearnKind.Earth, 7),
            ],
            Description = "Earth energy  [Area] [Medium]",
        },
        new()
        {
            Id = Skill.Gravity,
            Note = "Gravity",
            Power = 14, // vanilla -7
            Cost = 8, // vanilla 4
            Speed = 5, // vanilla 75
            Exp = 25, // vanilla 20
            Effect = EffectType.Status, // vanilla 7
            CharacterMask = 0x9A, // vanilla 0x98
            Requirements =
            [
                new(LearnKind.Earth, 9),
            ],
            Description = "Grasp of earth  [Single] [Paralyse]",
        },
        new()
        {
            Id = Skill.Quake,
            Note = "Quake",
            Power = 240, // vanilla 250
            Cost = 32, // vanilla 12
            Speed = 30, // vanilla 120
            IpKnockback = 0, // vanilla 2000
            CancelChance = 30, // vanilla 35
            Unknown11 = 0x64, // LV6 (vanilla LV7)
            Requirements =
            [
                new(LearnKind.Earth, 22),
            ],
            Description = "Rage of earth  [All] [Strong]",
        },
        new()
        {
            Id = Skill.Heal,
            Note = "Heal",
            Power = 60, // vanilla 30
            Cost = 8, // vanilla 1
            Speed = 25, // vanilla 30
            Exp = 16, // vanilla 8
            CharacterMask = 0x86, // vanilla 0x97
            Description = "[Single] [Healing] [Medium]",
        },
        new()
        {
            Id = Skill.Alheal,
            Note = "Alheal",
            Power = 35, // vanilla 40
            Cost = 12, // vanilla 4
            Speed = 25, // vanilla 45
            Exp = 15, // vanilla 5
            Unknown11 = 0x50, // LV5 (vanilla LV6)
            CharacterMask = 0x11, // vanilla 0x07
            Requirements =
            [
                new(LearnKind.Water, 1),
            ],
            Description = "[All] [Healing] [Light]",
        },
        new()
        {
            Id = Skill.Snooze,
            Note = "Snooze",
            Power = 4, // vanilla 3
            Cost = 16, // vanilla 2
            Speed = 25, // vanilla 45
            Unknown11 = 0x60, // LV6 (vanilla LV5)
            CharacterMask = 0x01, // vanilla 0x17
            Requirements =
            [
                new(LearnKind.Water, 10),
            ],
            Description = "Magic bubbles  [All] [Sleep]",
        },
        new()
        {
            Id = Skill.Healer,
            Note = "Healer",
            Power = 120, // vanilla 80
            Cost = 18, // vanilla 3
            Speed = 25, // vanilla 75
            Exp = 16, // vanilla 8
            Unknown11 = 0x50, // LV5 (vanilla LV6)
            CharacterMask = 0x06, // vanilla 0x13
            Requirements =
            [
                new(LearnKind.Water, 14),
            ],
            Description = "[Single] [Healing] [Strong]",
        },
        new()
        {
            Id = Skill.Alhealer,
            Note = "Alhealer",
            Power = 55, // vanilla 80
            Cost = 24, // vanilla 8
            Speed = 25, // vanilla 105
            Exp = 8, // vanilla 5
            Unknown11 = 0x50, // LV5 (vanilla LV6)
            CharacterMask = 0x81, // vanilla 0x82
            Requirements =
            [
                new(LearnKind.Water, 18),
            ],
            Description = "[All] [Healing] [Medium]",
        },
        new()
        {
            Id = Skill.AlhealerPlus,
            Note = "AlhealerPlus",
            Power = 105, // vanilla 150
            Cost = 36, // vanilla 12
            Speed = 25, // vanilla 135
            Exp = 8, // vanilla 5
            Unknown11 = 0x50, // LV5 (vanilla LV7)
            CharacterMask = 0x01, // vanilla 0x97
            Requirements =
            [
                new(LearnKind.Water, 32),
            ],
            Description = "[All] [Healing] [Strong]",
        },
        new()
        {
            Id = Skill.Resurrect,
            Note = "Resurrect",
            Cost = 20, // vanilla 6
            Speed = 40, // vanilla 105
            Exp = 20, // vanilla 10
            Unknown11 = 0x50, // LV5 (vanilla LV7)
            CharacterMask = 0x83, // vanilla 0x87
            Requirements =
            [
                new(LearnKind.Water, 36),
            ],
            Description = "Water of life [Single] [Revive]",
        },
        new()
        {
            Id = Skill.Burn,
            Note = "Burn",
            Power = 100, // vanilla 40
            Cost = 6, // vanilla 1
            Speed = 20, // vanilla 30
            IpKnockback = 0, // vanilla 1000
            Exp = 12, // vanilla 10
            Radius = 23, // vanilla 15
            CancelChance = 0, // vanilla 15
            Unknown11 = 0x61, // LV6 (vanilla LV5)
            CharacterMask = 0x9A, // vanilla 0x9F
            Description = "Ring of fire  [Area] [Light]",
        },
        new()
        {
            Id = Skill.Burnflame,
            Note = "Burnflame",
            Power = 150, // vanilla 80
            Cost = 18, // vanilla 4
            Speed = 20, // vanilla 45
            IpKnockback = 0, // vanilla 1000
            Exp = 12, // vanilla 10
            CancelChance = 16, // vanilla 20
            CharacterMask = 0x9B, // vanilla 0x9F
            Requirements =
            [
                new(LearnKind.Fire, 8),
            ],
            Description = "Pillar of fire [Area] [Medium]",
        },
        new()
        {
            Id = Skill.Burnstrike,
            Note = "Burnstrike",
            Cost = 8, // vanilla 5
            Speed = 15, // vanilla 60
            IpKnockback = 4000, // vanilla 2000
            Exp = 30, // vanilla 20
            CancelChance = 0, // vanilla 30
            Requirements =
            [
                new(LearnKind.Fire, 1),
            ],
            ShortName = "BLAZE!",
            Name = "Blaze!",
            Description = "Bolts of fire  [Single] [Medium]",
        },
        new()
        {
            Id = Skill.Burnflare,
            Note = "Burnflare",
            Power = 220, // vanilla 150
            Cost = 28, // vanilla 7
            Speed = 25, // vanilla 75
            IpKnockback = 0, // vanilla 1500
            CancelChance = 0, // vanilla 30
            Unknown11 = 0x63, // LV6 (vanilla LV7)
            Requirements =
            [
                new(LearnKind.Fire, 18),
            ],
            ShortName = "BURNBLAZE",
            Name = "Burnblaze",
            Description = "Lots of fireballs  [All] [Strong]",
        },
        new()
        {
            Id = Skill.Fireburner,
            Note = "Fireburner",
            Power = 500, // vanilla 300
            Cost = 45, // vanilla 8
            Speed = 45, // vanilla 105
            IpKnockback = 0, // vanilla 3000
            Exp = 12, // vanilla 20
            Radius = 23, // vanilla 0
            CancelChance = 0, // vanilla 50
            Unknown10 = 0x52, // vanilla 0x51
            Unknown11 = 0x63, // LV6 (vanilla LV7)
            CharacterMask = 0x02, // vanilla 0x99
            Requirements =
            [
                new(LearnKind.Fire, 51),
            ],
            ShortName = "HELLBURNR",
            Name = "Hellburner",
            Description = "Purge with hellfire [Area] [Extreme]",
        },
        new()
        {
            Id = Skill.Howl,
            Note = "Howl",
            Power = 100, // vanilla 40
            Cost = 8, // vanilla 2
            Speed = 20, // vanilla 45
            IpKnockback = 0, // vanilla 2000
            Exp = 12, // vanilla 10
            CancelChance = 0, // vanilla 15
            Unknown11 = 0x61, // LV6 (vanilla LV5)
            CharacterMask = 0x95, // vanilla 0x97
            Description = "Gust of wind [Area] [Light]",
        },
        new()
        {
            Id = Skill.Runner,
            Note = "Runner",
            Power = 3, // vanilla 2
            Cost = 5, // vanilla 1
            Speed = 5, // vanilla 15
            Exp = 14, // vanilla 8
            Radius = 25, // vanilla 20
            Requirements =
            [
                new(LearnKind.Wind, 1),
            ],
            Description = "Tailwind  [Area] [Move+] [Aura]",
        },
        new()
        {
            Id = Skill.Howlslash,
            Note = "Howlslash",
            Power = 160, // vanilla 80
            Cost = 20, // vanilla 6
            Speed = 25, // vanilla 75
            IpKnockback = 0, // vanilla 2000
            CancelChance = 0, // vanilla 20
            CharacterMask = 0x81, // vanilla 0x87
            Requirements =
            [
                new(LearnKind.Wind, 11),
            ],
            Description = "Very strong winds [All] [Medium]",
        },
        new()
        {
            Id = (Skill)20,
            Note = "20",
            Requirements =
            [
                new(LearnKind.Wind, 13),
            ],
        },
        new()
        {
            Id = Skill.Shhh,
            Note = "Shhh",
            Power = 300, // vanilla 4
            Cost = 15, // vanilla 3
            Speed = 25, // vanilla 60
            IpKnockback = 4000, // vanilla 0
            Exp = 30, // vanilla 20
            Effect = EffectType.Damage, // vanilla 5
            Mode = 1, // vanilla 7
            Unknown11 = 0x61, // LV6 (vanilla LV6)
            CharacterMask = 0x12, // vanilla 0x16
            Requirements =
            [
                new(LearnKind.Wind, 13),
            ],
            ShortName = "HOWLSPIN",
            Name = "Howlspin",
            Description = "Sharp wind blades  [Single] [Strong]",
        },
        new()
        {
            Id = Skill.Howlnado,
            Note = "Howlnado",
            Power = 220, // vanilla 250
            Cost = 30, // vanilla 8
            Speed = 30, // vanilla 120
            IpKnockback = 0, // vanilla 3000
            CancelChance = 0, // vanilla 35
            Unknown11 = 0x63, // LV6 (vanilla LV7)
            Requirements =
            [
                new(LearnKind.Wind, 20),
            ],
            Description = "A tornado [All] [Strong] [Scatter]",
        },
        new()
        {
            Id = Skill.Poizn,
            Note = "Poizn",
            Power = 7, // vanilla 2
            Cost = 12, // vanilla 2
            Speed = 10, // vanilla 30
            IpKnockback = 500, // vanilla 1000
            Exp = 20, // vanilla 10
            Radius = 23, // vanilla 20
            Unknown11 = 0x71, // LV7 (vanilla LV5)
            CharacterMask = 0x94, // vanilla 0x90
            Requirements =
            [
                new(LearnKind.Water, 11),
                new(LearnKind.Earth, 13),
            ],
            Description = "Poisonous gel  [Area] [Poison]",
        },
        new()
        {
            Id = Skill.Cure,
            Note = "Cure",
            Cost = 2, // vanilla 1
            Speed = 5, // vanilla 30
            Exp = 20, // vanilla 10
            CharacterMask = 0x15, // vanilla 0x07
            Requirements =
            [
                new(LearnKind.Water, 5),
                new(LearnKind.Earth, 3),
            ],
            Description = "Forest energy [Single] [Heal poison]",
        },
        new()
        {
            Id = Skill.Stram,
            Note = "Stram",
            Cost = 10, // vanilla 3
            Speed = 10, // vanilla 30
            Exp = 30, // vanilla 20
            Unknown11 = 0x70, // LV7 (vanilla LV5)
            CharacterMask = 0x91, // vanilla 0x90
            Requirements =
            [
                new(LearnKind.Water, 16),
                new(LearnKind.Earth, 16),
            ],
            Description = "Lowers energy  [Single] [Attack-]",
        },
        new()
        {
            Id = Skill.Craze,
            Note = "Craze",
            Power = 360, // vanilla 3
            Cost = 18, // vanilla 1
            Speed = 15, // vanilla 30
            IpKnockback = 4000, // vanilla 500
            Exp = 32, // vanilla 20
            Effect = EffectType.Damage, // vanilla 5
            Unknown11 = 0x71, // LV7 (vanilla LV6)
            CharacterMask = 0x92, // vanilla 0x90
            Requirements =
            [
                new(LearnKind.Water, 19),
                new(LearnKind.Earth, 15),
            ],
            ShortName = "WRATH",
            Name = "Wrath",
            Description = "Wrath of nature [Single] [Strong]",
        },
        new()
        {
            Id = (Skill)27,
            Note = "27",
            Cost = 8, // vanilla 3
            Speed = 5, // vanilla 60
            Exp = 20, // vanilla 10
            Mode = 8, // vanilla 6
            Unknown11 = 0x50, // LV5 (vanilla LV6)
            CharacterMask = 0x15, // vanilla 0x06
            Requirements =
            [
                new(LearnKind.Water, 14),
                new(LearnKind.Earth, 14),
            ],
            ShortName = "HALVAH",
            Name = "Halvah",
            Description = "Refresh [Single] [Restore status]",
        },
        new()
        {
            Id = (Skill)28,
            Note = "28",
            Cost = 18, // vanilla 4
            Speed = 10, // vanilla 90
            Exp = 24, // vanilla 10
            Unknown11 = 0x50, // LV5 (vanilla LV7)
            CharacterMask = 0x12, // vanilla 0x16
            Requirements =
            [
                new(LearnKind.Water, 26),
                new(LearnKind.Earth, 28),
            ],
            Description = "Burst of speed  [Single] [Action+]",
        },
        new()
        {
            Id = Skill.Halvah,
            Note = "Halvah",
            Power = 9999, // vanilla 7
            Cost = 28, // vanilla 5
            Speed = 20, // vanilla 120
            Exp = 28, // vanilla 10
            Effect = EffectType.Heal, // vanilla 6
            Mode = 0, // vanilla 8
            Unknown11 = 0x50, // LV5 (vanilla LV7)
            CharacterMask = 0x16, // vanilla 0x17
            Requirements =
            [
                new(LearnKind.Water, 35),
                new(LearnKind.Earth, 37),
            ],
            ShortName = "RESTORE",
            Name = "Restore",
            Description = "Fully healing [Single] [Maximum]",
        },
        new()
        {
            Id = Skill.Boom,
            Note = "Boom",
            Power = 380, // vanilla 120
            Cost = 20, // vanilla 7
            Speed = 20, // vanilla 60
            IpKnockback = 4000, // vanilla 3000
            Exp = 34, // vanilla 10
            Radius = 0, // vanilla 30
            CancelChance = 0, // vanilla 35
            Unknown10 = 0x51, // vanilla 0x52
            Unknown11 = 0x72, // LV7 (vanilla LV5)
            CharacterMask = 0x9D, // vanilla 0x8D
            Requirements =
            [
                new(LearnKind.Earth, 18),
                new(LearnKind.Fire, 16),
            ],
            Description = "Small explosion [Single] [Strong]",
        },
        new()
        {
            Id = Skill.Wow,
            Note = "Wow",
            Power = 2, // vanilla 1
            Cost = 8, // vanilla 3
            Speed = 5, // vanilla 30
            Exp = 20, // vanilla 10
            Requirements =
            [
                new(LearnKind.Earth, 10),
                new(LearnKind.Fire, 12),
            ],
            Description = "Heat 'em up  [Single] [Attack+]",
        },
        new()
        {
            Id = Skill.MeteorStrike,
            Note = "MeteorStrike",
            Power = 600, // vanilla 450
            Cost = 32, // vanilla 10
            Speed = 30, // vanilla 120
            IpKnockback = 4000, // vanilla 5000
            Exp = 34, // vanilla 30
            CancelChance = 0, // vanilla 80
            Unknown11 = 0x74, // LV7 (vanilla LV6)
            Requirements =
            [
                new(LearnKind.Earth, 44),
                new(LearnKind.Fire, 45),
            ],
            ShortName = "METEOR",
            Description = "Powerful meteorites [Single] [Extreme]",
        },
        new()
        {
            Id = Skill.BoomPow,
            Note = "BoomPow",
            Power = 280, // vanilla 220
            Cost = 30, // vanilla 10
            Speed = 30, // vanilla 90
            IpKnockback = 0, // vanilla 3500
            Exp = 14, // vanilla 10
            CancelChance = 0, // vanilla 40
            Unknown11 = 0x73, // LV7 (vanilla LV6)
            Requirements =
            [
                new(LearnKind.Earth, 26),
                new(LearnKind.Fire, 28),
            ],
            ShortName = "BOOMOR!",
            Name = "BOOMOR!",
            Description = "Erupting magma  [All] [Strong]",
        },
        new()
        {
            Id = Skill.BaBoom,
            Note = "BaBoom",
            Cost = 40, // vanilla 18
            Speed = 40, // vanilla 120
            IpKnockback = 0, // vanilla 4000
            Exp = 14, // vanilla 10
            CancelChance = 0, // vanilla 50
            CharacterMask = 0x9D, // vanilla 0x9F
            Requirements =
            [
                new(LearnKind.Earth, 47),
                new(LearnKind.Fire, 41),
            ],
            Description = "A massive explosion [All] [Strong]",
        },
        new()
        {
            Id = Skill.Crackle,
            Note = "Crackle",
            Power = 320, // vanilla 120
            Cost = 14, // vanilla 2
            Speed = 15, // vanilla 30
            IpKnockback = 4000, // vanilla 5000
            Exp = 34, // vanilla 20
            CancelChance = 0, // vanilla 30
            Unknown11 = 0x71, // LV7 (vanilla LV5)
            CharacterMask = 0x03, // vanilla 0x07
            Requirements =
            [
                new(LearnKind.Wind, 15),
                new(LearnKind.Water, 17),
            ],
            Description = "Icicle knives  [Single] [Medium]",
        },
        new()
        {
            Id = Skill.Freeze,
            Note = "Freeze",
            Power = 50, // vanilla -2
            Cost = 16, // vanilla 3
            Speed = 25, // vanilla 60
            IpKnockback = 8000, // vanilla 1000
            Exp = 14, // vanilla 10
            CancelChance = 80, // vanilla 0
            Effect = EffectType.Damage, // vanilla 7
            Mode = 1, // vanilla 3
            Unknown11 = 0x78, // LV7 (vanilla LV5)
            CharacterMask = 0x80, // vanilla 0x81
            Requirements =
            [
                new(LearnKind.Wind, 19),
                new(LearnKind.Water, 13),
            ],
            Description = "Blizzard [All] [Light] [Critical]",
        },
        new()
        {
            Id = Skill.Cold,
            Note = "Cold",
            Cost = 10, // vanilla 3
            Speed = 10, // vanilla 60
            Exp = 26, // vanilla 20
            Unknown11 = 0x70, // LV7 (vanilla LV6)
            CharacterMask = 0x84, // vanilla 0x81
            Requirements =
            [
                new(LearnKind.Wind, 20),
                new(LearnKind.Water, 20),
            ],
            Description = "Cover with ice  [Single] [Action-]",
        },
        new()
        {
            Id = Skill.Fiora,
            Note = "Fiora",
            Cost = 18, // vanilla 2
            Speed = 15, // vanilla 30
            Exp = 22, // vanilla 20
            Radius = 16, // vanilla 0
            Unknown10 = 0x52, // vanilla 0x51
            Requirements =
            [
                new(LearnKind.Wind, 29),
                new(LearnKind.Water, 27),
            ],
            Description = "Magic symbols [Area] [Skill Block]",
        },
        new()
        {
            Id = Skill.Crackling,
            Note = "Crackling",
            Power = 380, // vanilla 220
            Cost = 38, // vanilla 14
            Speed = 35, // vanilla 120
            IpKnockback = 0, // vanilla 5000
            Exp = 14, // vanilla 10
            CancelChance = 0, // vanilla 35
            Unknown11 = 0x73, // LV7 (vanilla LV6)
            CharacterMask = 0x83, // vanilla 0x97
            Requirements =
            [
                new(LearnKind.Wind, 45),
                new(LearnKind.Water, 43),
            ],
            ShortName = "ABSLTZERO",
            Name = "Absolute Zero",
            Description = "Diamond dust  [All] [Strong]",
        },
        new()
        {
            Id = Skill.Zap,
            Note = "Zap",
            Power = 240, // vanilla 180
            Cost = 22, // vanilla 11
            Speed = 20, // vanilla 60
            IpKnockback = 0, // vanilla 2500
            Exp = 14, // vanilla 10
            CancelChance = 0, // vanilla 35
            Unknown11 = 0x71, // LV7 (vanilla LV5)
            CharacterMask = 0x87, // vanilla 0x85
            Requirements =
            [
                new(LearnKind.Fire, 21),
                new(LearnKind.Wind, 18),
            ],
            Description = "Lightning ball [Area] [Medium]",
        },
        new()
        {
            Id = Skill.GadZap,
            Note = "GadZap",
            Power = 720, // vanilla 550
            Cost = 36, // vanilla 13
            Speed = 35, // vanilla 120
            IpKnockback = 4000, // vanilla 7000
            Exp = 34, // vanilla 30
            Requirements =
            [
                new(LearnKind.Fire, 62),
                new(LearnKind.Wind, 57),
            ],
            Description = "Holy lightning [Single] [Extreme]",
        },
        new()
        {
            Id = Skill.ZapAll,
            Note = "ZapAll",
            Power = 300, // vanilla 280
            Cost = 32, // vanilla 13
            Speed = 30, // vanilla 90
            IpKnockback = 0, // vanilla 3000
            Exp = 14, // vanilla 10
            CancelChance = 0, // vanilla 40
            Unknown11 = 0x73, // LV7 (vanilla LV6)
            CharacterMask = 0x93, // vanilla 0x95
            Requirements =
            [
                new(LearnKind.Fire, 29),
                new(LearnKind.Wind, 32),
            ],
            Description = "Lightning storm [All] [Strong]",
        },
        new()
        {
            Id = Skill.DragonZap,
            Note = "DragonZap",
            Power = 420, // vanilla 450
            Cost = 42, // vanilla 20
            Speed = 40, // vanilla 120
            IpKnockback = 0, // vanilla 4000
            Exp = 14, // vanilla 10
            CancelChance = 0, // vanilla 60
            CharacterMask = 0x83, // vanilla 0x93
            Requirements =
            [
                new(LearnKind.Fire, 48),
                new(LearnKind.Wind, 49),
            ],
            ShortName = "ASTRAZAP",
            Name = "Astraea Zap",
            Description = "Ultimate lightning [All] [Strong]",
        },
        new()
        {
            Id = Skill.MagicArt,
            Note = "MagicArt",
            Cost = 45, // vanilla 11
            Exp = 24, // vanilla 20
            CancelChance = 45, // vanilla 50
            Unknown11 = 0x40, // LV4 (vanilla LV5)
            Requirements =
            [
                new(LearnKind.Fire, 24),
            ],
            Description = "Animated art [Single] [Extreme]",
        },
        new()
        {
            Id = Skill.StarSymphony,
            Note = "StarSymphony",
            Power = 10, // vanilla 1
            Cost = 70, // vanilla 12
            Speed = 60, // vanilla 90
            Exp = 8, // vanilla 5
            Effect = EffectType.Heal, // vanilla 7
            Mode = 8, // vanilla 5
            Unknown11 = 0x40, // LV4 (vanilla LV6)
            Requirements =
            [
                new(LearnKind.Water, 37),
                new(LearnKind.Earth, 40),
            ],
            Description = "Call upon spirit energy [All]",
        },
        new()
        {
            Id = (Skill)46,
            Note = "46",
            Unknown11 = 0x40, // LV4 (vanilla LV7)
            Requirements =
            [
                new(LearnKind.Fire, 41),
                new(LearnKind.Wind, 41),
            ],
            Description = "Magic binding  [Area] [Seal]",
        },
        new()
        {
            Id = (Skill)47,
            Note = "47",
            Cost = 90, // vanilla 25
            Speed = 200, // vanilla 90
            Unknown10 = 0x5B, // vanilla 0x60
            Unknown11 = 0x80, // LV8 (vanilla LV5)
            Requirements =
            [
                new(LearnKind.Wind, 64),
                new(LearnKind.Water, 68),
            ],
            Description = "Commune with spirits [Freeze time]",
        },
        new()
        {
            Id = (Skill)48,
            Note = "48",
            Cost = 80, // vanilla 28
            Speed = 120, // vanilla 90
            Unknown10 = 0x5B, // vanilla 0xE3
            Unknown11 = 0x80, // LV8 (vanilla LV6)
            Requirements =
            [
                new(LearnKind.Water, 45),
                new(LearnKind.Earth, 43),
            ],
            Description = "Heart of Gaia  [All] [Full Restore]",
        },
        new()
        {
            Id = (Skill)49,
            Note = "49",
            Power = 1337, // vanilla 999
            Cost = 45, // vanilla 33
            Speed = 140, // vanilla 120
            IpKnockback = 0, // vanilla 9999
            Exp = 8, // vanilla 10
            CancelChance = 0, // vanilla 100
            Unknown10 = 0x5B, // vanilla 0x53
            Unknown11 = 0x42, // LV4 (vanilla LV7)
            Requirements =
            [
                new(LearnKind.Fire, 60),
            ],
            Description = "True Icarian power  [All] [Fixed]",
        },
    ];
}
