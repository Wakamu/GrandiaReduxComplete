using Grandia.Sdk;

namespace GrandiaReduxComplete.Characters;

internal sealed class CharacterEdit
{
    public required CharacterId Id { get; init; }

    /// <summary>Vanilla join level. Used only to recognize a just-joined block.</summary>
    public int JoinLevel { get; init; } = 1;

    /// <summary>Complete MCHAR +6. HD Justin is stored as 2; PPF is 1.</summary>
    public int StartLevel { get; init; } = 1;

    public int StartHp { get; init; }
    public int StartSp { get; init; }
    public int StartMp1 { get; init; }
    public int StartMp2 { get; init; }
    public int StartMp3 { get; init; }
    public int StartStr { get; init; }
    public int StartVit { get; init; }
    public int StartWit { get; init; }
    public int StartAgi { get; init; }

    /// <summary>Complete MCHAR +0x44 bag (0-terminated). Applied on HD start.</summary>
    public Item[] StartItems { get; init; } = [];

    /// <summary>Complete MCHAR +0x38..+0x42 equip. Applied on HD start.</summary>
    public Item[] StartEquip { get; init; } = [];

    /// <summary>Vanilla HD bag. Used to restamp if stats already landed but bag did not.</summary>
    public Item[] VanillaItems { get; init; } = [];

    public bool Matches(CharacterEvent e) => e.Id == Id;

    public void Apply(CharacterEvent e)
    {
        var start = LooksLikeHdStart(e);
        if (start)
        {
            // HD new-game Justin is L2; Complete MCHAR +6 is 1. Later joiners
            // keep the HD join level — only force the new-game range (1–2).
            if (StartLevel is > 0 and <= 2)
            {
                e.Level = StartLevel;
                e.Exp = 0;
            }

            e.MaxHp = Math.Max(1, StartHp);
            e.Hp = e.MaxHp;
            e.MaxSp = Math.Max(1, StartSp);
            e.Sp = e.MaxSp;
            e.Mp1 = StartMp1;
            e.Mp2 = StartMp2;
            e.Mp3 = StartMp3;
            e.Str = Math.Max(1, StartStr);
            e.Vit = Math.Max(1, StartVit);
            e.Wit = Math.Max(1, StartWit);
            e.Agi = Math.Max(1, StartAgi);
        }

        if (StartItems.Length > 0 && (start || SameBag(e.Items, VanillaItems)))
        {
            WriteSlots(e.Items, StartItems);
        }

        if (StartEquip.Length > 0 && start)
        {
            WriteSlots(e.Equip, StartEquip);
        }

        if (Id == CharacterId.Justin)
        {
            e.Forget(Skill.WBreak);
        }
    }

    /// <summary>
    /// HD copies vanilla MCHAR (Justin L2, MP 8/3/1). Stamp once while that
    /// snapshot — or the old fake HP/SP-growth apply — is still live. Later
    /// levels keep the game's own growth.
    /// </summary>
    private bool LooksLikeHdStart(CharacterEvent e)
    {
        if (e.Level > Math.Max(StartLevel, JoinLevel) + 1)
        {
            return false;
        }

        if (StartMp1 > 0)
        {
            return e.Mp1 < StartMp1;
        }

        return e.MaxHp < StartHp || e.MaxSp < StartSp;
    }

    private static bool SameBag(Item[] current, Item[] vanilla)
    {
        if (vanilla.Length == 0)
        {
            return false;
        }

        var a = NonZero(current);
        var b = NonZero(vanilla);
        if (a.Count != b.Count)
        {
            return false;
        }

        for (var i = 0; i < a.Count; i++)
        {
            if (a[i] != b[i])
            {
                return false;
            }
        }

        return true;
    }

    private static List<Item> NonZero(Item[] slots)
    {
        var list = new List<Item>();
        foreach (var id in slots)
        {
            if (id == 0)
            {
                break;
            }

            list.Add(id);
        }

        return list;
    }

    private static void WriteSlots(Item[] dest, Item[] src)
    {
        for (var i = 0; i < dest.Length; i++)
        {
            dest[i] = i < src.Length ? src[i] : 0;
        }
    }
}
