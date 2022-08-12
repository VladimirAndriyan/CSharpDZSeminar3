// Написать программу для разворота массива 
// Вариант без использования метода


int[] arr = { 8, 2, 4, 4, 5 };
int N = arr.Length;
for (int i = 0; i < N / 2; i++)
{
    int temp = arr[i];
    arr[i] = arr[N - i - 1];
    arr[N - i - 1] = temp;
}
for (int index = 0; index < N; index++)
{
    Console.Write(arr[index] + " ");
}