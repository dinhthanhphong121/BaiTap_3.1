using Microsoft.AspNetCore.Components;
using quanlynhansu.App.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quanlynhansu.App.Pages
{
    public class FetchDataBase : ComponentBase
    {
        public WeatherForecast[] forecasts;
        public readonly WeatherForecastService _weatherForecastService = new WeatherForecastService();
        protected override async Task OnInitializedAsync()
        {
            forecasts = await _weatherForecastService.GetForecastAsync(DateTime.Now);
        }
    }
}
