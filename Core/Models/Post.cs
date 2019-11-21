using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QA_Api.Core.Models
{
    /// <summary>
    /// Post
    /// </summary>
    public class Post
    {
        /// <summary>
        /// PostId
        /// </summary>
        public int PostId { get; set; }
        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Content
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// BlogId
        /// </summary>
        public int BlogId { get; set; }
        /// <summary>
        /// Blog
        /// </summary>
        public Blog Blog { get; set; }
    }
}
