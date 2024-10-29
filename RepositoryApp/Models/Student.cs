using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RepositoryApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Email")]
        [EmailAddress(ErrorMessage = "Email should be valid")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter RegNo")]
        
        public string RegNo { get; set; }
    }
}