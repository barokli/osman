using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Web.Configuration;
using System.Web.UI;

public partial class fizik : System.Web.UI.Page
{
    private readonly string _s = WebConfigurationManager.ConnectionStrings["osmanConnectionString"].ConnectionString;
    public int Question_id
    {
        get
        {
            return (int)ViewState["question_id"];
        }

        set
        {
            ViewState["question_id"] = value;
        }
    }
    public int DogruSay
    {
        get
        {
            return (int)ViewState["dogruSay"];
        }

        set
        {
            ViewState["dogruSay"] = value;
        }
    }
    public int ToplamSoru
    {

        get
        {
            using (var connection = new SqlConnection(_s))
            {
                connection.Open();
                using (
                    var command = new SqlCommand(@"select count(*) say from dt_fizik", connection))
                {
                    command.CommandType = CommandType.Text;


                    SqlDataReader dr = command.ExecuteReader();
                    dr.Read();
                    var a = Convert.ToInt32(dr["say"].ToString());
                    return a;

                }
            }
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {


        if (!Page.IsPostBack)
        {

            DogruSay = 0;
            Question_id = 1;
            soruYukle();
            cevapYukle();
        }
    }

    private void soruYukle()
    {
        using (var connection = new SqlConnection(_s))
        {
            connection.Open();
            using (
                var command = new SqlCommand(@"select * from dt_fizik where id = @Question_id", connection))
            {
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@Question_id", Question_id);

                SqlDataReader dr = command.ExecuteReader();
                dr.Read();


                try
                {

                    Image1.ImageUrl = "../" + dr["question"].ToString();

                }
                catch (Exception)
                {
                    HyperLink1.Visible = true;
                    HyperLink1.Text = "Bilemediğiniz konuların anlatımı";

                }



            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        using (var connection = new SqlConnection(_s))
        {
            connection.Open();
            using (
                var command = new SqlCommand(@"
select answer from dt_fizik where id= @Question_id ", connection))
            {
                var sonuc = false;
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@Question_id", Question_id);
                //command.ExecuteNonQuery();
                SqlDataReader dr = command.ExecuteReader();

                //SqlDataAdapter adp = new SqlDataAdapter(command);
                //DataTable dtable = new DataTable();
                //adp.Fill(dtable);

                dr.Read();

                var a = dr["answer"].ToString();







                if (RadioButtonList1.SelectedValue == a)
                {
                    sonuc = true;
                }


                // var sonuc = command.ExecuteScalar();

                //lbl_dogruMu.Text = sonuc == true ? "doğru" : "yanlış";


                if (sonuc)
                {
                    DogruSay++;

                    lblDogru.Text = DogruSay.ToString();

                }
                if (sonuc == false)
                {

                    /*        string script = "alert(\"Üzgünüm Yanlış! Doğru sayın:\");";
                            ScriptManager.RegisterStartupScript(this, GetType(),
                                                  "ServerControlScript", script, true);
                                                  */


                    Response.Write("<script language=javascript>alert('" + "Üzgünüm Yanlış! Doğru sayınız :  " + DogruSay.ToString() + "');</script>");

                }

                Question_id++;
                soruYukle();
                RadioButtonList1.Items.Clear();
                cevapYukle();
            }
        }

        if (true)
        {


        }
    }

    private void cevapYukle()
    {
        using (var connection = new SqlConnection(_s))
        {
            connection.Open();
            DataTable dt = new DataTable();
            using (
                var command = new SqlCommand(@"select answer_count from dt_fizik where question_id = @question_id", connection))
            {
                /*
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("Question_id", Question_id);
                SqlDataReader dr = command.ExecuteReader();
                dr.Read();
                */
                //int x = int.Parse(dr["answer_count"].ToString());


                RadioButtonList1.Items.Add(('A').ToString());
                RadioButtonList1.Items.Add(('B').ToString());
                RadioButtonList1.Items.Add(('C').ToString());
                RadioButtonList1.Items.Add(('D').ToString());
                RadioButtonList1.Items.Add(('E').ToString());

                //    int x = (int)dr["answer_count"];


                // RadioButtonList1.Items.Add(RadioButtonList1);



                /*   RadioButtonList1.DataTextField = "answer";
                   RadioButtonList1.DataValueField = "id";
                   RA
                   RadioButtonList1.DataSource = dt;
                   RadioButtonList1.DataBind();
                   */
            }
        }
    }





    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Write("<script language=javascript>alert('" + "Üzgünüm Yanlış! Doğru sayınız :  " + DogruSay.ToString() + "');</script>");
        Server.Transfer("Giriş.aspx");
    }

}