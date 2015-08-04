using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Factory.Models
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public string SecondName { get; set; }

        public DateTime? RegistretionDate { get; set; }

        public string PhoneNumber { get; set; }

        public string Adress { get; set; } 
    }
}