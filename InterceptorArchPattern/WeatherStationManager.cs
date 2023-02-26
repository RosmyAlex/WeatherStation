using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.InterceptorArchPattern.NotifyInterceptors;
using WeatherStation.InterceptorArchPattern.WeatherUpdateDispatchers;

namespace WeatherStation.InterceptorArchPattern
{
    public class WeatherStationManager
    {
        private IDispatcher updateDispatcher;
        private IDispatcher UpdateDispatcher
        {
            get 
            {
                if (updateDispatcher == null)
                {
                    updateDispatcher = new UpdateDispatcher();
                }
                return updateDispatcher;
            }
        }

        public bool UpdateReading(float temperature, float pressureReading, float humidityReading)
        {
            var contextObject = new DataReadingContextObject(temperature,pressureReading,humidityReading);
            return UpdateDispatcher.DataReadingUpdate(contextObject);
        }

        public void RegisterInterceptor(INotifyInterceptor interceptor)
        {
            UpdateDispatcher?.Register(interceptor);
        }
    }
}
