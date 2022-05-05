using System.Web;
using System.Web.Mvc;

namespace NPOI.NET4.EXCEL
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
