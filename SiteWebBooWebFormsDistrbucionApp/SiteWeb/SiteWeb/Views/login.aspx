<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="SiteWeb.login" %>

<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
  <meta name="description" content="">
  <meta name="author" content="">
  <title>Web DistribucionApp</title>
  <!-- Bootstrap core CSS-->
  <link href="/content/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
  <!-- Custom fonts for this template-->
  <link href="/content/vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">
  <!-- Custom styles for this template-->
  <link href="/content/css/coming-soon.min.css" rel="stylesheet">
    <style type="text/css">
        .auto-style1 {
            margin-left: 12px;
        }
        .auto-style2 {
            margin-left: 5px;
        }
    </style>
</head>

<body >
    
    <%--<div class="bg-dark"></div>--%>
    <div class="overlay"></div>
    <video playsinline="playsinline" autoplay="autoplay" muted="muted" loop="loop">
      <source src="/content/MP4/VISTONY2.mp4" type="video/mp4">
    </video>

 <%--<div class="container">--%>


    <div class="masthead">
      <div class="masthead-bg"></div>
      <div class="container h-100">
        <div class="row h-100">
          <div class="col-12 my-auto">
            <div class="masthead-content text-white py-5 py-md-0">
 <div class="container">
    <div class="card card-login mx-auto mt-5" style="left: 0px; top: 0px; width: 237px">
      <div class="card-header">
          <form id="form1" runat="server">
              Login<asp:Image ID="Image1" runat="server" Height="44px" ImageUrl="~/logo_vistony_hotizontal_para_fondo_blanco.png" Width="208px" />
              <div class="form-group">
            <%--<label for="exampleInputEmail1">Usuario</label>--%>
            <%--<input class="form-control" id="exampleInputEmail1" type=">Usuario" aria-describedby="emailHelp" placeholder="Usuario">--%>
                  <asp:Label ID="Label2" runat="server" BackColor="White" BorderColor="Black" Font-Italic="True" ForeColor="Black" Text="Usuario:"></asp:Label>
                  <asp:TextBox ID="usutxt" runat="server" CssClass="auto-style1" Width="112px"></asp:TextBox>
                  </div>
                  <div class="form-group">
            <%--<label for="exampleInputPassword1">Contraseña</label>--%>
            <%--<input class="form-control" id="exampleInputPassword1" type="password" placeholder="Contraseña">--%>
                      <asp:Label ID="Label1" runat="server" ForeColor="Black" Text="Password:"></asp:Label>
                      <asp:TextBox ID="passtxt"  type="password" runat="server" CssClass="auto-style2" Width="112px"></asp:TextBox>
                  </div>
              <%--<input id="passtxt" type="password" runat="server" PropertyName="text"/>--%>
         
              </div>
              <div class="form-group">
                  <div class="form-check">
                      <%--<label class="form-check-label" ForeColor="Black" BorderColor="Black"  >--%>
<%--                      <input class="form-check-input" type="checkbox">  Recordar Contraseña</label>--%>
                      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=192.168.254.6;Initial Catalog=DistribucionApp;Persist Security Info=True;User ID=report;Password=Report01" ProviderName="System.Data.SqlClient" SelectCommand="SPM_InicioSesionWeb_Usuario" SelectCommandType="StoredProcedure">
                          <SelectParameters>
                              <asp:ControlParameter ControlID="usutxt" Name="usu" PropertyName="Text" Type="String" />
                              <asp:ControlParameter ControlID="passtxt" Name="pass" PropertyName="text" Type="String" />
                          </SelectParameters>
                      </asp:SqlDataSource>
                  </div>
              </div>
              <a class="btn btn-primary btn-block" href="/Views/index.aspx">Login</a>
          </form>
          <div class="text-center">
              <a class="d-block small mt-3" href="register.html">Registrar Usuario</a> <a class="d-block small" href="forgot-password.html">Olvido Contraseña?</a>
          </div>
        </div>
    </div>
 </div>
                </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  <!-- Bootstrap core JavaScript-->
  <script src="/content/vendor/jquery/jquery.min.js"></script>
  <script src="/content/vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
  <!-- Core plugin JavaScript-->
  <script src="/content/vendor/jquery-easing/jquery.easing.min.js"></script>
</body>

</html>

