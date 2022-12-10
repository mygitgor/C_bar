internal class Program
{
    private static void Main(string[] args)
    {
        // Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
        
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        
        int c = a * a;
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
        else
        {
             System.Console.WriteLine("your sums are equal");
        }


        // Задача 4: Напишите программу, которая принимает на вход
        // три числа и выдает максимальное из этих чисел.

        int a1 = Convert.ToInt32(Console.ReadLine());
        int b1 = Convert.ToInt32(Console.ReadLine());
        int c1 = Convert.ToInt32(Console.ReadLine());
        int max;
    
        max = 0;
        if (a1 > b1 && a1 > c1) 
        {
            max = a1;
            Console.WriteLine("maximal chislo " + max);
        }
        else if (b1 > a1 && b1 > c1) 
        {
            max = b1;
            Console.WriteLine("maximal chislo " + max);
        }
        else if (c1 > a1 && c1 > b1) 
        {
            max = c1;
            Console.WriteLine("maximal chislo " + max);
        }


        // Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

                   for (int n = -10; n <= 10; n++) {
                     System.Console.WriteLine("natural chislo:"+ n);  
                   }


            // Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным

        int number = new Random().Next(0, 10);
                   for (number = 0; number <= 10; number++)
                   {
                     if (number % 2 == 0) 
                     System.Console.WriteLine("cetnaya chislo:"+ number);  
                   }


    //    Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

       
       int n1 = Convert.ToInt32(Console.ReadLine());       
       
       for (int i=n1; i>0;  i--)if (i%2==0)
       {
        System.Console.WriteLine(i);
       }
       


    }



}