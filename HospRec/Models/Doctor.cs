﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HospRec.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public int hospId { get; set; }        
        [Required]
        [StringLength(15, ErrorMessage = "Last name must be 15 characters long")]
        [RegularExpression(@"[a-zA-Z]", ErrorMessage = "First name must be alphebetical")]
        public string firstName { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Last name must be 15 characters long")]
        [RegularExpression(@"[a-zA-Z]", ErrorMessage = "First name must be alphebetical")]
        public string lastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [Required]
        [RegularExpression(@"[0-9]{10}", ErrorMessage = "Phone number must be 10 digits long")]
        public string phoneNumber { get; set; }
        [Required]
        [RegularExpression(@"[^-]", ErrorMessage = "Invalid Gender")]
        public char gender { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public string DOB { get; set; }
    }
}
