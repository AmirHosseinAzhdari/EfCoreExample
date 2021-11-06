using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreExample_DataAccess.Models
{
    [Table("tbl_Author")]
    public class Author
    {
        [Key]
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)] or we can use None for not identifier
        public int Id { get; set; }

        [Required] [MaxLength(400)] public string FirstName { get; set; }

        [Required] [MaxLength(400)] public string LastName { get; set; }

        [Required] public DateTime BirthDate { get; set; }

        public string Location { get; set; }

        [NotMapped] public string FullName => $"{FirstName} {LastName}";


        #region Relations

        public List<BookAuthor> BookAuthors { get; set; }

        #endregion
    }
}