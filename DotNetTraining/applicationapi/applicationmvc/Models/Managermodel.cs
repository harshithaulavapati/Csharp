using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace applicationmvc.Models
{
    public class Managermodel
    {
        //[Required(ErrorMessage = "please enter valid date")]
        public int Requestid { get; set; }
        //[DisplayFormat(DataFormatString = "{dd.MM.yyyy}")]
        [Required(ErrorMessage = "please enter valid date")]
        public Nullable<System.DateTime> RequestDate { get; set; }
        [Required(ErrorMessage = "please enter valid Locaton")]
        public string FromLocation { get; set; }
        [Required(ErrorMessage = "please enter valid Locaton")]
        public string ToLocation { get; set; }
        [Required(ErrorMessage = "please enter valid userid these numbers 2,3")]
        public Nullable<int> UserId { get; set; }
        [Required(ErrorMessage = "please enter valid status")]
        public string CurrentStatus { get; set; }
    }

   
}