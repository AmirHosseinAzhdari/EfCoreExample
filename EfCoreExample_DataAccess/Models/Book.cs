using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreExample_DataAccess.Models
{
    [Table("tbl_Book")]
    public class Book
    {
        [Key] // primary key, unique identifier
        public int Id { get; set; }

        [ForeignKey("Category")] public int CategoryId { get; set; }

        [ForeignKey("Publisher")] public int PublisherId { get; set; }

        [Required] [MaxLength(300)] public string Title { get; set; }

        [Required] [MaxLength(50)] public string Isbn { get; set; }

        [Required] public double Price { get; set; }

        [NotMapped] // not generated into database
        public string PriceRange { get; set; }


        #region Relations

        public Category Category { get; set; }
        public BookDetail BookDetail { get; set; }
        public Publisher Publisher { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }

        #endregion
    }
}