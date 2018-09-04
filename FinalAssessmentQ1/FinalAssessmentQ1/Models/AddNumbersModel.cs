using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalAssessmentQ1.Models
{
    public class AddNumbersModel
    {
        [Required]
        [RegularExpression(@"\d+")]
        [Range(1, 1000, ErrorMessage = "Sorry but the number must be between 1 and 1000")]
        public int NumberOne { get; set; }
        [Required]
        [RegularExpression(@"\d+")]
        [Range(1, 1000, ErrorMessage = "Sorry but the number must be between 1 and 1000")]
        public int NumberTwo { get; set; }
    }
}