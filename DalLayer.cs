using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BalLibrary;

namespace DalLibrary
{
    public class DalLayer
    {

        public bool Check(CustomerBAL ba)
        {

            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-6C58L34N\\SQLEXPRESS;Integrated Security=true; Database=OnlineShopping");
            string s = "Select[dbo].[AdminLoginFunction](@p_aid,@p_pwd)";
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.Parameters.AddWithValue("@p_aid", ba.AdminId);
            cmd.Parameters.AddWithValue("@p_pwd", ba.AdminPassword);
            cn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            bool ans = true;
            if (Convert.ToInt32(rdr[0]) == 1)
            {
                ans = true;
            }
            else
            {

                ans = false;
            }
            cn.Close();
            cn.Dispose();
            return ans;
        }




        public bool CustomerCheck(CustomerBAL ba)
        {
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-6C58L34N\\SQLEXPRESS;Integrated Security=true;Initial Catalog=OnlineShopping");
            string s = "Select[dbo].[CustomerLoginFunction](@p_uid,@p_pwd)";
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.Parameters.AddWithValue("@p_uid", ba.EmailId);
            cmd.Parameters.AddWithValue("@p_pwd", ba.Password);
            cn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            bool ans;
            if (Convert.ToInt32(rdr[0]) == 1)
            {
                ans = true;
            }
            else
            {
                ans = false;
            }
            cn.Close();
            cn.Dispose();
            return ans;
        }





        public string AddCustomer(CustomerBAL ba)
        {
            SqlConnection cn = new SqlConnection("server=LAPTOP-6C58L34N\\SQLEXPRESS;Integrated Security=true;database=OnlineShopping");
            string s = "[dbo].[p_InsertCustomer]";
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.Parameters.AddWithValue("@p_firstname", ba.FirstName);
            cmd.Parameters.AddWithValue("@p_lastname", ba.LastName);
            cmd.Parameters.AddWithValue("@p_emailId", ba.EmailId);
            cmd.Parameters.AddWithValue("@p_password", ba.Password);
            cmd.Parameters.AddWithValue("@p_MobileNos", ba.MobileNo);
            cmd.Parameters.AddWithValue("@p_city", ba.City);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cn.Open();
            string s1 = "u are welcome";
            
            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();
            return s1;
        }
    }
}