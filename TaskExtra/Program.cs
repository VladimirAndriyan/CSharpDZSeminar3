// Написать программу для разворота массива


void PrintArray(int[] arr)
{
int count = arr.Length;
int index = 0;
while(index < count)
{
    Console.Write(arr[index] + " ");
    index ++;
}
}
int[] arr = { 1, 2, 3, 4, 5 };
int N = arr.Length;
for (int i = 0; i < N / 2; i++)
{
    int temp = arr[i];
    arr[i] = arr[N - i - 1];
    arr[N - i - 1] = temp;
}
PrintArray(arr);