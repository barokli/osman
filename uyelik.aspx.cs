using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    private readonly string _s = WebConfigurationManager.ConnectionStrings["osmanConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btngiris_Click(object sender, EventArgs e)
    {
        using (var connection = new SqlConnection(_s))
        {
            connection.Open();
            using (
                var command = new SqlCommand(@"
SELECT id FROM dt_membership WHERE m_name=@m_name and m_password=@m_password", connection))
            {
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@m_name", txtuyeadi.Text);
                command.Parameters.AddWithValue("@m_password", txtsifre.Text);



                var member_id = command.ExecuteScalar();

                if (member_id == null)
                {
                    this.lbldurum.ForeColor = System.Drawing.Color.Red;
                    this.lbldurum.Text = "Kullanıcı Adı veya Şifre Yanlış";

                }
                else
                {//viewstate 
                    Session["member_id"] = member_id;
                    Response.Redirect("Giriş.aspx");
                }
            }

        }

    }
}