using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Xml.Linq;

{
    string fel = "";
    int choice = 0;
    bool run = true;
    do
    {
        Console.WriteLine("Calculator");
        Console.WriteLine("\tMenysystem");
        Console.WriteLine("\tVälj mellan funktionerna: ");
        Console.WriteLine("\t\t 1: Addition ");
        Console.WriteLine("\t\t 2: Subtraction ");
        Console.WriteLine("\t\t 3: Division ");
        Console.WriteLine("\t\t 4: Multiplication ");
        Console.WriteLine("\t\t 5: SquareRoot ");
        Console.WriteLine("\t\t 6: Max ");
        Console.WriteLine("\t\t 7: Min ");
        Console.WriteLine("\t\t 8: Absolute ");
        Console.WriteLine("\t\t 9: Log2 ");
        Console.WriteLine("\t\t 10: Log10 ");
        Console.WriteLine("\t\t 11: Percent ");
        Console.WriteLine("\t\t 99: för att avsluta");

        if (fel == "")
        {
            Console.WriteLine("\t" + fel);
            fel = "";
        }

        choice = CheckNummer("\tAnge ditt val!");

    

        switch (choice)
        {
            case 1:
                {
                    Console.Clear();
                    Addition();
                    Console.ReadLine();
                    break;
                }
            case 2:
                {
                    Console.Clear();
                    Subtraction();
                    Console.ReadLine();
                    break;
                }
            case 3:
                {
                    Console.Clear();
                    Division();
                    Console.ReadLine();
                    break;
                }
            case 4:
                {
                    Console.Clear();
                    Multiplication();
                    Console.ReadLine();
                    break;
                }
            case 5:
                {
                    Console.Clear();
                    SquareRoot();
                    Console.ReadLine();
                    break;
                }
            case 6:
                {
                    Console.Clear();
                    Max();
                    Console.ReadLine();
                    break;
                }
            case 7:
                {
                    Console.Clear();
                    Min();
                    Console.ReadLine();
                    break;
                }
            case 8:
                {
                    Console.Clear();
                    Absolute();
                    Console.ReadLine();
                    break;
                }
            case 9:
                {
                    Console.Clear();
                    Log2();
                    Console.ReadLine();
                    break;
                }
            case 10:
                {
                    Console.Clear();
                    Log10();
                    Console.ReadLine();
                    break;
                }
            case 11:
                {
                    Console.Clear();
                    Percent();
                    Console.ReadLine();
                    break;
                }
            case 99:
                {
                    run = false;
                    break;
                }

            default:
                {
                    fel = "Felaktig inmatnig försök igen!";
                    break;
                }

        }

        Console.Clear();
    } while (run);
    Console.WriteLine("Hej då");
    Console.ReadLine();
}

static void Addition()
{
    var maths = Inputs("Addition");

    Console.WriteLine(maths.Item1 + maths.Item2);
}

static void Subtraction()
{
    var maths = Inputs("Subtraction");

    int max = Math.Max(maths.Item1, maths.Item2);
    int min = Math.Min(maths.Item1, maths.Item2);

    Console.WriteLine(max - min);
}

static void Division()
{
    var maths = Inputs("Division");

    if(maths.Item2 == 0)
    {
        Console.WriteLine("Division med noll är inte definierad för de reella talen");
    }
    else
    {
        Console.WriteLine(maths.Item1 / maths.Item2 );
    }
    
}

static void Multiplication()
{
    var maths = Inputs("Multiplication");

    Console.WriteLine(maths.Item1 * maths.Item2);
}

static void SquareRoot()
{
    Console.WriteLine("Square Root");
    int temp = CheckNummer("Ange siffran");

    NotNoll( Math.Sqrt(temp) );
}

static void Max()
{
    var maths = Inputs("Max");

    Console.WriteLine(Math.Max(maths.Item1, maths.Item2) );
}

static void Min()
{
    var maths = Inputs("Min");

    Console.WriteLine(Math.Min(maths.Item1, maths.Item2) );
}

static void Absolute()
{
    Console.WriteLine("Absolute");
    int temp = CheckNummer("Ange en negative siffran");
    Console.WriteLine(Math.Abs(temp));
}

static void Log2()
{
    Console.WriteLine("Log2");
    int temp = CheckNummer("Ange siffran");
    NotNoll(Math.Log2(temp));
}

static void Log10()
{
    Console.WriteLine("Log10");
    int temp = CheckNummer("Ange siffran");

    NotNoll(Math.Log10(temp));
}


static void Percent()
{
    Console.WriteLine("Percent");
    int temp = CheckNummer("Ange talet");
    double temp2 = Convert.ToDouble( CheckNummer("Ange Percent tal 'te.x 45'") );
    double temp3 = (temp2/100);
    NotNoll(Math.Round(temp * temp3));

}

static Tuple<int, int> Inputs(string type)
{
    Console.WriteLine(type);

    int temp = CheckNummer("Ange första siffran");
    int temp2 = CheckNummer("Ange andra siffran");

    return Tuple.Create(temp, temp2);
}

static int CheckNummer(string num)
{
    string fel = "";
    string? temp = null;
    int choice = 0;

    do
    {
        if (fel == "")
        {
            Console.WriteLine("\t" + fel);
            fel = "";
        }
            

        Console.WriteLine(num);
        
        temp = Convert.ToString(Console.ReadLine());
        
        if (!int.TryParse(temp, out choice))
        {
            temp = null;
            fel = "Felaktig inmatnig försök igen!";
            continue;
        }
    } while (string.IsNullOrEmpty(temp));

    return choice;
}

static void NotNoll(double res)
{
    if (res < 1)
    {
        Console.WriteLine(res);
    }
    else
    {
        Console.WriteLine("För litet för att vissa som heltal");
    }
}