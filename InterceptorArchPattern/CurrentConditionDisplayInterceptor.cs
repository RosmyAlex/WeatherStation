using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.InterceptorArchPattern
{
    internal class CurrentConditionDisplayInterceptor : IInterceptor
    {
        public void OnWeatherParamsChanged(ContextObject contextObject)
        {
            Console.WriteLine("Current conditions: " + contextObject.Temperature
                + "F degrees and " + contextObject.Humidity + "% humidity");
        }
    }
}
