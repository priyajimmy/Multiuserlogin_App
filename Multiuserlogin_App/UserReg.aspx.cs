using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace Multiuserlogin_App
{
    public partial class UserReg : System.Web.UI.Page
    {
        concls obj = new concls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(Reg_id) from Login";
            string regid = obj.Fn_scalar(sel);
            int reg_id = 0;
            if (regid == "")
            {
                reg_id = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(regid);
                reg_id = newregid + 1;

            }
            string ins = "insert into User_Reg values("+reg_id+",'"+TextBox1.Text+"','"+TextBox2.Text+"')";
            int i = obj.Fn_Nonquery(ins);
            if (i != 0)
            {
                string inslog = "insert into Login values(" + reg_id + ",'" + TextBox3.Text + "','" + TextBox4.Text + "','user','active')";
                int j = obj.Fn_Nonquery(inslog);
            }

        }
    }
}