using System.Reflection.Emit;

namespace aRRAyS
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] numbers = new int[101 ];
            Random generator = new Random();

            Console.WriteLine("Here are the numbers:");
            Console.WriteLine();


            for (int i = 0; i < 100; i++) 
            {
                numbers[i] = generator.Next(1, 101);
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
            int sumOfEvens = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumOfEvens++;
                }
            }

            Console.WriteLine() ;
            Console.WriteLine($"There are {sumOfEvens} even numbers in the array.");
            Console.WriteLine("Below are multiples of 5 in the array.");

            Console.WriteLine();

            for (int i = 0; i <100; i++)
            {
                if (numbers[i] % 5 == 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("I doubled all of the second numbers in the array, here is the new array.");
            Console.WriteLine();

            for (int i = 1; i < numbers.Length; i += 2)
            {
                numbers[i] *= 2;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Array.Sort(numbers);

            int smallest, largest;

            smallest = numbers[0];
            largest = numbers[100];

            Console.WriteLine($"The smallest value in the array is {smallest} and the largest is {largest}.");

        }
    }
}