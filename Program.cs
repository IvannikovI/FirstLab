using System;
using System.Linq;
using System.Numerics;
 
namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            	Console.WriteLine("Введите число от 1 до 1000");
                int Number = int.Parse(Console.ReadLine());
                Console.WriteLine("N = " + Number);
                if (Number <= 0 || Number > 1000)
                {
                    Console.WriteLine("N должно быть в диапозоне от 1 до 1000");
                    Console.ReadLine();
                    return;
                }
 
                BigInteger NewNumber = Number;
                for (int i = 0; i < Number; i++)
                    NewNumber *= Number;
                Console.WriteLine("N^N = " + NewNumber);
                var Counter = new int[10];
                while (NewNumber != 0)
                {
                    int index = (int)(NewNumber % 10);
                    Counter[index]++;
                    NewNumber /= 10;
                }
 
                for (int i = 0; i < Counter.Count(); i++)
                    Console.WriteLine(Counter[i] + " - повторений, цифры - " + i);
                    Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
                Console.ReadLine();
            }
        }
    }
}