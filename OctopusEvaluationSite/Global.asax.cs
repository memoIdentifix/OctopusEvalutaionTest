using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using BusinessLogic;
using Microsoft.Ajax.Utilities;

namespace OctopusEvaluationSite
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            try
            {
                var mgr = new BusinessManager();
                var b = mgr.CheckIfBusinessIsViable(true);
            }
            catch (Exception exp)
            {
                throw new Exception("Unable to create BusinessLogic component!", exp);
            }
        }
    }
}