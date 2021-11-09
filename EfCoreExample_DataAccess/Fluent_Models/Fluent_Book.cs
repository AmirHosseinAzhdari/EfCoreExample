using System.Collections.Generic;

namespace EfCoreExample_DataAccess.Fluent_Models
{
    public class Fluent_Book
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int PublisherId { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public double Price { get; set; }
        public string PriceRange { get; set; }


        #region Relations

        public Fluent_Category FluentCategory { get; set; }
        public Fluent_BookDetail FluentBookDetail { get; set; }
        public Fluent_Publisher FluentPublisher { get; set; }
        public List<Fluent_BookAuthor> FluentBookAuthors { get; set; }

        #endregion
    }
}