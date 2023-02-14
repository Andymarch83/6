// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int GetNumber (string message)
{
    int result = 0;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ошибка ввода, вы ввели не число. Повторите ввод:");
        }
    }
    return result;
}

int [] GenerateArray(int Lenght, int minValue, int maxValue)
{
    int [] array = new int [Lenght];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue+1);
    }
return array;
}

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       Console.Write($"{array[i]}, "); 
    }
    Console.WriteLine();
}


int [] CoppyArray (int [] arr)
{
    int [] resultArray = new int[arr.Length];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = arr[i];
    }
return resultArray;
}

int lengthArray = GetNumber("Введите количество элементов массива: ");
int max = GetNumber("Введите начало для диапазона: ");
int min = GetNumber("Введите конечное значение для диапазона: ");
int [] array = GenerateArray(lengthArray, max, min);
PrintArray (array);
int [] coppyArray = CoppyArray(array);
Console.WriteLine();
PrintArray (coppyArray);
