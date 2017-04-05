<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webforminicio.aspx.cs" Inherits="practica_de_asp.Webforminicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" type="text/css" href="../../css/style.css">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h1> Formulario de Inicio</h1>
            <asp:HyperLink ID="EnlaceCursos" Text="Mantenimiento de Curso" NavigateUrl="~/WebformCurso.aspx"  runat="server"><p>Mantenimiento del Curso</p></asp:HyperLink>
            <asp:HyperLink ID="EnlaceAlumnos" Text="Mantenimiento Alumnos" runat="server" NavigateUrl="~/WebformAlumnos.aspx" ><p>Mantenimiento de Alumnos</p></asp:HyperLink>
            <asp:HyperLink ID="EnlaceNotas" Text="Mantenimiento Notas" runat="server" NavigateUrl="~/WebformCurso.aspx" > <p>Mantenimiento de Notas</p></asp:HyperLink>
        </div>
    </form>
</body>
</html>
