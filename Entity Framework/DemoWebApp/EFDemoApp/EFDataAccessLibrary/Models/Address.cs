﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFDataAccessLibrary.Models
{
    public class Address
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(200)]
        public string StreetAddress { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string City { get; set; }
        
    }
}
