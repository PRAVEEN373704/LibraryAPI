using LibraryManagement.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options):base(options)
        {
            
        }


        public DbSet<Author> _author { get; set; }
        public DbSet<Book> _book { get; set; }
        public DbSet<Category> _category { get; set; }
    }
}
