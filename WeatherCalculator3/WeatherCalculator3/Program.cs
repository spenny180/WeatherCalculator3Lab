using System;

namespace WeatherCalculator3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Weather Calculator 3 ###");

            int temperature;
            int windSpeed;
            double windChill;
            int relativeHumidity;
            double heatIndex;
            string input = "";

            do
            {
                Console.WriteLine("Enter the temperature");
                input = Console.ReadLine();
                temperature = int.Parse(input);
                if (temperature > 49.9)
                {
                    Console.WriteLine("Enter the relative humidity");
                    input = Console.ReadLine();
                    relativeHumidity = int.Parse(input);
                    heatIndex = 0.5 * (temperature + 61.0 + ((temperature - 68.0) * 1.2) + (relativeHumidity * 0.094));
                    Console.WriteLine("The heat index is " + heatIndex);
                }
                else
                {
                    Console.WriteLine("Enter the wind speed");
                    input = Console.ReadLine();
                    windSpeed = int.Parse(input);
                    windChill = 35.74 + (0.6125 * temperature) - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * temperature * Math.Pow(windSpeed, 0.16);
                    Console.WriteLine("The wind chill is " + windChill);
                }
                Console.WriteLine("Would you like to continue? Enter yes or no");
                input = Console.ReadLine();
            } while (input == "yes");
            Console.WriteLine("Program has ended...Thank you!");
        }
    }
}