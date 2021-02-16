<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WS_Cliente_WebForms.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 435px">
    <form id="form1" runat="server">
        <div>
            Saludo - Adios<br />
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Vizualizar Saludo" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Visualizar Adios" />
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Width="287px"></asp:TextBox>
        </p>
        <hr />
        <p>
            &nbsp;</p>
        Suma de 2 numeros<br />
        <asp:TextBox ID="TextBox2" placeholder="Numero 1" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox3" placeholder="Numero 2" runat="server"></asp:TextBox>
        <p>
            <asp:TextBox ID="TextBox4" placeholder="Resultado" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Calcular" />
        </p>
        <hr />
        <p>
            &nbsp;</p>
        <p>
            Tabla de multiplicar</p>
        <p>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button4" placeholder="Numero" runat="server" Text="Calcular" OnClick="Button4_Click" />
        </p>
        <p>
            <asp:ListBox ID="ListBox1" runat="server" Height="146px" Width="100%" Rows="10" SelectionMode="Multiple"></asp:ListBox>
        </p>
        <hr />
        <p>
            &nbsp;</p>
        <p>
            Años BISIESTOS</p>
        <p>
            Año inicial
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </p>
        <p>
            Año Final
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button5" runat="server" Text="Calcular" OnClick="Button5_Click" />
        </p>
        <p>
            <asp:ListBox ID="ListBox2" Height="146px" Width="100%" Rows="10" runat="server"></asp:ListBox>
        </p>
        <hr />
        <p>
            &nbsp;</p>
        <p>
            OPERACIONES ARITMETICAS</p>
        <p>
            Numero 1
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        </p>
        <p>
            Numero 2
            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        </p>
        <p>
            Tipo de operacion
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Sumar</asp:ListItem>
                <asp:ListItem>Restar</asp:ListItem>
                <asp:ListItem>Multiplicar</asp:ListItem>
                <asp:ListItem>Dividir</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Calcular" />
            &nbsp;</p>
        <p>
            Resultado&nbsp; <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
