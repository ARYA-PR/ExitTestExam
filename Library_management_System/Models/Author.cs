﻿using System.ComponentModel.DataAnnotations;

namespace Library_management_System.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Bio {  get; set; }
        public ICollection<Book> Books {  get; set; }

    }
}
