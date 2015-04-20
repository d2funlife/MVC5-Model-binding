#region Using statements
using System;
using System.Web.Mvc;
#endregion

namespace ModelBinding.Web.Helper
{
    public static class MenuLinkHelper
    {
        public static MvcHtmlString IsLinkActive(this HtmlHelper htmlHelper, string actionName)
        {
            var currentAction = htmlHelper.ViewContext.RouteData.GetRequiredString("action");
            return string.Equals(actionName, currentAction, StringComparison.CurrentCultureIgnoreCase) ? new MvcHtmlString("class=\"active\"") : null;
        }
    }
}