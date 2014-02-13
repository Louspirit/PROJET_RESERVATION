<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InfosClient.aspx.cs" Inherits="SiteReservation.InfosClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 999px;
            width: 1955px;
        }
        .auto-style1 {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SITE DE RESERVATION<br />
        <br />
&nbsp;&nbsp;&nbsp; <strong>Rappel de votre sélection :</strong>
        <br />
        <br />
&nbsp;&nbsp;&nbsp; Vol au départ de
        <asp:Label ID="rappelVolDepart" runat="server"></asp:Label>
&nbsp;en destination de
        <asp:Label ID="rappelVolArrivee" runat="server"></asp:Label>
&nbsp;le
        <asp:Label ID="rappelVolDate" runat="server"></asp:Label>
&nbsp;pour un montant total de
        <asp:Label ID="rappelVolMontant" runat="server"></asp:Label>
&nbsp;euros.<br />
        <br />
&nbsp;&nbsp;&nbsp; Hotel &quot;<asp:Label ID="rappelHotelNom" runat="server"></asp:Label>
        &quot; pour une durée de
        <asp:Label ID="rappelHotelDuree" runat="server"></asp:Label>
&nbsp;jour(s) et un montant total de
        <asp:Label ID="rappelHotelMontantTotal" runat="server"></asp:Label>
&nbsp;euros.<br />
        <br />
&nbsp;&nbsp;&nbsp; <span class="auto-style1">Montant total de votre réservation : </span>
        <asp:Label ID="montantTotalReservation" runat="server" CssClass="auto-style1"></asp:Label>
        <span class="auto-style1">&nbsp;euros.</span><br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp; <strong>Veuillez saisir les informations suivantes :</strong><br />
        <br />
&nbsp;&nbsp;&nbsp; Nom* :&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbNomClient" runat="server"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp; Prenom* :&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbPrenomClient" runat="server"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp; Adresse* :&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbAdresseClient" runat="server"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp; Numéro de carte bancaire* :<asp:TextBox ID="tbNumCarteClient" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnValiderCommande" runat="server" OnClick="validerCommande" Text="Valider votre réservation" />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="errorMsg" runat="server" BackColor="Orange"></asp:Label>
    </form>
</body>
</html>
