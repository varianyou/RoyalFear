using System;
using System.Xml.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        action(enterfnum(), entersnum(), menu());
    }
    public static int menu()
    {
        Console.WriteLine("1 - Частное");
        Console.WriteLine("2 - Произведение");
        Console.WriteLine("3 - Разность");
        Console.WriteLine("4 - Сумма");
        Console.WriteLine("Выберите вариант действия: ");
        return Convert.ToInt32(Console.ReadLine());
    }
    public static int enterfnum()
    {
        int firsnum = 0;
        Console.WriteLine("Введите 1-ое число: ");
        firsnum = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        return firsnum;
    }
    public static int entersnum()
    {
        int secnum = 0;
        Console.WriteLine("Введите 2-ое число: ");
        secnum = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        return secnum;
    }
    public static void action(int firsnum, int secnum, int casechos)
    {
        switch (casechos)
        {
            case 1:
                int result = firsnum / secnum;
                Console.Clear();
                Console.WriteLine("Результат - " + result);
                break;
            case 2:
                result = firsnum * secnum;
                Console.Clear();
                Console.WriteLine("Результат - " + result);
                break;
            case 3:
                result = firsnum - secnum;
                Console.Clear();
                Console.WriteLine("Результат - " + result);
                break;
            case 4:
                result = firsnum + secnum;
                Console.Clear();
                Console.WriteLine("Результат - " + result);
                break;
            default:
                Console.Clear();
                Console.WriteLine("Неправильно!");
                break;
        }
    }
    public static void bublesort()
    {
        int startpoint = 0;
        int finishpoint = 0;
    }
}