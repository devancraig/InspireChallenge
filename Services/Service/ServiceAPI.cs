using Newtonsoft.Json;
using Services.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Services
{
    public class ServiceAPI
    {
        private string _weatherKey;
        public ServiceAPI(string key)
        {
            _weatherKey = key;
        }
        public ImageObject GetRandomImage()
        {
            ImageObject image;
            string reqUrl = "http://www.splashbase.co/api/v1/images/random";
            var httpWebRequestQR = (HttpWebRequest)WebRequest.Create(reqUrl);
            httpWebRequestQR.ContentType = "application/json";
            httpWebRequestQR.Method = "GET";

            var httpResponseQR = (HttpWebResponse)httpWebRequestQR.GetResponse();
            using (var streamReader = new StreamReader(httpResponseQR.GetResponseStream()))
            {
                var resultQR = streamReader.ReadToEnd();
                string jsonString = resultQR;
                image = JsonConvert.DeserializeObject<ImageObject>(jsonString);
            }
            return image;
        }
        public List<QuoteObject> GetQuote()
        {
            List<QuoteObject> quote;
            string reqUrl = "https://quotesondesign.com/wp-json/wp/v2/posts/?orderby=rand";
            var httpWebRequestQR = (HttpWebRequest)WebRequest.Create(reqUrl);
            httpWebRequestQR.ContentType = "application/json";
            httpWebRequestQR.Method = "GET";

            var httpResponseQR = (HttpWebResponse)httpWebRequestQR.GetResponse();
            using (var streamReader = new StreamReader(httpResponseQR.GetResponseStream()))
            {
                var resultQR = streamReader.ReadToEnd();
                string jsonString = resultQR;
                quote = JsonConvert.DeserializeObject<List<QuoteObject>>(jsonString);
            }
            return quote;
        }



        public WeatherObject GetWeather(string city, string stateID, string countryID, string tempType)
        {
            WeatherObject weather;
            string reqUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city},{stateID},{countryID}&appid={_weatherKey}&units={tempType}";
            var httpWebRequestQR = (HttpWebRequest)WebRequest.Create(reqUrl);
            httpWebRequestQR.ContentType = "application/json";
            httpWebRequestQR.Method = "GET";

            var httpResponseQR = (HttpWebResponse)httpWebRequestQR.GetResponse();
            using (var streamReader = new StreamReader(httpResponseQR.GetResponseStream()))
            {
                var resultQR = streamReader.ReadToEnd();
                string jsonString = resultQR;
                weather = JsonConvert.DeserializeObject<WeatherObject>(jsonString);
            }

            return weather;
        }

    }
}
