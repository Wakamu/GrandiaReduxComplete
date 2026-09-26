using Grandia.Sdk;

namespace GrandiaReduxComplete.Magic;

/// <summary>
/// One party spell or weapon move. Leave a field null to keep vanilla.
/// </summary>
internal sealed class MagicEdit
{
    public required Skill Id { get; init; }

    public string Note { get; init; } = "";

    public int? Power { get; init; }
    public int? Cost { get; init; }
    public int? Speed { get; init; }
    public int? IpKnockback { get; init; }
    public int? Exp { get; init; }
    public int? Radius { get; init; }
    public int? Distance { get; init; }
    public int? CancelChance { get; init; }
    public int? CharacterMask { get; init; }
    public int? ElementFlags { get; init; }
    public EffectType? Effect { get; init; }
    public int? Mode { get; init; }
    public LearnRequirement[]? Requirements { get; init; }
    public string? Name { get; init; }
    public string? ShortName { get; init; }
    public string? Description { get; init; }
    public int? CombatId { get; init; }
    public int? Unknown10 { get; init; }
    public int? Unknown11 { get; init; }
    public int? Unknown15 { get; init; }

    public bool Matches(MagicEvent e) => e.Id == Id;

    public void Apply(MagicEvent e)
    {
        if (Power is int power)
        {
            e.Power = power;
        }

        if (Cost is int cost)
        {
            e.Cost = cost;
        }

        if (Speed is int speed)
        {
            e.Speed = speed;
        }

        if (IpKnockback is int knockback)
        {
            e.IpKnockback = knockback;
        }

        if (Exp is int exp)
        {
            e.Exp = exp;
        }

        if (Radius is int radius)
        {
            e.Radius = radius;
        }

        if (Distance is int distance)
        {
            e.Distance = distance;
        }

        if (CancelChance is int cancel)
        {
            e.CancelChance = cancel;
        }

        if (CharacterMask is int mask)
        {
            e.CharacterMask = mask;
        }

        if (ElementFlags is int flags)
        {
            e.ElementFlags = flags;
        }

        if (Effect is EffectType effect)
        {
            e.Effect = effect;
        }

        if (Mode is int mode)
        {
            e.Mode = mode;
        }

        if (Requirements is { } reqs)
        {
            e.Requirements.Clear();
            e.Requirements.AddRange(reqs);
        }

        if (Name is { } name)
        {
            e.Name = name;
        }

        if (ShortName is { } shortName)
        {
            e.ShortName = shortName;
        }

        if (Description is { } description)
        {
            e.Description = description;
        }

        if (CombatId is int combatId)
        {
            e.CombatId = combatId;
        }

        if (Unknown10 is int unknown10)
        {
            e.Unknown10 = unknown10;
        }

        if (Unknown11 is int unknown11)
        {
            e.Unknown11 = unknown11;
        }

        if (Unknown15 is int unknown15)
        {
            e.Unknown15 = unknown15;
        }
    }
}
