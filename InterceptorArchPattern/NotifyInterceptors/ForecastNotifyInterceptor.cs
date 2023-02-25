
namespace WeatherStation.InterceptorArchPattern.NotifyInterceptors
{
    internal class ForecastNotifyInterceptor : INotifyInterceptor
    {
        private float? currentPressure = 29.92f;
        private float? lastPressure;
        private float? humidity;
        private float? temperature;

        public void OnTemperatureChanged(WeatherFactorContextObject contextObject)
        {
            temperature = contextObject.WeatherFactorReading;
            Console.WriteLine("Forecast: ");
            EvaluateAndDisplayTemperatureForecast();
        }
        public void OnPressureChanged(WeatherFactorContextObject contextObject)
        {
            lastPressure = currentPressure;
            currentPressure = contextObject.WeatherFactorReading;
            Console.WriteLine("Forecast: ");
            EvaluateAndDisplayPressureForecast();
        }
        public void OnHumidityChanged(WeatherFactorContextObject contextObject)
        {
            humidity = contextObject.WeatherFactorReading;
            Console.WriteLine("Forecast: ");
            EvaluateAndDisplayHumidityForecast();
        }
        private void EvaluateAndDisplayHumidityForecast()
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
        private void EvaluateAndDisplayTemperatureForecast()
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
        private void EvaluateAndDisplayPressureForecast()
        {
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
