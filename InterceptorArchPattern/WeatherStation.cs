namespace WeatherStation.InterceptorArchPattern
{
    internal class WeatherStation
    {
        private static IDispatcher dispatcher;
        private static WeatherStationFramework weatherStationFramework;
        private static IDispatcher Dispatcher
        {
            get 
            {
                if (dispatcher == null)
                {
                    dispatcher = new Dispatcher();
                }
                return dispatcher;
            }
        }
        public static WeatherStationFramework WeatherStationFramework
        {
            get
            {
                if (weatherStationFramework == null)
                {
                    weatherStationFramework = new WeatherStationFramework(Dispatcher);
                }
                return weatherStationFramework;
            }
        }
        public WeatherStation()
        {
            RegisterDisplay(DisplayType.Statistics);
            RegisterDisplay(DisplayType.Forecast);
            RegisterDisplay(DisplayType.CurrentCondition);
        }

        public static void Main(string[] args)
        {
            MeasurementUpdateEvent(80, 65, 30.4f);
            MeasurementUpdateEvent(82, 70, 29.2f);
            MeasurementUpdateEvent(78, 90, 29.2f);

           // Dispatcher.Remove(forecastDisplay);
            //MeasurementUpdateEvent(62, 90, 28.1f);
        }
        private static void MeasurementUpdateEvent(float temperature, float humidity, float pressure)
        {
            WeatherStationFramework.UpdateWeatherFactors(temperature, humidity, pressure);
        }
        private void RegisterDisplay(DisplayType displayType)
        {
            IInterceptor displayInterceptor = InterceptorFactory.CreateInterceptor(DisplayType.CurrentCondition);
            Dispatcher.Register(displayInterceptor);
        }
    }
}
