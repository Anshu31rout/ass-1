using System;

public class FinancialForecasting
{
    public static double CalculateFutureValueRecursive(double currentValue, double growthRate, int periods)
    {
        if (periods == 0)
            return currentValue;
        double nextValue = currentValue * (1 + growthRate);
        return CalculateFutureValueRecursive(nextValue, growthRate, periods - 1);
    }
}

public class ForecastTest
{
    public static void Main(string[] args)
    {
        double initialInvestment = 1000.00;
        double annualGrowthRate = 0.05;
        int yearsToForecast = 10;

        double futureValue = FinancialForecasting.CalculateFutureValueRecursive(initialInvestment, annualGrowthRate, yearsToForecast);
        Console.WriteLine($"Predicted Future Value: ${futureValue:N2}");
    }
}
