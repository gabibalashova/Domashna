namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = input.Length;
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            int x = int.Parse(Console.ReadLine());
            int left = 0;
            int right = n - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (x < arr[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            int pos = left;
            int[] result = new int[n + 1];

            for (int i = 0; i < pos; i++)
            {
                result[i] = arr[i];
            }

            result[pos] = x;
            for (int i = pos; i < n; i++)
            {
                result[i + 1] = arr[i];
            }
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}
