// проверка пятизначного палиндрома:

/* Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int num = number.Length;
if (num == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("введеное число является палиндромом");
    }
    else 
    {
        Console.WriteLine("введеное число не палиндром");
    }
}
else 
{
    Console.Write("вы ввели не пятизначное число");

}




// программа принимает координаты трех точек на вход и находит расстояние между ними в 3д пространстве;
/ A (3,6,8), B(2,1,-7) -> 15,84 
int ax = 3;
int ay = 6;
int az = 8;
int bx = 2;
int by = 1;
int bz = -7; 

double a = Math.Pow(ax - bx, 2);
double b = Math.Pow(ay - by, 2);
double c = Math.Pow(az - bz, 2);

double result = Math.Sqrt(a+b+c);
Console.WriteLine(result);  */


// программа принимает на вход число N и на выходе выдает таблицу кубов от 1 до N:

/* int number = ReadInt("Введите число: ");

for (int i = 1; i <= number; i++)
{
    Console.Write($"{i * i * i}, ");
}

// Метод
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} */


















Console.WriteLine("введите число: ");
string input= Console.ReadLine();
int number = Convert.ToInt32(input);
int a = 1;
Console.Write($"{number} ->  ");
while (a <= number) 
{
    int result = a*a*a; 
    Console.Write($"{result}, ");
    a++;
}





