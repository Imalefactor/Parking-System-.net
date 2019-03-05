<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin.aspx.cs" Inherits="admin" %>

<!DOCTYPE html>
<html lang="en" class="no-js">

    <head>

        <meta charset="utf-8">
        <title>小区停车管理系统</title>
        <meta name="viewport" content="width=device-width, initial-scale=2.0">
        <meta name="description" content="">
        <meta name="author" content="">
            <style type="text/css">
                #form1 {
                    top: 1px;
                    left: -2px;
                    width: 620px;
                }
            </style>
            <form id="form1" runat="server">
            <div style="background-color: #2894FF; position: absolute; top: 286px; left: -152px; width: 923px; height: 447px; text-align: center; margin-top: 0;">
                <br />
                <br />
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

                <br />
                <br />
                <br />

                <asp:Button ID="Button1" runat="server" Height="35px" Text="添加用户" Width="200px" OnClick="Button1_Click" />
                <br />
                <br />
                <asp:Button ID="Button2" runat="server" Height="35px" Text="显示车位车辆所有信息" Width="200px" OnClick="Button2_Click" />
                <br />
                <br />

                <asp:Button ID="Button3" runat="server"  Height="35px" Text="删除用户" Width="200px" OnClick="Button3_Click"/>
                <br />
                <br />
                <asp:Button ID="Button4" runat="server" Height="35px" Text="添加车位" Width="200px" OnClick="Button4_Click" />
    </div>
        <!-- CSS -->
        <link rel='stylesheet' href='http://fonts.googleapis.com/css?family=PT+Sans:400,700'>
        <link rel="stylesheet" href="assets/css/reset.css">
        <link rel="stylesheet" href="assets/css/supersized.css">
        <link rel="stylesheet" href="assets/css/style.css">

        <!-- HTML5 shim, for IE6-8 support of HTML5 elements -->
        <!--[if lt IE 9]>
            <script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
        <![endif]-->

    </head>

    <body>

        <div class="page-container">

             <!-- Javascript -->
        <script src="assets/js/jquery-1.8.2.min.js"></script>
        <script src="assets/js/supersized.3.2.7.min.js"></script>
        <script src="assets/js/supersized-init.js"></script>
        <script src="assets/js/scripts.js"></script>

            </form>
        </form>
            <h1>小区自助停车管理系统</h1>

    </body>             