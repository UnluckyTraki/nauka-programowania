using System;
using System.Collections.Generic;

namespace WiredBrainCoffeeSurveys.Reports
{
    class Program
    {
        static void Main(string[] args)
        {
            //obliczeniowe pierdoly

            //double responseRate = Q1Results.NumberResponded / Q1Results.NumberSurveyed;
            //double unansweredCount = Q1Results.NumberSurveyed - Q1Results.NumberResponded;
            //Console.WriteLine($"Response Percentage: {responseRate}");
            //Console.WriteLine($"Unanswered Surveys: {unansweredCount}");
            //double ogolnaSredniaOcenaKawiarni = (Q1Results.ServiceScore + Q1Results.CoffeeScore + Q1Results.FoodScore + Q1Results.PriceScore) / 4;
            //Console.WriteLine($"Ocena kawiarni: {ogolnaSredniaOcenaKawiarni}/10");

            //Logiczne porownania

            //bool higherCofeeScore = Q1Results.CoffeeScore > Q1Results.FoodScore;
            //bool customerRecommend = Q1Results.WouldRecommend > 5;
            //bool noGranolaYesCappucino = Q1Results.LeastFavoriteProduct == "Granola" && Q1Results.FavoriteProduct == "Cappucino";
            //Console.WriteLine($"Coffee score higher than food: {higherCofeeScore}");
            //Console.WriteLine($"Customers would recommend us: {customerRecommend}");
            //Console.WriteLine($"Hate on granola and love to cappucino: {noGranolaYesCappucino}");

            var tasks = new List<string>();
            double responseRate = Q1Results.NumberResponded / Q1Results.NumberSurveyed;
            double unansweredCount = Q1Results.NumberSurveyed - Q1Results.NumberResponded;
            bool lowerCofeeScore = Q1Results.CoffeeScore < Q1Results.FoodScore;

            if (lowerCofeeScore) //lub gorna linijka w nawiasie
            {
                tasks.Add("Sprawdz skladniki");
            }
           


        }


    }
}
