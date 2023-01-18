// Author: Jaxon Walter
// Description: Write a program in C# that simulates the rolling of two 6-sided dice. Use an Array to keep track of the number
// of times that each total number is thrown. In other words, keep track of how many times the combination of the two simulated
// dice is 2, how many times the combination is 3, and so on, all the way up through 12.
// Allow the user to choose how many times the “dice” will be thrown. Then, once the dice have been thrown the specified number
// of times, print a histogram (using the* character) that shows the total percentage each number was rolled. Each * will represent
// 1% of the total rolls.

using System;

class DiceRollSimulation
{
    static void Main(string[] args)
    {
        int[] totals = new int[13]; // array to keep track of the number of times each total is thrown
        int rollCount; // number of times the dice will be thrown
        Random rand = new Random();

        Console.Write("Welcome to the dice throwing simulator!\nHow many dice rolls would you like to simulate? ");
        rollCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < rollCount; i++)
        {
            int die1 = rand.Next(1, 7); // simulates rolling a 6-sided die
            int die2 = rand.Next(1, 7);
            int total = die1 + die2; // calculates the total of the two dice
            totals[total]++; // increments the count for the corresponding total
        }

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS\nEach '*' represents 1% of the total number of rolls.\nTotal number of rolls = " + rollCount);
        for (int i = 2; i <= 12; i++)
        {
            double percentage = (double)totals[i] / rollCount * 100; // calculates the percentage for each total
            Console.Write(i + ": ");
            for (int j = 0; j < percentage; j++)
            {
                Console.Write("*"); // print a * for every 1% of the total rolls
            }
            Console.WriteLine();
        }

        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}