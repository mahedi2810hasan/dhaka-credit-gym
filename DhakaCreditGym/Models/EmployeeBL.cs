using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using DhakaCreditGym.Models;

namespace DhakaCreditGym.Models
{
    public class EmployeeBL
    {
        string constring = ConfigurationManager.ConnectionStrings["cccul_db"].ConnectionString;
        public void NewEmployee(Employees e)
        {
            SqlConnection con = new SqlConnection();
            con.Open();
            string query = "insert into tbl_Employees values('"+e.emp_First_Name+"','"+e.emp_Middle_Name+"','"+e.emp_Last_Name+"','"+e.emp_Date_Of_Birth+"','"
                +e.emp_NiD_Number+"','"+e.emp_Father_Name+"','"+e.emp_Mother_Name+"','"+e.emp_Religion+"','"+e.emp_Gender+"','"+e.emp_Marital_Status+"','"
                +e.emp_Spouse_Name+"','"+e.emp_Present_Address+"','"+e.emp_Permanent_Address+"','"+e.emp_Phone+"','"+e.emp_Email+"','"+e.emp_Blood_Group+"','"
                +e.emp_Last_Academic_Certification+"','"+e.emp_Last_Academic_Certification_Result+"','"+e.emp_Joining_Date+"','"+e.emp_Designation+"','"
                +e.emp_Salary+"','"+e.emp_Image+"','"+e.emp_Status+"','"+e.Created_Date+"','"+e.Created_By+"',)";
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            con.Close();
        }
        public List<Employees>GetAll()
        {
            List<Employees> empList = new List<Employees>();
            SqlConnection con = new SqlConnection();
            con.Open();
            string query = "select * From tbl_Employees";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            if(reader.Read())
            {
                Employees e = new Employees();
                e.emp_Id = Convert.ToInt32(reader["emp_Id"].ToString());
                e.emp_First_Name = reader["emp_First_Name"].ToString();
                e.emp_Middle_Name = reader["emp_Middle_Name"].ToString();
                e.emp_Last_Name = reader["emp_Last_Name"].ToString();
                e.emp_Date_Of_Birth = Convert.ToDateTime(reader["emp_Date_Of_Birth"].ToString());
                e.emp_NiD_Number = reader["emp_NID_Number"].ToString();
                e.emp_Father_Name = reader["emp_Father_Name"].ToString();
                e.emp_Mother_Name = reader["emp_Mother_Name"].ToString();
                e.emp_Religion = reader["emp_Religion"].ToString();
                e.emp_Gender = reader["emp_Gender"].ToString();
                e.emp_Marital_Status = reader["emp_Marital_Status"].ToString();
                e.emp_Spouse_Name = reader["emp_Spouse_Name"].ToString();
                e.emp_Present_Address = reader["emp_Present_Address"].ToString();
                e.emp_Permanent_Address = reader["emp_Permanent_Address"].ToString();
                e.emp_Phone = reader["emp_Phone"].ToString();
                e.emp_Email = reader["emp_Email"].ToString();
                e.emp_Blood_Group = reader["emp_Blood_Group"].ToString();
                e.emp_Last_Academic_Certification = reader["emp_Last_Academic_Certification"].ToString();
                e.emp_Last_Academic_Certification_Result = reader["emp_Last_Academic_Certification_Result"].ToString();
                e.emp_Joining_Date = Convert.ToDateTime(reader["emp_Joining_Date"].ToString());
                e.emp_Designation = reader["emp_Designation"].ToString();
                e.emp_Salary = Convert.ToDouble(reader["emp_Salary"].ToString());
                e.emp_Image = reader["emp_Image"].ToString();
                e.emp_Status = reader["emp_Status"].ToString();
                e.Created_Date = Convert.ToDateTime(reader["Created_Date"].ToString());
                e.Created_By = reader["Created_By"].ToString();
                empList.Add(e);
            }
            con.Close();
            return empList;
        }
        public Employees Search(int id)
        {
            Employees e = new Employees();
            SqlConnection con = new SqlConnection();
            con.Open();
            string query = "select * From tbl_Employees where emp_Id='"+id+"'";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                e.emp_Id = Convert.ToInt32(reader["emp_Id"].ToString());
                e.emp_First_Name = reader["emp_First_Name"].ToString();
                e.emp_Middle_Name = reader["emp_Middle_Name"].ToString();
                e.emp_Last_Name = reader["emp_Last_Name"].ToString();
                e.emp_Date_Of_Birth = Convert.ToDateTime(reader["emp_Date_Of_Birth"].ToString());
                e.emp_NiD_Number = reader["emp_NID_Number"].ToString();
                e.emp_Father_Name = reader["emp_Father_Name"].ToString();
                e.emp_Mother_Name = reader["emp_Mother_Name"].ToString();
                e.emp_Religion = reader["emp_Religion"].ToString();
                e.emp_Gender = reader["emp_Gender"].ToString();
                e.emp_Marital_Status = reader["emp_Marital_Status"].ToString();
                e.emp_Spouse_Name = reader["emp_Spouse_Name"].ToString();
                e.emp_Present_Address = reader["emp_Present_Address"].ToString();
                e.emp_Permanent_Address = reader["emp_Permanent_Address"].ToString();
                e.emp_Phone = reader["emp_Phone"].ToString();
                e.emp_Email = reader["emp_Email"].ToString();
                e.emp_Blood_Group = reader["emp_Blood_Group"].ToString();
                e.emp_Last_Academic_Certification = reader["emp_Last_Academic_Certification"].ToString();
                e.emp_Last_Academic_Certification_Result = reader["emp_Last_Academic_Certification_Result"].ToString();
                e.emp_Joining_Date = Convert.ToDateTime(reader["emp_Joining_Date"].ToString());
                e.emp_Designation = reader["emp_Designation"].ToString();
                e.emp_Salary = Convert.ToDouble(reader["emp_Salary"].ToString());
                e.emp_Image = reader["emp_Image"].ToString();
                e.emp_Status = reader["emp_Status"].ToString();
                e.Created_Date = Convert.ToDateTime(reader["Created_Date"].ToString());
                e.Created_By = reader["Created_By"].ToString();
            }
            con.Close();
            return e;
        }
        public void Update(Employees e)
        {
            SqlConnection con = new SqlConnection();
            con.Open();
            string query = "update tbl_Employees set emp_First_Name='" + e.emp_First_Name 
                + "',emp_Middle_Name='" + e.emp_Middle_Name 
                + "',emp_Last_Name='" + e.emp_Last_Name 
                + "',emp_Date_Of_Birth='" + e.emp_Date_Of_Birth 
                + "',emp_NID_Numbe=r'"+ e.emp_NiD_Number 
                + "',emp_Father_Name='" + e.emp_Father_Name 
                + "',emp_Mother_Name='" + e.emp_Mother_Name 
                + "',emp_Religion='" + e.emp_Religion 
                + "',emp_Gender='" + e.emp_Gender 
                + "',emp_Marital_Status='" + e.emp_Marital_Status 
                + "',emp_Spouse_Name='"+ e.emp_Spouse_Name
                + "',emp_Present_Address='" + e.emp_Present_Address 
                + "',emp_Permanent_Address='" + e.emp_Permanent_Address 
                + "',emp_Phone='" + e.emp_Phone 
                + "',emp_Email='" + e.emp_Email
                + "',emp_Blood_Group='" + e.emp_Blood_Group
                + "',emp_Last_Academic_Certification='" + e.emp_Last_Academic_Certification
                + "',emp_Last_Academic_Certification_Result='" + e.emp_Last_Academic_Certification_Result 
                + "',emp_Joining_Date='" + e.emp_Joining_Date
                + "',emp_Designation='" + e.emp_Designation 
                + "',emp_Salary='" + e.emp_Salary 
                + "',emp_Image='" + e.emp_Image
                + "',emp_Status='" + e.emp_Status
                + "',emp_Created_Date='" + e.Created_Date 
                + "',emp_Created_By='" + e.Created_By + "',";
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}