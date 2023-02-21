using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.InterceptorArchPattern
{
    internal interface IInterceptor
    {
        public void Update(float temperature, float humidity, float pressure);
    }
}
