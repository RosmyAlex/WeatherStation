
namespace WeatherStation.InterceptorArchPattern.NotifyInterceptors
{
    internal class ForecastNotifyInterceptor : INotifyInterceptor
    {
        private float? currentPressure = 29.92f;
        private float? lastPressure;

        public bool OnReadingChanged(DataReadingContextObject contextObject)
        {
            Console.WriteLine("Forecast: ");
            EvaluateAndDisplayTemperatureForecast(contextObject.TemperatureReading);
            EvaluateAndDisplayPressureForecast(contextObject.PressureReading);
            EvaluateAndDisplayHumidityForecast(contextObject.HumidityReading);
            return true;
        }
        private void EvaluateAndDisplayHumidityForecast(float humidity)
        {
            if (humidity > 50)
            {
                Console.WriteLine("Ideal humidity for health and comfort");
            }
            else
            {
                Console.WriteLine("Not an Ideal humidity for health and comfort");
            }
        }
        private void EvaluateAndDisplayTemperatureForecast(float temperature)
        {
            if (temperature > 30)
            {
                Console.WriteLine("Weather is sunny");
            }
            else
            {
                Console.WriteLine("Weather is pleasant");
            }
        }
        private void EvaluateAndDisplayPressureForecast(float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;
            if (currentPressure > lastPressure)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if (currentPressure == lastPressure)
            {
                Console.WriteLine("More of the same");
            }
            else if (currentPressure < lastPressure)
            {
                Console.WriteLine("Watch out for cooler, rainy weather");
            }
        }
    }
}
