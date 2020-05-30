using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LR.Models
{
    public class WorkerModel
    {
        [Required]
        [DataType (DataType.Text)]
        public string FirstName { get; set; }

        [Required]
        [DataType (DataType.Text)]
        public string SecondName { get; set; }

        [Required]
        [DataType (DataType.Text)]
        public string CafeName { get; set; }
    }
}