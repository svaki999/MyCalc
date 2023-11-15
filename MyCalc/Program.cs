using MyCalc;

Console.WriteLine("Ohm's Law Calculator");


while (true)
{
    Console.WriteLine("Choose what you want to calculate:");
    Console.WriteLine("1. Voltage (V)");
    Console.WriteLine("2. Current (I)");
    Console.WriteLine("3. Resistance (R)");
    Console.WriteLine("4. Power (P)");
    Console.WriteLine("5. Exit");

    int choice;
    if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
    {
        Console.WriteLine("Invalid choice. Please try again.");
        continue;
    }

    double voltage, current, resistance, power;

    // Create instances of the calculator classes
    CalcVoltage voltageCalculator = new CalcVoltage();
    CalcCurrent currentCalculator = new CalcCurrent();
    CalcPower powerCalculator = new CalcPower();
    CalcResistance resistanceCalculator = new CalcResistance();

    switch (choice)
    {
        case 1:
            Console.Write("Enter current (I): ");
            if (!double.TryParse(Console.ReadLine(), out current))
            {
                Console.WriteLine("Invalid input. Please try again.");
                continue;
            }

            Console.Write("Enter resistance (R): ");
            if (!double.TryParse(Console.ReadLine(), out resistance))
            {
                Console.WriteLine("Invalid input. Please try again.");
                continue;
            }

            voltage = voltageCalculator.GetVoltageByResistanceAndCurrent(resistance, current);
            power = powerCalculator.GetPowerByResistanceAndCurrent(resistance, current);
            Console.WriteLine($"Result: Voltage (V) = {voltage} volts, Power (P) = {power} watts");
            break;

        case 2:
            Console.Write("Enter voltage (V): ");
            if (!double.TryParse(Console.ReadLine(), out voltage))
            {
                Console.WriteLine("Invalid input. Please try again.");
                continue;
            }

            Console.Write("Enter resistance (R): ");
            if (!double.TryParse(Console.ReadLine(), out resistance))
            {
                Console.WriteLine("Invalid input. Please try again.");
                continue;
            }

            current = currentCalculator.GetCurrentByVoltageAndResistance(voltage, resistance);
            power = powerCalculator.GetPowerByVoltageAndResistance(voltage, resistance);
            Console.WriteLine($"Result: Current (I) = {current} amperes, Power (P) = {power} watts");
            break;

        case 3:
            Console.Write("Enter voltage (V): ");
            if (!double.TryParse(Console.ReadLine(), out voltage))
            {
                Console.WriteLine("Invalid input. Please try again.");
                continue;
            }

            Console.Write("Enter current (I): ");
            if (!double.TryParse(Console.ReadLine(), out current))
            {
                Console.WriteLine("Invalid input. Please try again.");
                continue;
            }

            resistance = resistanceCalculator.GetResistanceByVoltageAndCurrent(voltage, current);
            power = powerCalculator.GetPowerByVoltageAndCurrent(voltage, current);
            Console.WriteLine($"Result: Resistance (R) = {resistance} ohms, Power (P) = {power} watts");
            break;

        case 4:
            Console.Write("Enter voltage (V): ");
            if (!double.TryParse(Console.ReadLine(), out voltage))
            {
                Console.WriteLine("Invalid input. Please try again.");
                continue;
            }

            Console.Write("Enter current (I): ");
            if (!double.TryParse(Console.ReadLine(), out current))
            {
                Console.WriteLine("Invalid input. Please try again.");
                continue;
            }

            power = powerCalculator.GetPowerByVoltageAndCurrent(voltage, current);
            Console.WriteLine($"Result: Power (P) = {power} watts");
            break;

        case 5:
            Console.WriteLine("Goodbye!");
            return;
    }
}