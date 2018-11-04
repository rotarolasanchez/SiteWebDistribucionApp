<%@ Page Language="C#" MasterPageFile="~/Views/principal.Master" Debug="true" AutoEventWireup="true" CodeBehind="ReporteTestIFP.aspx.cs" Inherits="SiteWeb.Reporte" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" href="//fonts.googleapis.com/css?family=Titillium+Web:400,300,700&amp;subset=latin,latin-ext" />
    <link rel="stylesheet" href="/node_modules/bootstrap-ui/dist/css/bootstrap-ui.min.css" />

    <!-- External JS dependencies -->
    <script src="/node_modules/jquery/dist/jquery.min.js"></script>
    <script src="/node_modules/moment/min/moment-with-locales.min.js"></script>
    <script src="/node_modules/bootstrap/dist/js/bootstrap.min.js"></script>
    <script src="/node_modules/eonasdan-bootstrap-datetimepicker/build/js/bootstrap-datetimepicker.min.js"></script>
    <script src="/node_modules/select2/select2.js"></script>
    <!-- Bootstrap UI JS -->
    <script src="/node_modulescbootstrap-ui/dist/js/bootstrap-ui.min.js"></script>
 
  <div class="content-wrapper">
    <div class="container-fluid">
     <!-- Breadcrumbs-->
      <ol class="breadcrumb">
        <li class="breadcrumb-item">
          <a href="#">Indicador</a>
        </li>
        <li class="breadcrumb-item active">Tables</li>
      </ol>
<!-- Example DataTables Card-->

    <form id="form4" runat="server">
        <asp:Button ID="btnbuscar4" runat="server" OnClick="btnbuscar4_Click" Text="Obtener IFP Test" />
        <asp:ScriptManager ID="ScriptManager5" runat="server"></asp:ScriptManager>
    <rsweb:ReportViewer ID="ReportViewer5" runat="server" BackColor="" ClientIDMode="AutoID" HighlightBackgroundColor="" InternalBorderColor="204, 204, 204" InternalBorderStyle="Solid" InternalBorderWidth="1px" LinkActiveColor="" LinkActiveHoverColor="" LinkDisabledColor="" PrimaryButtonBackgroundColor="" PrimaryButtonForegroundColor="" PrimaryButtonHoverBackgroundColor="" PrimaryButtonHoverForegroundColor="" SecondaryButtonBackgroundColor="" SecondaryButtonForegroundColor="" SecondaryButtonHoverBackgroundColor="" SecondaryButtonHoverForegroundColor="" SplitterBackColor="" ToolbarDividerColor="" ToolbarForegroundColor="" ToolbarForegroundDisabledColor="" ToolbarHoverBackgroundColor="" ToolbarHoverForegroundColor="" ToolBarItemBorderColor="" ToolBarItemBorderStyle="Solid" ToolBarItemBorderWidth="1px" ToolBarItemHoverBackColor="" ToolBarItemPressedBorderColor="51, 102, 153" ToolBarItemPressedBorderStyle="Solid" ToolBarItemPressedBorderWidth="1px" ToolBarItemPressedHoverBackColor="153, 187, 226" Width="700px">
    <LocalReport ReportPath="Content/Report/Report4.rdlc">
     </LocalReport>
        
    </rsweb:ReportViewer>
    </form>
      
     <!-- /.container-fluid-->
    <!-- /.content-wrapper-->
    <footer class="sticky-footer">
      <div class="container">
        <div class="text-center">
          <small>Copyright © Your Website 2018</small>
        </div>
      </div>
    </footer>
    <!-- Scroll to Top Button-->
    <a class="scroll-to-top rounded" href="#page-top">
      <i class="fa fa-angle-up"></i>
    </a>
      </div>
    </div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

</asp:Content>
