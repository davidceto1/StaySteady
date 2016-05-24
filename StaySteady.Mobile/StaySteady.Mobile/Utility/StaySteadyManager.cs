using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace StaySteady.Mobile.Utility
{
    public class StaySteadyManager
    {
        static StaySteadyManager defaultInstance = new StaySteadyManager();
        MobileServiceClient client;

        private StaySteadyManager()
        {
            client = new MobileServiceClient(
                "https://staysteady.azurewebsites.net");
        }

        public static StaySteadyManager DefaultManager
        {
            get
            {
                return defaultInstance;
            }
            private set
            {
                defaultInstance = value;
            }
        }

        public MobileServiceClient CurrentClient
        {
            get { return client; }
        }
    }
}
