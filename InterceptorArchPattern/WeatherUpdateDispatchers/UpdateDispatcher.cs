using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.InterceptorArchPattern.NotifyInterceptors;

namespace WeatherStation.InterceptorArchPattern.WeatherUpdateDispatchers
{
    public class UpdateDispatcher : IDispatcher
    {
        private IList<INotifyInterceptor> interceptors;
        private IList<INotifyInterceptor> Interceptors
        {
            get
            {
                if (interceptors == null) { interceptors = new List<INotifyInterceptor>(); }
                return interceptors;
            }
        }

        public void TemperatureUpdate(WeatherFactorContextObject contextObject)
        {
            foreach (var interceptor in Interceptors)
            {
                interceptor.OnTemperatureChanged(contextObject);
            }
        }
        public void PressureUpdate(WeatherFactorContextObject contextObject)
        {
            foreach (var interceptor in interceptors)
            {
                interceptor.OnPressureChanged(contextObject);
            }
        }
        public void HumidityUpdate(WeatherFactorContextObject contextObject)
        {
            foreach (var interceptor in interceptors)
            {
                interceptor.OnHumidityChanged(contextObject);
            }
        }
        public void Register(INotifyInterceptor interceptor)
        {
            Interceptors.Add(interceptor);
        }
        public void Remove(INotifyInterceptor interceptor)
        {
            Interceptors.Remove(interceptor);
        }
    }
}
