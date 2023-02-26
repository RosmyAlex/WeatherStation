using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.InterceptorArchPattern.NotifyInterceptors;

namespace WeatherStation.InterceptorArchPattern.WeatherUpdateDispatchers
{
    internal interface IDispatcher
    {
        bool DataReadingUpdate(DataReadingContextObject contextObject);
        void Register(INotifyInterceptor interceptor);
        void Remove(INotifyInterceptor interceptor);
    }
}
