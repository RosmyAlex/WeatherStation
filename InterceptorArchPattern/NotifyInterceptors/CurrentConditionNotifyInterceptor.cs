namespace WeatherStation.InterceptorArchPattern.NotifyInterceptors
{
    internal class CurrentConditionNotifyInterceptor : INotifyInterceptor
    {
        public bool OnReadingChanged(DataReadingContextObject contextObject)
        {
            Console.WriteLine("Current conditions:- Temperature: {0}, Pressure: {1}, Humidity: {2}", 
                contextObject.TemperatureReading, contextObject.PressureReading, contextObject.HumidityReading);
            return true;
        }
    }
}
