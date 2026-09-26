using Grandia.Sdk;
using GrandiaReduxComplete.Magic;

namespace GrandiaReduxComplete.Enemies;

internal static class EnemyBook
{
    private static readonly EnemyEdit[] All =
    [
        ..Ids001.All,
        ..Ids064.All,
        ..Ids128.All,
        ..Ids192.All,
    ];

    public static void Apply(EnemyLoadedEvent e)
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
}
