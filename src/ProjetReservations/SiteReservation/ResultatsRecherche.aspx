<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResultatsRecherche.aspx.cs" Inherits="SiteReservation._ResultatsRecherche" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Resultats Recherche</title>
    <link rel="stylesheet" media="screen" type="text/css" title="Style" href="./style.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="main_container">
        <h1>RESULTAT RECHERCHE</h1>
        <div class="selection_voyage">
            <strong>Rappel de vos critères de recherche :</strong>
            <asp:Label ID="labelRequestParam" runat="server"></asp:Label>
       </div>

        <div class="selection_voyage">
            <strong>Sélectionnez un vol :</strong>
            <asp:GridView ID="listVols" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="selectionVol">
            </asp:GridView>
            <asp:Label ID="selectedVol" runat="server"></asp:Label>
            <asp:Label ID="selectedVolDepart" runat="server"></asp:Label>
            <asp:Label ID="selectedVolArrivee" runat="server"></asp:Label>
            <asp:Label ID="selectedVolDate" runat="server"></asp:Label>
            <asp:Label ID="selectedVolTarif" runat="server"></asp:Label>
        </div>
        
        <div class="selection_voyage">
            <strong>Sélectionnez un hôtel :</strong>
            <asp:GridView ID="listHotels" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="selectionHotel">
            </asp:GridView>
            <asp:Label ID="selectedHotel" runat="server"></asp:Label>
            <asp:Label ID="selectedHotelNom" runat="server"></asp:Label>
            <asp:Label ID="selectedHotelAdresse" runat="server"></asp:Label>
            <asp:Label ID="selectedHotelTarifNuit" runat="server"></asp:Label>
        </div>

        <asp:Button ID="buttonValiderCommande" runat="server" Text="Valider votre sélection" OnClick="validerSelection" />    
        <asp:Label ID="errorMsg" runat="server" BackColor="Orange"></asp:Label>
    
    </div>
    </form>
</body>
</html>
