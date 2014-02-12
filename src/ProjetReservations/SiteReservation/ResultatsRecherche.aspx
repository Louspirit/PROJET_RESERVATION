<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResultatsRecherche.aspx.cs" Inherits="SiteReservation._ResultatsRecherche" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 979px; width: 1471px; ">
    
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SITE DE RESERVATION<br />
        <br />
        <asp:Label ID="labelRequestParam" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp; Sélectionner un vol :&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:GridView ID="listVols" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="selectionVol">
        </asp:GridView>
        <br />
        <br />
&nbsp;&nbsp;&nbsp; Sélectionner un hôtel :&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:GridView ID="listHotels" runat="server" AutoGenerateSelectButton="True">
        </asp:GridView>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="buttonValiderCommande" runat="server" Text="Valider votre commande" />
    
        <br />
        <asp:TextBox ID="selectedVol" runat="server" Visible="False"></asp:TextBox>
        <asp:TextBox ID="selectedHotel" runat="server" Visible="False"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
