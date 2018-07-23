using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookingAppStore.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Purchase> Purchases { get; set; }
    }

    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Відьмак 1", Author = "Сапковський" , Price = 98});
            db.Books.Add(new Book { Name = "Відьмак 2", Author = "Сапковський", Price = 98 });
            db.Books.Add(new Book { Name = "Відьмак 3", Author = "Сапковський", Price = 98 });

            base.Seed(db);
        }
    }
}