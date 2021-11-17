using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BalLibrary;

namespace DalLibrary
{
    public class ProductDAL
    {

        public string AddProduct(ProductBAL ba)
        {
            SqlConnection cn = new SqlConnection("server=LAPTOP-6C58L34N\\SQLEXPRESS;Integrated Security=true;database=OnlineShopping");
            string s = "[dbo].[sp_InsertProduct]";
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.Parameters.AddWithValue("@p_name", ba.ProductName);
            cmd.Parameters.AddWithValue("@p_actualprice", ba.ActualPrice);
            cmd.Parameters.AddWithValue("@p_discount", ba.Discount);
            cmd.Parameters.AddWithValue("@p_quantity", ba.Quantity);
            cmd.Parameters.AddWithValue("@p_description", ba.Description);
            cmd.Parameters.AddWithValue("@p_image", ba.Image);
            cmd.Parameters.AddWithValue("@p_catid", ba.CategoryId);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cn.Open();
            string s1 = "your product added";
            
            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();
            return s1;
        }


        public string DeleteProduct(ProductBAL ba)
        {
            SqlConnection cn = new SqlConnection("server=LAPTOP-6C58L34N\\SQLEXPRESS;Integrated Security=true;database=OnlineShopping");
            string s = "[dbo].[sp_deleteProduct]";
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.Parameters.AddWithValue("@p_pid", ba.ProductId);
           
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cn.Open();
            string s1 = "your product deleted";

            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();
            return s1;
        }


        public string UpdateProduct(ProductBAL ba)
        {
            SqlConnection cn = new SqlConnection("server=LAPTOP-6C58L34N\\SQLEXPRESS;Integrated Security=true;database=OnlineShopping");
            string s = "[dbo].[sp_UpdateProduct]";
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.Parameters.AddWithValue("@p_pid", ba.ProductId);
            cmd.Parameters.AddWithValue("@p_name", ba.ProductName);
            cmd.Parameters.AddWithValue("@p_actualprice", ba.ActualPrice);
            cmd.Parameters.AddWithValue("@p_discount", ba.Discount);
            cmd.Parameters.AddWithValue("@p_quantity", ba.Quantity);
            cmd.Parameters.AddWithValue("@p_description", ba.Description);
            cmd.Parameters.AddWithValue("@p_image", ba.Image);
            cmd.Parameters.AddWithValue("@p_catid", ba.CategoryId);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cn.Open();
            string s1 = "your product updated";

            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();
            return s1;
        }


        public string DisplayAllProduct(ProductBAL ba)
        {
            SqlConnection cn = new SqlConnection("server=LAPTOP-6C58L34N\\SQLEXPRESS;Integrated Security=true;database=OnlineShopping");
            string s = "[dbo].[sp_DisplayAllProducts]";
            SqlCommand cmd = new SqlCommand(s, cn);
            cmd.Parameters.AddWithValue("@p_pid", ba.ProductId);
            cmd.Parameters.AddWithValue("@p_name", ba.ProductName);
            cmd.Parameters.AddWithValue("@p_actualprice", ba.ActualPrice);
            cmd.Parameters.AddWithValue("@p_discount", ba.Discount);
            cmd.Parameters.AddWithValue("@p_quantity", ba.Quantity);
            cmd.Parameters.AddWithValue("@p_description", ba.Description);
            cmd.Parameters.AddWithValue("@p_image", ba.Image);
            cmd.Parameters.AddWithValue("@p_catid", ba.CategoryId);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cn.Open();
            string s1 = "Your Products are here";

            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();
            return s1;
        }

    }
}
