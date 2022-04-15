public class HighEfficiencyVendingMachine : IVendingMachine
{
    private readonly IMenuLoader _menuLoader;

    public HighEfficiencyVendingMachine(IMenuLoader menuLoader)
    {
        _menuLoader = menuLoader;
    }
    
    public void DisplayMenu()
    {
        var products = _menuLoader.LoadMenu();
        foreach(var product in products)
            Console.WriteLine(product.ToString());
    }

    public void Start()
    {
        DisplayMenu();
    }
}