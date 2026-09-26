using Grandia.Sdk;

namespace GrandiaReduxComplete.Magic;

/// <summary>
/// Applies the Complete WINDT spell / move delta. Disc 1 only —
/// skip after story flag 289 (PS1 CD2 swap).
/// </summary>
internal static class MagicBook
{
    internal const uint Disc2Flag = 289;

    private static readonly MagicEdit[] All =
    [
        ..Spells.All,
        ..Moves.All,
    ];

    public static void Apply(MagicEvent e)
    {
        if (Game.Flags.IsSet(Disc2Flag))
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
}
