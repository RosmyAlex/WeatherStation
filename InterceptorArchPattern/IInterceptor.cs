using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.InterceptorArchPattern.WeatherFactorsContextObjects;

namespace WeatherStation.InterceptorArchPattern
{
    internal interface IInterceptor
    {
        void OnTemperatureChanged(IContextObject contextObject);
        void OnPressureChanged(IContextObject contextObject);
        void OnHumidityChanged(IContextObject contextObject);
    }
}
