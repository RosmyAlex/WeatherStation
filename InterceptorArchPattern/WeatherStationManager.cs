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

        public void UpdateTemperature(float temperature)
        {
            var contextObject = new WeatherFactorContextObject(temperature);
            UpdateDispatcher?.TemperatureUpdate(contextObject);
        }
        public void UpdatePressure(float pressure)
        {
            var contextObject = new WeatherFactorContextObject(pressure);
            UpdateDispatcher?.PressureUpdate(contextObject);
        }
        public void UpdateHumidity(float humidity)
        {
            var contextObject = new WeatherFactorContextObject(humidity);
            UpdateDispatcher?.HumidityUpdate(contextObject);
        }
        public void RegisterInterceptor(INotifyInterceptor interceptor)
        {
            UpdateDispatcher?.Register(interceptor);
        }
    }
}
