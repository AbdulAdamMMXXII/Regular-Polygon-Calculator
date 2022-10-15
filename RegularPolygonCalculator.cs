using System;

class RegularPolygonCalculator
{
    // Declare constants
    private const double PI = 3.14;

    static void Main(string[] args)
    {
        // Declare variables
        double length, perimeter, apothem, area;
        int numberOfSides;
        string units;

        // Print welcome message
        Console.WriteLine("Welcome to Regular Polygon Calculator!");
        Console.WriteLine("Note: This calculator only carries out polygons with 3 to 10 sides.");

        while (true)
        {
            // Get user input for length, units, and number of sides
            Console.Write("Enter the length of a side: ");
            length = double.Parse(Console.ReadLine());

            Console.Write("Enter the units of measurement (e.g. cm, m, in): ");
            units = Console.ReadLine();

            Console.Write("Enter the number of sides (3-10): ");
            numberOfSides = int.Parse(Console.ReadLine());

            if (numberOfSides < 3 || numberOfSides > 10)
            {
                Console.WriteLine("Invalid input! Enter a valid number.");
                continue;
            }

            // Compute perimeter, apothem, and area
            perimeter = numberOfSides * length;
            apothem = length / (2 * Math.Tan(PI / numberOfSides));
            area = (perimeter * apothem) / 2;

            // Print the results rounded to 2 decimal places
            Console.WriteLine("Perimeter: " + Math.Round(perimeter, 2) + " " + units);
            Console.WriteLine("Area: " + Math.Round(area, 2) + " " + units + "^2");

            // Ask user if they want to continue
            Console.Write("Do you want to calculate for another polygon? (y/n) ");
            string answer = Console.ReadLine();
            if (answer.ToLower() != "y")
            {
                break;
            }
        }
        Console.WriteLine("Thank you for using the calculator. Bye!");
    }
}
