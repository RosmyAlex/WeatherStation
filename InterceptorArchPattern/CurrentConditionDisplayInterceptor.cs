using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.InterceptorArchPattern.WeatherFactorsContextObjects;

namespace WeatherStation.InterceptorArchPattern
{
    internal class CurrentConditionDisplayInterceptor : IInterceptor
    {
        public void OnHumidityChanged(IContextObject contextObject)
        {
            throw new NotImplementedException();
        }

        public void OnPressureChanged(IContextObject contextObject)
        {
            throw new NotImplementedException();
        }

        public void OnTemperatureChanged(IContextObject contextObject)
        {
            throw new NotImplementedException();
        }

        public void OnWeatherParamsChanged(TemperatureContextObject contextObject)
        {
            Console.WriteLine("Current conditions: " + contextObject.Temperature
                + "F degrees and " + contextObject.Humidity + "% humidity");
        }
    }
}
