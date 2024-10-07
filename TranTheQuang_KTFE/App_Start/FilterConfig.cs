using System.Web;
using System.Web.Mvc;

namespace TranTheQuang_KTFE
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
