using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Movie Theater Ticket Price Calculator!");
        Console.Write("Please enter your age: ");

        // Read user input and convert to integer
        string input = Console.ReadLine();
        int age;

        // Validate input
        if (int.TryParse(input, out age))
        {
            int ticketPrice;

            // Determine ticket price based on age
            if (age <= 12 || age >= 65)
            {
                ticketPrice = 7;
                Console.WriteLine("You qualify for a discounted ticket.");
            }
            else
            {
                ticketPrice = 10;
                Console.WriteLine("You will pay the regular ticket price.");
            }

            Console.WriteLine($"Your ticket price is: GHC{ticketPrice}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }

        Console.WriteLine("Thank you for using the Ticket Price Calculator!");
    }
}
