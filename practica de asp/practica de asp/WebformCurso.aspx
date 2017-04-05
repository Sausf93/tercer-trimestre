<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebformCurso.aspx.cs" Inherits="practica_de_asp.Cursos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" type="text/css" href="../../css/style2.css">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <h1> Mantenimiento de Cursos</h1>
        <div>
            <asp:Panel runat="server" BorderStyle="Solid" BorderWidth="2" Width="50%">
            <p>
                <asp:Label runat="server" id="lblCod_cur" Text="Código Curso"></asp:Label>
                <asp:TextBox runat="server" ID="txtCod_cur" Text=""   ></asp:TextBox>
            </p>
              <p>
                <asp:Label runat="server" id="Lbl_Descrip" Text="Descripción"></asp:Label>
                <asp:TextBox runat="server" ID="Txt_descrip" Text=""   ></asp:TextBox>
            </p>
              <p>
                <asp:Label runat="server" id="Lbl_horas" Text="Horas"></asp:Label>
                <asp:TextBox runat="server" ID="Txt_horas" Text=""   ></asp:TextBox>
            </p>
              <p>
                <asp:Label runat="server" id="Lbl_tutor" Text="Tutor"></asp:Label>
                <asp:TextBox runat="server" ID="Txt_tutor" Text=""   ></asp:TextBox>
            </p>
            </asp:Panel>
            <p> <bt/>
                <div class="botones">
                <asp:Button runat="server" ID="btnPrimero" Text="|<" OnClick="btnPrimero_OnClick"/>
                <asp:Button runat="server" ID="btnAnterior" Text="<<" OnClick="btnAnterior_OnClick"/>
                <asp:Button runat="server" ID="btnSiguiente" Text=">>" OnClick="btnSiguiente_OnClick"/>
                <asp:Button runat="server" ID="btnUltimo" Text=">|" OnClick="btnUltimo_OnClick" />
                <asp:Button runat="server" ID="btnModifica" Text="Graba" OnClick="btnModifica_OnClick"/>
                <asp:Button runat="server" ID="btnBorra" Text="Borra" OnClick="btnBorra_OnClick"/>
                <asp:Button runat="server" ID="btnNuevo" Text="Nuevo" OnClick="btnNuevo_OnClick"/>
                <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" OnClick="btnCancelar_OnClick"/>
                    </div>
            </p>
        </div>
        <div>
            <p>
                <br/><br/>
                    <div class="volver">
                    <asp:HyperLink runat="server" ID="Enlaceinicio" Text="Volver" NavigateUrl="Webforminicio.aspx" BorderColor="blue" BorderStyle="Double"></asp:HyperLink>
                        </div>
            </p>
        </div>
    </form>
</body>
</html>
