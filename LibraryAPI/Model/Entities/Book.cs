using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Model.Entities
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public int PublicationYear { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }

    }


    public class GetBook
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public int PublicationYear { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
    }
}
