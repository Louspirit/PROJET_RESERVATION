﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SiteReservation._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Site de reservation</title>
    <link rel="stylesheet" media="screen" type="text/css" title="Style" href="./style.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="main_container">
        <h1>SELECTION VOYAGE</h1>
        <div class="selection_voyage">
        Sélectionner une ville de départ :
        <asp:DropDownList ID="listVilleDepart" runat="server">
        </asp:DropDownList>
        </div>

        <div class="selection_voyage">
        Sélectionner une ville d&#39;arrivée :
        <asp:DropDownList ID="listVilleArrivee" runat="server">
        </asp:DropDownList>
        </div>

        <div class="selection_voyage">
        Durée du séjour :
        <asp:DropDownList ID="dureeSejour" runat="server">
            <asp:ListItem Selected="True" Value="1"></asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>11</asp:ListItem>
            <asp:ListItem>12</asp:ListItem>
            <asp:ListItem>13</asp:ListItem>
            <asp:ListItem>14</asp:ListItem>
            <asp:ListItem>15</asp:ListItem>
            <asp:ListItem>16</asp:ListItem>
            <asp:ListItem>17</asp:ListItem>
            <asp:ListItem>18</asp:ListItem>
            <asp:ListItem>19</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
        </asp:DropDownList>
        </div>

        <div class="selection_calendar">
        Date du départ :
        <div class="calendar">
        <asp:Calendar ID="dateDepart" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
            <NextPrevStyle VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#808080" />
            <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
            <SelectorStyle BackColor="#CCCCCC" />
            <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
            <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
            <WeekendDayStyle BackColor="#FFFFCC" />
        </asp:Calendar>
        </div>
        </div>

        <div class="submit_btn">
        <asp:Button ID="buttonReservation" runat="server" Text="Rechercher" OnClick="rechercherVolsHotels"/>
            <br />
        <asp:Label ID="errorMsg" runat="server" BackColor="Orange"></asp:Label>
        </div>  
    </div>
    </form>
</body>
</html>
