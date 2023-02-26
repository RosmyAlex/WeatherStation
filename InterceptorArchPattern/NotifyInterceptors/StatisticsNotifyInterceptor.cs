namespace WeatherStation.InterceptorArchPattern.NotifyInterceptors
{
    internal class StatisticsNotifyInterceptor : INotifyInterceptor
    {
        public bool OnReadingChanged(DataReadingContextObject contextObject)
        {
            return OnHumidityChanged(contextObject.HumidityReading) &&
                OnPressureChanged(contextObject.PressureReading) &&
                OnTemperatureChanged(contextObject.TemperatureReading);
        }
        private bool OnHumidityChanged(float newHumidity)
        {
            float maxHumidity = 0.0f;
            float minHumidity = 200;
            float humiditySum = 0.0f;
            int numReadings = 10;
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
            return true;    
        }

        private bool OnPressureChanged(float newPressure)
        {
            float maxPressure = 0.0f;
            float minPressure = 200;
            float pressureSum = 0.0f;
            int numReadings = 10;
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
            return true;
        }

        private bool OnTemperatureChanged(float newTemp)
        {
            float? maxTemp = 0.0f;
            float? minTemp = 200;
            float? tempSum = 0.0f;
            int numReadings = 10;
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
            return true;
        }
    }
}
