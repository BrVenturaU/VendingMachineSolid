public class VendingMachine: IFriendlyVendingMachine{
    private readonly IMenuLoader _menuLoader;

    public VendingMachine(IMenuLoader menuLoader)
    {
        _menuLoader = menuLoader;
    }

    public void SayHello(){
        Console.WriteLine("Por favor, ingresa tu nombre");
        var username = Console.ReadLine();
        Console.WriteLine($"Hola apreciado {username}, selecciona lo que prefieras");
    }

    public void ShowTime(){
        var date = DateTime.Now.ToLocalTime();
        Console.WriteLine($"Fecha {date:d} a las {date:t}");
    }

    public void DisplayMenu(){
        var products = _menuLoader.LoadMenu();
        foreach(var product in products){
            Console.WriteLine(product.ToString());
        }
    }

    public void SayBye(){
        Console.Write("Presiona cualquier tecla para salir...");
        Console.ReadKey(true);
    }

    public void Start(){
        SayHello();
        ShowTime();
        DisplayMenu();
        SayBye();
    }
}