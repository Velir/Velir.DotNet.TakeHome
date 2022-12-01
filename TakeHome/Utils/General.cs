using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace TakeHome.Utils
{
    /// <summary>
    /// General class for utility functions.
    /// </summary>
    public class General
    {
        /// <summary>
        /// Returns the index status based on the status code. Can be extended to include additional cases.
        /// </summary>
        /// <returns></returns>
        public static bool GetIndexStatus()
        {
            return HttpContext.Current.Response.StatusCode.ToString().StartsWith("4");
        }
    }
}
