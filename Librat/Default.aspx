﻿<%@ Page Title="Librat | Libraria" Language="C#" MasterPageFile="~/Masters/Layout.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Librat_Default" %>

<%@ Register Src="~/Controls/BookControl.ascx" TagPrefix="uc1" TagName="BookControl" %>


<asp:Content runat="server" ContentPlaceHolderID="head">
    <link href="/vendor/magnific-popup/magnific-popup.css" rel="stylesheet" type="text/css" />

    <script src="/js/work-popup.js" type="text/javascript"></script>
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    
    <div class="row">
        <div class="container content-lg">
            <div class="row">
                <div class="content-md container">
                    <div class="masonry-grid row row-space-2">
                        <asp:Repeater ID="repeaterBooks" runat="server">
                            <ItemTemplate>
                                <uc1:BookControl runat="server" ID="BookControl" Book='<%#(Container.DataItem as Book) %>' />
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
