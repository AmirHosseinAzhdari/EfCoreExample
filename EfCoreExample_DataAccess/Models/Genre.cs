using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreExample_DataAccess.Models
{
    [Table("tbl_Genre")]
    public class Genre
    {
        [Key] public int Id { get; set; }

        [Column("Name")] // Column name in database
        public string GenreName { get; set; }

        public int DisplayOrder { get; set; }
    }
}