/* Найти максимальное из трех чисел. */

using System;

public class Answer {
    
  static int FindMax(int a, int b, int c)

    {
      // Введите свое решение ниже
int result = a;
if (b > result) result = b;
if (c > result) result = c;

    {
     Console.WriteLine("max = ");
     return result;
     }
  


    }

  // Не удаляйте и не меняйте метод Main! 
  static public void Main(string[] args) {
        int a, b, c;

        if (args.Length >= 3) {
           a = int.Parse(args[0]);
           b = int.Parse(args[1]);
           c = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           a = 18;
           b = 9;
           c = 976;
        }

        // Не удаляйте строки ниже
        int result = FindMax(a, b, c);
        System.Console.WriteLine($"{result}");
    }
}

/* найти большее из двух чисел */

using System;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        if (firstNumber == secondNumber)
        {
            Console.WriteLine($"Введенные числа равны `{firstNumber}`");
        }
        if (firstNumber > secondNumber)
        {
            Console.WriteLine($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
        }
        if (firstNumber < secondNumber)
        {
            Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
        }
    }

    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
            firstNumber = 5;
            secondNumber = 5;
        }

        CompareNumbers(firstNumber, secondNumber);
    }

    /* вывести четные числа */

    using System;

public class Answer {
    static void PrintEvenNumbers(int number)
    {
        for (int count = 2; count <= number; count += 2)
        {
            Console.Write($"{count}\t");
        }
    }

    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
            number = 6;
        }

        PrintEvenNumbers(number);
    }
}


    /* проверка на четность */

    using System;

class Answer {
    static void CheckIfEven(int number)
    {
        if ((number % 2) == 0)
        {
            Console.WriteLine($"Число `{number}` чётное");
        }
        else
        {
            Console.WriteLine($"Число `{number}` нечётное");
        }
    }

    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
            number = 6;
        }

        CheckIfEven(number);
    }
}