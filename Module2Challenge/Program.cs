// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!"); 

        Console.Write("Enter the number of miles driven: ");
        double milesDriven = Convert.ToDouble(Console.ReadLine());

    
        Console.Write("Enter the amount of gasoline used (in gallons): ");
        double gallonsUsed = Convert.ToDouble(Console.ReadLine());

      
        double mpg = milesDriven / gallonsUsed;

      
        Console.WriteLine($"The miles per gallon (MPG) is: {mpg:F2}");
    