<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormModificaAlumno.aspx.cs" Inherits="practica_de_asp.WebFormModificaAlumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="../../css/style4.css">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                Alumno
            </h1>
            <div class="bloque">
            <div class="alumno">
                <asp:Label ID="Alumno" runat="server" Text="Alumno"></asp:Label>
                <asp:TextBox ID="TextBoxAlu" runat="server"></asp:TextBox>
            </div>
            <div class="Curso">
                <asp:Label ID="Curso" runat="server" Text="Curso"></asp:Label>
                <asp:TextBox ID="TextBoxCur" runat="server"></asp:TextBox>
            </div>
            <div class="DNI">
                <asp:Label ID="DNI" runat="server" Text="DNI"></asp:Label>
                <asp:TextBox ID="TextBoxDNI" runat="server"></asp:TextBox>
            </div>
            <div class="Apellidos">
                <asp:Label ID="Apellidos" runat="server" Text="Apellidos"></asp:Label>
                <asp:TextBox ID="TexboxApe" runat="server"></asp:TextBox>
            </div>
            <div class="Nombre">
                <asp:Label ID="Nombre" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox ID="TextBoxNom" runat="server"></asp:TextBox>
            </div>
            <asp:Button ID="Aceptar" runat="server" Text="Aceptar" OnClick="Aceptar_OnClick" />
            <asp:Button ID="Cancelar" runat="server" Text="Cancelar" OnClick="Cancelar_OnClick"/>
        </div>
            </div>
    </form>
</body>
</html>
