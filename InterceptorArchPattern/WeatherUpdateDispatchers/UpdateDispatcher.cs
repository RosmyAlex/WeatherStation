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

        public bool DataReadingUpdate(DataReadingContextObject dataReadingContextObject)
        {
            foreach (var interceptor in Interceptors)
            {
                if(!interceptor.OnReadingChanged(dataReadingContextObject))
                {
                    return false;
                }
            }
            return true;
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
