using System;

namespace TaxiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sentiment Analysis:
            Console.WriteLine("Write a review of your taxi driver: ");

            //Load input data
            var sampleData = new ReviewSentimentModel.ModelInput()
            {
                Comment = Console.ReadLine()
            };

            //Load model and predict output
            var result = ReviewSentimentModel.Predict(sampleData);

            string printedString = "";

            if (result.Prediction == "positive") { printedString = "Thanks for the great review! :)"; };

            if (result.Prediction == "negative") { printedString = "We're sorry you had a bad experience. :("; };

            Console.WriteLine($"\n{printedString}");
        }
    }
}
