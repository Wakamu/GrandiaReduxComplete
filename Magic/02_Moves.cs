using Grandia.Sdk;

namespace GrandiaReduxComplete.Magic;

/// <summary>Weapon moves that differ from vanilla USA Disc 1.</summary>
internal static class Moves
{
    internal static readonly MagicEdit[] All =
    [
        new()
        {
            Id = Skill.VSlash,
            Note = "VSlash",
            Power = 180, // vanilla 250
            Cost = 40, // vanilla 14
            Speed = 20, // vanilla 30
            IpKnockback = 7000, // vanilla 3500
            CancelChance = 100, // vanilla 10
            Description = "V-shaped slash  [Single] [Critical]",
        },
        new()
        {
            Id = Skill.WBreak,
            Note = "WBreak",
            Power = 240, // vanilla 260
            Cost = 50, // vanilla 20
            Speed = 20, // vanilla 60
            IpKnockback = 3000, // vanilla 7500
            CancelChance = 70, // vanilla 75
            CharacterMask = 0x00, // vanilla 0x01
            Description = "W-S [Single] [Critical]",
        },
        new()
        {
            Id = Skill.Shockwave,
            Note = "Shockwave",
            Power = 130, // vanilla 200
            Cost = 50, // vanilla 30
            Speed = 20, // vanilla 90
            IpKnockback = 4000, // vanilla 3000
            CancelChance = 0, // vanilla 10
            ElementFlags = 64, // vanilla 0
            Requirements =
            [
                new(LearnKind.Sword, 7),
                new(LearnKind.Wind, 5),
            ],
            Description = "A shockwave [Area] [Wind]",
        },
        new()
        {
            Id = Skill.MidairCut,
            Note = "MidairCut",
            Power = 200, // vanilla 350
            Cost = 60, // vanilla 32
            Speed = 20, // vanilla 60
            IpKnockback = 3000, // vanilla 8000
            Exp = 20, // vanilla 30
            Requirements =
            [
                new(LearnKind.Ax, 6),
                new(LearnKind.Mace, 9),
            ],
            Description = "Spinning attack  [Single] [Critical]",
        },
        new()
        {
            Id = Skill.ImmortalAura,
            Note = "ImmortalAura",
            Cost = 100, // vanilla 45
            Exp = 20, // vanilla 10
            Requirements =
            [
                new(LearnKind.Sword, 23),
                new(LearnKind.Mace, 26),
                new(LearnKind.Ax, 25),
            ],
            Description = "Protects from all damage [Self] [Aura]",
        },
        new()
        {
            Id = Skill.IceSlash,
            Note = "IceSlash",
            Power = 270, // vanilla 400
            Cost = 80, // vanilla 36
            Speed = 30, // vanilla 120
            IpKnockback = 3000, // vanilla 8500
            Exp = 20, // vanilla 50
            CancelChance = 0, // vanilla 60
            Requirements =
            [
                new(LearnKind.Sword, 16),
                new(LearnKind.Wind, 14),
                new(LearnKind.Water, 12),
            ],
            Description = "Power of ice  [Single] [Blizzard]",
        },
        new()
        {
            Id = Skill.LotusCut,
            Note = "LotusCut",
            Power = 250, // vanilla 350
            Cost = 70, // vanilla 32
            Speed = 30, // vanilla 120
            IpKnockback = 3000, // vanilla 8500
            Exp = 20, // vanilla 40
            CancelChance = 0, // vanilla 60
            Requirements =
            [
                new(LearnKind.Mace, 12),
                new(LearnKind.Fire, 14),
            ],
            ShortName = "LOTUS BRK",
            Name = "Lotus Break",
            Description = "Power of fire  [Single] [Fire]",
        },
        new()
        {
            Id = Skill.ThorCut,
            Note = "ThorCut",
            Power = 280, // vanilla 450
            Cost = 90, // vanilla 40
            Speed = 30, // vanilla 120
            IpKnockback = 2000, // vanilla 9000
            Exp = 20, // vanilla 50
            CancelChance = 0, // vanilla 80
            Requirements =
            [
                new(LearnKind.Ax, 20),
                new(LearnKind.Fire, 17),
                new(LearnKind.Wind, 19),
            ],
            ShortName = "THOR MGT",
            Name = "Thor's Might",
            Description = "Power of Thor  [Single] [Lightning]",
        },
        new()
        {
            Id = (Skill)58,
            Note = "58",
            Power = 200, // vanilla 250
            Cost = 120, // vanilla 45
            Speed = 50, // vanilla 120
            IpKnockback = 0, // vanilla 5000
            Exp = 8, // vanilla 20
            CancelChance = 0, // vanilla 50
            Requirements =
            [
                new(LearnKind.Sword, 28),
                new(LearnKind.Earth, 18),
                new(LearnKind.Fire, 12),
            ],
            Description = "Gadwin's teachings [All] [Explosion]",
        },
        new()
        {
            Id = Skill.HeavenAndEarth,
            Note = "HeavenAndEarth",
            Power = 300, // vanilla 500
            Cost = 180, // vanilla 90
            Speed = 100, // vanilla 150
            IpKnockback = 0, // vanilla 9999
            Exp = 10, // vanilla 20
            CancelChance = 0, // vanilla 100
            Requirements =
            [
                new(LearnKind.Sword, 43),
                new(LearnKind.Mace, 37),
                new(LearnKind.Ax, 40),
            ],
            Description = "Justin's best move  [All]",
        },
        new()
        {
            Id = Skill.KnifeHurl,
            Note = "KnifeHurl",
            Power = 235, // vanilla 200
            Cost = 50, // vanilla 10
            Speed = 50, // vanilla 30
            IpKnockback = 2000, // vanilla 3500
            CancelChance = 100, // vanilla 50
            Requirements =
            [
                new(LearnKind.Dagger, 1),
            ],
            ShortName = "FLURRY",
            Name = "Flurry of Knives",
            Description = "Hurl knives  [Single] [Critical]",
        },
        new()
        {
            Id = Skill.RandomHurl,
            Note = "RandomHurl",
            Power = 225, // vanilla 180
            Cost = 90, // vanilla 28
            Speed = 50, // vanilla 90
            IpKnockback = 0, // vanilla 2500
            CancelChance = 0, // vanilla 10
            Requirements =
            [
                new(LearnKind.Dagger, 16),
            ],
            ShortName = "DAGGERDNC",
            Name = "Deadly Dagger Dance",
            Description = "Fan of knives  [All]",
        },
        new()
        {
            Id = Skill.ParalyzeWhip,
            Note = "ParalyzeWhip",
            Power = 235, // vanilla 150
            Cost = 40, // vanilla 15
            Speed = 30, // vanilla 60
            IpKnockback = 8000, // vanilla 3000
            CancelChance = 100, // vanilla 15
            Mode = 0, // vanilla 4
            Requirements =
            [
                new(LearnKind.Whip, 1),
            ],
            ShortName = "POWERLASH",
            Name = "Power Lash",
            Description = "Whip attack  [Single] [Critical]",
        },
        new()
        {
            Id = Skill.FireWhip,
            Note = "FireWhip",
            Cost = 60, // vanilla 32
            Speed = 30, // vanilla 75
            IpKnockback = 0, // vanilla 3000
            Exp = 12, // vanilla 30
            CancelChance = 0, // vanilla 30
            Requirements =
            [
                new(LearnKind.Whip, 13),
                new(LearnKind.Fire, 15),
            ],
            ShortName = "FLAMESPIN",
            Name = "Flame Spin",
            Description = "Flaming whip  [Area] [Fire]",
        },
        new()
        {
            Id = Skill.ZapWhip,
            Note = "ZapWhip",
            Power = 350, // vanilla 450
            Cost = 80, // vanilla 38
            Speed = 50, // vanilla 120
            IpKnockback = 4500, // vanilla 9000
            Exp = 20, // vanilla 50
            CancelChance = 0, // vanilla 100
            Requirements =
            [
                new(LearnKind.Whip, 23),
                new(LearnKind.Fire, 19),
                new(LearnKind.Wind, 21),
            ],
            ShortName = "LGTSTRIKE",
            Name = "Lightning Strike",
            Description = "Lightning whip  [Single] [Lightning]",
        },
        new()
        {
            Id = Skill.FireAway,
            Note = "FireAway",
            Power = 140, // vanilla 180
            Cost = 60, // vanilla 28
            Speed = 20, // vanilla 90
            IpKnockback = 0, // vanilla 2500
            CancelChance = 0, // vanilla 10
            Description = "Shoot randomly  [All]",
        },
        new()
        {
            Id = Skill.RoundWhacker,
            Note = "RoundWhacker",
            Power = 140, // vanilla 200
            Cost = 50, // vanilla 30
            Speed = 20, // vanilla 75
            IpKnockback = 0, // vanilla 3000
            CancelChance = 50, // vanilla 10
            ElementFlags = 128, // vanilla 0
            Mode = 2, // vanilla 0
            Requirements =
            [
                new(LearnKind.Mace, 8),
                new(LearnKind.Earth, 6),
            ],
            ShortName = "EARTH PND",
            Name = "Earth Pound",
            Description = "Ground pound [Area] [Earth]",
        },
        new()
        {
            Id = Skill.PuffyFire,
            Note = "PuffyFire",
            Power = 220, // vanilla 250
            Cost = 100, // vanilla 36
            Speed = 30, // vanilla 75
            IpKnockback = 0, // vanilla 3500
            Exp = 12, // vanilla 20
            CancelChance = 0, // vanilla 30
            Requirements =
            [
                new(LearnKind.Bow, 14),
                new(LearnKind.Fire, 11),
            ],
            Description = "Breath fire [Area] [Fire]",
        },
        new()
        {
            Id = Skill.Yawn,
            Note = "Yawn",
            Power = 4, // vanilla 3
            Cost = 80, // vanilla 5
            Speed = 30, // vanilla 60
            Exp = 16, // vanilla 20
            ElementFlags = 160, // vanilla 32
            Mode = 5, // vanilla 2
            Requirements =
            [
                new(LearnKind.Mace, 12),
                new(LearnKind.Water, 9),
                new(LearnKind.Earth, 11),
            ],
            ShortName = "PUFY GAS",
            Name = "Puffy \"Gas\"",
            Description = "Release \"gas\" [Area] [Plague]",
        },
        new()
        {
            Id = Skill.PuffyKick,
            Note = "PuffyKick",
            Power = 160, // vanilla 200
            Cost = 30, // vanilla 8
            Speed = 20, // vanilla 30
            IpKnockback = 2000, // vanilla 3500
            CancelChance = 100, // vanilla 10
            Description = "Throw Puffy  [Single] [Critical]",
        },
        new()
        {
            Id = (Skill)70,
            Note = "70",
            Power = 50, // vanilla 25
            Cost = 90, // vanilla 18
            Speed = 70, // vanilla 30
            Exp = 5, // vanilla 3
            Requirements =
            [
                new(LearnKind.Mace, 1),
            ],
            Description = "Cheer with Puffy [All] [Healing]",
        },
        new()
        {
            Id = (Skill)71,
            Note = "71",
            Power = 2, // vanilla 1
            Cost = 70, // vanilla 16
            Speed = 30, // vanilla 60
            Exp = 4, // vanilla 8
            Requirements =
            [
                new(LearnKind.Mace, 10),
                new(LearnKind.Earth, 10),
                new(LearnKind.Fire, 12),
            ],
            Description = "Raise morale [All] [Attack+]",
        },
        new()
        {
            Id = Skill.EruptionCut,
            Note = "EruptionCut",
            Power = 100, // vanilla 200
            Cost = 100, // vanilla 24
            Speed = 120, // vanilla 60
            IpKnockback = 4000, // vanilla 3000
            Exp = 22, // vanilla 30
            CancelChance = 50, // vanilla 100
            ElementFlags = 0, // vanilla 144
            Effect = EffectType.ProbDamage, // vanilla 3
            Mode = 0, // vanilla 2
            Requirements =
            [
                new(LearnKind.Sword, 26),
            ],
            ShortName = "DEATHBLOW",
            Name = "Death Blow",
            Description = "Sudden death  [Single] [Death]",
        },
        new()
        {
            Id = Skill.FlyingDragonCut,
            Note = "FlyingDragonCut",
            Power = 200, // vanilla 160
            Cost = 40, // vanilla 14
            Speed = 20, // vanilla 30
            IpKnockback = 7000, // vanilla 3500
            Exp = 20, // vanilla 10
            Radius = 0, // vanilla 15
            CancelChance = 100, // vanilla 30
            Unknown10 = 0x59, // vanilla 0x5A
            Requirements =
            [
                new(LearnKind.Sword, 1),
            ],
            Description = "Lunge attck [Single] [Critical]",
        },
        new()
        {
            Id = Skill.DragonCut,
            Note = "DragonCut",
            Power = 210, // vanilla 250
            Cost = 120, // vanilla 45
            Speed = 80, // vanilla 120
            IpKnockback = 0, // vanilla 5000
            Exp = 8, // vanilla 20
            CancelChance = 0, // vanilla 50
            Requirements =
            [
                new(LearnKind.Sword, 28),
                new(LearnKind.Earth, 18),
                new(LearnKind.Fire, 13),
            ],
            Description = "Gadwin's best move [All] [Explosion]",
        },
        new()
        {
            Id = Skill.MistHide,
            Note = "MistHide",
            Cost = 10, // vanilla 5
            Speed = 10, // vanilla 15
            Exp = 8, // vanilla 5
        },
        new()
        {
            Id = Skill.Doppelganger,
            Note = "Doppelganger",
            Power = 400, // vanilla 300
            Cost = 150, // vanilla 27
            Speed = 100, // vanilla 90
            Description = "Divide self and attack  [Single]",
        },
        new()
        {
            Id = Skill.Dethsword,
            Note = "Dethsword",
            Cost = 80, // vanilla 25
            Speed = 150, // vanilla 60
            IpKnockback = 500, // vanilla 9999
            Exp = 20, // vanilla 30
            Requirements =
            [
                new(LearnKind.Dagger, 22),
                new(LearnKind.Sword, 20),
            ],
            Description = "Rapp's best move [Single] [Critical]",
        },
        new()
        {
            Id = Skill.Missile,
            Note = "Missile",
            IpKnockback = 3000, // vanilla 3500
            Description = "Barrage of throwing weapons [Single]",
        },
        new()
        {
            Id = Skill.Fireball,
            Note = "Fireball",
            Power = 200, // vanilla 250
            IpKnockback = 0, // vanilla 3500
            Exp = 10, // vanilla 20
            CancelChance = 20, // vanilla 30
            Description = "Throw fireballs  [Area] [Fire]",
        },
        new()
        {
            Id = Skill.Sidethrow,
            Note = "Sidethrow",
            Power = 140, // vanilla 200
            Cost = 28, // vanilla 40
            Speed = 50, // vanilla 120
            IpKnockback = 0, // vanilla 5000
            CancelChance = 0, // vanilla 50
            Description = "Attack by side throwing  [All]",
        },
        new()
        {
            Id = Skill.Discutter,
            Note = "Discutter",
            Power = 195, // vanilla 180
            Cost = 34, // vanilla 30
            Speed = 40, // vanilla 90
            IpKnockback = 1000, // vanilla 3500
            Exp = 14, // vanilla 10
            CancelChance = 50, // vanilla 25
            Description = "Rapp throws his secret weapon [Line]",
        },
        new()
        {
            Id = Skill.DemonBall,
            Note = "DemonBall",
            Power = 350, // vanilla 400
            Cost = 45, // vanilla 40
            IpKnockback = 6000, // vanilla 7500
            Exp = 12, // vanilla 50
            CancelChance = 65, // vanilla 100
            Description = "Rapp's ball attack [Single] [Critical]",
        },
        new()
        {
            Id = Skill.NeoDemonBall,
            Note = "NeoDemonBall",
            Power = 340, // vanilla 450
            Cost = 130, // vanilla 85
            IpKnockback = 0, // vanilla 9000
            Exp = 8, // vanilla 20
            CancelChance = 50, // vanilla 100
            Description = "Rapp's true ball attack  [All]",
        },
        new()
        {
            Id = (Skill)84,
            Note = "84",
            Power = 155, // vanilla 200
            Cost = 30, // vanilla 40
            Speed = 70, // vanilla 120
            IpKnockback = 0, // vanilla 5000
            Description = "Pounding earth attack  [All]",
        },
        new()
        {
            Id = (Skill)85,
            Note = "85",
            ShortName = "HRUN",
        },
        new()
        {
            Id = (Skill)87,
            Note = "87",
            IpKnockback = 3500, // vanilla 4000
            Description = "Ranged drop kick [Single] [Critical]",
        },
        new()
        {
            Id = (Skill)88,
            Note = "88",
            Description = "Milda's best move [Single] [Critical]",
        },
        new()
        {
            Id = Skill.MogayShot,
            Note = "MogayShot",
            Power = 360, // vanilla 250
            Cost = 18, // vanilla 14
            IpKnockback = 3500, // vanilla 2500
            Description = "Aimed attack  [Single] [Critical]",
        },
        new()
        {
            Id = Skill.MogayBomb,
            Note = "MogayBomb",
            Power = 180, // vanilla 150
            Cost = 25, // vanilla 38
            Speed = 60, // vanilla 90
            IpKnockback = 0, // vanilla 9999
            Description = "Throw lots of bombs  [Area] [Critical]",
        },
        new()
        {
            Id = Skill.MogayHypo,
            Note = "MogayHypo",
            Power = 50, // vanilla 45
            Cost = 20, // vanilla 45
            Description = "Energy shot [Single] [SP restore]",
        },
        new()
        {
            Id = Skill.PowerUp,
            Note = "PowerUp",
            Power = 2, // vanilla 1
            Cost = 30, // vanilla 20
            Speed = 40, // vanilla 60
            Description = "Adrenaline shot [Single] [All+]",
        },
        new()
        {
            Id = Skill.MogayPickpocket,
            Note = "MogayPickpocket",
            Power = 75, // vanilla 50
            Cost = 5, // vanilla 10
            Description = "Steal an item [Single] [Stealing]",
        },
        new()
        {
            Id = Skill.Redshock,
            Note = "Redshock",
            Power = 800, // vanilla 400
            IpKnockback = 5000, // vanilla 7000
            Exp = 40, // vanilla 30
            Description = "Splendid attack [Single] [Critical]",
        },
        new()
        {
            Id = Skill.EnchantmentDance,
            Note = "EnchantmentDance",
            Power = 30, // vanilla 4
            Cost = 36, // vanilla 34
            Speed = 30, // vanilla 90
            Exp = 35, // vanilla 20
            Requirements =
            [
                new(LearnKind.Mace, 12),
            ],
            Description = "Absorb MP [Single] [MP restore]",
        },
        new()
        {
            Id = Skill.Protect,
            Note = "Protect",
            Cost = 32, // vanilla 21
            Speed = 40, // vanilla 120
            Exp = 28, // vanilla 10
            Unknown11 = 0x50, // LV5 (vanilla LV7)
            CharacterMask = 0x84, // vanilla 0x86
            Requirements =
            [
                new(LearnKind.Water, 47),
                new(LearnKind.Wind, 49),
            ],
            ShortName = "CRYSTWALL",
            Description = "Prevents all damage [Single] [Aura]",
        },
        new()
        {
            Id = Skill.Diggin,
            Note = "Diggin",
            Cost = 10, // vanilla 1
            Speed = 10, // vanilla 30
            Exp = 10, // vanilla 7
            Radius = 20, // vanilla 15
            CharacterMask = 0x8C, // vanilla 0x9F
            Requirements =
            [
                new(LearnKind.Earth, 5),
            ],
            Description = "Soul of earth [All] [Defense+]",
        },
        new()
        {
            Id = Skill.RestoreLv3Mp,
            Note = "RestoreLv3Mp",
            Cost = 100, // vanilla 0
            Unknown15 = 0x00, // vanilla 0x3F
            ShortName = "INVOKE",
            Name = "Invoke",
            Description = "Invoke spirit energy [Self]",
        },
        new()
        {
            Id = Skill.ParalyzeItem,
            Note = "ParalyzeItem",
            Power = 11, // vanilla 3
            Cost = 30, // vanilla 0
            Speed = 25, // vanilla 30
            IpKnockback = 0, // vanilla 3000
            Exp = 12, // vanilla 0
            ElementFlags = 80, // vanilla 0
            Unknown11 = 0x71, // LV7 (vanilla LV4)
            Unknown15 = 0x00, // vanilla 0x3F
            CharacterMask = 0x02, // vanilla 0x00
            Requirements =
            [
                new(LearnKind.Wind, 34),
                new(LearnKind.Fire, 32),
            ],
            ShortName = "SHOCK",
            Name = "Shock",
            Description = "A jolting [Area] [Paralyze]",
        },
        new()
        {
            Id = Skill.DiseaseItem,
            Note = "DiseaseItem",
            Power = 4, // vanilla 3
            Cost = 18, // vanilla 0
            Speed = 15, // vanilla 30
            IpKnockback = 0, // vanilla 3000
            Exp = 12, // vanilla 0
            ElementFlags = 160, // vanilla 0
            Unknown11 = 0x71, // LV7 (vanilla LV4)
            Unknown15 = 0x00, // vanilla 0x3F
            ShortName = "TORMENT",
            Name = "Torment",
            Description = "A miasma [Area] [Plague]",
        },
        new()
        {
            Id = Skill.CureParalysis,
            Note = "CureParalysis",
            Power = 2, // vanilla 7
            Cost = 5, // vanilla 0
            Speed = 5, // vanilla 30
            Exp = 22, // vanilla 0
            ElementFlags = 128, // vanilla 0
            Effect = EffectType.PowerUpDown, // vanilla 6
            Mode = 1, // vanilla 3
            Unknown11 = 0x50, // LV5 (vanilla LV4)
            Unknown15 = 0x00, // vanilla 0x3F
            CharacterMask = 0x0A, // vanilla 0x00
            Requirements =
            [
                new(LearnKind.Earth, 1),
            ],
            ShortName = "AEGIS",
            Name = "Aegis",
            Description = "Earthen shield [Single] [Defense+]",
        },
        new()
        {
            Id = Skill.CurePlague,
            Note = "CurePlague",
            Power = 11, // vanilla 7
            Cost = 8, // vanilla 0
            Speed = 5, // vanilla 30
            Exp = 26, // vanilla 0
            ElementFlags = 96, // vanilla 0
            Effect = EffectType.Status, // vanilla 6
            Unknown10 = 0x51, // vanilla 0xE1
            Unknown11 = 0x70, // LV7 (vanilla LV4)
            Unknown15 = 0x00, // vanilla 0x3F
            CharacterMask = 0x04, // vanilla 0x00
            Requirements =
            [
                new(LearnKind.Water, 15),
                new(LearnKind.Wind, 18),
            ],
            ShortName = "CURSE",
            Name = "Curse",
            Description = "A hex [Single] [Plague]",
        },
        new()
        {
            Id = Skill.CureBlind,
            Note = "CureBlind",
            Power = 210, // vanilla 7
            Cost = 10, // vanilla 0
            Speed = 15, // vanilla 30
            IpKnockback = 4000, // vanilla 0
            Exp = 30, // vanilla 0
            ElementFlags = 32, // vanilla 0
            Effect = EffectType.Damage, // vanilla 6
            Mode = 1, // vanilla 2
            Unknown10 = 0x51, // vanilla 0x61
            Unknown11 = 0x60, // LV6 (vanilla LV4)
            Unknown15 = 0x00, // vanilla 0x3F
            CharacterMask = 0x06, // vanilla 0x00
            Requirements =
            [
                new(LearnKind.Water, 4),
            ],
            ShortName = "BUBBLE",
            Name = "Bubble",
            Description = "Water attack [Single] [Medium]",
        },
        new()
        {
            Id = Skill.TortesWhistle,
            Note = "TortesWhistle",
            Power = 210, // vanilla 7
            Cost = 26, // vanilla 0
            Speed = 25, // vanilla 30
            Exp = 10, // vanilla 0
            ElementFlags = 32, // vanilla 0
            Effect = EffectType.Damage, // vanilla 6
            Mode = 1, // vanilla 2
            Unknown10 = 0x53, // vanilla 0x63
            Unknown11 = 0x60, // LV6 (vanilla LV4)
            Unknown15 = 0x00, // vanilla 0x3F
            CharacterMask = 0x04, // vanilla 0x00
            Requirements =
            [
                new(LearnKind.Water, 16),
            ],
            ShortName = "BUBBLING",
            Name = "Bubbling",
            Description = "Water attack [All] [Medium]",
        },
        new()
        {
            Id = Skill.SmellingSaltsSkill,
            Note = "SmellingSaltsSkill",
            Power = 11, // vanilla 7
            Cost = 6, // vanilla 0
            Speed = 5, // vanilla 30
            Exp = 25, // vanilla 0
            ElementFlags = 32, // vanilla 0
            Effect = EffectType.Status, // vanilla 6
            Unknown10 = 0x51, // vanilla 0x61
            Unknown11 = 0x60, // LV6 (vanilla LV4)
            Unknown15 = 0x00, // vanilla 0x3F
            CharacterMask = 0x06, // vanilla 0x00
            Requirements =
            [
                new(LearnKind.Water, 8),
            ],
            ShortName = "CONFUSE",
            Name = "Confuse",
            Description = "[Single] [Confusion] [Critical]",
        },
        new()
        {
            Id = Skill.BondOfTrust,
            Note = "BondOfTrust",
            Power = 8000, // vanilla 5000
            Cost = 4, // vanilla 0
            Speed = 5, // vanilla 30
            Exp = 18, // vanilla 0
            ElementFlags = 64, // vanilla 0
            Unknown11 = 0x50, // LV5 (vanilla LV4)
            Unknown15 = 0x00, // vanilla 0x3F
            CharacterMask = 0x06, // vanilla 0x00
            Requirements =
            [
                new(LearnKind.Wind, 3),
            ],
            ShortName = "HASTE",
            Name = "Haste",
            Description = "Winds of time [Single] [IP+]",
        },
        new()
        {
            Id = Skill.RestoreAllMpParty,
            Note = "RestoreAllMpParty",
            ShortName = "INVOKE",
        },
        new()
        {
            Id = Skill.UnblockMagic,
            Note = "UnblockMagic",
            Power = 50, // vanilla 7
            Unknown10 = 0x58, // vanilla 0xE1
            CharacterMask = 0x1F, // vanilla 0x00
            Requirements =
            [
                new(LearnKind.Fire, 1),
                new(LearnKind.Earth, 1),
            ],
            Cost = 100, // vanilla 0
            Speed = 120, // vanilla 30
            Effect = EffectType.Heal, // vanilla 6
            Mode = (int) HealMode.AllMp, // HealMode.Sp (vanilla 7)
            ShortName = "INVOKE",
            Name = "Invoke",
            Description = "Invoke spirit energy [Self]",
        },
        new()
        {
            Id = (Skill)116,
            Note = "116",
            Cost = 10, // vanilla 0
            Speed = 60, // vanilla 90
            Exp = 5, // vanilla 0
            ElementFlags = 128, // vanilla 0
            Unknown15 = 0x00, // vanilla 0x3F
        },
        new()
        {
            Id = Skill.Protein,
            Note = "Protein",
            Power = 3, // vanilla 1
            Cost = 10, // vanilla 0
            Speed = 5, // vanilla 30
            Exp = 18, // vanilla 0
            ElementFlags = 144, // vanilla 0
            Unknown11 = 0x50, // LV5 (vanilla LV4)
            Unknown15 = 0x00, // vanilla 0x3F
            CharacterMask = 0x1A, // vanilla 0x00
            Requirements =
            [
                new(LearnKind.Fire, 9),
                new(LearnKind.Earth, 13),
            ],
            ShortName = "STAR",
            Name = "Star",
            Description = "Spirit power [Single] [MAXHP+]",
        },
    ];
}
