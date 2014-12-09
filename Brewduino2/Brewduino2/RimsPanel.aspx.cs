using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Brewduino2
{
    public partial class RimsPanel : System.Web.UI.Page
    {
        public static string[] myData = {
                                      "this", "is", "from", "the", "server"
                                  };
        protected void Page_Load(object sender, EventArgs e)
        {

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
    }
}