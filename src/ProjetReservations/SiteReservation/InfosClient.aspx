<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InfosClient.aspx.cs" Inherits="SiteReservation.InfosClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" media="screen" type="text/css" title="Style" href="./style.css" />

</head>
<body>
    <form id="form1" runat="server">
    <div id="main_container">
    <h1>RAPPEL DES INFORMATIONS</h1>
    <div class="selection_voyage">
    <strong>Rappel de votre sélection :</strong>
    Vol au départ de
        <asp:Label ID="rappelVolDepart" runat="server"></asp:Label>
    en destination de
        <asp:Label ID="rappelVolArrivee" runat="server"></asp:Label>
    le
        <asp:Label ID="rappelVolDate" runat="server"></asp:Label>
    pour un montant total de
        <asp:Label ID="rappelVolMontant" runat="server"></asp:Label>
    euros.
    </div>
    
    <div class="selection_voyage">            
    Hotel &quot;<asp:Label ID="rappelHotelNom" runat="server"></asp:Label>
    &quot; pour une durée de
        <asp:Label ID="rappelHotelDuree" runat="server"></asp:Label>
    jour(s) et un montant total de
        <asp:Label ID="rappelHotelMontantTotal" runat="server"></asp:Label>
     euros.
    </div> 
    
    <div class="selection_voyage">    
    <span class="auto-style1">Montant total de votre réservation : </span>
        <asp:Label ID="montantTotalReservation" runat="server" CssClass="auto-style1"></asp:Label>
        <span class="auto-style1">&nbsp;euros.</span><br />
    </div>

    <div class="selection_voyage">
    <strong>Veuillez saisir les informations suivantes :</strong><br />
    Nom* :
        <asp:TextBox ID="tbNomClient" runat="server" MaxLength="50"></asp:TextBox>
    Prenom* :
        <asp:TextBox ID="tbPrenomClient" runat="server" MaxLength="50"></asp:TextBox>
    Adresse* :
        <asp:TextBox ID="tbAdresseClient" runat="server" MaxLength="200"></asp:TextBox>
    Numéro de carte bancaire* :
        <asp:TextBox ID="tbNumCarteClient" runat="server" MaxLength="20"></asp:TextBox>

    <div class="submit_btn">
    <asp:Button ID="btnValiderCommande" runat="server" OnClick="validerCommande" Text="Valider votre réservation" />
    <asp:Label ID="errorMsg" runat="server" BackColor="Orange"></asp:Label>
    </div>
    </div>
    </div>
    </form>
</body>
</html>
