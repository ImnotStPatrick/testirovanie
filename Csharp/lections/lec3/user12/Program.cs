/*
void Method1()
{
    Console.WriteLine("Автор Мэри Энн");
}
Method1(); */


 /* void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("текст смс"); 


void Method21(string msg, int count)
{
    int i =0;
    while (i< count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("текст", 4);//
Method21(msg: "текст", count: 4); 

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year); 

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(100, "abcd");
Console.WriteLine(res); 


string Method5(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method5(10, "abcd");
Console.WriteLine(res); 


for (int i = 0; i <= 10; i++)
{
    for (int j = 0; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
    }
}



string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?"; 

 string Replace(string text, char oldValue, char newValue)
 {
    string result = String.Empty;
   int length = text.Length;
   for (int i =0; i < length; i++)
   {
    if(text[i] == oldValue) result = result + $"{newValue}";
    else result = result + $"{text[i]}";
   }
   
   return result;
 }         
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
 
 newText = Replace(newText, 'с', 'F');
Console.WriteLine(newText);

 newText = Replace(newText, 'к', 'М');
Console.WriteLine(newText); */

/* string newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

string newText = Replace(text, 'с', 'С');
Console.WriteLine(newText);
Console.WriteLine();

string newText = Replace(text, 'а', 'G');
Console.WriteLine(newText);
Console.WriteLine(); 






int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");

    }
    Console.WriteLine();
}
PrintArray(arr); 
 

 //int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1 }; 
 void SelectionSort(int[]array)
 {
    for (int i=0; i< array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i +1; j< array.Length; j++)
        {
            if (array[j]<array[minPosition])
            {
                minPosition= j;
            }
        }
        int temporary = array[i];
        array[i]= array[minPosition];
        array[minPosition]= temporary;
 }
 }
 
PrintArray(arr);
SelectionSort(arr);
//Console.WriteLine("arr");
PrintArray(arr);  задача на увеличение массива */

