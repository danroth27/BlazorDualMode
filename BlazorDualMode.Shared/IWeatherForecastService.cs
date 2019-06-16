using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorDualMode.Shared
{
    public interface IWeatherForecastService
    {
        Task<IEnumerable<WeatherForecast>> GetForecastAsync();
    }
}