// Написать программу для разворота массива
// вариант с использованием двух методов

void PrintArray(int[] arr)
{
    int count = arr.Length;
    int index = 0;
    while (index < count)
    {
        Console.Write(arr[index] + " ");
        index++;
    }
}
void ReverseArray(int[] array)
{
    int N = array.Length;
    for (int i = 0; i < N / 2; i++)
    {
        int temp = array[i];
        array[i] = array[N - i - 1];
        array[N - i - 1] = temp;
    }
}
int[] arr = { 1, 8, 3, 6, 5 };
ReverseArray(arr);
PrintArray(arr);