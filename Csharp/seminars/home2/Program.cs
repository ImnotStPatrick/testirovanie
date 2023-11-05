
//
/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */


Console.Write("Введите трехзначное число: ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

int minNumber = 100;
int maxNumber = 1000;

if (number > minNumber || number < maxNumber)
{
    int result = number / 10;
    int result2 = result % 10;
    Console.WriteLine(result2);
}
if (number < minNumber || number > maxNumber)
{
    Console.WriteLine("это не трехзначное число");
} 
// программа работает.
 

/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

 Console.Write("Введите число от 1 до 7: ");
 int number = Convert.ToInt32(Console.ReadLine());
 if (number < 6 )
 {
    Console.WriteLine("нет");
 }
if (number == 6 || number == 7)
{
    Console.WriteLine("да");
}
if (number > 7)
{
    Console.WriteLine("нет такого дня недели :) ");
}




/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */


 Console.Write("Введите трехзначное число: ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input); 

int minNumber = 100; 
int maxNumber = 10000;
if(number < minNumber)
{
    Console.WriteLine("число не трехзначное");
}
string numberString = Convert.ToString(number);
char symbol = numberString[2];

Console.WriteLine($"{number} ---> {symbol}"); 

// программа работает 









/* Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int result = number % 7;
int result2 = number % 23;

if(result == 0)
if(result2 == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Не кратны1 -> остаток {result}");
}
else
{
Console.WriteLine($"Не кратны2-> остаток {result2}");
} */


/* Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

int result1 = number1 * number1;
int result2 = number2 * number2;

if (number2 == result1)
{
    Console.WriteLine($"число {number2} является квадратом {number1}");
}

if (number1 == result2)
{
    Console.WriteLine($"число {number1} является квадратом {number2}");
}
else
{
    Console.WriteLine($"не квадрат -> {result1} {result2}");
} */ // **это мои решения задач с семинара** 
 
 /* int firstNumber = 7;
 int secondNumber = 23;
 Console.WriteLine("введите число");
 string input1 = Console.ReadLine();
 int inputNumber = Convert.ToInt32(input1);
 if (inputNumber % firstNumber == 0 && inputNumber % secondNumber == 0)
 {
    Console.WriteLine("да");
 }
else
{
    Console.WriteLine("нет");
} */

