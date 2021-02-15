using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InspireChallenge.Pages
{
    public class IndexModel : PageModel
    {
        private ServiceAPI _service;

        public List<Services.Models.QuoteObject> quotes { get; set; }
        public Services.Models.WeatherObject weather { get; set; }
        public Services.Models.ImageObject image { get; set; }
        public int counter { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ServiceAPI service)
        {
            _service = service;
            quotes = _service.GetQuote();
            weather = _service.GetWeather("Boise", "ID", "US", 0);
            image = _service.GetRandomImage();
            counter = 0;
        }
        public IActionResult OnGetRandomImage()
        {
            image = _service.GetRandomImage();
            return new OkObjectResult(image);
        }

        public IActionResult OnGetChangeWeather(string city, string stateID, string countryID, int tempType)
        {
            weather = _service.GetWeather(city, stateID, countryID, tempType);
            return new OkObjectResult(weather);
        }

    }
}
