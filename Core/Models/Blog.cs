using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QA_Api.Core.Models
{
    /// <summary>
    /// Blog
    /// </summary>
    public class Blog
    {
        /// <summary>
        /// 
        /// </summary>
        public int BlogId { get; set; }
        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Posts
        /// </summary>
        public List<Post> Posts { get; } = new List<Post>();
    }
}
