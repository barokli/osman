<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Admin_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
    <style>
body {font-family: "Lato", sans-serif}
.mySlides {display: none}
</style>
    <meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Lato">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">

</head> 
<body>

    <div class="w3-top">
  <div class="w3-bar w3-black w3-card">
    <a class="w3-bar-item w3-button w3-padding-large w3-hide-medium w3-hide-large w3-right" href="javascript:void(0)" onclick="myFunction()" title="Toggle Navigation Menu"><i class="fa fa-bars"></i></a>
    <a href="/Giriş.aspx" class="w3-bar-item w3-button w3-padding-large">Ana Sayfa</a>
          <div class="w3-dropdown-hover w3-hide-small">
      <button class="w3-padding-large w3-button" title="More">Ders Seç <i class="fa fa-caret-down"></i></button>     
      <div class="w3-dropdown-content w3-bar-block w3-card-4">
        <a href="/Math.aspx" class="w3-bar-item w3-button">Matematik</a>
        <a href="#" class="w3-bar-item w3-button">Fizik</a>
        <a href="#" class="w3-bar-item w3-button">Kimya</a>
      </div>
    </div>
    <a href="Default.aspx" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Yönetici Paneli</a>
    <a href="#tour" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Puan</a>
            <a href="/iletişim.aspx" class="w3-bar-item w3-button w3-padding-large w3-hide-small">İletişim</a>
    <a href="/uyelik.aspx" class="w3-bar-item w3-button w3-padding-large w3-hide-small">Çıkış</a>
    <a href="javascript:void(0)" class="w3-padding-large w3-hover-red w3-hide-small w3-right"><i class="fa fa-search"></i></a>
  </div>
</div>
     
    <br> <br/>



    <form id="form1" runat="server">
        <div>

            <table class="auto-style1">
                <tr>
                    <td>Soru</td>
                    <td>:</td>
                    <td>
                        
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                        <asp:Button ID="upload" runat="server" Text="Upload" onclick="Upload_Click" style="margin-left:0px"/>
                        <asp:Button ID="show" runat="server" Text="Display" onclick="Display_Click" style="margin-left:auto"/>
                        <hr />
                        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="false" ShowHeader="false">
                        <Columns>
                        <asp:BoundField DataField="Text" />
                        <asp:ImageField DataImageUrlField="Value" ControlStyle-Height="100" ControlStyle-Width="100" />
                        </Columns>
                        </asp:GridView>
                </tr>
                <tr>
                    <td>Konu</td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="txt_konu" runat="server"></asp:TextBox>
                        <asp:Button ID="btn_kaydet" runat="server" Text="Kaydet" OnClick="btn_kaydet_Click" /> </td>
                </tr>
                <tr>
                    
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>





            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="LinqDataSource1" DataKeyNames="id">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" InsertVisible="False" />

                    <asp:BoundField DataField="text" HeaderText="Konular" SortExpression="text" />
                        <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true" ItemStyle-Width="150"/>

                </Columns>
            </asp:GridView>

            <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="SoruDBDataContext" EntityTypeName="" TableName="lu_topicOS"
                EnableDelete="true" EnableUpdate="true" EnableInsert ="true"

                >
            </asp:LinqDataSource>




        </div>
    </form>
    <p>
        </p>
</body>
</html>
