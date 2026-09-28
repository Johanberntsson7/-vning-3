using System.Runtime.Serialization.Formatters;

namespace _vning_3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write in a number");
        int number = int.Parse(Console.ReadLine()!);

        for (int i = 1; i <= 10; i++)
        {
            int result = number * i;
            Console.WriteLine($"{number} x {i} = {result}");
        }
    }
}
