using System;
using System.IO;
using System.Net;
using System.Text;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetData();
            //ConvertFromLeiToEuro(100);
            //Console.WriteLine("Hello World!");
        }
        static public void GetDataWithService()
        {
          


        }
        static public void ConvertFromLeiToEuro(double value)
        {
            try
            {
                var endPoint = "https://localhost:44338/WebService1.asmx";
                var data = "?op=Converted&value=" + value.ToString() + "&Currency=Lei";
                var webReq = (HttpWebRequest)WebRequest.Create(endPoint);
                webReq.Method = "POST";
                var bytes = Encoding.UTF8.GetBytes(data);
                webReq.ContentLength = bytes.Length;
                webReq.ContentType = "application/x-www-form-urlencoded";
                webReq.UserAgent = ".NET Framework Test Client";
                using (var requestStream = webReq.GetRequestStream())
                {
                    requestStream.Write(bytes, 0, bytes.Length);
                }
                using (var response = webReq.GetResponse())
                {
                    using (var responseStream = response.GetResponseStream())
                    {
                        var reader = new StreamReader(responseStream);
                        var responseString = reader.ReadToEnd();
                        Console.WriteLine(responseString);
                        //Do whatever with responseString
                    }
                }

            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static public void GetData()
        {
            try
            {
                var endPoint = "https://localhost:44338/WebService1.asmx";
                var data = "/GetCurrentDate";
                var webReq = (HttpWebRequest)WebRequest.Create(endPoint);
                webReq.Method = "POST";
                var bytes = Encoding.UTF8.GetBytes(data);
                webReq.ContentLength = bytes.Length;
                webReq.ContentType = "application/x-www-form-urlencoded";
                webReq.UserAgent = ".NET Framework Test Client";
                using (var requestStream = webReq.GetRequestStream())
                {
                    requestStream.Write(bytes, 0, bytes.Length);
                }
                using (var response = webReq.GetResponse())
                {
                    using (var responseStream = response.GetResponseStream())
                    {
                        var reader = new StreamReader(responseStream);
                        var responseString = reader.ReadToEnd();
                        Console.WriteLine(responseString);
                        //Do whatever with responseString
                    }
                }

            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
