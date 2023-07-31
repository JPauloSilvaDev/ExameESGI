<%@ Page Title="Listagem de Pessoas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarPessoas.aspx.cs" Inherits="TesteAdmissao.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <h2><%: Title %></h2>
     <asp:Button class="btn btn-primary btn-lg" ID="Button1" runat="server" Text="Calcular Salário"  OnClick="recalcularSalario"/>
    <br />
    <br />
    <asp:GridView class="table" ID="GridView1" runat="server" AutoPostBack="true"
        BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black"
        GridLines="Vertical" PageSize="50" AllowPaging="true" OnPageIndexChanging="GridView1_PageIndexChanging"
        EnableViewState="true">


        <AlternatingRowStyle BackColor="#CCCCCC" />
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />

        <PagerSettings Visible="true" />
    </asp:GridView>


    <h2>Contato</h2>
    <address>
        
        <strong>Email:</strong> jpsilva.sousa97@outlook.com<br />
        <strong>Telefone:</strong> (85) 98811-3621
    </address>




</asp:Content>

