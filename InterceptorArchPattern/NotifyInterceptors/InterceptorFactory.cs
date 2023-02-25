using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.InterceptorArchPattern.NotifyInterceptors
{
    internal class InterceptorFactory
    {
        internal static INotifyInterceptor CreateInterceptor(DisplayType displayType)
        {
            INotifyInterceptor interceptor = null;
            switch (displayType)
            {
                case DisplayType.CurrentCondition:
                    interceptor = new CurrentConditionNotifyInterceptor();
                    break;
                case DisplayType.Statistics:
                    interceptor = new StatisticsNotifyInterceptor();
                    break;
                case DisplayType.Forecast:
                    interceptor = new ForecastNotifyInterceptor();
                    break;
            }
            return interceptor;
        }
    }
}
