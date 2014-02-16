<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InfosClient.aspx.cs" Inherits="SiteReservation.InfosClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" media="screen" type="text/css" title="Style" href="./style.css" />

    <style type="text/css">
        .auto-style1 {
            text-decoration: underline;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <div id="main_container">
    <h1>RAPPEL DES INFORMATIONS</h1>
    <div class="selection_voyage">
    <strong>Rappel de votre sélection :</strong>
        <br />
    Vol au départ de
        <asp:Label ID="rappelVolDepart" runat="server" Font-Bold="True"></asp:Label>
    en destination de
        <asp:Label ID="rappelVolArrivee" runat="server" Font-Bold="True"></asp:Label>
    le
        <asp:Label ID="rappelVolDate" runat="server"></asp:Label>
    pour un montant total de
        <asp:Label ID="rappelVolMontant" runat="server" Font-Bold="True"></asp:Label>
        <strong>€</strong>.&nbsp;
    </div>
    
    <div class="selection_voyage">            
        Hotel <asp:Label ID="rappelHotelNom" runat="server" Font-Bold="True"></asp:Label>
    &nbsp;pour une durée de
        <asp:Label ID="rappelHotelDuree" runat="server" Font-Bold="False"></asp:Label>
    jour(s) et un montant total de
        <asp:Label ID="rappelHotelMontantTotal" runat="server" Font-Bold="True"></asp:Label>
        <strong>€</strong>.
    </div> 
    
    <div class="selection_voyage">    
    <span class="auto-style1">Montant total de votre réservation</span>
        :
        <asp:Label ID="montantTotalReservation" runat="server" Font-Bold="True"></asp:Label>
        <strong>€</strong>. <br />
    </div>

    <div class="selection_voyage">
    <strong>Veuillez saisir les informations suivantes :</strong><br />
    Nom* :
        <asp:TextBox ID="tbNomClient" runat="server" MaxLength="50"></asp:TextBox>
        <br />
    Prenom* :
        <asp:TextBox ID="tbPrenomClient" runat="server" MaxLength="50"></asp:TextBox>
        <br />
    Adresse* :
        <asp:TextBox ID="tbAdresseClient" runat="server" MaxLength="200"></asp:TextBox>
        <br />
    Numéro de carte bancaire* :
        <asp:TextBox ID="tbNumCarteClient" runat="server" MaxLength="20"></asp:TextBox>

        <br />
        <br />

    <div class="submit_btn">
        <asp:Button ID="btnRetour" runat="server" OnClick="btnRetour_Click" Text="Retour aux résultats" />
&nbsp;<asp:Button ID="btnValiderCommande" runat="server" OnClick="validerCommande" Text="Valider votre réservation" />
        <br />
    <asp:Label ID="errorMsg" runat="server" BackColor="Orange"></asp:Label>
        <asp:Label ID="LabelReservOk" runat="server"></asp:Label>
        <br />
        <asp:Button ID="btnRetHome" runat="server" OnClick="btnRetHome_Click" Text="Retourner à la page d'accueil" Visible="False" />
    </div>
    </div>
    </div>
    </form>
</body>
</html>
