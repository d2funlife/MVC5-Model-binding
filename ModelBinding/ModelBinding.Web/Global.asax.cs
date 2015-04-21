#region Using statements

using ModelBinding.Web.ModelBind;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

#endregion

namespace ModelBinding.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            //Uncomment for custom binding
            //ModelBinderProviders.BinderProviders.Add(new MovieModelBinderProvider());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}