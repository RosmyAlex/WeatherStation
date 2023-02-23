using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.InterceptorArchPattern.WeatherFactorsContextObjects;

namespace WeatherStation.InterceptorArchPattern.WeatherUpdateDispatchers
{
    internal interface IDispatcher
    {
        void TemperatureUpdate(IContextObject contextObject);
        void PressureUpdate(IContextObject contextObject);
        void HumidityUpdate(IContextObject contextObject);
        void Register(IInterceptor interceptor);
        void Remove(IInterceptor interceptor);
    }
}
