using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;
using System.Linq;

public partial class Questions : System.Web.UI.Page
{
    private readonly string _s = dbQueries._s;
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
    public int Member_id
    {
        get
        {
            if (Session["member_id"] == null)
                return 1005;
            else
                return (int)Session["member_id"];
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
                    var command = new SqlCommand(@"select count(*) say from dt_questions", connection))
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
    public int Topic_id
    {

        get
        {
            string v = Request.QueryString["topic"];
            if (v != null)

                return Convert.ToInt32(v);
            else
                return 2;

        }
    }
    public int Iterator
    {
        get
        {
            return (int)ViewState["Iterator"];
        }

        set
        {
            ViewState["Iterator"] = value;
        }
    }
    public DataTable sorular
    {
        get
        {
            return (DataTable)ViewState["sorular"];
        }

        set
        {
            ViewState["sorular"] = value;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!Page.IsPostBack)
        {

            Iterator = 0;
            RadioButtonList1.Items.Add(('A').ToString());
            RadioButtonList1.Items.Add(('B').ToString());
            RadioButtonList1.Items.Add(('C').ToString());
            RadioButtonList1.Items.Add(('D').ToString());
            RadioButtonList1.Items.Add(('E').ToString());
            
            SoruDBDataContext x = new SoruDBDataContext();

            var puan = x.dt_memberTopicOS.Where(p => p.member_id == Member_id && p.topic_id == Topic_id).Select(p => p.puan).FirstOrDefault();

            if (puan == null)
            {
                sorular = dbQueries.first9Questions(Topic_id);

                DogruSay = 0;

                Question_id = (int)sorular.Rows[Iterator][0];
                soruYukle(Question_id);

            }
            else
            {
                double puan1 = Convert.ToDouble(puan);
                if (puan1 <= 35 && puan1 > 0)
                {
                    //dif = 1 
                    var complate = (from c in x.tx_answeredQuestionOS
                                    where c.member_id == Member_id
                                    select c.question_id);
                    //hangi soruları sordum
                    if (!complate.Contains(Question_id))
                    {
                        // eğer sormadıgım soru varsa burda ifin içinde çağırcam 
                    }

                    if (puan1 <= 65 && puan1 > 35)
                    {
                        //dif = 2

                    }

                    if (puan1 <= 100 && puan1 > 65)
                    {
                        //dif = 3

                    }
                }
            }
        }
    }


    protected void soruYukle(int question_id)
    {
        using (var connection = new SqlConnection(_s))
        {
            connection.Open();
            using (
                var command = new SqlCommand(@"select * from dt_questions where id = @Question_id", connection))
            {
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@Question_id", question_id);

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
    protected void btnAnswer_Click(object sender, EventArgs e)
    {
        var sonuc = dbQueries.answerCheck(Question_id, RadioButtonList1.SelectedValue);
        dbQueries.saveAnswer(Member_id, Question_id, DateTime.Now, sonuc, null); // null alan, soruyu kaç dakkada çözdüyü tutacaktı boş geçtim.

        if (sonuc)
        { 

            DogruSay++;

            lblDogru.Text = DogruSay.ToString();
            
        }
        else
        {
            //Response.Write("<script language=javascript>alert('" + "Üzgünüm Yanlış! Doğru sayınız :  " + DogruSay.ToString() + "');</script>");
        }
        
        Iterator++;
        if (Iterator == 9)
        {
            SoruDBDataContext x = new SoruDBDataContext();
            var puan = x.dt_memberTopicOS.Where(p => p.member_id == Member_id && p.topic_id == Topic_id).Select(p => p.puan).FirstOrDefault();
            if (puan==null)
            {
                dbQueries.afterFirst_9(Member_id, Topic_id);
            }
                


        }
        
        //ilk 9 soru bittiyse

        Question_id = (int)sorular.Rows[Iterator][0];
        soruYukle(Question_id);
        RadioButtonList1.SelectedIndex = -1;


    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Write("<script language=javascript>alert('" + "Üzgünüm Yanlış! Doğru sayınız :  " + DogruSay.ToString() + "');</script>");
        Server.Transfer("Math.aspx");
    }
}