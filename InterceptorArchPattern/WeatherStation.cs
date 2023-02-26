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
            SetReadingsEvent(80, 82, 78);
        }
        private static void RegisterDisplay()
        {
            RegisterDisplay(DisplayType.Statistics);
            RegisterDisplay(DisplayType.Forecast);
            RegisterDisplay(DisplayType.CurrentCondition);
        }
        private static void RegisterDisplay(DisplayType displayType)
        {
            INotifyInterceptor displayInterceptor = InterceptorFactory.CreateInterceptor(displayType);
            WeatherStationManager.RegisterInterceptor(displayInterceptor);
        }
        private static bool SetReadingsEvent(float temperature, float pressure, float humidity)
        {
            return WeatherStationManager.UpdateReading(temperature, pressure, humidity);
        }
    }
}
