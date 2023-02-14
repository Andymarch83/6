/*Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10*/

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


int [] GetResult (int number)
{
    List<int> result = new List<int> ();
    while (number>0)
    {
       result.Add(number%2);
       number/=2;

    }
return result.ToArray();
}

int num = GetNumber ("Введите число: ");
int [] arr = GetResult(num);
Array.Reverse(arr);
Console.Write(String.Join(" ", arr));
