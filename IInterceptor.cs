using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.InterceptorArchPattern;

namespace WeatherStation
{
    internal interface IInterceptor
    {
        void OnWeatherParamsChanged(ContextObject contextObject);
    }
}
