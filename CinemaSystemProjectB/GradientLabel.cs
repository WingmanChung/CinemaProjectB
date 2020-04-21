class Program
{
    public static int[] Range(int min, int max)
    {
        int[] arr = new int[max - min];
        for (int i = 0, j = min; i < arr.Length; i++, j++)
        {
            arr[i] = j;
        }
        return arr;
    }

    public static int[] PowersOf(int v, int howMany)
    {
        int[] arr = new int[howMany];
        for (int i = 1; i < arr.Length; i++)
        {
            arr[0] = 1;
            arr[i] = arr[i - 1] * v;
        }
        return arr;
    }

    public static void Main()
    {
        var rangeVal1 = Range(3, 7);
        var rangeVal2 = Range(-1, 5);
        var powersOf2 = PowersOf(2, 5);
        var powersOf3 = PowersOf(3, 4);
    }
} 
