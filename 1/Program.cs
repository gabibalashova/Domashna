using System;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the 1st word in separate letters: ");
            string[] arr1 = Console.ReadLine().Split(' ').ToArray();

            Console.Write("Enter the 2nd word in separate letters: ");
            string[] arr2 = Console.ReadLine().Split(' ').ToArray();

            int minLength = Math.Min(arr1.Length, arr2.Length);
            bool arr1First = false;
            int i;
            for (i = 0; i < minLength; i++)
            {
                if (string.Compare(arr1[i], arr2[i]) < 0)
                {
                    arr1First = true;
                    break;
                }
                else if (string.Compare(arr1[i], arr2[i]) > 0)
                {
                    arr1First = false;
                    break;
                }
            }

            if (arr1First || (arr1.Length < arr2.Length && minLength == arr1.Length))
            {
                Console.WriteLine(arr1[i]);
                Console.WriteLine(arr2[i]);
            }
            else
            {
                Console.WriteLine(arr2[i]);
                Console.WriteLine(arr1[i]);
            }
        }
    }
}
