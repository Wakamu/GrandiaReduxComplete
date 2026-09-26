using Grandia.Sdk;
using GrandiaReduxComplete.Items;
using GrandiaReduxComplete.Magic;

namespace GrandiaReduxComplete.Shops;

internal static class ShopBook
{
    public static void Apply(ShopOpenEvent e)
    {
        if (Game.Flags.IsSet(MagicBook.Disc2Flag) || e.Kind != ShopKind.Buy)
        {
            return;
        }

        foreach (var edit in Stock.All)
        {
            if (edit.Matches(e))
            {
                edit.Apply(e);
                break;
            }
        }

        foreach (var item in e.Weapons.Concat(e.Armor).Concat(e.Goods))
        {
            if (ItemBook.TryCost(item, out var gold))
            {
                e.SetPrice(item, gold);
            }
        }
    }
}
