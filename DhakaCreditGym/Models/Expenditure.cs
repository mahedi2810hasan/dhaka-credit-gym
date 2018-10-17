using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace DhakaCreditGym.Models
{
    public class Expenditure
    {
        [Key]
        public int exp_id { get; set; }
        public int emp_id { get; set; }
        public string exp_purpose { get; set; }
        public string exp_for { get; set; }
        public string exp_description { get; set; }
        public Decimal exp_amount { get; set; }
        public DateTime created_date { get; set; }
        public string created_by { get; set; }
    }
}