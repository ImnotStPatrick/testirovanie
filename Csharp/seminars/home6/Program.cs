
/* Random randomizer = new Random();
int size = 5;
int[] numbers = new int[size];

for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = randomizer.Next(1, 10);
}

PrintIntArray(numbers);

for(int i = 0; i < numbers.Length / 2; i++)
{
    int temp = numbers[i];
    numbers[i] = numbers[numbers.Length - 1 - i];
    numbers[numbers.Length - 1 - i] = temp;
}

PrintIntArray(numbers);

void PrintIntArray(int[] array)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }

    Console.WriteLine();
}
*/





// 40. Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
/* 
Console.WriteLine(" Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
 
// int[] numbers= new int{number1, number2, number3};
int sum1 = number1 + number2;
int sum2 = number2 + number3;
int sum3 = number1 + number3; 

 if ( sum1 > number3 && sum2 > number1 && sum3 > number2 )
{
    Console.Write("треугольник существует");
}
else
{
Console.WriteLine("такого треугольника нет");
}
*/
// программа работает
/* 
int fistSide = ReadInt("Введите первое число: ");
int secondSide = ReadInt("Введите первое число: ");
int thirdSide = ReadInt("Введите первое число: ");

if (fistSide + secondSide > thirdSide && fistSide + thirdSide > secondSide && secondSide + thirdSide > fistSide)
{
    Console.WriteLine("Три числа являются сторонами треугольника");
}
else
{
    Console.WriteLine("Три числа НЕ являются сторонами треугольника");
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
} 
*/

// 42. Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
/*

Random randomizer = new Random();
// int number = randomizer.Next(minRandomNumber, maxRandomNumber +1);
int minRandomNumber = 5;
int maxRandomNumber = 10;
string result = string.Empty;
int number = randomizer.Next(minRandomNumber, maxRandomNumber +1);
int[] numbers = new int[6];

Console.WriteLine(number);
 
while (number >= 1)
{

  result = number % 2 + result;
   number = number / 2;
}
Console.WriteLine(result); 



// решение препода

int number = ReadInt("Введите число: ");
string output = string.Empty;
int tempNumber = number;
int baseNumber = 2;

while(tempNumber > 0)
{
    output = tempNumber % baseNumber + output;
    tempNumber /= baseNumber;
}
Console.WriteLine(output);

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}



// Напишите программу, которая будет создавать копию заданного 
// одномерного массива с помощью поэлементного копирования.
int size = ReadInt("Введите размер массива: ");
Random randomizer = new Random();
int[] numbers = new int[size];

for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = randomizer.Next(0, 10);
}

int[] result = CopyArray(numbers);

PrintIntArray(numbers);
PrintIntArray(result);

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
*/