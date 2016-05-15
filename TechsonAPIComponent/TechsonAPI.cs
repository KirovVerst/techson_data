using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.ComponentModel;
using Newtonsoft.Json.Linq;
using System.Drawing;
using System.Drawing.Imaging;
using RestSharp;

namespace TechsonAPIComponent
{
    public class User
    {
        public string firstName { get; set; }
        public int id { get; set; }
    }
    public class TechsonAPI : Component
    {

        private const string hostname = "http://46.101.106.176";
        private const string apiVersion = "v1";
        private const string baseApiUrl = hostname + "/api/" + apiVersion;

        public static User[] UsersList()
        {
            using (WebClient webClient = new WebClient())
            {
                Uri apiUrl = new Uri(baseApiUrl + "/users");
                byte[] responseBytes = webClient.DownloadData(apiUrl);
                string jsonString = Encoding.UTF8.GetString(responseBytes);
                JArray json = JArray.Parse(jsonString);
                User[] result = new User[json.Count];
                var i = 0;
                foreach (JObject o in json.Children<JObject>())
                {
                    User user = new User() { id = o["id"].Value<int>(), firstName = o["first_name"].Value<string>() };
                    result[i] = user;
                    i++;
                }
                return result;
            }
        }

        public static Tuple<int, string> UploadImage(Image image, string imageNameWithoutExtension, string userId, string label)
        {
            RestClient client = new RestClient(baseApiUrl);
            var request = new RestRequest("/image/", Method.POST);
            request.AddHeader("content-type", "multipart/form-data");

            request.AddParameter("user", userId);
            request.AddParameter("label", label);

            byte[] imageByte;
            using (var ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imageByte = ms.ToArray();
            }
            request.AddFile("image", imageByte, imageNameWithoutExtension + ".gif");
            var response = client.Execute(request);
            Console.WriteLine(response.Content);
            Tuple<int, string> result = Tuple.Create((int)response.StatusCode, response.Content);
            return result;

        }
    }
    
}
