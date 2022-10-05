using CalculatorApp;
using System.Text.RegularExpressions;

Calculator calculator = new Calculator();

string fel = "";
int choice = 0;
bool run = true;
do
{
    Console.WriteLine("Calculator");
    Console.WriteLine("\tMenysystem");
    Console.WriteLine("\tVälj mellan funktionerna: ");
    Console.WriteLine("\t\t 1: Addition ");
    Console.WriteLine("\t\t 2: Addition Array");
    Console.WriteLine("\t\t 3: Subtraction");
    Console.WriteLine("\t\t 4: Subtraction Array");
    Console.WriteLine("\t\t 5: Division ");
    Console.WriteLine("\t\t 6: Multiplication ");
    Console.WriteLine("\t\t 7: SquareRoot ");
    Console.WriteLine("\t\t 8: Max ");
    Console.WriteLine("\t\t 9: Min ");
    Console.WriteLine("\t\t 10: Absolute ");
    Console.WriteLine("\t\t 11: Log2 ");
    Console.WriteLine("\t\t 12: Log10 ");
    Console.WriteLine("\t\t 13: Percent ");
    Console.WriteLine("\t\t 99: för att avsluta");

    if (fel != "")
    {
        Console.WriteLine("\t" + fel);
        fel = "";
    }

    choice = CheckNummer("\tAnge ditt val!");


    Console.Clear();
    switch (choice)
    {
        case 1:
            {
                var maths = Inputs("Addition");

                Console.WriteLine(calculator.Addition(maths.Item1, maths.Item2));

            }
            break;
        case 2:
            {
                var maths = InputArray();

                Console.WriteLine(calculator.Addition(maths));

            }
            break;
        case 3:
            {
                var maths = Inputs("Subtraction");

                Console.WriteLine(calculator.Subtraction(maths.Item1, maths.Item2));

            }
            break;
        case 4:
            {
                var maths = InputArray();

                Console.WriteLine(calculator.Addition(maths));

            }
            break;
        case 5:
            {
                var maths = Inputs("Division");
                try
                {
                    Console.WriteLine(calculator.Division(maths.Item1, maths.Item2));
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Division med noll är inte definierad för de reella talen");
                }
            }
            break;
        case 6:
            {
                var maths = Inputs("Multiplication");

                Console.WriteLine(calculator.Multiplication(maths.Item1, maths.Item2));

            }
            break;
        case 7:
            {
                Console.WriteLine("Square Root");
                int maths = CheckNummer("Ange siffran");

                Console.WriteLine(calculator.SquareRoot(maths));

            }
            break;
        case 8:
            {
                var maths = Inputs("Max");

                Console.WriteLine(calculator.Max(maths.Item1, maths.Item2));

            }
            break;
        case 9:
            {
                var maths = Inputs("Min");

                Console.WriteLine(calculator.Min(maths.Item1, maths.Item2));


            }
            break;
        case 10:
            {
                Console.WriteLine("Absolute");
                int maths = CheckNummer("Ange en negative siffran");

                Console.WriteLine(calculator.Absolute(maths));

            }
            break;
        case 11:
            {
                Console.WriteLine("Log2");
                int maths = CheckNummer("Ange siffran");

                Console.WriteLine(calculator.Log2(maths));

            }
            break;
        case 12:
            {
                Console.WriteLine("Log10");
                int maths = CheckNummer("Ange siffran");

                Console.WriteLine(calculator.Log10(maths));

            }
            break;
        case 13:
            {
                Console.WriteLine("Percent");
                int maths = CheckNummer("Ange talet");
                int maths2 = CheckNummer("Ange Percent tal 'te.x 45'");

                Console.WriteLine(calculator.Percent(maths, maths2));

            }
            break;
        case 99:
            {
                Console.WriteLine("Hej då");
                run = false;

            }
            break;

        default:
            {
                fel = "Felaktig val försök igen!";

            }
            break;
    }

    Console.ReadLine();
    Console.Clear();
} while (run);

Console.ReadLine();

static Tuple<int, int> Inputs(string type)
{
    Console.WriteLine(type);

    int temp = CheckNummer("Ange första siffran");
    int temp2 = CheckNummer("Ange andra siffran");

    return Tuple.Create(temp, temp2);
}

static bool DoesInputContainsNumbers(string input)
{
    if (string.IsNullOrWhiteSpace(input))
    {
        return false;
    }
    try
    {
        input.Split(",").Select(x => int.Parse(x)).ToList();
    }
    catch (Exception ex)
    {
        return false;
    }
    return true;
}

static int[] InputArray()
{
    bool isRuning = true;
    string? temp = "";
    List<int> myInts = new List<int>();

    do
    {
        Console.WriteLine("Ange de komma-separerade siffror som ska adderas");
        Console.WriteLine($"Ange siffra");
        temp = Convert.ToString(Console.ReadLine());

        string pattern = @"^\d+(,\d+)*$";

        isRuning = !Regex.IsMatch(temp, pattern);

    } while (!DoesInputContainsNumbers(temp));

    try
    {
        Array.ForEach(temp.Split(",".ToCharArray()), s =>
        {
            int currentInt;
            if (Int32.TryParse(s, out currentInt))
                myInts.Add(currentInt);
        });

        isRuning = false;
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }

    return myInts.ToArray();
}

static int CheckNummer(string num)
{
    string fel = "";
    string? temp = null;
    int choice = 0;

    do
    {
        if (fel != "")
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