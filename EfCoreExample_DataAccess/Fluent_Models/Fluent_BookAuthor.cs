namespace EfCoreExample_DataAccess.Fluent_Models
{
    public class Fluent_BookAuthor
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }


        #region Relations

        public Fluent_Book FluentBook { get; set; }
        public Fluent_Author FluentAuthor { get; set; }

        #endregion
    }
}