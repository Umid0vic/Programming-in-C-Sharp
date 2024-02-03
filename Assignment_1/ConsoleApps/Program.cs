// Created by Osman Said on 2024-02-02

namespace ConsoleApps;

class Program
{
    static void Main(string[] args)
    {
        // Configure the console window's appearance.
        SetupConsoleWindow();

        // Create a pet object
        Pet petObj = new Pet();
        petObj.Start();

        Console.WriteLine("Press Enter to start next part!");
        Console.ReadLine();

        // Create a TicketSeller object 
        TicketSeller ticketSellerObj = new TicketSeller();
        ticketSellerObj.Start();

        Console.WriteLine("Press Enter to start next part!");
        Console.ReadLine();

        // Create a Album object 
        Album albumObj = new Album();
        albumObj.Start();

        Console.WriteLine("Press Enter to start next part!");
        Console.ReadLine();

        // Smartphone object
        Smartphone smartphoneObj = new Smartphone();
        smartphoneObj.Start();

        Console.WriteLine("Thanks!");
        Console.ReadLine();
    }

    // Configures the console window's appearance for better readability.
    static void SetupConsoleWindow()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear(); // Paint the background with above color
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Title = "My Console Classes";
    }
}