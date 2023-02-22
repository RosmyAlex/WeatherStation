using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.InterceptorArchPattern
{
    internal interface IDispatcher
    {
        void Dispatch(ContextObject contextObject);
        void Register(IInterceptor interceptor);
        void Remove(IInterceptor interceptor);
    }
}
