﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Minix.Data
{
    [Table("user")]
    public partial class user
    {
      
        [Key]
        public int id { get; set; }
        [StringLength(100)]
        public string User { get; set; }
        public string Password { get; set; }

 
    }
}