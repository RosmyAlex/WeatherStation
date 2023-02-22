using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.InterceptorArchPattern
{
    internal class InterceptorFactory
    {
        internal static IInterceptor CreateInterceptor(DisplayType displayType)
        {
            IInterceptor interceptor = null;
            switch (displayType)
            {
                case DisplayType.CurrentCondition:
                    interceptor = new CurrentConditionDisplayInterceptor();
                    break;
                case DisplayType.Statistics:
                    interceptor = new StatisticsDisplayInterceptor();
                    break;
                case DisplayType.Forecast:
                    interceptor = new ForecastDisplayInterceptor();
                    break;
            }
            return interceptor;
        }
    }
}
