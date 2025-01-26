namespace practise_5;
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static string str = "Hello";
    public static int i = 123;
    public static bool flag = true;
    public static double j = 12.33;
    public static char c = 't';


    static void Main(string[] args)
    {
        // практика A
        Console.WriteLine($"Строка : {str}");
        Console.WriteLine($"Целочисленное : {i}");
        Console.WriteLine($"Логическое : {flag}"); 
        Console.WriteLine($"Вещественный : {j}"); 
        Console.WriteLine($"Символ : {c}"); 
        // практика B
        Console.WriteLine($"Введите первое число :"); 
        double a =  Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Введите второе число :"); 
        double b =  Convert.ToDouble(Console.ReadLine());  
        Console.WriteLine($"Сумма : {a+b}");
        Console.WriteLine($"Вычитание : {a-b}");
        Console.WriteLine($"Умножение : {a*b}");
        Console.WriteLine($"Деление : {a/b}");
        // практика C
        Console.WriteLine($"Введите число :"); 
        int s =  Convert.ToInt32(Console.ReadLine());  
        Console.WriteLine($"Результат : {s*5}");

    }

}
