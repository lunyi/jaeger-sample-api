using jaeget_sample_api;
using jaeget_sample_api.Repository;

namespace jaeget_sample_api.Services
{
    public interface IWeatherService
    {
        IEnumerable<WeatherForecast> GetWeatherForecast();
    }
    public class WeatherService : IWeatherService
    {
        public IWeatherRepository _weatherRepository { get; set; }

        public WeatherService(IWeatherRepository weatherRepository )
        {
            _weatherRepository = weatherRepository;
        }
        public IEnumerable<WeatherForecast> GetWeatherForecast()
        {
            return _weatherRepository.Get();
        }
    }
}
