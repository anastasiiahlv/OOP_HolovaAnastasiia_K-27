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
        Console.WriteLine("Result of conversion from UAH to USD: " + Convert.ToString(UAH / _dollarRate));
    }

    public void ConvertUAHtoEUR(decimal UAH)
    {
        Console.WriteLine("Result of conversion from UAH to EUR: " + Convert.ToString(UAH / _euroRate));
    }

    public void ConvertUSDtoUAH(decimal USD)
    {
        Console.WriteLine("Result of conversion from USD to UAH: " + Convert.ToString(USD * _dollarRate));
    }

    public void ConvertEURtoUAH(decimal EUR)
    {
        Console.WriteLine("Result of conversion from EUR to UAH: " + Convert.ToString(EUR * _euroRate));
    }
}

class Program
{
    static void Main(string[] args)
    {
        Converter converterFromUah = new Converter(38.2m, 40.9m);

        converterFromUah.ConvertUAHtoUSD(100);
        converterFromUah.ConvertUAHtoEUR(100);

        Converter converterToUah = new Converter(37.5m, 40.15m);
        converterToUah.ConvertUSDtoUAH(100);
        converterToUah.ConvertEURtoUAH(100);

        Console.ReadKey();
    }
}