using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InspireChallenge.Pages
{
    public class IndexModel : PageModel
    {
        private Services.Service.Service _service;

        public List<Services.Model.QuoteObject> quotes { get; set; }
        public Services.Model.WeatherObject weather { get; set; }
        public Services.Model.ImageObject image { get; set; }

        public IndexModel()
        {
            _service = new Services.Service.Service();
            quotes = _service.GetQuote();
            weather = _service.GetWeather("Boise", "ID", "US");
            image = _service.GetRandomImage();
        }
        public void OnGet()
        {

        }


    }
}
