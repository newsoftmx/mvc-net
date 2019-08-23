using System.Web;
using System.Web.Mvc;

namespace mvc_codigo_4_auten_autor
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
