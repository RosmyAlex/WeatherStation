using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.InterceptorArchPattern
{
    internal interface IInterceptor
    {
        void OnWeatherParamsChanged(ContextObject contextObject);
    }
}
