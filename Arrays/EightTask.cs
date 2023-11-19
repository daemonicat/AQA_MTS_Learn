public static class EightTask
{
    public static void BubbleSort()
    {
        int[] array = { 1, 6, 4, 2, 9, 5, 14, 10, 3, 7, 19, 16, 18, 8, 28, 11, 38 };
        
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        for (int j = 0; j < n - i - 1; j++)
            if (array[j] > array[j + 1])
            {
                (array[j], array[j + 1]) = (array[j + 1], array[j]);
            }
        
        for (int i = 0; i <= array.GetUpperBound(0); i++)
        {
            Console.Write($"{array[i]} ");
            if (i == array.GetUpperBound(0)) Console.WriteLine();
        }
    }
}