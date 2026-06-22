using System;

class Program
{
    static double Forecast(double amount,double rate,int years)
    {
        if (years==0)
            return amount;

        return Forecast(amount*(1+rate),rate,years-1);
    }

    static void Main()
    {
        double futureValue=Forecast(10000,0.05,5);

        Console.WriteLine("Future Value after 5 years: " +
                          futureValue.ToString("F2"));
    }
}
