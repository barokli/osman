using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using System.Web.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

public partial class yenisifre : System.Web.UI.Page
{
    private readonly string _s = WebConfigurationManager.ConnectionStrings["osmanConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        this.pnlsifregonder.Visible = true;
        this.pnlsonuc.Visible = false;
    }
    protected void btnsifregonder_Click(object sender, EventArgs e)
    {   
        using (var connection = new SqlConnection(_s))
        {
            connection.Open();
            using (var command = new SqlCommand(@"SELECT * FROM dt_membership WHERE real_name=@real_name or real_email=@real_email", connection))
            {
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@real_name", txtuyeadi.Text);
                command.Parameters.AddWithValue("@real_email", txtEmail.Text);

              

                SqlDataReader reader= command.ExecuteReader();

                if (reader == null)
                {
                    this.lbldurum.ForeColor = System.Drawing.Color.Red;
                    this.lbldurum.Text = "Kullanıcı Adı veya Şifre Yanlış";

                }
                else
                {   
                    reader.Read();
                    SmtpClient Kaynak = new SmtpClient();    
                    Kaynak.Host = "smtp.gmail.com";
                    Kaynak.Port = 587;
                    Kaynak.EnableSsl = true;
                    Kaynak.Credentials = new NetworkCredential("osmansonmezturk@gmail.com", "Bad123321+");
                    MailAddress Gonderen = new MailAddress("osmansonmezturk@gmail.com", "Bad123321+");
                    MailAddress Giden = new MailAddress(reader["real_email"].ToString(), reader["real_name"].ToString());
                    MailMessage Mesaj = new MailMessage(Gonderen, Giden);
                    Mesaj.From = Giden;
                    Mesaj.To.Add("osmansonmezturk@gmail.com");
                    Mesaj.Subject = "Kullanıcı Adı ve Şifreniz.";
                    Mesaj.Body = "üyelik bilgileriniz.</br> Kullanıcı Adınız..:" + reader["m_name"].ToString() + "</br> Şifreniz=" + reader["m_password"].ToString();
                    Mesaj.IsBodyHtml = true;
                    Kaynak.Send(Mesaj);
                    this.lblmesaj.Text = "Şifreniz ve bilgileriniz (" + reader["real_email"].ToString() + ") adresine gönderilmiştir...";
                    this.pnlsifregonder.Visible = false;
                    this.pnlsonuc.Visible = true;
                }

                reader.Close();
                connection.Close();

            }

        }

    }
}