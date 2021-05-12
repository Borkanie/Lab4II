using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Lab4II
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        static List<string> Lista = new List<string>();
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public int Sum(int a,int b)
        {
            return a + b;
        }
        [WebMethod]
        public double ConversieGrade(double grade,bool FtoC)
        {
            if(FtoC)
            {
                return grade - 32 / 1.8;
            }
            else
            {
                return 1.8 * grade + 32;
            }
        }
        [WebMethod]
        public DateTime GetCurrentDate()
        {
            return DateTime.Now;
        }
        [WebMethod]
        public List<string> GetLista5Elemenmts()
        {
            if (Lista.Count != 5)
            {
                for (int i = 0; i < 5; i++)
                    Lista.Add(i.ToString());
            }
            return Lista;
        }
        [WebMethod]
        public double Converted(double value,string Currency)
        {
            switch(Currency)
            {
                case "Lei":
                    return value * 5;
                case "Euro":
                    return value / 5;
                default:
                    return 0;
            }
        }
    }
}
