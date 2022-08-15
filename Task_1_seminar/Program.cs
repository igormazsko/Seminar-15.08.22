// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// **Задача 30:** Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.[1,0,1,1,0,1,0,0]

using static System.Console;
Clear();
// WriteLine("Введите число А");
// int [] array = new int [8];
// int i = 0;
// array [ i ] = new Random().Next(0,2);

int [] GetArrey (int N)
{
int [] array = new int[N];
for (int i = 0;  i<N; i++)
    {
       array [i]= new Random().Next (0,2);  
    }
       return array;
       }

void PrintArray(int[] Mass)
{
    Write("[ ");
    for (int i = 0;  i<Mass.Length; i++)
    {
      Write (Mass[i] + " ");
    }
    Write(" ]");
}



int[] array = GetArrayFromString(ReadLine());

WriteLine($"[{String.Join(",",array)}]");

int[] GetArrayFromString(string arrayString)
{
    string[] massString = arrayString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result= new int [massString.Length];
    for (int i=0; i<result.Length; i++)
    {
        result[i] = int.Parse(massString[i]);
    }
    return result;
}

