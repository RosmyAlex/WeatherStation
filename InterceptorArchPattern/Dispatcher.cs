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
        private ContextObject contextObject;
        public IList<IInterceptor> Interceptors { 
            get
            {
                if (interceptors == null) { interceptors=new List<IInterceptor>(); }
                return interceptors;
            }
        }
        internal void Dispatch(ContextObject contextObject)
        {
            this.contextObject = contextObject;
            IterateList();
        }
        internal void Register(IInterceptor interceptor)
        {
            Interceptors.Add(interceptor);
        }
        internal void Remove(IInterceptor interceptor)
        {
            Interceptors.Remove(interceptor);
        }
        private void IterateList()
        {
            foreach (var interceptor in interceptors)
            {
                interceptor.Update(contextObject.Temperature, contextObject.Humidity, contextObject.Pressure);
            }
        }
    }
}
