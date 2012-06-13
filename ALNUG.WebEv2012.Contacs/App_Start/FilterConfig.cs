using System.Web;
using System.Web.Mvc;

namespace ALNUG.WebEv2012.Contacs
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}