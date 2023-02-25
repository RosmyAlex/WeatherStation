namespace WeatherStation.InterceptorArchPattern.NotifyInterceptors
{
    public interface INotifyInterceptor
    {
        public void OnTemperatureChanged(WeatherFactorContextObject contextObject);
        public void OnPressureChanged(WeatherFactorContextObject contextObject);
        public void OnHumidityChanged(WeatherFactorContextObject contextObject);
    }
}
