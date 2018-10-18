using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace DhakaCreditGym.Models.Business_Logic
{
    public class Expenditure_BL
    {
        string connection = ConfigurationManager.ConnectionStrings["cccul_db"].ConnectionString;

        public void createPayReceive(Expenditure ex)
        {
            //query for insert command
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string createQuery = "Insert into tbl_Expenditure values('"
                + ex.exp_id + "','"
                + ex.emp_id + "','"
                + ex.exp_purpose + "','"
                + ex.exp_for + "','"
                + ex.exp_description + "','"
                + ex.exp_amount + "','"
                + ex.created_date + "','"
                + ex.created_by + "')";
            SqlCommand command = new SqlCommand(createQuery, con);
            command.ExecuteNonQuery();
            con.Close();

        }
        public List<Expenditure> selectPayReceive()
        {
            //query for select command
            List<Expenditure> PayReceiveList = new List<Expenditure>();
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string selectQuery = "Select * from tbl_Expenditure";
            SqlCommand command = new SqlCommand(selectQuery, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Expenditure ex = new Expenditure();
                ex.exp_id = Convert.ToInt32(reader["Exp_ID"].ToString());
                ex.emp_id = Convert.ToInt32(reader["Emp_id"].ToString());
                ex.exp_purpose = reader["Purpose"].ToString();
                ex.exp_for = reader["Exp_for"].ToString();
                ex.exp_description = reader["Exp_Description"].ToString();
                ex.exp_amount = Convert.ToDecimal(reader["Exp_amount"].ToString());
                ex.created_date = Convert.ToDateTime(reader["created_date"].ToString());
                ex.created_by = reader["created_by"].ToString();
                PayReceiveList.Add(ex);

            }
            con.Close();
            return PayReceiveList;

        }
        public Expenditure SearchPr(int id)
        {
            //query for select command
            Expenditure ex = new Expenditure();
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string selectQuery = "Select * from tbl_Expenditure where exp_id = '" + id + "'";
            SqlCommand command = new SqlCommand(selectQuery, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ex.exp_id = Convert.ToInt32(reader["Exp_ID"].ToString());
                ex.emp_id = Convert.ToInt32(reader["Emp_id"].ToString());
                ex.exp_purpose = reader["Purpose"].ToString();
                ex.exp_for = reader["Exp_for"].ToString();
                ex.exp_description = reader["Exp_Description"].ToString();
                ex.exp_amount = Convert.ToDecimal(reader["Exp_amount"].ToString());
                ex.created_date = Convert.ToDateTime(reader["created_date"].ToString());
                ex.created_by = reader["created_by"].ToString();


            }
            con.Close();
            return ex;

        }
        public void updatePayReceive(Expenditure ex)
        {
            //query for insert command
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string createQuery = "Update tbl_Expenditure set exp_id = '" + ex.exp_id
                + "',emp_id = '" + ex.emp_id
                + "',purpose = '" + ex.exp_purpose
                + "',Exp_for = '" + ex.exp_for
                + "', exp_description = '" + ex.exp_description
                + "',exp_amount = '" + ex.exp_amount
                + "',created_date = '" + ex.created_date
                + "',created_by = '" + ex.created_by + "')";
            SqlCommand command = new SqlCommand(createQuery, con);
            command.ExecuteNonQuery();
            con.Close();

        }
    }
}