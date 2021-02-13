using Newtonsoft.Json;
using Services.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Services.Service
{
    public class Service
    {
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

        public WeatherObject GetWeather(string city, string stateID, string countryID)
        {
            WeatherObject weather;
            string reqUrl = $"http://api.openweathermap.org/data/2.5/weather?q={city},{stateID},{countryID}&appid=cc51c0c36de75e4ff442f7f4337d2190&units=standard";
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
            weather.main.temp = KelvinConvert(weather.main.temp);
            weather.main.temp_min = KelvinConvert(weather.main.temp_min);
            weather.main.temp_max = KelvinConvert(weather.main.temp_max);
            return weather;
        }

        public static int KelvinConvert(float temp)
        {
            //Formula: (Temp − 273.15) × 9/5 + 32
            int fahrenheit = (int)((temp - 273.15) * 9 / 5 + 32);
            return fahrenheit;
        }


    }
}
