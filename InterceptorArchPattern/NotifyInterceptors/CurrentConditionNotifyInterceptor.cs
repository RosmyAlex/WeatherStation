namespace WeatherStation.InterceptorArchPattern.NotifyInterceptors
{
    internal class CurrentConditionNotifyInterceptor : INotifyInterceptor
    {
        public void OnHumidityChanged(WeatherFactorContextObject contextObject)
        {
            Console.WriteLine("Current Humidity conditions: " + contextObject.WeatherFactorReading);
        }

        public void OnPressureChanged(WeatherFactorContextObject contextObject)
        {
            Console.WriteLine("Current Pressure conditions: " + contextObject.WeatherFactorReading);
        }

        public void OnTemperatureChanged(WeatherFactorContextObject contextObject)
        {
            Console.WriteLine("Current Temperarture conditions: " +
                contextObject.WeatherFactorReading + "F degrees ");
        }
    }
}
