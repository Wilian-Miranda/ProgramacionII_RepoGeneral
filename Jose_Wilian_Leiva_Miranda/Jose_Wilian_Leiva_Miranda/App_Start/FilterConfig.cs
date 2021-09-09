using System.Web;
using System.Web.Mvc;

namespace Jose_Wilian_Leiva_Miranda
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
