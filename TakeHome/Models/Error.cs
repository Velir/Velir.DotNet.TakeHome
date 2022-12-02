using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace TakeHome.Models
{
    /// <summary>
    /// The Error model for displaying information related to the error pages.
    /// </summary>
    public class Error : Base
    {
        /// <summary>
        /// A simple, unset property for causing an error on the ErrorTest page. 
        /// This is to showcase the error handling in the web.config.
        /// </summary>
        public bool ErrorTest { get; set; }
    }
}
