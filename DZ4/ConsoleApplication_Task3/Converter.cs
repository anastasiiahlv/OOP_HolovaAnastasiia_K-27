using System;
class Converter
{
    private decimal _dollarRate;
    private decimal _euroRate;

    public Converter(decimal dollarRate, decimal euroRate)
    {
        this._dollarRate = dollarRate;
        this._euroRate = euroRate;
    }

    public void ConvertUAHtoUSD(decimal UAH)
    {
        Console.WriteLine("Result of conversion from UAH to USD: " + Convert.ToString(UAH / _dollarRate) + "\n");
    }

    public void ConvertUAHtoEUR(decimal UAH)
    {
        Console.WriteLine("Result of conversion from UAH to EUR: " + Convert.ToString(UAH / _euroRate) + "\n");
    }

    public void ConvertUSDtoUAH(decimal USD)
    {
        Console.WriteLine("Result of conversion from USD to UAH: " + Convert.ToString(USD * _dollarRate) + "\n");
    }

    public void ConvertEURtoUAH(decimal EUR)
    {
        Console.WriteLine("Result of conversion from EUR to UAH: " + Convert.ToString(EUR * _euroRate) + "\n");
    }
}

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Enter the dollar rate: ");
        decimal dollarRate = Checking();
        Console.WriteLine("---------------------------");

        Console.Write("Enter the euro rate: ");
        decimal euroRate = Checking();
        Console.WriteLine("---------------------------");

        Converter converter = new Converter(dollarRate, euroRate);

        decimal funcNum;
        string toContinue = " ";

        do {
            Console.WriteLine(" 1 - Convert from UAH to USD\n 2 - Convert from UAH to EUR\n 3 - Convert from USD to UAH\n 4 - Convert from EUR to UAH\n");
            Console.Write("Enter the function number shown above: ");
            funcNum = Checking();

            switch (funcNum)
            {
                case 1:
                    Console.WriteLine("Enter UAH: ");
                    decimal UAH = Checking();
                    converter.ConvertUAHtoUSD(UAH);
                    break;
                case 2:
                    Console.WriteLine("Enter UAH: ");
                    UAH = Checking();
                    converter.ConvertUAHtoEUR(UAH);
                    break;
                case 3:
                    Console.WriteLine("Enter USD: ");
                    decimal USD = Checking();
                    converter.ConvertUSDtoUAH(USD);
                    break;
                case 4:
                    Console.WriteLine("Enter EUR: ");
                    decimal EUR = Checking();
                    converter.ConvertEURtoUAH(EUR);
                    break;
                default:
                    Console.WriteLine("Incorrect input.");
                    break;
            }
            Console.WriteLine("If you want to continue, enter 'YES'. Otherwise, press any key.");
            toContinue = Console.ReadLine();
        } while (toContinue == "YES");

        Console.WriteLine("You have finished running the program.");

        Console.ReadKey();
    }

    static decimal Checking()
    {
        decimal rate;
        string input = Console.ReadLine();
        while (true)
        {
            if (decimal.TryParse(input, out rate))
            {
                if(rate > 0)
                {
                    return rate;
                }
            }
            Console.WriteLine("Incorrect input.");
            Console.Write("Please, try again: ");
            input = Console.ReadLine();
        }
    }
}