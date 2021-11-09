using EfCoreExample_DataAccess.Models;
using EfCoreExample_DataAccess.Fluent_Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCoreExample_DataAccess.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        #region Data annotations
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        
        #endregion

        #region Fluents
        
        public DbSet<Fluent_Book> Fluent_Books { get; set; }
        public DbSet<Fluent_Publisher> Fluent_Publishers { get; set; }
        public DbSet<Fluent_Author> Fluent_Authors { get; set; }
        public DbSet<Fluent_BookDetail> Fluent_BookDetails { get; set; }
        public DbSet<Fluent_BookAuthor> Fluent_BookAuthors { get; set; }
        public DbSet<Fluent_Category> Fluent_Categories { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // add book id and author id as Key in database for BookAuthor
            modelBuilder.Entity<BookAuthor>().HasKey(b => new {b.AuthorId, b.BookId});

            #region Category

            modelBuilder.Entity<Fluent_Category>().ToTable("tbl_fluent_category");
            modelBuilder.Entity<Fluent_Category>().HasKey(b => b.Id);
            modelBuilder.Entity<Fluent_Category>().Property(b => b.Name).IsRequired();

            #endregion

            #region Book Detail

            modelBuilder.Entity<Fluent_BookDetail>().ToTable("tbl_fluent_bookDetail");
            modelBuilder.Entity<Fluent_BookDetail>().HasKey(b => b.Id);
            modelBuilder.Entity<Fluent_BookDetail>()
                .Property(b => new {b.NumberOfChapters, b.NumberOfPages}).IsRequired();
            // Foreign key (one to one)
            modelBuilder.Entity<Fluent_BookDetail>()
                .HasOne(b => b.FluentBook).WithOne(b => b.FluentBookDetail)
                .HasForeignKey<Fluent_BookDetail>("BookId");

            #endregion

            #region Book

            modelBuilder.Entity<Fluent_Book>().ToTable("tbl_fluent_book");
            modelBuilder.Entity<Fluent_Book>().HasKey(b => b.Id);
            modelBuilder.Entity<Fluent_Book>().Property(b => b.Title)
                .IsRequired().HasMaxLenght(300);
            modelBuilder.Entity<Fluent_Book>().Property(b => b.Isbn)
                .IsRequired().HasMaxLenght(50);
            modelBuilder.Entity<Fluent_Book>().Property(b => b.Price).IsRequired();
            modelBuilder.Entity<Fluent_Book>().Ignore(b => b.PriceRange);
            // foreign key (one to many)
            modelBuilder.Entity<Fluent_Book>()
                .HasOne(b => b.FluentPublisher).WithMany(b => b.FluentBooks)
                .HasForeignKey<Fluent_Book>("PublisherId");


            #endregion

            #region Author

            modelBuilder.Entity<Fluent_Author>().ToTable("tbl_fluent_author");
            modelBuilder.Entity<Fluent_Author>().HasKey(b => b.Id);
            modelBuilder.Entity<Fluent_Author>().Property(b => new {b.FirstName, b.LastName})
                .IsRequired().HasMaxLenght(400);
            modelBuilder.Entity<Fluent_Author>().Property(b => b.BirthDate).IsRequired();
            modelBuilder.Entity<Fluent_Author>().Ignore(b => b.FullName);

            #endregion

            #region Publisher

            modelBuilder.Entity<Fluent_Publisher>().ToTable("tbl_fluent_publisher");
            modelBuilder.Entity<Fluent_Publisher>().HasKey(b => b.Id);
            modelBuilder.Entity<Fluent_Publisher>().Property(b => b.Name)
                .IsRequired().HasMaxLenght(400);
            modelBuilder.Entity<Fluent_Publisher>().Property(b => b.Location).IsRequired();

            #endregion

            #region Book Author

            modelBuilder.Entity<Fluent_BookAuthor>().ToTable("tbl_fluent_bookAuthor");
            modelBuilder.Entity<Fluent_BookAuthor>().HasKey(b => new {b.AuthorId, b.BookId});
            // foreign keys (many to many)
            modelBuilder.Entity<Fluent_BookAuthor>()
                .HasOne(b => b.FluentBook).WithMany(b => b.FluentBookAuthors)
                .HasForeignKey(b => b.BookId);
            modelBuilder.Entity<Fluent_BookAuthor>()
                .HasOne(b => b.FluentAuthor).WithMany(b => b.FluentBookAuthors)
                .HasForeignKey(b => b.AuthorId);


            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}