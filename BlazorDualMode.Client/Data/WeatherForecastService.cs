using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorDualMode.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazorDualMode.Client.Data
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly HttpClient _httpClient;

        public WeatherForecastService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<WeatherForecast>> GetForecastAsync()
        {
            return await _httpClient.GetJsonAsync<WeatherForecast[]>("api/WeatherForecasts");
        }
    }
}
