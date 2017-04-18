using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Microservice_WCF_library;

namespace WindowsServiceHost
{
    public partial class GetEstimateWSHost : ServiceBase
    {
        ServiceHost host = new ServiceHost(typeof(GetEstimate));

        public GetEstimateWSHost()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            host.Open();
        }

        protected override void OnStop()
        {
            host.Close();
        }
    }
}
