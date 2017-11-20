using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class uyekayit : System.Web.UI.Page
{
    private readonly string _s = WebConfigurationManager.ConnectionStrings["osmanConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        this.pnlRegister.Visible = true;
        this.pnlFinish.Visible = false;
    }

    protected void btnkayit_Click(object sender, EventArgs e)
    {
        using (var connection = new SqlConnection(_s))
        {
            connection.Open();
            using (var command = new SqlCommand(@"SELECT count(*) FROM dt_membership WHERE m_name=@m_name", connection))
            {
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@m_name", txtuyeadi.Text);
               // SqlDataReader reader = command.ExecuteReader();
               int CountOfMember = (int)command.ExecuteScalar();
               if (CountOfMember >= 1)
                {
                    this.lbldurum.ForeColor = System.Drawing.Color.Red;
                    this.lbldurum.Text = "Üye Adı Kayıtlı Başka Bir İsim Bulun...";
                    return;
                }
            }
            using (var command = new SqlCommand("SELECT COUNT(*) FROM dt_membership WHERE real_email=@real_email", connection))
            {
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@real_email", txtEmail.Text);
                var CountOfMember = (int)command.ExecuteScalar();

                if (CountOfMember >= 1)
                {
                    this.lbldurum.ForeColor = System.Drawing.Color.Red;
                    this.lbldurum.Text = "Mail adresi kullanılıyor...";
                    return;
                }

            }
            using (var command = new SqlCommand("INSERT INTO dt_membership (m_name,m_password,real_name,real_email,m_info) VALUES (@m_name,@m_password,@real_name,@real_email,@m_info)", connection))
            {
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@m_name", txtuyeadi.Text);
                command.Parameters.AddWithValue("@m_password", txtsifre.Text);
                command.Parameters.AddWithValue("@real_name", txtad.Text);
                command.Parameters.AddWithValue("@real_email", txtEmail.Text);
                command.Parameters.AddWithValue("@m_info", txtbilgi.Text);
                command.ExecuteNonQuery();
            }

            connection.Close();
            this.pnlRegister.Visible = false;
            this.pnlFinish.Visible = true;
        }



    }
}