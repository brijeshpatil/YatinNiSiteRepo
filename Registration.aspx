<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="YatinNiSite.Registration" %>

<!DOCTYPE html>
<html>
<head>
    <title>Pooled Admin Panel Category Flat Bootstrap Responsive Web Template | Sign Up :: w3layouts</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="keywords" content="Pooled Responsive web template, Bootstrap Web Templates, Flat Web Templates, Android Compatible web template, 
Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />
    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
    <!-- Bootstrap Core CSS -->
    <link href="pooled/web/css/bootstrap.min.css" rel='stylesheet' type='text/css' />
    <!-- Custom CSS -->
    <link href="pooled/web/css/style.css" rel='stylesheet' type='text/css' />
    <link rel="stylesheet" href="pooled/web/css/morris.css" type="text/css" />
    <!-- Graph CSS -->
    <link href="pooled/web/css/font-awesome.css" rel="stylesheet">
    <link rel="stylesheet" href="pooled/web/css/jquery-ui.css">
    <!-- jQuery -->
    <script src="pooled/web/js/jquery-2.1.4.min.js"></script>
    <!-- //jQuery -->
    <link href='//fonts.googleapis.com/css?family=Roboto:700,500,300,100italic,100,400' rel='stylesheet' type='text/css' />
    <link href='//fonts.googleapis.com/css?family=Montserrat:400,700' rel='stylesheet' type='text/css'>
    <!-- lined-icons -->
    <link rel="stylesheet" href="pooled/web/css/icon-font.min.css" type='text/css' />
    <!-- //lined-icons -->
</head>
<body>
    <div class="main-wthree">
        <div class="container">
            <div class="sin-w3-agile">
                <h2>Sign Up</h2>
                <form runat="server" id="form1" >
                    <div class="username">
                        <span class="username">First Name:</span>
                        <asp:TextBox ID="txtfname" runat="server" CssClass="name"></asp:TextBox>
                        <%--<input type="text" name="name" class="name" placeholder="" required="">--%>
                        <div class="clearfix"></div>
                    </div>
                    <div class="username">
                        <span class="username">Last Name:</span>
                        <asp:TextBox ID="txtlname" runat="server" CssClass="name"></asp:TextBox>
                        <%--<input type="text" name="name" class="name" placeholder="" required="">--%>
                        <div class="clearfix"></div>
                    </div>
                    <div class="username">
                        <span class="username">Gender:</span>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" CssClass="name" RepeatDirection="Horizontal">
                            <asp:ListItem Selected="True">Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:RadioButtonList>
                        <%--<input type="text" name="name" class="name" placeholder="" required="">--%>
                        <div class="clearfix"></div>
                    </div>
                    <div class="State">
                        <span class="username">State:</span>
                        <asp:DropDownList ID="drpState" runat="server" AutoPostBack="true" OnSelectedIndexChanged="drpState_SelectedIndexChanged"></asp:DropDownList>
                        <%--<input type="text" name="name" class="name" placeholder="" required="">--%>
                        <div class="clearfix"></div>
                    </div>
                    <div class="username">
                        <span class="username">City:</span>
                        <asp:DropDownList ID="drpCity" runat="server"></asp:DropDownList>
                        <%--<input type="text" name="name" class="name" placeholder="" required="">--%>
                        <div class="clearfix"></div>
                    </div>
                    <div class="username">
                        <span class="username">Email:</span>
                        <asp:TextBox ID="txtUname" runat="server" CssClass="name"></asp:TextBox>
                        <%--<input type="text" name="email" class="name" placeholder="" required="">--%>
                        <div class="clearfix"></div>
                    </div>
                    <div class="password-agileits">
                        <span class="username">Password:</span>
                        <asp:TextBox ID="txtpass" TextMode="Password" runat="server" CssClass="password"></asp:TextBox>
                        <%--<input type="password" name="password" class="password" placeholder="" required="">--%>
                        <div class="clearfix"></div>
                    </div>
                    <div class="password-agileits">
                        <span class="username">Confirm Password:</span>
                        <asp:TextBox ID="txtCPass" TextMode="Password" CssClass="password" runat="server"></asp:TextBox>
                        <%--<input type="password" name="password" class="password" placeholder="" required="">--%>
                        <div class="clearfix"></div>
                    </div>
                    <div class="login-w3">
                        <asp:Button ID="Button1" runat="server" CssClass="login" Text="Sign Up" OnClick="Button1_Click"/>
                        <%--<input type="submit" class="login" value="Sign Up">--%>
                    </div>
                    <div class="clearfix"></div>
                </form>
                <div class="back">
                    <a href="index.html">Back to home</a>
                </div>
                <div class="footer">
                    <p>&copy; 2016 Pooled . All Rights Reserved | Design by <a href="http://w3layouts.com">W3layouts</a></p>
                </div>
            </div>
        </div>
    </div>
</body>
</html>

