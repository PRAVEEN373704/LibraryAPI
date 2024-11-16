namespace LibraryManagement.Model.Entities
{
    public class BookRequest
    {
       

        public string Title { get; set; }
        public string Description { get; set; }
        public int PublicationYear { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }

    }

    public class BookFilterRequest
    {

        public int id { get; set; }

    }
}
