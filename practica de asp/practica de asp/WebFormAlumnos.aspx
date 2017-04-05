<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormAlumnos.aspx.cs" Inherits="practica_de_asp.WebFormAlumnos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <link rel="stylesheet" type="text/css" href="../../css/style3.css">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="tabla">
            
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_OnSelectedIndexChanged"></asp:DropDownList>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_OnRowCommand">
            <columns>
                <asp:BoundField DataField="COD_ALU" HeaderText="ALUMNO"/>
                <asp:BoundField DataField="COD_CUR" HeaderText="CURSO"/>
                <asp:BoundField DataField="DNI" HeaderText="DNI"/>
                <asp:BoundField DataField="APELLIDOS" HeaderText="APELLIDOS"/>
                <asp:BoundField DataField="NOMBRE" HeaderText="NOMBRE"/>
                <asp:ButtonField Text="Modificar" HeaderText="Modificar" CommandName="M"/>
                <asp:ButtonField Text="Borrar" HeaderText="Borrar" CommandName="B"/>
            </columns>
                </asp:GridView>
            <div class="volver">
                    <asp:HyperLink runat="server" ID="Enlaceinicio" Text="Volver" NavigateUrl="Webforminicio.aspx" BorderColor="blue" BorderStyle="Double"></asp:HyperLink>
                        </div>
        </div>
    </form>
</body>
</html>
