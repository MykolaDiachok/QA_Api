using Microsoft.EntityFrameworkCore;
using QA_Api.Core.Models;

namespace QA_Api
{
    /// <summary>
    /// DbContext
    /// </summary>
    public class DbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        /// <summary>
        /// Blogs
        /// </summary>
        public DbSet<Blog> Blogs { get; set; }
        /// <summary>
        /// Posts
        /// </summary>
        public DbSet<Post> Posts { get; set; }

        /// <summary>
        /// OnConfiguring
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=lite.db");
    }
}
