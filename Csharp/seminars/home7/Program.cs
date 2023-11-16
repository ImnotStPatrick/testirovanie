/* Console.Write("Введите числа через запятую: ");
string inputNumbers = Console.ReadLine();

int size = 1;
for(int i = 0; i < inputNumbers.Length; i++)
{
    if(inputNumbers[i] == ',')
        size++;
}

int[] numbers = new int[size];

string subString = string.Empty;
int numbersIndex = 0;
for(int i = 0; i < inputNumbers.Length; i++)
{
    if(inputNumbers[i] == ',')
    {
        numbers[numbersIndex] = Convert.ToInt32(subString);
        subString = string.Empty;
        numbersIndex++;
    }
    else
    {
        subString += inputNumbers[i];
    }
}
numbers[numbersIndex] = Convert.ToInt32(subString);

Console.WriteLine(size);
PrintIntArray(numbers);

int[] CopyArray(int[] array)
{
    int[] copyArray = new int[array.Length];

    for(int i = 0; i < copyArray.Length; i++)
    {
        copyArray[i] = array[i];
    }

    return copyArray;
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintIntArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
}



/* Задача 46: Задайте двумерный массив размером m×n,
 заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1 

int rows = 3;
int columns = 4;
int[,] numbers = new int[rows, columns];
Random randomizer = new Random();

for(int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i, j] = randomizer.Next(1, 10);
    }
}

PrintIntArray2D(numbers);

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintIntArray2D(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}

 

 Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
 
int m = 3;
int n =4;

int[,] numbers = new int[m, n];
int count = 0;
for( int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[count, j]= i +j;
        Console.Write(numbers[i, j] + " ");

    }
    Console.WriteLine();
}


// 49. Задайте двумерный массив. Найдите элементы, у которых оба индекса 
// нечётные, и замените эти элементы на их квадраты.


*/