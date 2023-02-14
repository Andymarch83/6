/*Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.*/
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
        Console.WriteLine("Ввели не цифроб попробуйте еще раз: ");
       }
    }
    return result;
}

void Getlenght (int numberA, int numberB, int numberC )
{


    if(numberA < numberB + numberC && 
      numberB<  numberA+ numberC && 
      numberC < numberA + numberB)
    Console.WriteLine (" является треугольник с сторонами такой длины.");
    else Console.WriteLine ("не является треугольником");


}

int numberA =GetNumber();
int numberB =GetNumber();
int numberC =GetNumber();
Getlenght(numberA,numberB,numberC);