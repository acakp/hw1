using System;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        // Task1();
        // Task2();
        Task3();
    }

    // Begin9. Найти площадь кольца, внутренний радиус которого равен R1,
    // а внешний радиус равен R2 (R1 < R2).
    // В качестве значения Pi использовать 3.14.
    private static void Task1()
    {
        const double pi = 3.14;
        Console.WriteLine("Введите радиус внутреннего кольца");
        var R1 = Console.ReadLine();
        Console.WriteLine("Введите радиус внешнего кольца");
        var R2 = Console.ReadLine();

        double dR1 = Convert.ToDouble(R1);
        double dR2 = Convert.ToDouble(R2);

        if (dR1 < dR2)
        {
            Console.WriteLine("Площадь кольца = " + (dR2 * dR2 * pi - dR1 * dR1 * pi));
        }
        else
        {
            Console.WriteLine("Введены некорректные значения");
        }
    }

    // Begin9.Даны две переменные целого типа: A и B.Если их значения не равны,
    // то присвоить каждой переменной максимальное из этих значений, а если равны,
    // то присвоить переменным нулевые значения.
    private static void Task2()
    {
        Console.WriteLine("Введите значение А");
        var A = Console.ReadLine();
        Console.WriteLine("Введите значение В");
        var B = Console.ReadLine();

        int iB = Convert.ToInt32(B);
        int iA = Convert.ToInt32(A);

        if (iA != iB)
        {
            if (iA > iB)
            {
                B = A;
            }
            else
            {
                A = B;
            }
        }
        else
        {
            A = "0"; B = "0";
        }
    }

    // Begin9.Локатор ориентирован на одну из сторон света
    // ("С" — север, "З" — запад, "Ю" — юг, "В" — восток)
    // и может принимать три цифровые команды: 1 — поворот налево,
    // –1 — поворот направо, 2 — поворот на 180 градусов.
    // Дан символ C — исходная ориентация локатора и числа N1 и N2 —
    // две посланные ему команды.Вывести ориентацию локатора после
    // выполнения данных команд. 
    private static void Task3()
    {
        Console.WriteLine("Введите начальную ориентацию (С/З/Ю/В):");
        var C = Console.ReadLine();
        Console.WriteLine("Введите первую команду (-1/1/2):");
        var N1 = Console.ReadLine();
        Console.WriteLine("Введите вторую команду (-1/1/2):");
        var N2 = Console.ReadLine();

        int currOrientation = 0;
        switch (C)
        {
            case "С": currOrientation = 0; break;
            case "З": currOrientation = 1; break;
            case "Ю": currOrientation = 2; break;
            case "В": currOrientation = 3; break;
            default: Console.WriteLine("Введены некорректные значения"); break;
        }

        int iN1 = Convert.ToInt32(N1);
        int iN2 = Convert.ToInt32(N2);
        currOrientation = currOrientation + iN1 + iN2;

        // чтобы значение оставалось в пределах от 0 до 3
        if (currOrientation < 1)
        {
            currOrientation += 4;
        }
        currOrientation %= 4;

        Console.Write("Локатор ориентирован на ");
        switch (currOrientation)
        {
            case 0: Console.WriteLine("север"); break;
            case 1: Console.WriteLine("запад"); break;
            case 2: Console.WriteLine("юг"); break;
            case 3: Console.WriteLine("восток"); break;
            default: Console.WriteLine("[НЕ ОПРЕДЕЛЕНО]"); break;
        }
    }
}
