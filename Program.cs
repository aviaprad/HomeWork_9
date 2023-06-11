//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



void ShowNumbers(int n, int i)
{

  if (i<n) ShowNumbers(n,i+1);
    Console.Write (i+" ");
}


Console.WriteLine("Input number:");
int number = Convert.ToInt32(Console.ReadLine());
ShowNumbers(number,1);



//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*

int SumOfElements(int n, int m)
{
  if (n == m) return n;
  else return SumOfElements(n + 1, m) + n;
}

Console.WriteLine("Input number M:");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number N:");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumOfElements(numM, numN));
*/
/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

/*
int AkkermannFunction (int numberM, int numberN) // Метод вычисления функции Аккермана
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AkkermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AkkermannFunction(numberM - 1, AkkermannFunction(numberM, numberN - 1));
return AkkermannFunction(numberM, numberN);
}

Console.WriteLine("Input number M:");
int numM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number N:");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Akkerman function of numbers({numM},{numN}) = {AkkermannFunction(numM, numN)}");
*/