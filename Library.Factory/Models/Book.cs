using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Factory.Models
{
    public class Book
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public string AuthorName { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string Serial { get; set; }

        public DateTime? Modify { get; set; }
    }
}
