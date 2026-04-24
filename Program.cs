using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Enter contractor name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter contractor number:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter start date:");
            string startDate = Console.ReadLine();

            Console.WriteLine("Enter shift (1 = day, 2 = night):");
            int shift = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter hourly pay rate:");
            double payRate = double.Parse(Console.ReadLine());

            // create object
            Subcontractor s = new Subcontractor(name, number, startDate, shift, payRate);

            // display result
            Console.WriteLine("Pay is: " + s.CalculatePay());

            Console.WriteLine("Do you want to add another? (yes/no)");
            string answer = Console.ReadLine();

            if (answer.ToLower() != "yes")
            {
                running = false;
            }
        }
    }
}