using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using System.Text;
namespace ConsoleApp1.Controller
{
    class Activitat : Base
    {
        public async void Actividad(object sender, EventArgs e)
        {
            string ruta = @"c:\temp\Backup.txt";
            if (File.Exists(ruta))
            {
                File.Delete(ruta);
            }
            var x = GetActividades();
            FileStream fs = File.Create(ruta);
            Byte[] info = new UTF8Encoding(true).GetBytes(x);
            fs.Write(info, 0, info.Length);

        }
    }
}
