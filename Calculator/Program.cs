
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
                Console.WriteLine("Hej då");
                run = false;
                break;
            }

        default:
            {
                fel = "Felaktig val försök igen!";
                break;
            }

    }

    Console.ReadLine();
    Console.Clear();
} while (run);

Console.ReadLine();


static void Addition()
{
    var maths = Inputs("Addition");

    Console.WriteLine(maths.Item1 + maths.Item2);
}

static void Subtraction()
{
    var maths = Inputs("Subtraction");

    Console.WriteLine(maths.Item1 - maths.Item2);
}

static void Division()
{
    var maths = Inputs("Division");

    if (maths.Item2 == 0)
    {
        Console.WriteLine("Division med noll är inte definierad för de reella talen");
    }
    else
    {
        Console.WriteLine(maths.Item1 / maths.Item2);
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

    NotNoll(Math.Sqrt(temp));
}

static void Max()
{
    var maths = Inputs("Max");

    Console.WriteLine(Math.Max(maths.Item1, maths.Item2));
}

static void Min()
{
    var maths = Inputs("Min");

    Console.WriteLine(Math.Min(maths.Item1, maths.Item2));
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
    double temp2 = Convert.ToDouble(CheckNummer("Ange Percent tal 'te.x 45'"));
    double temp3 = (temp2 / 100);
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

static void NotNoll(double res)
{
    if (res < 1)
    {
        Console.WriteLine(res);
    }
    else
    {
        Console.WriteLine(0);
    }
}