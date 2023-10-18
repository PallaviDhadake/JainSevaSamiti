<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Digambar Jain Seva Samiti| Kupwad Sangli</title>
   <meta content="IE=edge" http-equiv="X-UA-Compatible" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width,initial-scale=1.0,minimum-scale=1.0,maximum-scale=1.0,user-scalable=no" />
    <meta charset="utf-8" />

    <link href="Css/intro.css" rel="stylesheet" />
    <link href="Vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <script src="Vendor/bootstrap/js/bootstrap.min.js"></script>
    <script src="Js/jquery-1.8.2.min.js"></script>
    <link href="Css/redmond.datepick.css" rel="stylesheet" />
    <script src="Js/jquery.plugin.js"></script>
    <script src="Js/jquery.datepick.js"></script>
    <style type="text/css">
        .jainColor {
            height: 15px;
            background: url(color-strip.png) repeat-x left center;
            width: 100%;
        }
    </style>

    <script>
        $(function () {
            $('#<%=txtBirthDate.ClientID %>').datepick({ dateFormat: 'dd/mm/yyyy' });
         });

        function myCalendar() {
            $('#<%=txtBirthDate.ClientID %>').datepick({ dateFormat: 'dd/mm/yyyy' });
        }

    </script>
    <script>
        function validateNumber(e) {
            const pattern = /^[0-9]$/;

            return pattern.test(e.key)
        }
    </script>

<%--    <script>
        function alpha(e) {
            alert("Alpha Called");
            var k;
            document.all ? k = e.keyCode : k = e.which;
            return ((k > 64 && k < 91) || (k > 96 && k < 123) || k == 8 || k == 32 || (k >= 48 && k <= 57));
        }

    </script>--%>

    <%-- Tost Notifications --%>
    <link href="Css/toastr.css" rel="stylesheet" />
    <script src="Js/toastr.js"></script>

    <script type="text/javascript">
        function TostTrigger(EventName, MsgText) {
            // code to be executed
           // alert("hello");
            Command: toastr[EventName](MsgText)
            toastr.options = {
                "closeButton": true,
                "debug": false,
                "newestOnTop": false,
                "progressBar": false,
                "positionClass": "toast-top-full-width",
                "preventDuplicates": false,
                "onclick": null,
                "showDuration": "300",
                "hideDuration": "1000",
                "timeOut": "5000",
                "extendedTimeOut": "1000",
                "showEasing": "swing",
                "hideEasing": "linear",
                "showMethod": "slideDown",
                "hideMethod": "fadeOut"
            }

        }
    </script>


</head>
<body>
    <section id="HeadBanner">
        <div class="jainColor"></div>
        <div class="themeBGPrime">
            <div class="container">
                <div class="row">
                    <div class="col"><span class="colorWhite fontRegular">नोंदणी क्र. ई ५८३ सांगली</span></div>
                    <div class="col text-center"><span class="colorWhite fontRegular ">"वितरागाय नमः"</span></div>
                    <div class="col text-right"><span class="colorWhite fontRegular">स्थापना : २५/०४/१९८५ </span></div>
                </div>
            </div>
        </div>
        <!--<span class="space15"></span>-->
        <div class="headerregbg">
            <span class="space80"></span>
            <span class="space60"></span>
            <div class="container text-center">
                <%--<img src="jain-logo.png" />--%>
                <span class="space10"></span>
                <div class="d-flex align-items-center justify-content-center" style="height: 100px;">
                    <h2 class="semiBold large colorWhite text-center">जैन धर्मीय पोट जातीसह भव्य वधु - वर सुचक व पालक स्नेह मेळावा</h2>
                </div>

                <%--<span class="semiBold fontRegular semiMedium colorSec">ता. मिरज जि. सांगली </span>--%>
                <span class="space40"></span>
            </div>
        </div>
        <span class="theamLine"></span>
    </section>
    <span class="space30"></span>
    <section id="RegisterForm">
        <div class="container">

            <span class="colorDarkyellow semiBold large">Registration Form / नोंदणी फॉर्म </span>
            <span class="space20"></span>
            <form runat="server">
                <%-- <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                 <asp:UpdatePanel ID="UpdatePanel1" runat="server" OnLoad="UpdatePanel1_Load" >
                <ContentTemplate>--%>

                <div class="row g-3">
                    <!-- --------- Form Starts ------- -->
                    <div class="col-md-6">
                        <label for="inputFname" class="form-label">Full Name (Marathi) / पूर्ण नाव (मराठीत) <span class="colorred">*</span></label>
                        <asp:TextBox ID="txtFullName" CssClass="form-control" Placeholder="Enter Full Name In Marathi" runat="server" MaxLength="70"></asp:TextBox>
                    </div>
                    <div class="col-md-6">
                        <label for="inputFname" class="form-label">Gender / लिंग : <span class="colorred">*</span></label>
                        <asp:DropDownList ID="ddrGender" CssClass="form-select" runat="server">
                            <asp:ListItem Value="0">- Select Gender -</asp:ListItem>
                            <asp:ListItem Value="1">Male</asp:ListItem>
                            <asp:ListItem Value="2">Female</asp:ListItem>
                        </asp:DropDownList>
                    </div>

                    <div class="col-md-4">
                        <label for="inputFname" class="form-label">First Name / नाव <span class="colorred">*</span></label>
                        <asp:TextBox ID="txtFname" CssClass="form-control" runat="server" MaxLength="30"></asp:TextBox>
                    </div>
                    <div class="col-md-4">
                        <label for="inputFname" class="form-label">Middle Name / वडिलांचे नाव <span class="colorred">*</span></label>
                        <asp:TextBox ID="txtMname" CssClass="form-control" runat="server" MaxLength="30"></asp:TextBox>
                    </div>
                    <div class="col-md-4">
                        <label for="inputFname" class="form-label">Last Name / आडनाव <span class="colorred">*</span></label>
                        <asp:TextBox ID="txtLname" CssClass="form-control" runat="server" MaxLength="30"></asp:TextBox>
                    </div>

                    <div class="col-md-6">
                        <label for="inputFname" class="form-label">Father's Name / वडिलांचे नाव <span class="colorred">*</span></label>
                        <asp:TextBox ID="txtFather" CssClass="form-control" runat="server" MaxLength="50"></asp:TextBox>
                    </div>
                    <div class="col-md-6">
                        <label for="inputFname" class="form-label">Mother's Name / आईचे नाव <span class="colorred">*</span></label>
                        <asp:TextBox ID="txtMother" CssClass="form-control" runat="server" MaxLength="50"></asp:TextBox>
                    </div>

                    <div class="col-md-6">
                        <label for="inputFname" class="form-label">Mobile No. / मोबाईल नं <span class="colorred">*</span></label>
                        <asp:TextBox ID="txtMobile" onkeypress="return validateNumber(event)" CssClass="form-control" MaxLength="10" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-6">
                        <label for="inputFname" class="form-label">WhatsApp No. / वॉट्सअप नं <span class="colorred">*</span></label>
                        <asp:TextBox ID="txtWhatsapp" onkeypress="return validateNumber(event)" CssClass="form-control" MaxLength="10" runat="server"></asp:TextBox>
                    </div>

                    <div class="col-md-6">
                        <label for="inputFname" class="form-label">Address / पत्ता <span class="colorred">*</span></label>
                        <asp:TextBox ID="txtAddress" CssClass="form-control" runat="server" MaxLength="300"></asp:TextBox>
                    </div>

                    <div class="col-md-6">
                        <label for="inputFname" class="form-label">State / राज्य <span class="colorred">*</span></label>
                        <asp:DropDownList ID="ddrState" CssClass="form-select" runat="server">
                            <asp:ListItem Value="0">- Select State -</asp:ListItem>
                        </asp:DropDownList>
                    </div>

                    <div class="col-md-6">
                        <label for="inputFname" class="form-label">District / जिल्हा <span class="colorred">*</span></label>
                        <asp:TextBox ID="txtDistrict" CssClass="form-control" runat="server" MaxLength="30"></asp:TextBox>
                    </div>

                    <div class="col-md-6">
                        <label for="inputFname" class="form-label">Taluka / City / तालुका <span class="colorred">*</span></label>
                        <asp:TextBox ID="txtCity" CssClass="form-control" runat="server" MaxLength="30"></asp:TextBox>
                    </div>

                    <div class="col-md-4">
                        <label for="inputFname" class="form-label">Birth Date / जन्म तारीख <span class="colorred">*</span></label>
                        <asp:TextBox ID="txtBirthDate" CssClass="form-control" Placeholder="Click here to open calendar" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-4">
                        <label for="inputFname" class="form-label">Birth Time / जन्म वेळ <span class="colorred">*</span></label>
                        <asp:TextBox ID="txtBirthTime" CssClass="form-control" runat="server" Placeholder="00:00 AM/PM" MaxLength="15"></asp:TextBox>
                    </div>
                    <div class="col-md-4">
                        <label for="inputFname" class="form-label">Birth Place / जन्म ठिकाण <span class="colorred">*</span></label>
                        <asp:TextBox ID="txtBirthPlace" CssClass="form-control" runat="server" MaxLength="30"></asp:TextBox>
                    </div>
                    <div class="col-md-6">
                        <label for="exampleFormControlSelect3" class="form-label">Height / उंची <span class="colorred">*</span></label>
                        <asp:DropDownList ID="ddrHieght" CssClass="form-select" runat="server">
                            <asp:ListItem Value="0">- Select Height -</asp:ListItem>
                            <asp:ListItem Value="1">4ft 6in - 137 cm</asp:ListItem>
                            <asp:ListItem Value="2">4ft 7in - 140 cm</asp:ListItem>
                            <asp:ListItem Value="3">4ft 8in - 142 cm</asp:ListItem>
                            <asp:ListItem Value="4">4ft 9in - 145 cm</asp:ListItem>
                            <asp:ListItem Value="5">4ft 10in - 147 cm</asp:ListItem>
                            <asp:ListItem Value="6">4ft 11in - 150 cm</asp:ListItem>
                            <asp:ListItem Value="7">5ft 0in - 152 cm</asp:ListItem>
                            <asp:ListItem Value="8">5ft 1in - 155 cm</asp:ListItem>
                            <asp:ListItem Value="9">5ft 2in - 157 cm</asp:ListItem>
                            <asp:ListItem Value="10">5ft 3in - 160 cm</asp:ListItem>
                            <asp:ListItem Value="11">5ft 4in - 163 cm</asp:ListItem>
                            <asp:ListItem Value="12">5ft 5in - 165 cm</asp:ListItem>
                            <asp:ListItem Value="13">5ft 6in - 168 cm</asp:ListItem>
                            <asp:ListItem Value="14">5ft 7in - 170 cm</asp:ListItem>
                            <asp:ListItem Value="15">5ft 8in - 173 cm</asp:ListItem>
                            <asp:ListItem Value="16">5ft 9in - 175 cm</asp:ListItem>
                            <asp:ListItem Value="17">5ft 10in - 178 cm</asp:ListItem>
                            <asp:ListItem Value="18">5ft 11in - 180 cm</asp:ListItem>
                            <asp:ListItem Value="19">6ft 0in - 183 cm</asp:ListItem>
                            <asp:ListItem Value="20">6ft 1in - 185 cm</asp:ListItem>
                            <asp:ListItem Value="21">6ft 2in - 188 cm</asp:ListItem>
                            <asp:ListItem Value="22">6ft 3in - 191 cm</asp:ListItem>
                            <asp:ListItem Value="23">6ft 4in - 193 cm</asp:ListItem>
                            <asp:ListItem Value="24">6ft 5in - 195 cm</asp:ListItem>
                            <asp:ListItem Value="25">6ft 6in - 198 cm</asp:ListItem>
                            <asp:ListItem Value="26">6ft 7in - 201 cm</asp:ListItem>
                            <asp:ListItem Value="27">6ft 8in - 203 cm</asp:ListItem>
                            <asp:ListItem Value="28">6ft 9in - 205 cm</asp:ListItem>
                            <asp:ListItem Value="29">6ft 10in - 208 cm</asp:ListItem>
                            <asp:ListItem Value="30">6ft 11in - 210 cm</asp:ListItem>
                            <asp:ListItem Value="31">7ft 0in - 213 cm</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-6">
                        <label for="exampleFormControlSelect4" class="form-label">Color / वर्ण  <span class="colorred">*</span></label>
                        <asp:DropDownList ID="ddrColor" CssClass="form-select" runat="server">
                            <asp:ListItem Value="0">- Select Color -</asp:ListItem>
                            <asp:ListItem Value="1">Fair</asp:ListItem>
                            <asp:ListItem Value="2">Very Fair</asp:ListItem>
                            <asp:ListItem Value="3">Wheatish</asp:ListItem>
                            <asp:ListItem Value="4">Wheatish Medium</asp:ListItem>
                            <asp:ListItem Value="5">Wheatish Brown</asp:ListItem>
                            <asp:ListItem Value="6">Dark</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-6">
                        <label for="inputFname" class="form-label">Highest Education / शिक्षण <span class="colorred">*</span></label>
                        <asp:TextBox ID="txtEducation" CssClass="form-control" runat="server" MaxLength="50"></asp:TextBox>
                    </div>
                    <div class="col-md-6">
                        <label for="inputFname" class="form-label">Job / Business / नोकरी / व्यवसाय   <span class="colorred">*</span></label>
                        <asp:TextBox ID="txtJobBusins" CssClass="form-control" runat="server" MaxLength="100"></asp:TextBox>
                    </div>
                    <div class="col-md-6">
                        <label for="inputFname" class="form-label">Monthly Income / मासिक उत्पन्न  <span class="colorred">*</span></label>
                        <asp:TextBox ID="txtMonthIncom" CssClass="form-control" runat="server" MaxLength="20"></asp:TextBox>
                    </div>
                    <div class="col-md-6">
                        <label for="inputFname" class="form-label">Sub Cast / पोटजात <span class="colorred">*</span></label>
                        <asp:TextBox ID="txtSubCast" CssClass="form-control" runat="server" MaxLength="30"></asp:TextBox>
                    </div>
                    <div class="col-md-4">
                        <label for="inputFname" class="form-label">Brothers / भाऊ </label>
                        <asp:TextBox ID="txtBrother" onkeypress="return validateNumber(event)" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-4">
                        <label for="inputFname" class="form-label">Married Brothers / विवाहित </label>
                        <asp:TextBox ID="txtmarridbro" onkeypress="return validateNumber(event)" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-4">
                        <label for="inputFname" class="form-label">Unmarried Brothers / अविवाहित </label>
                        <asp:TextBox ID="txtunmarridbro" onkeypress="return validateNumber(event)"  CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-4">
                        <label for="inputFname" class="form-label">Sisters / बहीण  </label>
                        <asp:TextBox ID="txtSister" onkeypress="return validateNumber(event)"  CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-4">
                        <label for="inputFname" class="form-label">Married Sisters / विवाहित </label>
                        <asp:TextBox ID="txtmarriedSis" onkeypress="return validateNumber(event)" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-4">
                        <label for="inputFname" class="form-label">Unmarried Sisters / अविवाहित </label>
                        <asp:TextBox ID="txtunmarriedSis" onkeypress="return validateNumber(event)" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-6">
                        <label for="inputFname" class="form-label">Farm / शेती  </label>
                        <asp:TextBox ID="txtFarm" CssClass="form-control" runat="server" MaxLength="30"></asp:TextBox>
                    </div>

                    <div class="col-md-6">
                        <label for="inputFname" class="form-label">Upload Photo / फोटो  <span class="colorred">*</span></label>
                        <asp:FileUpload ID="fuimage" runat="server" class="form-control" />
                        <%--<asp:TextBox ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox>--%>
                    </div>
                    <div class="col-md-12">
                        <label for="inputFname" class="form-label">Partner Expectations / जोडीदाराबद्दल  अपेक्षा  <span class="colorred">*</span></label>
                        <asp:TextBox ID="txtPartExcept" CssClass="form-control" runat="server" MaxLength="300"></asp:TextBox>
                    </div>
                    <!-- --------- Form Ends ------- -->
                </div>
                <span class="space20"></span>
                <asp:Button ID="btnSubmit" CssClass="btn btn-primary text-uppercase" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                <asp:Button ID="btnCancel" CssClass="btn btn-secondary text-uppercase" runat="server" Text="Cancel" OnClick="btnCancel_Click" />

                <span class="space50"></span>
                <%--</ContentTemplate>
            </asp:UpdatePanel> --%>
            </form>
        </div>
    </section>

</body>
</html>
