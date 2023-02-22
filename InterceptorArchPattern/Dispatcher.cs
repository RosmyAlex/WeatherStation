using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.InterceptorArchPattern
{
    internal class Dispatcher
    {
        private IList<IInterceptor> interceptors;
        public IList<IInterceptor> Interceptors
        {
            get
            {
                if (interceptors == null) { interceptors = new List<IInterceptor>(); }
                return interceptors;
            }
        }

        public void Dispatch(ContextObject contextObject)
        {
            foreach (var interceptor in interceptors)
            {
                interceptor.OnWeatherParamsChanged(contextObject);
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
        //private void IterateList()
        //{
        //    foreach (var interceptor in interceptors)
        //    {
        //        interceptor.();
        //    }
        //}
    }
}
