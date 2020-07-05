using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ConAppJson
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = "";
            SSISDBEntities context = new SSISDBEntities();

            var result = from r in context.Customers where (r.CustomerID == "ALFKI") select r;

            foreach(Customer customer in result)
            {
                json = new JavaScriptSerializer().Serialize(customer);
                json = "[" + json + "]";
                Console.WriteLine(json);
            }            
        }
    }
}
