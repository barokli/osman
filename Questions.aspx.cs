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
                Iterator = 0;
                Question_id = (int)sorular.Rows[Iterator][0];
                soruYukle(Question_id);

            }
            else
            {
                
           
                double puan1 = Convert.ToDouble(puan);

                
                    //dif = 1 
                    var  complate = (from c in x.tx_answeredQuestionOS
                                    where c.member_id == Member_id
                                    select c.question_id);
                //hangi soruları sordum

                //abi burda her soruyu tek nasıl sorcam şimdilik olesine bunu yazdım senle bidaha bakak sonra
                // bıraktığı dif den devam etsin
                 
                    if (puan1 <= (0.6666) && puan1 > 0)
                    {
                    kenanİsik(1);

                    }

                    if (puan1 <= 1.33333 && puan1 > 0.6666)
                    {
                    kenanİsik(2);

                    }

                    if (puan1 <= 2 && puan1 > 1.3333)
                    {
                    kenanİsik(2);
           
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
<<<<<<< HEAD
            dbQueries.afterFirst_9(Member_id, Topic_id);
        }
=======
            SoruDBDataContext x = new SoruDBDataContext();
            var puan = x.dt_memberTopicOS.Where(p => p.member_id == Member_id && p.topic_id == Topic_id).Select(p => p.puan).FirstOrDefault();
            if (puan==null)
            {
                dbQueries.afterFirst_9(Member_id, Topic_id);
            }
                
>>>>>>> master

       

        //ilk 9 soru bittiyse

        //Question_id = (int)sorular.Rows[Iterator][0];
        //soruYukle(Question_id);
        RadioButtonList1.SelectedIndex = -1;


    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Write("<script language=javascript>alert('" + "Üzgünüm Yanlış! Doğru sayınız :  " + DogruSay.ToString() + "');</script>");
        Server.Transfer("Math.aspx");
    }

    protected void kenanİsik(int diff)
    {
        SoruDBDataContext x = new SoruDBDataContext();
        var complate = (from c in x.tx_answeredQuestionOS
                        where c.member_id == Member_id
                        select c.question_id);


        DogruSay = 0;
        Iterator = 0;
        var sorular = dbQueries.dif(Member_id, Topic_id, diff);
        Question_id = (int)sorular.Rows[Iterator][0];

        if (!complate.Contains(Question_id))
        {
            soruYukle(Question_id);

            if(DogruSay>=4)
            {
                kenanİsik(diff + 1);
            }

            if (DogruSay < 4 && diff != 0)
            {
                kenanİsik(diff - 1);
            }

        }
   
    }
}