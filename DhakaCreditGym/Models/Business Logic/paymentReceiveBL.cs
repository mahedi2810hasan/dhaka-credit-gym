using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace DhakaCreditGym.Models.Business_Logic
{
    public class paymentReceiveBL
    {
        string connection = ConfigurationManager.ConnectionStrings["cccul_db"].ConnectionString;

        public void createPayReceive(PaymentReceive pr)
        {
            //query for insert command
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string createQuery = "Insert into tbl_Payment_Receive values('" 
                + pr.paymentNo + "','" 
                + pr.memberID + "','" 
                + pr.paymentDate + "','" 
                + pr.paymentType + "','" 
                + pr.paymentAmount + "','" 
                + pr.paymentDiscount + "','" 
                + pr.paymentTotal + "','" 
                + pr.createdBy + "')";
            SqlCommand command = new SqlCommand(createQuery, con);
            command.ExecuteNonQuery();
            con.Close();

        }
        public List<PaymentReceive> selectPayReceive()
        {
            //query for select command
            List<PaymentReceive> PayReceiveList = new List<PaymentReceive>();
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string selectQuery = "Select * from tbl_Payment_Receive";
            SqlCommand command = new SqlCommand(selectQuery, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                PaymentReceive pr = new PaymentReceive();
                pr.paymentNo = Convert.ToInt32(reader["paymentNo"].ToString());
                pr.memberID = Convert.ToInt32(reader["m_id"].ToString());
                pr.paymentDate = Convert.ToDateTime(reader["pay_date"].ToString());
                pr.paymentType = reader["pay_type"].ToString();
                pr.paymentAmount = Convert.ToDecimal(reader["pay_amount"].ToString());
                pr.paymentDiscount = Convert.ToDecimal(reader["pay_discount"].ToString());
                pr.paymentTotal = Convert.ToDecimal(reader["pay_total"].ToString());
                pr.createdBy = reader["created_by"].ToString();
                PayReceiveList.Add(pr);

            }
            con.Close();
            return PayReceiveList;

        }
        public PaymentReceive SearchPr(int id)
        {
            //query for select command
            PaymentReceive pr = new PaymentReceive();
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string selectQuery = "Select * from tbl_Payment_Receive where paymentNo = '"+id+"'";
            SqlCommand command = new SqlCommand(selectQuery, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                pr.paymentNo = Convert.ToInt32(reader["paymentNo"].ToString());
                pr.memberID = Convert.ToInt32(reader["m_id"].ToString());
                pr.paymentDate = Convert.ToDateTime(reader["pay_date"].ToString());
                pr.paymentType = reader["pay_type"].ToString();
                pr.paymentAmount = Convert.ToDecimal(reader["pay_amount"].ToString());
                pr.paymentDiscount = Convert.ToDecimal(reader["pay_discount"].ToString());
                pr.paymentTotal = Convert.ToDecimal(reader["pay_total"].ToString());
                pr.createdBy = reader["created_by"].ToString();
                    

            }
            con.Close();
            return pr;

        }
        public void updatePayReceive(PaymentReceive pr)
        {
            //query for insert command
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string createQuery = "Update tbl_Payment_Receive set paymentNo = '" + pr.paymentNo 
                + "',m_id = '" + pr.memberID 
                + "',pay_date = '" + pr.paymentDate 
                + "',pay_type = '" + pr.paymentType 
                + "', pay_amount = '" + pr.paymentAmount 
                + "',pay_discount = '" + pr.paymentDiscount 
                + "',pay_total= '" + pr.paymentTotal 
                + "',created_by = '" + pr.createdBy + "')";
            SqlCommand command = new SqlCommand(createQuery, con);
            command.ExecuteNonQuery();
            con.Close();

        }



    }
}
