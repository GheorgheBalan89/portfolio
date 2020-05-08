using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using Newtonsoft.Json;


namespace TreeDemo
{
    public class Task2
    {
        //private readonly IHttpClientFactory _clientFactory;
        public static string[] getMovieTitles(string substr)
        {
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create($"https://jsonmock.hackerrank.com/api/movies/search/?Title={substr}");
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse httpResponse = (HttpWebResponse) request.GetResponse())
            using (Stream stream = httpResponse.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
             var data = reader.ReadToEnd();
             var jsonData = JsonConvert.DeserializeObject<Data>(data);


            List<string> movieTitles = new List<string>();
            foreach (var movie in jsonData.data)
            {
                movieTitles.Add(movie.Title);      
            }

            if (jsonData.total_pages > 1)
            {
                for (int i = 2; i <= jsonData.total_pages; i++)
                {
                    movieTitles.AddRange(subpageTitles(substr, i));
                }
            }

             return movieTitles.OrderBy(x => x).ToArray();
            }
            
        }

        private static List<string> subpageTitles(string query, int pageNumber)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"https://jsonmock.hackerrank.com/api/movies/search/?Title={query}&page={pageNumber}");
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse httpResponse = (HttpWebResponse)request.GetResponse())
            using (Stream stream = httpResponse.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                var data = reader.ReadToEnd();
                var jsonData = JsonConvert.DeserializeObject<Data>(data);
                
                List<string> movieTitles = new List<string>();
                foreach (var movie in jsonData.data)
                {
                    movieTitles.Add(movie.Title);
                }
                
                return movieTitles;
            }
        }

        public class Data
        {
            public string page { get; set; }
            public int per_page { get; set; }
            public int total { get; set; }
            public int total_pages { get; set; }
            public List<Movie> data { get; set; }
        }

        public class Movie
        {
            public string Title { get; set; }
            public string Year { get; set; }
            public string imdbID { get; set; }
        }
    }
}
