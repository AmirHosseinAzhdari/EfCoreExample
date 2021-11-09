using System.Collections.Generic;

namespace EfCoreExample_DataAccess.Fluent_Models
{
    public class Fluent_Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        #region Relations

        public List<Fluent_Book> FluentBooks { get; set; }

        #endregion
    }
}