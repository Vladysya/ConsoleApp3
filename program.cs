using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(1, 15);
            foreach (int i in arr)
                Console.Write(arr[i] + " ");
            Console.WriteLine("\nMax: " + arr.Max());
            Console.Write("Мin: " + arr.Min() + "\n");
        }


    }

    static class Array
    {
        public static int Max(this int[] arr)
        {

            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static int Min(this int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }
    }
}
