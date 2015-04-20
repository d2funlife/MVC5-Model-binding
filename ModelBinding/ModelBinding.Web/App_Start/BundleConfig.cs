#region Usign statements
using System.Web.Optimization;
#endregion

namespace ModelBinding.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/pagecss").Include(
                      "~/Content/css/bootstrap.css",
                      "~/Content/css/font-icons/entypo/css/entypo.css",
                      "~/Content/css/neon-core.css",
                      "~/Content/css/neon-theme.css",
                      "~/Content/css/neon-forms.css",
                      "~/Content/css/custom.css"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/pagejs").Include(
                        "~/Scripts/jquery-2.1.3.min.js",
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/jquery-ui-1.10.3.minimal.min.js",
                        "~/Scripts/gsap/main-gsap.js",
                        "~/Scripts/resizeable.js",
                        "~/Scripts/neon-api.js",
                        "~/Scripts/neon-chat.js",
                        "~/Scripts/neon-custom.js"
                        ));
        }
    }
}