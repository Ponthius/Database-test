using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Database_test
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            string Name = nameTxt.Text;
            string Email = emailTxt.Text;
            string Password = passwordTxt.Text;
            string registerStatus = "";
            string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;

            using(SqlConnection conn = new SqlConnection(conStr))
            {
                string query = "INSERT INTO Users (name, email, password) VALUES (@Name, @Email, @Password)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Password", Password);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                registerStatus = "Registration successful!";
            }
        }
    }
}