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
            <strong>Sélectionnez un vol :<br />
            </strong>
            <asp:Label ID="labelNoVols" runat="server"></asp:Label>
&nbsp;<asp:GridView ID="listVols" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="selectionVol" CssClass="tableau_resultats">
            </asp:GridView>
            <asp:Label ID="selectedVol" runat="server" Visible="False"></asp:Label>
            <asp:Label ID="selectedVolDepart" runat="server" Visible="False"></asp:Label>
            <asp:Label ID="selectedVolArrivee" runat="server" Visible="False"></asp:Label>
            <asp:Label ID="selectedVolDate" runat="server" Visible="False"></asp:Label>
            <asp:Label ID="selectedVolTarif" runat="server" Visible="False"></asp:Label>
        </div>
        
        <div class="selection_voyage">
            <strong>Sélectionnez un hôtel :<br />
            </strong>
            <asp:Label ID="labelNoHotels" runat="server"></asp:Label>
&nbsp;<asp:GridView ID="listHotels" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="selectionHotel" CssClass="tableau_resultats">
            </asp:GridView>
            <asp:Label ID="selectedHotel" runat="server" Visible="False"></asp:Label>
            <asp:Label ID="selectedHotelNom" runat="server" Visible="False"></asp:Label>
            <asp:Label ID="selectedHotelAdresse" runat="server" Visible="False"></asp:Label>
            <asp:Label ID="selectedHotelTarifNuit" runat="server" Visible="False"></asp:Label>
        </div>
        <div class="submit_btn">
            <asp:Button ID="btnRetour" runat="server" OnClick="btnRetour_Click" Text="Modifier ma recherche" />
&nbsp;<asp:Button ID="buttonValiderCommande" runat="server" Text="Valider votre sélection" OnClick="validerSelection" />    
            <br />
            <asp:Label ID="errorMsg" runat="server" BackColor="Orange"></asp:Label>
        </div>
    </div>
    </form>
</body>
</html>
