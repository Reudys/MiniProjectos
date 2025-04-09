using MyMLApp;
using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            // Solicitar entrada del usuario
            Console.WriteLine("Ingrese un texto para analizar el sentimiento:");
            var userInput = Console.ReadLine();

            // Crear datos de entrada con el texto proporcionado por el usuario
            var sampleData = new SentimentModel.ModelInput()
            {
                Col0 = userInput
            };

            // Cargar el modelo y predecir el sentimiento del texto de entrada
            var result = SentimentModel.Predict(sampleData);

            // Determinar el sentimiento según el valor predicho
            var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";
            Console.WriteLine($"Texto: {sampleData.Col0}\nSentimiento: {sentiment}");
            Console.ReadKey();
            Console.Clear();
        }
    }
}