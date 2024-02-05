using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace Multiuserlogin_App
{
    public class concls
    {
        SqlConnection con;
        SqlCommand cmd;

        public concls()
        {
            con = new SqlConnection(@"server=LAPTOP-OLUFQ7H5\SQLEXPRESS;database=DbNovember;Integrated security=true");
        }
        public int Fn_Nonquery(string sql)
        {
            cmd = new SqlCommand(sql, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public string Fn_scalar(string sql)
        {
            cmd = new SqlCommand(sql, con);
            con.Open();
            string s = cmd.ExecuteScalar().ToString();
            con.Close();
            return s;
        }
    }
}
