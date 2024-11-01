using Rosculet_Cosmin_Laborator2.Models;

namespace Rosculet_Cosmin_Laborator2.Models.ViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
