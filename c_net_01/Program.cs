internal class Program
{
    private static void Main(string[] args)
    {
        // Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
        int a, b, c;
        a = 5;
        b = 25;
        c = a * a;
        if (b == c) Console.WriteLine("a kvadrat b");
        else if (b != c) Console.WriteLine("a !=no kvadrat b");



        // Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.


        int digit1 = Convert.ToInt32(Console.ReadLine());
        int digit2 = Convert.ToInt32(Console.ReadLine());


        if (digit1 > digit2)
        {
            System.Console.WriteLine($"max= {digit1}");
            System.Console.WriteLine($"min= {digit2}");
        }
        else if (digit1 < digit2)
        {
            System.Console.WriteLine($"max= {digit2}");
            System.Console.WriteLine($"min= {digit1}");
        }


        // Задача 4: Напишите программу, которая принимает на вход
        // три числа и выдает максимальное из этих чисел.


        int a1, b1, c1, max;
        a1 = 8;
        b1 = 5;
        c1 = 4;
        max = 0;
        if (a1 > b1 && c1 < b1) max = a1;
        {
            Console.WriteLine("maximal chislo " + max);
        }


        // Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

        int numBer = new Random().Next(-10, 10);
                   for (numBer = -10; numBer < 10; numBer++) {
                     System.Console.WriteLine("natural chislo:"+ numBer);  
                   }


            // Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным

        int number = new Random().Next(0, 10);
                   for (number = 0; number <= 10; number++)
                   {
                     if (number % 2 == 0) 
                     System.Console.WriteLine("cetnaya chislo:"+ number);  
                   }



    }



}