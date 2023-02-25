namespace WeatherStation.InterceptorArchPattern.NotifyInterceptors
{
    internal class StatisticsNotifyInterceptor : INotifyInterceptor
    {
        public void OnHumidityChanged(WeatherFactorContextObject contextObject)
        {
            float maxHumidity = 0.0f;
            float minHumidity = 200;
            float humiditySum = 0.0f;
            int numReadings = 10;
            float newHumidity = contextObject.WeatherFactorReading;
            humiditySum += newHumidity;
            numReadings++;

            if (newHumidity > maxHumidity)
            {
                maxHumidity = newHumidity;
            }

            if (newHumidity < minHumidity)
            {
                minHumidity = newHumidity;
            }

            Console.WriteLine("Avg/Max/Min Humidity = " + humiditySum / numReadings
                + "/" + maxHumidity + "/" + minHumidity);
        }

        public void OnPressureChanged(WeatherFactorContextObject contextObject)
        {
            float maxPressure = 0.0f;
            float minPressure = 200;
            float pressureSum = 0.0f;
            int numReadings = 10;
            float newPressure = contextObject.WeatherFactorReading;
            pressureSum += newPressure;
            numReadings++;

            if (newPressure > maxPressure)
            {
                maxPressure = newPressure;
            }

            if (newPressure < minPressure)
            {
                minPressure = newPressure;
            }

            Console.WriteLine("Avg/Max/Min Pressure = " + pressureSum / numReadings
                + "/" + maxPressure + "/" + minPressure);
        }

        public void OnTemperatureChanged(WeatherFactorContextObject contextObject)
        {
            float? maxTemp = 0.0f;
            float? minTemp = 200;
            float? tempSum = 0.0f;
            int numReadings = 10;
            float? newTemp = contextObject.WeatherFactorReading;
            tempSum += newTemp;
            numReadings++;

            if (newTemp > maxTemp)
            {
                maxTemp = newTemp;
            }

            if (newTemp < minTemp)
            {
                minTemp = newTemp;
            }

            Console.WriteLine("Avg/Max/Min temperature = " + tempSum / numReadings
                + "/" + maxTemp + "/" + minTemp);
        }
    }
}
