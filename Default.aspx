<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        @font-face {
            font-family: M-Saras;
            src: url(M-Saras.TTF);
        }
    </style>
</head>
<body>
<div id="google_translate_element">
<span id="translateddata">  
     <textarea id="someTextBox"></textarea>
     <div id="target" style="font-family:M-Saras; font-size: 18px"></div>
     <script src="http://code.jquery.com/jquery-1.9.1.js"></script>
     <script src="http://code.jquery.com/jquery-migrate-1.1.0.js"></script>
    </span>
</div>
<script>
    $('#someTextBox').keyup(function () {
        $('#target').html($(this).val());
    })
</script>
</body>
</html>
