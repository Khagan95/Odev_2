using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayList primeNumbers = new ArrayList();
        ArrayList nonPrimeNumbers = new ArrayList();

        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Enter a positive number {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
            {
                if (IsPrime(number))
                {
                    primeNumbers.Add(number);
                }
                else
                {
                    nonPrimeNumbers.Add(number);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive numeric value.");
                i--;
            }
        }

        primeNumbers.Sort();
        primeNumbers.Reverse();
        nonPrimeNumbers.Sort();
        nonPrimeNumbers.Reverse();

        Console.WriteLine("Prime Numbers:");
        foreach (int prime in primeNumbers)
        {
            Console.WriteLine(prime);
        }

        Console.WriteLine("Non-Prime Numbers:");
        foreach (int nonPrime in nonPrimeNumbers)
        {
            Console.WriteLine(nonPrime);
        }

        Console.WriteLine($"Prime Numbers Count: {primeNumbers.Count}, Average: {CalculateAverage(primeNumbers)}");
        Console.WriteLine($"Non-Prime Numbers Count: {nonPrimeNumbers.Count}, Average: {CalculateAverage(nonPrimeNumbers)}");
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static double CalculateAverage(ArrayList list)
    {
        double sum = 0;
        foreach (int item in list)
        {
            sum += item;
        }
        return sum / list.Count;
    }
}