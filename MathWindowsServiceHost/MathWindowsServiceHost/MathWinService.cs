using System;
using System.ServiceModel;
using System.ServiceProcess;
using MathServiceLibrary;

namespace MathWindowsServiceHost
{
    public partial class MathWinService : ServiceBase
    {
        private ServiceHost _myHost;
       
        public MathWinService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (_myHost != null)
            {
                _myHost.Close();
                _myHost = null;
            }

            _myHost=new ServiceHost(typeof(MathServiceLibrary.MathService));

            // ABC
            Uri address=new Uri("http://localhost:8080/MathServiceLibrary");
            WSHttpBinding binding=new WSHttpBinding();
            Type contract = typeof(IBasicMath);
            _myHost.AddServiceEndpoint(contract, binding, address);
            _myHost.Open();
        }

        protected override void OnStop()
        {
            _myHost?.Close();
        }
    }
}
