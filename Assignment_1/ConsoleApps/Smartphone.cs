// Created by Osman Said on 2024-02-02

namespace ConsoleApps;

public class Smartphone
{
    // Fields for the Smartphone's brand, model, and storage capacity.
    private string brand;
    private string model;
    private int storageCapacity;
    private double batteryCapacity = 100.0; // Assume battery level starts at 100%
    private DateTime manufacturingDate;

    // Reads details about the smartphone from the user.
    private void ReadSmartphoneDetails()
    {
        Console.Write("Enter the brand of the smartphone: ");
        brand = Console.ReadLine();

        Console.Write("Enter the model of the smartphone: ");
        model = Console.ReadLine();

        Console.Write("Enter the storage capacity (GB) of the smartphone: ");
        storageCapacity = int.Parse(Console.ReadLine());

        Console.Write("Enter the manufacturing date (yyyy-mm-dd): ");
        manufacturingDate = DateTime.Parse(Console.ReadLine());
    }

    // Calculates the current health of the battery based on its discharge rate.
    private void CalculateBatteryHealth()
    {
        // Let's assume the battery discharges 0.01% per day since manufacturing
        TimeSpan timeSinceManufactured = DateTime.Now - manufacturingDate;
        double dischargeRate = 0.01;
        double days = timeSinceManufactured.TotalDays;
        batteryCapacity = Math.Max(0, batteryCapacity - (dischargeRate * days));
    }

    // Displays the current status of the smartphone including battery capacity.
    private void DisplaySmartphoneStatus()
    {
        Console.WriteLine("Smartphone Brand: {0}", brand);
        Console.WriteLine("Smartphone Model: {0}", model);
        Console.WriteLine("Storage Capacity: {0} GB", storageCapacity);
        Console.WriteLine("Current battery Capacity: {0}%", batteryCapacity);
        Console.WriteLine("Current battery Capacity: {0:F2}%", batteryCapacity); // round to 2 decimal places
        Console.WriteLine("Manufacturing Date: {0}", manufacturingDate.ToShortDateString());
    }

    // Starts the process of reading details, calculating battery health, and displaying status.
    public void Start()
    {
        Console.WriteLine(); // blank line
        Console.WriteLine("Starting the Smartphone Program!");
        Console.WriteLine(); // blank line

        ReadSmartphoneDetails();
        CalculateBatteryHealth();
        DisplaySmartphoneStatus();
    }
}