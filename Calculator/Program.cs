using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Xml.Linq;

//todo att kunna ange fler än två tal

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

    choice = CheckNummer("Ange ditt val!");

    switch (choice)
    {
        case 1:
            {
                Addition();
                break;
            }
        case 2:
            {
                Subtraction();
                break;
            }
        case 3:
            {
                Division();
                break;
            }
        case 4:
            {
                Multiplication();
                break;
            }
        case 5:
            {
                SquareRoot();
                break;
            }
        case 6:
            {
                Max();
                break;
            }
        case 7:
            {
                Min();
                break;
            }
        case 8:
            {
                Absolute();
                break;
            }
        case 9:
            { 
                Log2();
                break;
            }
        case 10:
            {
                Log10();
                break;
            }
        case 11:
            {
                Percent();
                break;
            }
        case 99:
            {
                Console.Clear();
                Console.WriteLine("Hej då");
                run = false;
                break;
            }

        default:
            {
                Console.WriteLine("Felaktig inmatnig försök igen!");
                break;
            }

    }
    Console.WriteLine("Tryck enter för att fortsätta");
    Console.ReadLine();

    Console.Clear();
} while (run);

static void Addition()
{
    var maths = Inputs("Addition");

    Console.WriteLine(maths.Item1 + maths.Item2);
}

static void Subtraction()
{
    var maths = Inputs("Subtraction");

    Console.WriteLine(maths.Item1 - maths.Item2 );
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

    Console.WriteLine( Math.Sqrt(temp) );
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
    int temp = CheckNummer("Ange siffran");
    Console.WriteLine(Math.Abs(temp));
}

static void Log2()
{
    Console.WriteLine("Log2");
    int temp = CheckNummer("Ange siffran");
    Console.WriteLine(Math.Log2(temp));
}

static void Log10()
{
    Console.WriteLine("Log10");
    int temp = CheckNummer("Ange siffran");
    Console.WriteLine(Math.Log10(temp));
}

static void Percent()
{
    Console.WriteLine("Percent");
    int temp = CheckNummer("Ange talet");
    int temp2 = CheckNummer("Ange Percent 'te.x 45'");
    double temp3 = temp2/100;
    Console.WriteLine( Math.Round( temp * temp3));
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
    string? temp = null;
    int choice = 0;

    do
    {
        Console.WriteLine(num);
        
        temp = Convert.ToString(Console.ReadLine());

        if (!int.TryParse(temp, out choice))
        {
            temp = null;
            Console.Clear();
            Console.WriteLine("Felaktig inmatnig försök igen!");
            continue;
        }
    } while (string.IsNullOrEmpty(temp));

    return choice;
}

