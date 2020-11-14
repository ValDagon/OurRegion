using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FunctionTemplates
{
    public class FunctionsB
    {
        // Запрос справочника ОКТМО
        public static void OfficesRequest()
        {
            var url = "http://193.169.35.211/api/v1/oktmoObjects.json?size=1000"; 
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = @"application/json";
            httpWebRequest.Method = "GET";
            httpWebRequest.Credentials = new NetworkCredential("eq", "eq");
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string result;
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }

        // Статистика электронной очереди по id подразделения
        public static void PripriorityStatistics()
        {
            var url = "http://193.169.35.211/api/v1/buildCountVisitorsInQueueReport";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    // id нужного подразделения, полученное в функции OfificesRequest
                });

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string result;
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
        }
    }
}