namespace ConsoleApp
{
    class Program
    {
        static void MaxIndex(int[] numArray)
        {
            int max = numArray[0];
            int index = 0;
            for (int i = 1; i < numArray.Length; i++)
            {
                if (max < numArray[i])
                {
                    max = numArray[i];
                    index = i;
                }
            }
            Console.WriteLine(index);
        }
        static void Main(string[] args)
        {
            int[] numArr = new int[7] { 1, 5, 8, 9, 4, 3, 2 };
            MaxIndex(numArr);
        }
    }
}