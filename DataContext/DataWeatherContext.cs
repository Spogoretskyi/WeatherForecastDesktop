using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace DataContext
{
    public class DataWeatherContext<T, N, U> : IDataWeatherContext<T, N, U> where T: class, new()
                                                                            where N: class, new()
                                                                            where U: class, new()
    {
        private NameValueCollection appSettings = ConfigurationManager.AppSettings;
        private string GetWeatherFromAPI(string type = "current", int ? id = 703448, string city = null)
        {
            string url = String.Empty;

            if (city == null)
                url = type == "current" ? appSettings["apiUrlCurrentWeather"] + id : appSettings["apiUrlWeatherForecast"] + id;
            else
                url = appSettings["apiUrlListCities"] + city;

            try
            {
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                //HttpWebResponse responseCurrent = (HttpWebResponse)request.GetResponse();

                //if (responseCurrent.StatusCode == HttpStatusCode.OK)
                //{
                //    string answerCurrent = String.Empty;
                //    using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                //    {
                //        StreamReader reader = new StreamReader(response.GetResponseStream());
                //        answerCurrent = reader.ReadToEnd();
                //    }
                //    return answerCurrent;
                //}
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string answerCurrent = String.Empty;
                    using (Stream dataStream = response.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(dataStream);
                        answerCurrent = reader.ReadToEnd();
                    }
                    response.Close();
                    return answerCurrent;
                }
            }
            catch (Exception ex) { }
            return null;
        }

        public IEnumerable<U> GetForecast(int id)
        {
            var getWeatherFromAPI = GetWeatherFromAPI("forecast", id);
            if (getWeatherFromAPI == null)
                return null;
            return JsonConvert.DeserializeObject<IEnumerable<U>>(getWeatherFromAPI);
        }

        public IEnumerable<T> GetListCities(string city)
        {
            var getWeatherFromAPI = GetWeatherFromAPI("na", 0, city);
            if (getWeatherFromAPI == null)
                return null;
            return JsonConvert.DeserializeObject<IEnumerable<T>>(getWeatherFromAPI);
        }

        public N GetWeather(int id)
        {
            var getWeatherFromAPI = GetWeatherFromAPI("current", id);
            if (getWeatherFromAPI == null)
                return null;
            return JsonConvert.DeserializeObject<N>(getWeatherFromAPI);
        }
    }
}
