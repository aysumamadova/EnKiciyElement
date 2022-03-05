using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -6, 0, 7, 9 };
            int small = 0;
            small = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (small > arr[i])
                {
                    small = arr[i];
                }
            }
            Console.WriteLine("Ən kiçik element: " + small);






        }
    }
}
