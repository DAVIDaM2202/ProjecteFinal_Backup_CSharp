using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Authorization
    {
        public readonly HttpClient client = new HttpClient();

        public Authorization()
        {
            Autentifiacio();
        }

        public void Autentifiacio()
        {
            client.DefaultRequestHeaders.Authorization =
                   new AuthenticationHeaderValue(
                       "Basic",
                    Convert.ToBase64String(
                       System.Text.ASCIIEncoding.ASCII.GetBytes(
                           string.Format("{0}:{1}", "", ""))));
        }

    }
}
