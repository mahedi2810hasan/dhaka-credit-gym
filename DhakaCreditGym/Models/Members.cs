using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DhakaCreditGym.Models
{
    public class Members
    {
        [Key]
        public int M_Id { get; set; }
        public string M_First_Name { get; set; }
        public string M_Middle_Name { get; set; }
        public string M_Last_Name { get; set; }
        public DateTime M_Date_Of_Birth { get; set; }
        public string M_NiD_Number { get; set; }
        public string M_Father_Name { get; set; }
        public string M_Mother_Name { get; set; }
        public string M_Religion { get; set; }
        public string M_Gender { get; set; }
        public string M_Marital_Status { get; set; }
        public string M_Present_Address { get; set; }
        public string M_Permanent_Address { get; set; }
        public string M_Phone { get; set; }
        public string M_Email { get; set; }
        public string M_Occupation { get; set; }
        public string M_Working_Address { get; set; }
        public string M_Group { get; set; }
        public string M_Catagory { get; set; }
        public int M_Code { get; set; }
        public string M_Cccul_Membership_No { get; set; }
        public string M_Status { get; set; }
        public DateTime Created_Date { get; set; }
        public string Created_By { get; set; }
    }
}