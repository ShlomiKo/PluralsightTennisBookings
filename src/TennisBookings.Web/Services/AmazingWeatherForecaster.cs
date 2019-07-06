namespace TennisBookings.Web.Services
{
    public class AmazingWeatherForecaster : IWeatherForecaster
    {
        public WeatherResult GetCurrentWeather()
        {
            // Do something amazing here

            return new WeatherResult
            {
                WeatherCondition = WeatherCondition.Sun
            };
        }
    }
}
