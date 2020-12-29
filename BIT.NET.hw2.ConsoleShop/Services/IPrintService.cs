namespace BIT.NET.hw5.ConsoleShop.Services
{
    public interface IPrintService
    {
        void AddPrint(string itemAdded, int quantity);
        void BalancePrint(double balance);
        void BuyPrint(string operationResult, int quantity, string itemBought);
        void ItemList(string name, double price, int quantity);
        void ItemListTitle();
        void PrintMenu();
        void StartMessage();
    }
}