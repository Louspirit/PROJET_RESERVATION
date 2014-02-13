<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResultatsRecherche.aspx.cs" Inherits="SiteReservation._ResultatsRecherche" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 1085px; width: 1471px; ">
    
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SITE DE RESERVATION<br />
        <br />
&nbsp;&nbsp;&nbsp; <strong>Rappel de vos critères de recherche :</strong><br />
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="labelRequestParam" runat="server"></asp:Label>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp; <strong>Sélectionnez un vol :&nbsp;</strong>&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:GridView ID="listVols" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="selectionVol">
        </asp:GridView>
        <asp:Label ID="selectedVol" runat="server"></asp:Label>
        <asp:Label ID="selectedVolDepart" runat="server"></asp:Label>
        <asp:Label ID="selectedVolArrivee" runat="server"></asp:Label>
        <asp:Label ID="selectedVolDate" runat="server"></asp:Label>
        <asp:Label ID="selectedVolTarif" runat="server"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp; <strong>Sélectionnez un hôtel :&nbsp;</strong>&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:GridView ID="listHotels" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="selectionHotel">
        </asp:GridView>
        <asp:Label ID="selectedHotel" runat="server"></asp:Label>
        <asp:Label ID="selectedHotelNom" runat="server"></asp:Label>
        <asp:Label ID="selectedHotelAdresse" runat="server"></asp:Label>
        <asp:Label ID="selectedHotelTarifNuit" runat="server"></asp:Label>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:Button ID="buttonValiderCommande" runat="server" Text="Valider votre sélection" OnClick="validerSelection" />
    
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="errorMsg" runat="server" BackColor="Orange"></asp:Label>
    
        <br />
    
    </div>
    </form>
</body>
</html>
