<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ManejoDataSetDataTableGridview.aspx.vb" Inherits="ManejoDataSetGridview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Manejo de Dataset y Gridview</title>
</head>
<body>
    <h1>Manejo de Dataset, Datatable y Gridview con Base de Datos</h1>
    <form id="form1" runat="server">
    <div>
        <h3></h3>
        <asp:Button ID="btnMostrarProductos" runat="server" Text="Mostrar Productos" />
        <br /><br />
        <asp:Label ID="lbl1" runat="server" Text="Listado de los 10 Primeros Productos" Font-Bold="True" Visible="False"></asp:Label>
        <br /><br />
        <asp:GridView ID="gvProductos" runat="server"></asp:GridView>
        <br /><br />
        <asp:Label ID="lbl2" runat="server" Text="Listado de los Productos de Proveedor especifico" Font-Bold="True" Visible="False"></asp:Label>
        <br /><br />
        <asp:GridView ID="gvProductosCategoria2" runat="server"></asp:GridView>
        <br /><br />
    </div>
    </form>
</body>
</html>
