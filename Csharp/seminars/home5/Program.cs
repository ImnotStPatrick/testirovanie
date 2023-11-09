 /* Cумма положительных и отрицательных в массиве от -9 до 9: 

  Random f = new Random();
int[] numbers = new int[12];
int sumMin = 0;
int sumMax = 0;


for (int i = 0; i < numbers.Length; i++)
{
    numbers[i]= f.Next(-9, 10);
    Console.Write(numbers[i] + " ");
} 
Console.WriteLine();

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] >0)
    sumMax += numbers[i];
    else 
    sumMin += numbers[i];
}
Console.WriteLine($"сумма положительных чисел равна {sumMax} , сумма отрицательных чисел равна {sumMin} .");




// поменять числа с - на + и наоборот.- умножить их на -1:
int[] numbers= {-4, -8, 8, 2};
for(int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i]);
}
Console.WriteLine();
for( int i = 0; i < numbers.Length; i++)
{
    numbers[i] *= -1;
    Console.Write(numbers[i]);

}   

// проверка наличия числа в массиве:
int[] numbers= {6,7,19,345,3};
Console.WriteLine("Введите число: ");
string input = Console.ReadLine();
int number= int.Parse(input);
for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i]==number)
    Console.WriteLine("yes");
    else 
    Console.WriteLine("no");
}



 // еще одна проверка числа в массиве: 

int[] numbers = {6, 7, 19, 345, -3};

Console.WriteLine("Введите число: ");
string input = Console.ReadLine();
int number = int.Parse(input);
bool ok = false;

for(int i = 0; i < numbers.Length; i++)
{
if(numbers[i] == number)
{

ok = true;
break;
}

}
if(!ok)
{
Console.WriteLine("Отсутствует");
}
else
{
Console.WriteLine("Присутствует");
}





Random randomizer = new Random();
int minRandomNumber = -9;
int maxRandomNumber = 9;
int sizeArray = 4;
int[] numbers = new int[sizeArray];

for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = randomizer.Next(minRandomNumber, maxRandomNumber + 1);
}

WriteIntArray(numbers);

Console.WriteLine("Введите число: ");
string input = Console.ReadLine();
int number = int.Parse(input);
string result = "No";

for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] == number)
    {
        result = "Yes";
        break;
    }
}
Console.WriteLine(result);


void WriteIntArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}




// количество элементов в массиве 123от 10 до 99:

Random f = new Random();
int[] numbers = new int[10];
int min = 0; 
int max = 123;
int a = 10;
int b = 99;
  int result = 0; //(a+b);
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = f.Next(min, max +1);
    Console.Write(numbers[i] + ",");
}
 for (int i = 0; i < numbers.Length; i++)
 {
    if (numbers[i] > a)
    a += numbers[i];
 
else if
 (numbers[i] < b)
b += numbers[i];
result++;
}

 //int result = (a+b);
 Console.WriteLine($"количество элементов от 10 до 99 в массиве 123 равно {result}");

 */


 // призведение пар чисел в массиве - первый и последний, второй и предпоследний элемент и так далее.
  //результат записать в новый массив. 
  int[] arr = {1, 2, 3, 4, 5};
  /* void PrintArray(int[] arr)
{
    int count = arr.Length;
    for (int i =0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr); 

   
   
   
   
   
     Мое неправильное решение, пусть останется
     void SelectionSort (int[] arr); 
// int i = firstPosition; //= i;
//int j = lastPosition; // = j;
{
    for (int l = 0; l < arr.Length; l++)
    {    //int l = firstPosition;
        Console.WriteLine($"первая цифра {arr[l]}");
    }
    for (int j = 0; j > arr.Length; j--)
    {   //int j = lastPosition;
        Console.WriteLine($"последняя цифра {arr[j]}");
    }
    int temporary1 = arr[l];
    //arr[l]=arr[firstPosition];
    arr[firstPosition] = temporary1;

    int temporary2 = arr[j];
    //arr[j]=arr[lastPosition];
    arr[lastPosition] = temporary2;
}


void PrintArray(int[] arr)
{
    int count = arr.Length;
    for (int i =0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr); 




// найти сумму произведения чисел в массиве- первого и последнего, второго и предпоследнего и тд
//namespace CyberForum
{
    //class Program
    {
        static void Main()
        {
            int[] array = { 1, 3, 8, 3, 2 };
 
            int sum = 0;
            for (int i = 0; i <array.Length / 2; i++)
            {
                sum += array[i] * array[array.Length - 1 - i];
            }
 
            //Console.WriteLine(sum); // 11
 
        }
 // Console.WriteLine(sum);
    }
    //Console.WriteLine(sum);
}

  // решение от однокурсника: 
Random randomizer = new Random();
int[] numbers = new int[7];
int minRanomNumber = 0;
int maxRandoNUmber = 10;
//int result = 0;
int[] resultArray;

for(int i = 0; i < numbers.Length; i++)
{
numbers[i] = randomizer.Next(minRanomNumber, maxRandoNUmber +1);
Console.Write(numbers[i] + ",");

}
Console.WriteLine();
if(numbers.Length % 2 == 0)
{
resultArray = new int[numbers.Length / 2];
}
else
{
resultArray = new int[numbers.Length / 2 + 1];
}

for(int i = 0; i < resultArray.Length; i++) // [1, 2, 3, 4, 5, 6] - 1*6, 2*5, 3*4
{

resultArray[i] = numbers[i] * numbers[(numbers.Length - 1) - i];

}

if (resultArray.Length % 2 != 0)
{
resultArray[resultArray.Length - 1] = numbers[numbers.Length / 2];
}

for(int i = 0; i < resultArray.Length; i++)
{
Console.Write(resultArray[i] + ", ");
}
Console.WriteLine(); 


*/


// решение преподавателя:
Random randomizer = new Random();
int minRandomNumber = 1;
int maxRandomNumber = 10;
int sizeArray = 4;
int[] numbers = new int[sizeArray];

for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = randomizer.Next(minRandomNumber, maxRandomNumber + 1);
}

WriteIntArray(numbers);

int[] result;
if (numbers.Length % 2 == 0)
{
    result = new int[numbers.Length / 2];
}
else
{
    result = new int[numbers.Length / 2 + 1];
    result[result.Length - 1] = numbers[numbers.Length / 2];
}

for(int i = 0; i < numbers.Length / 2; i++)
{
    result[i] = numbers[i] * numbers[numbers.Length - 1 - i];
}
WriteIntArray(result);



void WriteIntArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}