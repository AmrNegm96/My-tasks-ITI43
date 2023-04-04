using System.Web;
using System.Web.Mvc;

namespace MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new AuthorizeAttribute() {Users= "None" });
            filters.Add(new HandleErrorAttribute());
        }
    }
}
