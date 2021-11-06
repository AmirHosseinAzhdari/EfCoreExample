using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreExample_DataAccess.Models
{
    [Table("tbl_BookDetail")]
    public class BookDetail
    {
        [Key] public int Id { get; set; }

        [ForeignKey("Book")] public int BookId { get; set; }

        [Required] public int NumberOfChapters { get; set; }

        [Required] public int NumberOfPages { get; set; }

        public double Weight { get; set; }


        #region Relations

        public Book Book { get; set; }

        #endregion
    }
}