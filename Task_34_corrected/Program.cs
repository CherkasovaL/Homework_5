// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArray(numbers);
Console.WriteLine("");
PrintArray(numbers);
int count = 0;

for (int a = 0; a < numbers.Length; a++)
if (numbers[a] % 2 == 0)
count++;

Console.WriteLine($"Всего {count} чётных числа");

void FillArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,999);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("");
    Console.WriteLine();
}
