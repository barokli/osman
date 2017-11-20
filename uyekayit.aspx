<%@ Page Language="C#" AutoEventWireup="true" CodeFile="uyekayit.aspx.cs" Inherits="uyekayit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
   <style>
body {font-family: "Lato", sans-serif}
.mySlides {display: none}
@import url(https://fonts.googleapis.com/css?family=Open+Sans);
.btn { display: inline-block; *display: inline; *zoom: 1; padding: 4px 10px 4px; margin-bottom: 0; font-size: 13px; line-height: 18px; color: #333333; text-align: center;text-shadow: 0 1px 1px rgba(255, 255, 255, 0.75); vertical-align: middle; background-color: #f5f5f5; background-image: -moz-linear-gradient(top, #ffffff, #e6e6e6); background-image: -ms-linear-gradient(top, #ffffff, #e6e6e6); background-image: -webkit-gradient(linear, 0 0, 0 100%, from(#ffffff), to(#e6e6e6)); background-image: -webkit-linear-gradient(top, #ffffff, #e6e6e6); background-image: -o-linear-gradient(top, #ffffff, #e6e6e6); background-image: linear-gradient(top, #ffffff, #e6e6e6); background-repeat: repeat-x; filter: progid:dximagetransform.microsoft.gradient(startColorstr=#ffffff, endColorstr=#e6e6e6, GradientType=0); border-color: #e6e6e6 #e6e6e6 #e6e6e6; border-color: rgba(0, 0, 0, 0.1) rgba(0, 0, 0, 0.1) rgba(0, 0, 0, 0.25); border: 1px solid #e6e6e6; -webkit-border-radius: 4px; -moz-border-radius: 4px; border-radius: 4px; -webkit-box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.2), 0 1px 2px rgba(0, 0, 0, 0.05); -moz-box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.2), 0 1px 2px rgba(0, 0, 0, 0.05); box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.2), 0 1px 2px rgba(0, 0, 0, 0.05); cursor: pointer; *margin-left: .3em; }
.btn:hover, .btn:active, .btn.active, .btn.disabled, .btn[disabled] { background-color: #e6e6e6; }
.btn-large { padding: 9px 14px; font-size: 15px; line-height: normal; -webkit-border-radius: 5px; -moz-border-radius: 5px; border-radius: 5px; }
.btn:hover { color: #333333; text-decoration: none; background-color: #e6e6e6; background-position: 0 -15px; -webkit-transition: background-position 0.1s linear; -moz-transition: background-position 0.1s linear; -ms-transition: background-position 0.1s linear; -o-transition: background-position 0.1s linear; transition: background-position 0.1s linear; }
.btn-primary, .btn-primary:hover { text-shadow: 0 -1px 0 rgba(0, 0, 0, 0.25); color: #ffffff; }
.btn-primary.active { color: rgba(255, 255, 255, 0.75); }
.btn-primary { background-color: #4a77d4; background-image: -moz-linear-gradient(top, #6eb6de, #4a77d4); background-image: -ms-linear-gradient(top, #6eb6de, #4a77d4); background-image: -webkit-gradient(linear, 0 0, 0 100%, from(#6eb6de), to(#4a77d4)); background-image: -webkit-linear-gradient(top, #6eb6de, #4a77d4); background-image: -o-linear-gradient(top, #6eb6de, #4a77d4); background-image: linear-gradient(top, #6eb6de, #4a77d4); background-repeat: repeat-x; filter: progid:dximagetransform.microsoft.gradient(startColorstr=#6eb6de, endColorstr=#4a77d4, GradientType=0);  border: 1px solid #3762bc; text-shadow: 1px 1px 1px rgba(0,0,0,0.4); box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.2), 0 1px 2px rgba(0, 0, 0, 0.5); }
.btn-primary:hover, .btn-primary:active, .btn-primary.active, .btn-primary.disabled, .btn-primary[disabled] { filter: none; background-color: #4a77d4; }
.btn-block { width: 100%; display:block; }

* { -webkit-box-sizing:border-box; -moz-box-sizing:border-box; -ms-box-sizing:border-box; -o-box-sizing:border-box; box-sizing:border-box; }

html { width: 100%; height:100%; overflow:hidden; }

body { 
	width: 100%;
	height:100%;
	font-family: 'Open Sans', sans-serif;
	background: #092756;
	background: -moz-radial-gradient(0% 100%, ellipse cover, rgba(104,128,138,.4) 10%,rgba(138,114,76,0) 40%),-moz-linear-gradient(top,  rgba(57,173,219,.25) 0%, rgba(42,60,87,.4) 100%), -moz-linear-gradient(-45deg,  #670d10 0%, #092756 100%);
	background: -webkit-radial-gradient(0% 100%, ellipse cover, rgba(104,128,138,.4) 10%,rgba(138,114,76,0) 40%), -webkit-linear-gradient(top,  rgba(57,173,219,.25) 0%,rgba(42,60,87,.4) 100%), -webkit-linear-gradient(-45deg,  #670d10 0%,#092756 100%);
	background: -o-radial-gradient(0% 100%, ellipse cover, rgba(104,128,138,.4) 10%,rgba(138,114,76,0) 40%), -o-linear-gradient(top,  rgba(57,173,219,.25) 0%,rgba(42,60,87,.4) 100%), -o-linear-gradient(-45deg,  #670d10 0%,#092756 100%);
	background: -ms-radial-gradient(0% 100%, ellipse cover, rgba(104,128,138,.4) 10%,rgba(138,114,76,0) 40%), -ms-linear-gradient(top,  rgba(57,173,219,.25) 0%,rgba(42,60,87,.4) 100%), -ms-linear-gradient(-45deg,  #670d10 0%,#092756 100%);
	background: -webkit-radial-gradient(0% 100%, ellipse cover, rgba(104,128,138,.4) 10%,rgba(138,114,76,0) 40%), linear-gradient(to bottom,  rgba(57,173,219,.25) 0%,rgba(42,60,87,.4) 100%), linear-gradient(135deg,  #670d10 0%,#092756 100%);
	filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#3E1D6D', endColorstr='#092756',GradientType=1 );
}
.login { 
	position: absolute;
	top: 50%;
	left: 50%;
	margin: -150px 0 0 -150px;
	width:300px;
	height:300px;
}
.login h1 { color: #fff; text-shadow: 0 0 10px rgba(0,0,0,0.3); letter-spacing:1px; text-align:center; }

input { 
	width: 100%; 
	margin-bottom: 10px; 
	background: rgba(0,0,0,0.3);
	border: none;
	outline: none;
	padding: 10px;
	font-size: 13px;
	color: #fff;
	text-shadow: 1px 1px 1px rgba(0,0,0,0.3);
	border: 1px solid rgba(0,0,0,0.3);
	border-radius: 4px;
	box-shadow: inset 0 -5px 45px rgba(100,100,100,0.2), 0 1px 1px rgba(255,255,255,0.2);
	-webkit-transition: box-shadow .5s ease;
	-moz-transition: box-shadow .5s ease;
	-o-transition: box-shadow .5s ease;
	-ms-transition: box-shadow .5s ease;
	transition: box-shadow .5s ease;
}
input:focus { box-shadow: inset 0 -5px 45px rgba(100,100,100,0.4), 0 1px 1px rgba(255,255,255,0.2); }

}

</style> 
</head>
<body>
    <form id="form1" runat="server"  method="post" >
        <div class="login" >
    <asp:Label ID="lblbaslik" runat="server" Font-Size="X-Large"
        Text="Yeni Üye Kayıt"></asp:Label>
   
      <asp:Panel ID="pnlRegister" runat="server">
    
             <asp:Label ID="lbldurum" runat="server"></asp:Label>
        <table border="1"  >
                 <tr>
                     <td >
                         <asp:Label ID="lblTitleUsername" runat="server" Text="Üye Adı"></asp:Label>
                     </td>
                     <td  >
                         <asp:TextBox ID="txtuyeadi" runat="server" Width="98px"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="Requyeadi" runat="server"
                             ControlToValidate="txtuyeadi" Display="Dynamic" ErrorMessage="*Gerekli"></asp:RequiredFieldValidator>
                     </td>
                 </tr>
                 <tr>
                     <td>
                         <asp:Label ID="lblTitlePassword" runat="server" Text="Şifre:"></asp:Label>
                     </td>
                     <td>
                         <asp:TextBox ID="txtsifre" runat="server" TextMode="Password" Width="112px"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="Reqsifre" runat="server"
                             ControlToValidate="txtsifre" ErrorMessage="* Gerekli"></asp:RequiredFieldValidator>
                     </td>
                 </tr>
                 <tr>
                     <td>
                         <asp:Label ID="lblTitleConPassword" runat="server" Text="Şifre Tekrar:"></asp:Label>
                     </td>
                     <td>
                         <asp:TextBox ID="txtsifretekrar" runat="server" TextMode="Password"
                             Width="112px"></asp:TextBox>
                     &nbsp;<asp:CompareValidator ID="regsifretekrar" runat="server"
                             ControlToCompare="txtsifre" ControlToValidate="txtsifretekrar"
                             ErrorMessage="* Şifreler Uyuşmuyor"></asp:CompareValidator>
                     </td>
                 </tr>
                 <tr>
                     <td>
                         <asp:Label ID="lblTitleName" runat="server" Text="Adınız:"></asp:Label>
                     </td>
                     <td>
                         <asp:TextBox ID="txtad" runat="server" Width="191px"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="Reqad" runat="server"
                             ControlToValidate="txtad" Display="Dynamic" ErrorMessage="* Gerekli"></asp:RequiredFieldValidator>
                     </td>
                 </tr>
                 <tr>
                     <td>
                         <asp:Label ID="lblTitleEmail" runat="server" Text="Email : "></asp:Label>
                     </td>
                     <td>
                         <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="ReqEmail" runat="server"
                             ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="* Gerekli"></asp:RequiredFieldValidator>
                     &nbsp;<asp:RegularExpressionValidator ID="RegEmail"
                             runat="server" ErrorMessage="* Geçersiz Email"
                             ControlToValidate="txtEmail" Display="Dynamic"
                             ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                     </td>
                 </tr>
                 <tr>
                     <td>
                         <asp:Label ID="lblCountry" runat="server" Text="Kısa Bilgi"></asp:Label>
                     </td>
                     <td>
                         <asp:TextBox ID="txtbilgi" runat="server" Width="190px" Height="63px"
                             ></asp:TextBox>
                         <asp:RequiredFieldValidator ID="Reqbilgi" runat="server"
                             ControlToValidate="txtbilgi" ErrorMessage="* Gerekli"></asp:RequiredFieldValidator>
                     </td>
                 </tr>
        </table>
            
             <asp:Button ID="btnkayit" runat="server"  class="btn btn-primary btn-block btn-large" Text="Kayıt Ol"
                 onclick="btnkayit_Click"/>
             &nbsp;<input ID="btntemizleme" type="reset" value="Temizle" />
        </asp:Panel>
                <asp:Panel ID="pnlFinish" runat="server">
            <asp:Label ID="lblFinish" runat="server" Text="Kayıt İşlemi Başarılı"></asp:Label>
    
            <asp:HyperLink ID="hplLogin" runat="server"  NavigateUrl="~/uyelik.aspx.aspx">Üye Girişi</asp:HyperLink>
        </asp:Panel>

            </div>
        </form>
</body>
</html>