﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Minix
{
    [Keyless]
    public partial class View_Mag
    {
        
        public int ID { get; set; }
        [StringLength(30)]
        public string PN { get; set; }
        [StringLength(500)]
        public string DESCRIZIONE { get; set; }
        public int? SATATO { get; set; }
        [StringLength(500)]
        public string CERTIFICAZIONE { get; set; }
        public int? QTA { get; set; }
        public double? COSTO { get; set; }
        [StringLength(100)]
        public string REPARTO { get; set; }
        public bool? CERTIFICATO { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DATA { get; set; }
    }
}