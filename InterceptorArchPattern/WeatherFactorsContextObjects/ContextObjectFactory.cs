namespace WeatherStation.InterceptorArchPattern.WeatherFactorsContextObjects
{
    internal class ContextObjectFactory
    {
        internal static IContextObject CreateContextObject(WeatherFactorType weatherFactorType, float reading)
        {
            IContextObject contextObject = null;
            switch (weatherFactorType)
            {
                case WeatherFactorType.Temperature:
                    contextObject = new TemperatureContextObject(reading);
                    break;
                case WeatherFactorType.Pressure:
                    contextObject = new PressureContextObject(reading);
                    break;
                case WeatherFactorType.Humidity:
                    contextObject= new HumidityContextObject(reading);
                    break;
            }
            return contextObject;
        }
    }
}
