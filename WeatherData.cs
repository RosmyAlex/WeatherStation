using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    internal class WeatherData : ISubject
    {
        private IList<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;
        public IList<IObserver> Observers
        {
            get
            {
                if (observers == null) { observers = new List<IObserver>(); }
                return observers;
            }
        }
        public void NotifyObservers()
        {
            foreach (var observer in Observers)
            {
                observer.update(temperature, humidity, pressure);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            Observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
           Observers.Remove(o);
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }
}
