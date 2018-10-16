using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DhakaCreditGym.Models.Business_Logic
{
    public class PaymentReceive
    {
        [Required]
        [Display(Name = "Payment No")]
        public int paymentNo { get; set; }
        [Required]
        [Display(Name = "Member  ID")]
        public int memberID { get; set; }
        [Display(Name = "Payment Date")]
        public DateTime paymentDate { get; set; }
        [Display(Name = "Type of Payment")]
        public string paymentType { get; set; }
        [Display(Name = "Payment Amount")]
        public decimal paymentAmount { get; set; }
        [Display(Name = "Discount")]
        public decimal paymentDiscount { get; set; }
        [Display(Name = "Total Payment")]
        public decimal paymentTotal { get; set; }
        public string createdBy { get; set; }

    }
}