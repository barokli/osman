using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Linq;
using System.IO;

public partial class Admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }

    protected void btn_kaydet_Click(object sender, EventArgs e)
    {



        SoruDBDataContext ohamg = new SoruDBDataContext();
        var a = ohamg.lu_topicOS;
        
        lu_topicOS topik = new lu_topicOS { text = txt_konu.Text };

        ohamg.lu_topicOS.InsertOnSubmit(topik);
        ohamg.SubmitChanges();

        //GridView1.DataSource = a;


    }

    
protected void Upload_Click(object sender, EventArgs e)
    {
        if(FileUpload1.HasFile && FileUpload1.PostedFile.ContentLength > 0){
            string fileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
            FileUpload1.PostedFile.SaveAs(Server.MapPath("~/imgs/") + fileName);
            Response.Redirect(Request.Url.AbsoluteUri);

        }
    }

    protected void Display_Click(object sender, EventArgs e)
    {
        string[] filePaths = Directory.GetFiles(Server.MapPath("~/imgs/"));
        List<ListItem> files = new List<ListItem>();
        foreach (string filePath in filePaths)
        {
            string fileName = Path.GetFileName(filePath);
            files.Add(new ListItem(fileName, "~/imgs/" + fileName));
        }
        GridView2.DataSource = files;
        GridView2.DataBind();
    }
}