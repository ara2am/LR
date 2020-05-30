using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LR.Models
{
    public class GetWorkersModel
    {
        [Required]
        [DataType (DataType.Text)]
        public string CafeName { get; set; }
    }
}