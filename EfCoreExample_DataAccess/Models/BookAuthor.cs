using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreExample_DataAccess.Models
{
    [Table("tbl_BookAuthor")]
    public class BookAuthor
    {
        [ForeignKey("Book")] public int BookId { get; set; }

        [ForeignKey("Author")] public int AuthorId { get; set; }


        #region Relations

        public Book Book { get; set; }
        public Author Author { get; set; }

        #endregion
    }
}