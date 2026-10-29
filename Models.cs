namespace LojaGamesRetro;

internal record GameItem(string Name, string Platform, decimal Price, string Icon);

internal record Sale(string Customer, string Game, int Quantity, decimal UnitPrice, DateTime Date)
{
    public decimal Total => Quantity * UnitPrice;
}
