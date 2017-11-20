 
<%@ Page  Language="C#" AutoEventWireup="true"  CodeFile="Questions.aspx.cs" Inherits="Questions" %>
 
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="style.css" />
    <meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Lato">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <style type="text/css">
        #form1 {
            width: 412px;
        }

        .auto-style1 {
            height: 23px;
        }

        #menu {
            margin: 0px;
            padding: 0px;
            list-style-type: none;
        }

            #menu li {
                float: left;
                width: 150px;
                position: relative;
            }

            #menu a {
                font-family: "Times New Roman", Times, serif;
                font-size: 16px;
                color: #FFFFFF;
                text-decoration: none;
                background-color: #00CCFF;
                display: block;
                padding-top: 5px;
                padding-right: 5px;
                border: 1px solid #00CCFF;
                text-align: center;
                line-height: 30px;
                margin-right: 2px;
            }

                #menu a:hover {
                    background-color: #0099FF;
                }

        .fixed-bg {
            background-image: url("a.jpg");
            min-height: 500px;
            background-attachment: fixed;
            background-position: center;
            background-repeat: no-repeat;
            background-size: cover;
        }

        .empty-bg {
            background-color: white;
        }

        .rbl input[type="radio"]
{
   margin-left: 10px;
   margin-right: 1px;
}
    </style>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
<style>
body {font-family: "Lato", sans-serif}
.mySlides {display: none}
</style>


</head>
<body class="fixed-bg">

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

    

    <br>
    </br>
      <br>
    </br>
    <form  id="form1" runat="server" style="width:745px;">

        <%--
        <asp:DropDownList ID="ddlLessons" runat="server" AutoPostBack="True" DataSourceID="ldsLessons" DataTextField="text" DataValueField="id" ></asp:DropDownList>
        <asp:LinqDataSource ID="ldsLessons" runat="server" ContextTypeName="SoruDBDataContext" EntityTypeName="" TableName="lu_lessonOS">
        </asp:LinqDataSource>



        <asp:DropDownList ID="ddlTopics" runat="server" DataSourceID="ldsTopics" DataTextField="text" DataValueField="id"></asp:DropDownList>

        <asp:LinqDataSource ID="ldsTopics" runat="server" ContextTypeName="SoruDBDataContext" EntityTypeName="" TableName="lu_topicOS" Where="lesson_id == @lesson_id">
            <WhereParameters>
                <asp:ControlParameter ControlID="ddlLessons" DefaultValue="" Name="lesson_id" PropertyName="SelectedValue" Type="Int32" />
            </WhereParameters>
        </asp:LinqDataSource>
        --%>

        <div>
            <div class="empty-bg"  style="width: 745px; border: 1px solid red; float: left ">



                
                <asp:Image ID="Image1" runat="server" />
                <br />

                <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatLayout="Flow" RepeatDirection="Horizontal" CssClass="rbl"  >

  
                </asp:RadioButtonList>


                <br />
                <br />
                <br />

                <%-- <asp:Label ID="lbl_dogruMu" runat="server" Text=""></asp:Label>--%>

                <br />
                <asp:Button ID="btnAnswer" runat="server" OnClick="btnAnswer_Click" type="button" class="btn btn-primary" Text="İleri" style="width: 56px" />
              

                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://www.google.com.tr/" Visible="False"></asp:HyperLink>
                

                <asp:Button ID="Button2" runat="server" Text="Çalışmayı Bitir" type="button" class="btn btn-success" style="float:right" OnClick="Button2_Click"/>

            </div>

<%--            <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:osmanConnectionString %>'
                SelectCommand="select * from dt_answers where question_id = @question_id">
                <SelectParameters>
                    <asp:ControlParameter ControlID="__Page" Name="question_id" PropertyName="Question_id" />
                </SelectParameters>
            </asp:SqlDataSource>--%>
            <br />
            <br />
        </div>

            <div style="width: 745px; border: 1px solid red; float: left">

                <table style="width: 100%;">
                    <tr>
                        <td>Kalan Soru Sayısı:</td>
                        <td>
                            <asp:Label ID="lblKalanSoruSay" runat="server"></asp:Label>

                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Doğru Sayısı</td>
                        <td class="auto-style1">
                            <asp:Label ID="lblDogru" runat="server"></asp:Label>
                        </td>
                    </tr>

                </table>
            </div>

        
    </form>
      
</body>

</html>
    
