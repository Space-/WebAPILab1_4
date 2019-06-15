using System.Data.Entity;

namespace WebAPILab1_4.Models
{
    public class BookContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        //
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public BookContext() : base("name=BookContext")
        {
        }

        public System.Data.Entity.DbSet<WebAPILab1_4.Models.Book> Books { get; set; }

        public System.Data.Entity.DbSet<WebAPILab1_4.Models.Author> Authors { get; set; }
    }
}