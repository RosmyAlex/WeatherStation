using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    internal class CurrentConditionDisplayObserver : IObserver
    {
        private float temperature;
        private float humidity;
        private WeatherData weatherData;

        public CurrentConditionDisplayObserver(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + temperature
                + "F degrees and " + humidity + "% humidity");
        }
    }
}
