using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ConsoleApp1.Controller;

namespace ConsoleApp1
{
    public class Base
    {
        public Authorization _autorizacion = new Authorization();


        public  String GetActividades()
        {
            try
            {
                var result =  _autorizacion.client.GetStringAsync("localhost:8000/ensenyar/");
                return result.ToString();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return null;
        }
    }
}
