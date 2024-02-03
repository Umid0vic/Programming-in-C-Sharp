// Created by Osman Said on 2024-02-02

namespace ConsoleApps;

class TicketSeller
{
    // Fields related to the ticket selling process.
    private string name;
    private const double price = 100.0;
    private const double childDiscount = 0.25; // children's discount
    private int numOfAdults;
    private int numOfChildren;
    private double amountToPay;

    // Reads the number of adults and children from user input.
    private void ReadInput()
    {
        Console.Write("Your name please: ");
        name = Console.ReadLine();

        Console.Write("Number of adults: ");
        numOfAdults = int.Parse(Console.ReadLine());

        Console.Write("Number of children: ");
        numOfChildren = int.Parse(Console.ReadLine());
    }

    // Calculates the total amount to pay based on the number of adults and children.
    private void CalculateAmountToPay()
    {
        // Children's ticket is 25% of the adult price, hence adult price - childDiscount * adult price
        amountToPay = (numOfAdults * price) + (numOfChildren * price * (1 - childDiscount));
    }

    // Displays the results of the ticket sale including total amount to pay.
    private void ShowResults()
    {
        Console.WriteLine("+++ Your receipt +++");
        Console.WriteLine("+++ Amount to pay = {0}", amountToPay);
        Console.WriteLine("+++ Price per ticket = {0}", price);
        Console.WriteLine();
        Console.WriteLine("+++ Thank you {0} and please come back! +++", name);
    }

    // Starts the ticket selling process.
    public void Start()
    {
        Console.WriteLine("Welcome to KIDS' FAIR!");
        Console.WriteLine("Children get always a 75% discount!");
        Console.WriteLine();

        ReadInput();
        CalculateAmountToPay();
        ShowResults();
    }
}