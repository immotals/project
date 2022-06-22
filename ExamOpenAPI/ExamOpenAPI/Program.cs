using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;

namespace ExamOpenAPI
{
    class Program
    {
        static string requestURL = "http://data.ex.co.kr/openapi/safeDriving/forecast?key=test&type=json";
        static void Main(string[] args)
        {
            try
            {
                WebRequest request = WebRequest.Create(requestURL);
                request.Method = "GET";
                request.ContentType = "application/json";

                using (WebResponse response = request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    string data = reader.ReadToEnd();
                    var obj = JObject.Parse(data);
                    var list = obj["list"];

                    Console.WriteLine("============ List ============");
                    Console.WriteLine(obj);

                    Console.WriteLine("============ Item ============");
                    foreach (var item in list)
                    {
                        Console.WriteLine(string.Format("{0}: {1}", "날짜", item["sdate"]));
                        Console.WriteLine(string.Format("{0}: {1}", "시간", item["stime"]));
                        Console.WriteLine(string.Format("{0}: {1}", "전국 교통량", item["cjunkook"]));
                        Console.WriteLine(string.Format("{0}: {1}", "지방 방향 교통량", item["cjibangDir"]));
                        Console.WriteLine(string.Format("{0}: {1}", "서울 방향 교통량", item["cseoulDir"]));
                        Console.WriteLine(string.Format("{0}: {1}", "서울->대전 소요시간", item["csudj"]));
                        Console.WriteLine(string.Format("{0}: {1}", "서울->대구 소요시간", item["csudg"]));
                        Console.WriteLine(string.Format("{0}: {1}", "서울->울산 소요시간", item["csuus"]));
                        Console.WriteLine(string.Format("{0}: {1}", "서울->부산 소요시간", item["csubs"]));
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
