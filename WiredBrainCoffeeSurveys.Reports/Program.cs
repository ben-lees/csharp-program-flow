using System;

namespace WiredBrainCoffeeSurveys.Reports
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculated values
            double responseRate = Q1Results.NumberResponded / Q1Results.NumberSurveyed;
            double unansweredCount = Q1Results.NumberSurveyed - Q1Results.NumberResponded;
            double overallScore = (Q1Results.CoffeeScore + Q1Results.FoodScore + Q1Results.PriceScore + Q1Results.ServiceScore) / 4;

            Console.WriteLine($"Response Percentage: {responseRate}");
            Console.WriteLine($"Unanswered Suverys: {unansweredCount}");
            Console.WriteLine($"OverallScore: {overallScore}");

            bool higherCoffeeScore = Q1Results.CoffeeScore > Q1Results.FoodScore;
            bool customerRecommend = Q1Results.WouldRecommend >= 7;
            bool noGranolaYesCappucino = Q1Results.LeastFavoriteProduct == "Granola" && Q1Results.FavoriteProduct == "Cappucino";

            Console.WriteLine($"Coffee score higher than food:{higherCoffeeScore}");
            Console.WriteLine($"Customers would recommend us: {customerRecommend}");
            Console.WriteLine($"Dislike Granola, love Capupucino : {noGranolaYesCappucino}");
        }
    }
}
