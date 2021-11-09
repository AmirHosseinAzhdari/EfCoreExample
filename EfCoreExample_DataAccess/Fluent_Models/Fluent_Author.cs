using System.Collections.Generic;

namespace EfCoreExample_DataAccess.Fluent_Models
{
    public class Fluent_Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Location { get; set; }
        public string FullName => $"{FirstName} {LastName}";


        #region Relations

        public List<Fluent_BookAuthor> FluentBookAuthors { get; set; }

        #endregion
    }
}