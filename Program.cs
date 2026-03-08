namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] arr = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            int number = int.Parse(Console.ReadLine());
            int left = 0;
            int right = arr.Length - 1;
            bool found = false;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (arr[mid] == number)
                {
                    found = true;
                    break;
                }
                else if (arr[mid] < number)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            if (found)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
