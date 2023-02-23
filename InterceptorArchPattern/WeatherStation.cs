using WeatherStation.InterceptorArchPattern.WeatherUpdateDispatchers;

namespace WeatherStation.InterceptorArchPattern
{
    internal class WeatherStation
    {
        private static IDispatcher dispatcher;
        private static WeatherStationFramework weatherStationFramework;
        public WeatherStation()
        {
            RegisterDisplay(DisplayType.Statistics);
            RegisterDisplay(DisplayType.Forecast);
            RegisterDisplay(DisplayType.CurrentCondition);
        }
        public static WeatherStationFramework WeatherStationFramework
        {
            get
            {
                if (weatherStationFramework == null)
                {
                    weatherStationFramework = new WeatherStationFramework();
                }
                return weatherStationFramework;
            }
        }
        public static void Main(string[] args)
        {
            TemperatureUpdateEvent(80);
            PressureUpdateEvent(82);
            HumidityUpdateEvent(78);

           // Dispatcher.Remove(forecastDisplay);
            //MeasurementUpdateEvent(62, 90, 28.1f);
        }
        private static void TemperatureUpdateEvent(float temperature)
        {
            WeatherStationFramework.UpdateTemperature(temperature);
        }
        private static void PressureUpdateEvent(float pressure)
        {
            WeatherStationFramework.UpdatePressure(pressure);
        }
        private static void HumidityUpdateEvent(float humidity)
        {
            WeatherStationFramework.UpdateHumidity(humidity);
        }
        private static void RegisterDisplay(DisplayType displayType)
        {
            IInterceptor displayInterceptor = InterceptorFactory.CreateInterceptor(displayType);
            WeatherStationFramework.RegisterInterceptor(displayInterceptor);
        }
    }
}
