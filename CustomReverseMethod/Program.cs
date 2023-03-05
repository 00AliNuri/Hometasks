void Reverse(int[] arr, int rever = 0)
{
    rever = arr.Length;
    for (int i = rever - 1; i < arr.Length + rever; i--)
    {
        Console.WriteLine(arr[i]);
    }
}
Reverse(new int[] { 9, 8, 7, 98, 76, 19 });
