using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;
namespace ConsoleApp1.Service
{
    class ConfigureService
    {
        internal static void Configure()
        {
            HostFactory.Run(configure =>
            {
                configure.Service<SincronizacionService>(service =>
                {
                    service.ConstructUsing(s => new SincronizacionService());
                    service.WhenStarted(s => s.Start());
                    service.WhenStopped(s => s.Stop());
                });
                configure.RunAsLocalSystem();
                configure.SetServiceName("SincronizadorProjecte");
            });
        }
    }
}
