/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

int GetNumber ()
{
    int result = 0;
    while (true)
    {
        Console.WriteLine ("введите число: ");
       if (int.TryParse(Console.ReadLine(), out result))
       {
        break;
       }
       else
       {
        Console.WriteLine("Ввели не цифру попробуйте еще раз: ");
       }
    }
    return result;
}

void GetFibunuchi (int number)
{
    int number1 = 0;
    int number2 =1;
    int number3 =0;
    Console.Write("0 1 " );
    for (int i = 2; i < number; i++)
    {
      //1               0          1
      number3 =  number1 + number2;
      number1 = number2;
      number2 =number3;
       Console.Write($"{number3} ");
    }
   
}

int num = GetNumber();
GetFibunuchi(num);
