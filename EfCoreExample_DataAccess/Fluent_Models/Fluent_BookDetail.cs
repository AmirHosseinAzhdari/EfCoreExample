namespace EfCoreExample_DataAccess.Fluent_Models
{
    public class Fluent_BookDetail
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int NumberOfChapters { get; set; }
        public int NumberOfPages { get; set; }
        public double Weight { get; set; }

        #region Relations

        public Fluent_Book FluentBook { get; set; }

        #endregion
    }
}