using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.InterceptorArchPattern
{
    public class WeatherFactorContextObject
    {
        private float reading;
        public float WeatherFactorReading => reading;
        public WeatherFactorContextObject(float reading)
        {
            this.reading = reading;
        }
    }
}
