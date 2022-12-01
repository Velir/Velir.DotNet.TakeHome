using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace TakeHome.Models
{
    /// <summary>
    /// The base model which is inherited by other models.
    /// </summary>
    public class Base
    {
        /// <summary>
        /// Determines if the page should be indexed for SEO. Defaults to true.
        /// </summary>
        public bool NoIndex { get; set; } = true;
    }
}
