using ConsoleApp1.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace ConsoleApp1.Service
{
    class SincronizacionService
    {
        private Timer _timerDiario;
        private Activitat _activitat = new Activitat();

        public SincronizacionService()
        {
            _timerDiario = new Timer(8640000);//UN dia
            
            _timerDiario.Elapsed += new ElapsedEventHandler(_activitat.Actividad);
            _timerDiario.AutoReset = true;
            

        }
        public void Start()
        {
            _timerDiario.Start();
        }
        public void Stop()
        {
            _timerDiario.Stop();
        }
    }
}
