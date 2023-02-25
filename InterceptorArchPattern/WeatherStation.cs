using WeatherStation.InterceptorArchPattern.NotifyInterceptors;
using WeatherStation.InterceptorArchPattern.WeatherUpdateDispatchers;

namespace WeatherStation.InterceptorArchPattern
{
    internal class WeatherStation
    {
        private static WeatherStationManager weatherStationManager;
        public static WeatherStationManager WeatherStationManager
        {
            get
            {
                if (weatherStationManager == null)
                {
                    weatherStationManager = new WeatherStationManager();
                }
                return weatherStationManager;
            }
        }
        public static void Main(string[] args)
        {
            RegisterDisplay();

            TemperatureUpdateEvent(80);
            PressureUpdateEvent(82);
            HumidityUpdateEvent(78);

           // Dispatcher.Remove(forecastDisplay);
            //MeasurementUpdateEvent(62, 90, 28.1f);
        }
        private static void RegisterDisplay()
        {
            RegisterDisplay(DisplayType.Statistics);
            RegisterDisplay(DisplayType.Forecast);
            RegisterDisplay(DisplayType.CurrentCondition);
        }
        private static void TemperatureUpdateEvent(float temperature)
        {
            WeatherStationManager.UpdateTemperature(temperature);
        }
        private static void PressureUpdateEvent(float pressure)
        {
            WeatherStationManager.UpdatePressure(pressure);
        }
        private static void HumidityUpdateEvent(float humidity)
        {
            WeatherStationManager.UpdateHumidity(humidity);
        }
        private static void RegisterDisplay(DisplayType displayType)
        {
            INotifyInterceptor displayInterceptor = InterceptorFactory.CreateInterceptor(displayType);
            WeatherStationManager.RegisterInterceptor(displayInterceptor);
        }
    }
}
