using System;

namespace WeatherCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Weather Calculator 2");

            int temp;
            int windSpeed;
            int relHumidity;
            double heatIndex;
            double windChill;
            string input = "";

            // Get the temperature from the user
            Console.WriteLine("Enter the temperature");

            input = Console.ReadLine();

            temp = int.Parse(input);

            if (temp > 50)
            { Console.WriteLine("Enter the relative humidity");

                input = Console.ReadLine();

                relHumidity = int.Parse(input);

                heatIndex = 0.5 * ( temp + 61.0 + ((temp - 68.0) * 1.2) + (relHumidity * 0.094));

                Console.WriteLine("The heat index is " + heatIndex);
            }
            else
            { Console.WriteLine("Enter the wind speed");

                input = Console.ReadLine();

                windSpeed = int.Parse(input);
                
                windChill = 35.74 + (0.6125 * temp) - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * temp * Math.Pow(windSpeed, 0.16);

                Console.WriteLine("The wind chill is " + windChill);
            }
                    
        }
    }
}
