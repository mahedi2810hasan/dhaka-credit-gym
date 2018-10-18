using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DhakaCreditGym.Models
{
    public class Employees
    {
        [Key]
        public int emp_Id { get; set; }
        public string emp_First_Name { get; set; }
        public string emp_Middle_Name { get; set; }
        public string emp_Last_Name { get; set; }
        public DateTime emp_Date_Of_Birth { get; set; }
        public string emp_NiD_Number { get; set; }
        public string emp_Father_Name { get; set; }
        public string emp_Mother_Name { get; set; }
        public string emp_Religion { get; set; }
        public string emp_Gender { get; set; }
        public string emp_Marital_Status { get; set; }
        public string emp_Spouse_Name { get; set; }
        public string emp_Present_Address { get; set; }
        public string emp_Permanent_Address { get; set; }
        public string emp_Phone { get; set; }
        public string emp_Email { get; set; }
        public string emp_Blood_Group { get; set; }
        public string emp_Last_Academic_Certification { get; set; }
        public string emp_Last_Academic_Certification_Result { get; set; }
        public DateTime emp_Joining_Date { get; set; }
        public string emp_Designation { get; set; }
        public double emp_Salary { get; set; }
        public string emp_Image { get; set; }
        public string emp_Status { get; set; }
        public DateTime Created_Date { get; set; }
        public string Created_By { get; set; }
    }
}