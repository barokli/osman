<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Math.aspx.cs" Inherits="Math" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Lato">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
      <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
<style>
body {font-family: "Lato", sans-serif}
.mySlides {display: none}
</style>


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
    <br>
    </br>
    <form id="form1" runat="server">
    <div>
<div class="container">
  <h2>Konular</h2>
  <div class="list-group">
    <a href="Questions.aspx?topic=1" class="list-group-item">
      <h4 class="list-group-item-heading">Özel Tanımlı Foksiyonlar</h4>
      <p class="list-group-item-text">soru sayısı : 67 </p>
    </a>
    <a href="Questions.aspx?topic=2" class="list-group-item">
      <h4 class="list-group-item-heading">Limit</h4>
      <p class="list-group-item-text">soru sayısı : 117 </p>
    </a>
    <a href="Seriler" class="list-group-item">
      <h4 class="list-group-item-heading">Seriler</h4>
      <p class="list-group-item-text">soru sayısı : 31 </p>
    </a>

    <a href="Süreklilik" class="list-group-item">
      <h4 class="list-group-item-heading">Süreklilik</h4>
      <p class="list-group-item-text">soru sayısı : 30 </p>
    </a>

        <a href="L'Hospital" class="list-group-item">
      <h4 class="list-group-item-heading">L'Hospital</h4>
      <p class="list-group-item-text">soru sayısı : 47 </p>
    </a>

        <a href="Türev_alma" class="list-group-item">
      <h4 class="list-group-item-heading">Türev Alma Kuralı</h4>
      <p class="list-group-item-text">soru sayısı : 111 </p>
    </a>

        <a href="Geometrik" class="list-group-item">
      <h4 class="list-group-item-heading">Geometrik Yorum</h4>
      <p class="list-group-item-text">soru sayısı : 86 </p>
    </a>

            <a href="Belirsiz" class="list-group-item">
      <h4 class="list-group-item-heading">Belirsiz İntegral</h4>
      <p class="list-group-item-text">soru sayısı : 141 </p>
    </a>

            <a href="Belirli" class="list-group-item">
      <h4 class="list-group-item-heading">Belirli İntegral</h4>
      <p class="list-group-item-text">soru sayısı : 164 </p>
    </a>

            <a href="Alan" class="list-group-item">
      <h4 class="list-group-item-heading">Alan ve Hacim Hesaplamaları</h4>
      <p class="list-group-item-text">soru sayısı : 83 </p>
    </a>

  </div>
</div>

    </div>
    </form>
</body>
</html>
