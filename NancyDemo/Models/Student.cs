using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace NancyDemo.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required, Display(Name = "First Name")]
        public string FirstName { get; set; }

        public string Initials { get; set; }

        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; }

        public DateTime? BirthDate { get; set; }
    }
}