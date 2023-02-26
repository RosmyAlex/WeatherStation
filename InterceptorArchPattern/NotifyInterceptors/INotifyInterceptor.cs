namespace WeatherStation.InterceptorArchPattern.NotifyInterceptors
{
    public interface INotifyInterceptor
    {
        public bool OnReadingChanged(DataReadingContextObject contextObject);
    }
}
