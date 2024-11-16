﻿using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Model.Entities
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
    }
}
