using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;


namespace lab4
{
    public partial class registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            string cnic = TextBox2.Text;
            string age = TextBox3.Text;
            string gender = TextBox4.Text;
            string address = TextBox5.Text;
            string salary = TextBox4.Text;

            /*Connect with Database*/
            OleDbConnection dbcon = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data source=C:/Users/Teny/Documents/registration.mdb; Persist Security Info=False;");
            dbcon.Open();

            /*Run query to add login name and password in the stUser table*/

            //OleDbCommand cmd = new OleDbCommand();
            //cmd.Connection = dbcon;
            //cmd.CommandText = "INSERT INTO user ([nam],[username],[password],[domain]) VALUES(@name,@username,@password,@domain)";
            //cmd.Parameters.Add("@name", name);
            //cmd.Parameters.Add("@username", username);
            //cmd.Parameters.Add("@password", password);
            //cmd.Parameters.Add("@domain", domain);
            //cmd.ExecuteReader();
            OleDbCommand sqlcommand = new OleDbCommand("INSERT INTO [user] ([nam],[gender],[address],[salary],[cnic],[age]) VALUES('" + name + "','" + gender + "','" + address + "','" + salary + "','" + cnic + "','" + age + "')", dbcon);
            sqlcommand.ExecuteNonQuery();
            Response.Write("<script>alert('data insertion successful!!!')</script>");
        }
        }
}