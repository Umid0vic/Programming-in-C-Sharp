// Created by Osman Said on 2024-02-02

namespace ConsoleApps;

class Pet
{
    // Stores the pet's name.
    private string name;

    // Stores the pet's age as an integer.
    private int age;

    // Indicates if the pet is female (true if female, false otherwise).
    private bool isFemale;

    // Reads and saves pet data from user input.
    private void ReadAndSavePetData()
    {
        Console.Write("What is the name of your pet? ");
        name = Console.ReadLine();

        Console.Write("What is {0}'s age? ", name);
        age = int.Parse(Console.ReadLine());

        Console.Write("Is your pet a female (y/n)? ");
        isFemale = Console.ReadLine().ToLower() == "y";
    }

    // Displays the pet's information to the console.
    private void DisplayPetInfo()
    {
        Console.WriteLine("+++++++++++++++++++++++++++++");
        Console.WriteLine("Name: {0} Age: {1}", name, age);
        Console.WriteLine("{0}: She's such a wonderful pup!", name);
        Console.WriteLine("+++++++++++++++++++++++++++++");
    }

    // Initiates the process of reading and displaying pet data.
    public void Start()
    {
        Console.WriteLine(); // blank line
        Console.WriteLine("Greetings from the Pet class!");
        Console.WriteLine(); // blank line

        ReadAndSavePetData();
        DisplayPetInfo();
    }
}