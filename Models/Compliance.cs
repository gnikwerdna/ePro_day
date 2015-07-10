﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ePro.Models
{
    public class Compliance
    {
        [Key]
        [Display(Name = "ID")]
        public int ComplinanceID { get; set; }
        [Display(Name = "Compliance Form")]
        public int ComplianceFormID { get; set; }
        [Display(Name = "Compliance ID")]
        public int ComplianceitemsID { get; set; }
        public string Description { get; set; }
        public virtual ComplianceForm ComplianceForm { get; set; }
        public virtual ComplianceItems ComplianceItem { get; set; }
    }

    
}