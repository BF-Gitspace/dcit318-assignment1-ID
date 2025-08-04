using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string input;
        double Score;
        string grading;

        Console.WriteLine("This is the Grade Calculator. Please enter your score or 'q' to quit.\n");

        while (true)
        {
            Console.Write("What was your Score: ");
            input = Console.ReadLine();

            // Exit condition
            if (input.ToLower() == "q")
            {
                break;
            }

            try
            {
                Score = double.Parse(input);

                // Check range
                if (Score < 0 || Score > 100)
                {
                    Console.WriteLine("Please enter a score between 0 and 100.\n");
                    continue;
                }

                // Grading logic
                if (Score >= 90)
                {
                    grading = "A";
                }
                else if (Score >= 80)
                {
                    grading = "B";
                }
                else if (Score >= 70)
                {
                    grading = "C";
                }
                else if (Score >= 60)
                {
                    grading = "D";
                }
                else
                {
                    grading = "F";
                }

                // Show result
                Console.WriteLine($"Letter Grade: {grading}\n");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid number or 'q' to quit.\n");
            }
        }

        Console.WriteLine("\nThank you for using the Grade Calculator!");


        Console.ReadKey();
    }
}
