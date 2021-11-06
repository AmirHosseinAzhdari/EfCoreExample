using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreExample_DataAccess.Models
{
    [Table("tbl_Category")]
    public class Category
    {
        [Key] public int Id { get; set; }

        [Required] [MaxLength(200)] public string Name { get; set; }


        #region Relations

        public List<Book> Books { get; set; }

        #endregion
    }
}