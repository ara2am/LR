using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LR.Models
{
    public class AddCafeModel
    {
        [Required]
        [DataType (DataType.Text)]
        public string Name { get; set; }

        [Required]
        [DataType (DataType.Text)]
        public string Location { get; set; }

        [Required]
        public int PlaceCount { get; set; }
    }
}