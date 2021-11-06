using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreExample_DataAccess.Models
{
    [Table("tbl_Publisher")]
    public class Publisher
    {
        [Key] public int Id { get; set; }

        [Required] [MaxLength(400)] public string Name { get; set; }

        [Required] public string Location { get; set; }


        #region Relations

        public List<Book> Books { get; set; }

        #endregion
    }
}