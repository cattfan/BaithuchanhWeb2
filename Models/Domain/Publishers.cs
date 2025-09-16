﻿using System.ComponentModel.DataAnnotations;

namespace BaithuchanhWeb2.Models.Domain
{
    public class Publishers
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}