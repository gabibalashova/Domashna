namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split();
            int[] arr1 = new int[input1.Length];

            for (int i = 0; i < input1.Length; i++)
            {
                arr1[i] = int.Parse(input1[i]);
            }
            string[] input2 = Console.ReadLine().Split();
            int[] arr2 = new int[input2.Length];

            for (int i = 0; i < input2.Length; i++)
            {
                arr2[i] = int.Parse(input2[i]);
            }

            int[] result = new int[arr1.Length + arr2.Length];
            int i1 = 0;
            int i2 = 0;
            int k = 0;
            while (i1 < arr1.Length && i2 < arr2.Length)
            {
                if (arr1[i1] <= arr2[i2])
                {
                    result[k] = arr1[i1];
                    i1++;
                }
                else
                {
                    result[k] = arr2[i2];
                    i2++;
                }
                k++;
            }
            while (i1 < arr1.Length)
            {
                result[k] = arr1[i1];
                i1++;
                k++;
            }
            while (i2 < arr2.Length)
            {
                result[k] = arr2[i2];
                i2++;
                k++;
            }
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}
