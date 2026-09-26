using Grandia.Sdk;
using GrandiaReduxComplete.Magic;

namespace GrandiaReduxComplete.Items;

/// <summary>
/// Applies the Complete WINDT sec3 catalog. Re-run on every
/// <see cref="ItemEvent"/> — the game recopies vanilla tables each load.
/// </summary>
internal static class ItemBook
{
    private static readonly ItemEdit[] All =
    [
        ..Ids001.All,
        ..Ids128.All,
        ..Ids256.All,
        ..Ids384.All,
    ];

    public static void Apply(ItemEvent e)
    {
        if (Game.Flags.IsSet(MagicBook.Disc2Flag))
        {
            return;
        }

        foreach (var edit in All)
        {
            if (edit.Matches(e))
            {
                edit.Apply(e);
                return;
            }
        }
    }

    public static bool TryCost(Item id, out int cost)
    {
        foreach (var edit in All)
        {
            if (edit.Id == id && edit.Cost is int gold)
            {
                cost = gold;
                return true;
            }
        }

        cost = 0;
        return false;
    }
}
