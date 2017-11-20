<%@ Page Language="C#" AutoEventWireup="true" CodeFile="iletişim.aspx.cs" Inherits="iletişim" %>

<!DOCTYPE html>
<script runat="server">
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        System.Net.Mail.MailMessage mailMessage = new System.Net.Mail.MailMessage();
 
        mailMessage.From = new System.Net.Mail.MailAddress("gonderen@gmail.com", "Gönderen Firma Adı");
        mailMessage.Subject = "İletişim Formu: " + this.txtFullName.Text;
 
        mailMessage.To.Add("alici@firmaadi.com,digeralici@gmail.com");
 
        string body;
        body = "Ad Soyad: " + this.txtFullName.Text + "<br />";
        body += "Telefon: " + this.txtPhone.Text + "<br />";
        body += "E-posta: " + this.txtEmail.Text + "<br />";
        body += "Konu: " + this.txtSubject.Text + "<br />";
        body += "Mesaj: " + this.txtMessage.Text + "<br />";
        body += "Tarih: " + DateTime.Now.ToString("dd MMMM yyyy") + "<br />";
        mailMessage.IsBodyHtml = true;
        mailMessage.Body = body;
 
        System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
        smtp.Credentials = new System.Net.NetworkCredential("gonderen@gmail.com", "gondereninmailsifresi");
        smtp.EnableSsl = true;
        smtp.Send(mailMessage);
        Information.Text = "Mesajınız gönderildi. Teşekkür ederiz.";
    }
</script>
 
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Lato">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
<style>
body {font-family: "Lato", sans-serif}
.mySlides {display: none}
</style>
    <title>İletişim</title>    
</head>
<body>
    <div class="w3-top">
  <div class="w3-bar w3-black w3-card">
    <a class="w3-bar-item w3-button w3-padding-large w3-hide-medium w3-hide-large w3-right" href="javascript:void(0)" onclick="myFunction()" title="Toggle Navigation Menu"><i class="fa fa-bars"></i></a>
    <a href="Giriş.aspx" class="w3-bar-item w3-button w3-padding-large">Ana Sayfa</a>
          <div class="w3-dropdown-hover w3-hide-small">
      <button class="w3-padding-large w3-button" title="More">Ders Seç <i class="fa fa-caret-down"></i></button>     
      <div class="w3-dropdown-content w3-bar-block w3-card-4">
        <a href="Math.aspx" class="w3-bar-item w3-button">Matematik</a>
        <a href="#" class="w3-bar-item w3-button">Fizik</a>
        <a href="#" class="w3-bar-item w3-button">Kimya</a>
      </div>
    </div>
    <a href="Admin/Default.aspx" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Yönetici Paneli</a>
    <a href="#tour" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Puan</a>
            <a href="iletişim.aspx" class="w3-bar-item w3-button w3-padding-large w3-hide-small">İletişim</a>
    <a href="uyelik.aspx" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Çıkış</a>
    <a href="javascript:void(0)" class="w3-padding-large w3-hover-red w3-hide-small w3-right"><i class="fa fa-search"></i></a>
  </div>
</div>
     
    <br> <br/>
      
      <form id="form1" runat="server">
        <h2>İletişim Formu</h2> 
        <p><asp:Literal ID="Information" runat="server">Soru ve görüşleriniz için lütfen aşağıdaki formu kullanın.</asp:Literal></p>
        <table>
            <tr>
                <td style="width:200px">Ad Soyad:</td>
                <td>
                    <asp:TextBox ID="txtFullName" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Telefon Numarası:</td>
                <td>
                    <asp:TextBox ID="txtPhone" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>E-posta:</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Konu:</td>
                <td>
                    <asp:TextBox ID="txtSubject" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Mesaj:</td>
                <td>
                    <asp:TextBox ID="txtMessage" runat="server" Height="80px" TextMode="MultiLine" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" Text="Gönder" OnClick="btnSubmit_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>