using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;


namespace DhakaCreditGym.Models.Business_Logic
{
    public class MemberBL
    {
        string constring = ConfigurationManager.ConnectionStrings["cccul_db"].ConnectionString;
        public void NewMember(Members m)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "insert into tbl_Members values('" + m.M_First_Name + "','" + m.M_Middle_Name + "','" + m.M_Last_Name + "','" + m.M_Date_Of_Birth + "','"
                + m.M_NiD_Number + "','" + m.M_Father_Name + "','" + m.M_Mother_Name + "','" + m.M_Religion + "','" + m.M_Gender + "','" + m.M_Marital_Status + "','"
                + m.M_Present_Address + "','" + m.M_Permanent_Address + "','" + m.M_Phone + "','" + m.M_Email + "','"+m.M_Occupation+"','"+m.M_Working_Address+"','" 
                + m.M_Group + "','" +m.M_Catagory+ "','" +m.M_Code + "','" +m.M_Cccul_Membership_No + "','"+ m.M_Status + "','" + m.Created_Date + "','" + m.Created_By + "',)";
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            con.Close();
        }
        public List<Members> GetAll()
        {
            List<Members> mList = new List<Members>();
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "select * From tbl_Members";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Members m = new Members();
                m.M_Id = Convert.ToInt32(reader["M_Id"].ToString());
                m.M_First_Name = reader["M_First_Name"].ToString();
                m.M_Middle_Name = reader["M_Middle_Name"].ToString();
                m.M_Last_Name = reader["M_Last_Name"].ToString();
                m.M_Date_Of_Birth = Convert.ToDateTime(reader["M_Date_Of_Birth"].ToString());
                m.M_NiD_Number = reader["M_NID_Number"].ToString();
                m.M_Father_Name = reader["M_Father_Name"].ToString();
                m.M_Mother_Name = reader["M_Mother_Name"].ToString();
                m.M_Religion = reader["M_Religion"].ToString();
                m.M_Gender = reader["M_Gender"].ToString();
                m.M_Marital_Status = reader["M_Marital_Status"].ToString();
                m.M_Present_Address = reader["M_Present_Address"].ToString();
                m.M_Permanent_Address = reader["M_Permanent_Address"].ToString();
                m.M_Phone = reader["M_Phone"].ToString();
                m.M_Email = reader["M_Email"].ToString();
                m.M_Occupation = reader["M_Occupation"].ToString();
                m.M_Working_Address = reader["M_Working_Address"].ToString();
                m.M_Group = reader["M_Group"].ToString();
                m.M_Catagory = reader["M_Catagory"].ToString();
                m.M_Code = Convert.ToInt32(reader["M_Code"].ToString());
                m.M_Cccul_Membership_No = reader["M_Cccul_Membership_No"].ToString();
                m.M_Status = reader["emp_Status"].ToString();
                m.Created_Date = Convert.ToDateTime(reader["Created_Date"].ToString());
                m.Created_By = reader["Created_By"].ToString();
                mList.Add(m);
            }
            con.Close();
            return mList;
        }
        public Members Search(int id)
        {
            Members m = new Members();
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "select * From tbl_Member where emp_Id='" + id + "'";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                m.M_Id = Convert.ToInt32(reader["M_Id"].ToString());
                m.M_First_Name = reader["M_First_Name"].ToString();
                m.M_Middle_Name = reader["M_Middle_Name"].ToString();
                m.M_Last_Name = reader["M_Last_Name"].ToString();
                m.M_Date_Of_Birth = Convert.ToDateTime(reader["M_Date_Of_Birth"].ToString());
                m.M_NiD_Number = reader["M_NID_Number"].ToString();
                m.M_Father_Name = reader["M_Father_Name"].ToString();
                m.M_Mother_Name = reader["M_Mother_Name"].ToString();
                m.M_Religion = reader["M_Religion"].ToString();
                m.M_Gender = reader["M_Gender"].ToString();
                m.M_Marital_Status = reader["M_Marital_Status"].ToString();
                m.M_Present_Address = reader["M_Present_Address"].ToString();
                m.M_Permanent_Address = reader["M_Permanent_Address"].ToString();
                m.M_Phone = reader["M_Phone"].ToString();
                m.M_Email = reader["M_Email"].ToString();
                m.M_Occupation = reader["M_Occupation"].ToString();
                m.M_Working_Address = reader["M_Working_Address"].ToString();
                m.M_Group = reader["M_Group"].ToString();
                m.M_Catagory = reader["M_Catagory"].ToString();
                m.M_Code = Convert.ToInt32(reader["M_Code"].ToString());
                m.M_Cccul_Membership_No = reader["M_Cccul_Membership_No"].ToString();
                m.M_Status = reader["emp_Status"].ToString();
                m.Created_Date = Convert.ToDateTime(reader["Created_Date"].ToString());
                m.Created_By = reader["Created_By"].ToString();
            }
            con.Close();
            return m;
        }
        public void Update(Members m)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "update tbl_Members set M_First_Name='" + m.M_First_Name
                + "',M_Middle_Name='" + m.M_Middle_Name
                + "',M_Last_Name='" + m.M_Last_Name
                + "',M_Date_Of_Birth='" + m.M_Date_Of_Birth
                + "',M_NID_Numbe=r'" + m.M_NiD_Number
                + "',M_Father_Name='" + m.M_Father_Name
                + "',M_Mother_Name='" + m.M_Mother_Name
                + "',M_Religion='" + m.M_Religion
                + "',M_Gender='" + m.M_Gender
                + "',M_Marital_Status='" + m.M_Marital_Status
                + "',M_Present_Address='" + m.M_Present_Address
                + "',M_Permanent_Address='" + m.M_Permanent_Address
                + "',M_Phone='" + m.M_Phone
                + "',M_Email='" + m.M_Email
                + "',M_Occupation'" + m.M_Occupation
                + "',M_Working_Address'" + m.M_Working_Address
                + "',M_Group='" + m.M_Group
                + "',M_Catagory='" + m.M_Catagory
                + "',M_Code='" + m.M_Code
                + "',M_Cccul_Membership_No='" + m.M_Cccul_Membership_No
                + "',M_Status='" + m.M_Status
                + "',M_Created_Date='" + m.Created_Date
                + "',M_Created_By='" + m.Created_By + "',";
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}