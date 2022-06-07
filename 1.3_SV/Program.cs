using System;
namespace Sample5
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int[] array = new int[10];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10, 10);
            }
            for (int i = 1; i < array.Length; i = i + 2)
            {
                if (array[i] % 3 == 0)
                {
                    max = array[i];
                    break;
                }
            }
            for (int i = 1; i < array.Length; i = i + 2)
            {
                if (array[i] % 3 == 0 && array[i] > max) max = array[i];
            }
            Console.WriteLine($"Наибольший элемент = {max}");
        }
    }
}