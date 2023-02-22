using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.InterceptorArchPattern
{
    internal class WeatherStation
    {
        private static Dispatcher dispatcher;
        private IInterceptor currentDisplay;
        private IInterceptor statisticsDisplay;
        private static IInterceptor forecastDisplay;
        private static WeatherStationFramework weatherStationFramework;
        public static Dispatcher Dispatcher
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
            currentDisplay = new CurrentConditionDisplayInterceptor();
            statisticsDisplay = new StatisticsDisplayInterceptor();
            forecastDisplay = new ForecastDisplayInterceptor();
            Dispatcher.Register(currentDisplay);
            Dispatcher.Register(statisticsDisplay);
            Dispatcher.Register(forecastDisplay);
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
            WeatherStationFramework.UpdateWeatherParameters(temperature, humidity, pressure);
        }
    }
}
