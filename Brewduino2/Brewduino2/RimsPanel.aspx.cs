using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using BrewduinoCatalogLib;
using Newtonsoft.Json;



namespace Brewduino2
{
    public partial class RimsPanel : System.Web.UI.Page
    {
        public static string[] myData = {
                                      "this", "is", "from", "the", "server"
                                  };
        protected IArduinoSelfHost Arduino;
        protected static BrewController BrewControl;


        protected void Page_Load(object sender, EventArgs e)
        {
            var binding = new BasicHttpBinding();
            var address = new EndpointAddress("http://localhost:8080/SerialSwitch");
            //var address = new EndpointAddress("http://192.168.0.21:8080/SerialSwitch");
            Arduino = new ArduinoSelfHostClient(binding, address);
            Arduino = new ArduinoStub(); //This in there so I can work on the skin.
            BrewControl = new BrewController(Arduino);
        }

        [WebMethod]
        public static string[] JunkData()
        {
            Thread.Sleep(5000);
            return myData;
        }

        [WebMethod]
        public static string SingleJunkData(int whichOne)
        {
            return myData[whichOne];
        }

        [WebMethod]
        public static string GetStatus()
        {
            Dictionary<string, string> CurrentStatus;

            CurrentStatus = BrewControl.GetStatus();

            string returnString = string.Empty;

            returnString = JsonConvert.SerializeObject(CurrentStatus, Formatting.Indented, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
            return returnString;
        }
    }
}