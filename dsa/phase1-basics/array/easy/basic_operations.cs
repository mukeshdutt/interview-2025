
class ArrayBasicOperations
{
    void Insertion(int[] items, int position, int value)
    {
        if (position < 0)
        {

        }

        int[] arrResized = new int[items.Length];
        for (int i = 0; i < items.Length; i++)
        {

        }
    }

    void Deletion(int[] items, int position)
    {

    }

    void Replace(int[] items, int position, int item)
    {

    }

    public static void Searching(int[] items, int item)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == item)
            {
                System.Console.WriteLine($"Item found at position: {i}");
                return;
            }
        }
        System.Console.WriteLine("Record not found.");
    }

    public static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            System.Console.WriteLine(arr[i]);
        }
    }
}