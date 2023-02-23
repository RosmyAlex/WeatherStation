using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.InterceptorArchPattern.WeatherFactorsContextObjects;

namespace WeatherStation.InterceptorArchPattern.WeatherUpdateDispatchers
{
    internal class UpdateDispatcher : IDispatcher
    {
        private IList<IInterceptor> interceptors;
        private IList<IInterceptor> Interceptors
        {
            get
            {
                if (interceptors == null) { interceptors = new List<IInterceptor>(); }
                return interceptors;
            }
        }

        public void TemperatureUpdate(IContextObject contextObject)
        {
            foreach (var interceptor in interceptors)
            {
                interceptor.OnTemperatureChanged(contextObject);
            }
        }
        public void PressureUpdate(IContextObject contextObject)
        {
            foreach (var interceptor in interceptors)
            {
                interceptor.OnTemperatureChanged(contextObject);
            }
        }
        public void HumidityUpdate(IContextObject contextObject)
        {
            foreach (var interceptor in interceptors)
            {
                interceptor.OnTemperatureChanged(contextObject);
            }
        }
        public void Register(IInterceptor interceptor)
        {
            Interceptors.Add(interceptor);
        }
        public void Remove(IInterceptor interceptor)
        {
            Interceptors.Remove(interceptor);
        }
    }
}
