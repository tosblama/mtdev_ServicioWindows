using System.Diagnostics;
using System.ServiceProcess;
using System.Timers;

namespace MTDEV_0019_ServicioWindows
{
    public partial class MTDEV_Service : ServiceBase
    {        

        public MTDEV_Service()
        {
            InitializeComponent();
            serviceLog = new EventLog();
            if (!EventLog.SourceExists("MTDEV_Service"))
            {
                EventLog.CreateEventSource("MTDEV_Service", "MTDEV_Service");
            }
            serviceLog.Source = "MTDEV_Service";
            serviceLog.Log = "";
        }

        protected override void OnStart(string[] args)
        {
            serviceLog.WriteEntry("Servicio MTDEV iniciado.");
            Timer timer = new Timer(3000);
            timer.Elapsed += new ElapsedEventHandler(timer_elapsed);
            timer.Start();
        }

        protected override void OnStop()
        {
            serviceLog.WriteEntry("Servicio MTDEV detenido.");
        }


        private void timer_elapsed(object sender, ElapsedEventArgs e)
        {
            serviceLog.WriteEntry("Se ejecuta el evento del timer");
        }


    }
}
