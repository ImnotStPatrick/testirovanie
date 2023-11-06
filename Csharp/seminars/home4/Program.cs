//Домашние задачи: 
// 1)цикл, который принимает два числа (А и В) и на выходе возводит число А в натуральную степень В:
 /*
 int Prompt(string message)
 {
    Console.Write(message);
    string readInput =Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
 }

int Power(int powerBase, int exponent)
{
    int power = 1;
    for (int i =0; i < exponent; i++)
    {
        power *= powerBase;
    }
    return power;

}

bool ValidateExponent(int exponent)
{
    if (exponent <0 )
    {
        Console.WriteLine("Показатель не должен быть меньше нуля");
        return false;
    } 
    return true;
}
int powerBase = Prompt("Введите основание");
int exponent = Prompt("Введите показатель");
if (ValidateExponent (exponent))
{
    Console.WriteLine($" число {powerBase} в степени {exponent} равно = {Power(powerBase, exponent)}");
    
}


//2. принимает на вход число и на выходе выдает сумму цифр в числе. 
int Prompt(string message)
{
    string readInput = Console.ReadLine();
int result = int.Parse(readInput);
return result;
}
int SumAllDigit(int number)
{
    int result =0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}
int number = Prompt("введите число: ");
Console.WriteLine($"сумма цифр в числе {number} = {SumAllDigit(number)}");

*/

//3.программа, которая задает массив из 8 элементов и выводит их на экран:
 
 int Prompt(string message)
 {
    Console.Write(message);
    string ReadInput = Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
 }
 int [] GenerateArray(int Length, int minValue, int maxValue)
{
    int [] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length -1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
Console.WriteLine("]");
}

int length = Prompt("Длина массива: ");
int min = Prompt("начальное значение: ");
int max = Prompt("конечное значение: ");
int[] array = GenerateArray(length, min, max);
 PrintArray(array);  































































































































//Задачи с лекции: 
/* Console.Write("Введите число: ");
string input = Console.ReadLine();
int number = int.Parse(input);
int i =1;
int sum =0;
for (i =1; i <= number; i++)
{
    sum += i;

}
Console.WriteLine($"{number} -> {sum}"); 





Console.Write("ВВедите число: ");
string numberstr = Console.ReadLine();
int number = Convert.ToInt32(numberstr);
int x = 0;
while (number > 0)
{
x = number % 10;
Console.WriteLine(x);
number /= 10;
}
Console.WriteLine(x); */
