<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ManejoIO.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            STREAMWRITTER: Clase que se utiliza para escribir archivos.</p>
        <p>
            &nbsp;</p>
        <p>
            Nombre y Apellido:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="Campo Obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
        <p>
&nbsp;Legajo:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="Campo Obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
        <p>
            Puesto:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" Display="Dynamic" ErrorMessage="Campo Obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
        <p>
            Sueldo:
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" Display="Dynamic" ErrorMessage="Campo Obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:Label ID="lbValidacion" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Guardar" />
&nbsp;<asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" PostBackUrl="~/WebForm2.aspx">Ver Archivo</asp:LinkButton>
        </p>
    </form>
</body>
</html>
