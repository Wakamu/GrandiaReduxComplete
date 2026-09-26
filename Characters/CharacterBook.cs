using Grandia.Sdk;
using GrandiaReduxComplete.Magic;

namespace GrandiaReduxComplete.Characters;

internal static class CharacterBook
{
    public static void Apply(CharacterEvent e)
    {
        if (Game.Flags.IsSet(MagicBook.Disc2Flag))
        {
            return;
        }

        foreach (var edit in Starts.All)
        {
            if (edit.Matches(e))
            {
                edit.Apply(e);
                return;
            }
        }
    }
}
