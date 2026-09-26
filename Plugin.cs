using Grandia.Sdk;
using GrandiaReduxComplete.Characters;
using GrandiaReduxComplete.Enemies;
using GrandiaReduxComplete.Items;
using GrandiaReduxComplete.Magic;
using GrandiaReduxComplete.Shops;

[Mod("GrandiaReduxComplete", "1.0.0", Description = "Grandia ReDux Complete 1.0 (disc 1) for Grandia HD Remaster")]
public sealed class Plugin
{
    [Init]
    public void Init(ModContext ctx)
    {
        ctx.Log("Grandia Redux Complete (disc 1 tables)");
    }

    [OnCharacter]
    public void OnCharacter(CharacterEvent e)
    {
        CharacterBook.Apply(e);
    }

    [OnItem]
    public void OnItem(ItemEvent e)
    {
        ItemBook.Apply(e);
    }

    [OnMagic]
    public void OnMagic(MagicEvent e)
    {
        MagicBook.Apply(e);
    }

    [OnEnemyLoaded]
    public void OnEnemyLoaded(EnemyLoadedEvent e)
    {
        EnemyBook.Apply(e);
    }

    [OnShopOpen]
    public void OnShopOpen(ShopOpenEvent e)
    {
        ShopBook.Apply(e);
    }
}
