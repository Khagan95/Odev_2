using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[20];

        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Enter a number {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                numbers[i] = number;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
                i--;
            }
        }

        Array.Sort(numbers);
        int[] smallestThree = new int[3];
        int[] largestThree = new int[3];

        for (int i = 0; i < 3; i++)
        {
            smallestThree[i] = numbers[i];
            largestThree[i] = numbers[numbers.Length - 1 - i];
        }

        double smallestThreeAverage = CalculateAverage(smallestThree);
        double largestThreeAverage = CalculateAverage(largestThree);

        Console.WriteLine("Smallest Three Numbers:");
        foreach (int num in smallestThree)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("Largest Three Numbers:");
        foreach (int num in largestThree)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine($"Smallest Three Average: {smallestThreeAverage}");
        Console.WriteLine($"Largest Three Average: {largestThreeAverage}");
        Console.WriteLine($"Total Average: {(smallestThreeAverage + largestThreeAverage) / 2}");
    }

    static double CalculateAverage(int[] arr)
    {
        double sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        return sum / arr.Length;
    }
}