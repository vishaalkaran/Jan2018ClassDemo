<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ODSCRUD.aspx.cs" Inherits="Jan2018ClassDemoVincentWebsite.Webpages.ODSCRUD" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <h1>ODS CRUD of Albums</h1>

    <asp:ListView ID="AlbumCRUD" runat="server" DataSourceID="AlbumObjectDataSource" InsertItemPosition="LastItem" DataKeyNames="AlbumId">
        <AlternatingItemTemplate>
            <tr style="background-color: #FFFFFF; color: #284775;">
                <td><asp:Button runat="server" CommandName="Delete" Text="Delete" ID="DeleteButton" />
                    <asp:Button runat="server" CommandName="Edit" Text="Edit" ID="EditButton" /></td>
               
                <td><asp:Label Text='<%# Bind("AlbumId") %>' runat="server" ID="AlbumIdLabel" /></td>
                <td><asp:Label Text='<%# Bind("Title") %>' runat="server" ID="TitleLabel" /></td>
                <td><asp:DropDownList ID="DropDownList1" 
                    runat="server" 
                    DataSourceID="ArtistObjectDataSource" 
                    DataTextField="Name" 
                    DataValueField="ArtistId" 
                    selectedvalue='<%# Bind("ArtistId") %>'></asp:DropDownList></td>
                <td><asp:Label Text='<%# Bind("ReleaseYear") %>' runat="server" ID="ReleaseYearLabel" /></td>
                <td><asp:Label Text='<%# Bind("ReleaseLabel") %>' runat="server" ID="ReleaseLabelLabel" /></td>


            <%--<td><asp:Label Text='<%# Eval("Artist") %>' runat="server" ID="ArtistLabel" /></td>
                <td><asp:Label Text='<%# Eval("Tracks") %>' runat="server" ID="TracksLabel" /></td>--%>
            </tr>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <tr style="background-color: #999999;">
               <td><asp:Button runat="server" CommandName="Update" Text="Update" ID="UpdateButton" />
                    <asp:Button runat="server" CommandName="Cancel" Text="Cancel" ID="CancelButton" /></td>
               
                <td><asp:Label Text='<%# Bind("AlbumId") %>' runat="server" ID="AlbumIdLabel" /></td>
                <td><asp:TextBox Text='<%# Bind("Title") %>' runat="server" ID="TitleLabel" /></td>
                <td><asp:DropDownList ID="DropDownList1" 
                    runat="server" 
                    DataSourceID="ArtistObjectDataSource" 
                    DataTextField="Name" 
                    DataValueField="ArtistId" 
                    selectedvalue='<%# Bind("ArtistId") %>'></asp:DropDownList></td>
                <td><asp:TextBox Text='<%# Bind("ReleaseYear") %>' runat="server" ID="ReleaseYearLabel" /></td>
                <td><asp:TextBox Text='<%# Bind("ReleaseLabel") %>' runat="server" ID="ReleaseLabelLabel" /></td>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <table runat="server" style="background-color: #FFFFFF; border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px;">
                <tr>
                    <td>No data was returned.</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <tr style="">
                <td><asp:Button runat="server" CommandName="Insert" Text="Insert" ID="InsertButton" />
                    <asp:Button runat="server" CommandName="Cancel" Text="Cancel" ID="CancelButton" /></td>
               
                <td><asp:Label Text='<%# Bind("AlbumId") %>' runat="server" ID="AlbumIdLabel" /></td>
                <td><asp:TextBox Text='<%# Bind("Title") %>' runat="server" ID="TitleLabel" /></td>
                <td><asp:DropDownList ID="DropDownList1" 
                    runat="server" 
                    DataSourceID="ArtistObjectDataSource" 
                    DataTextField="Name" 
                    DataValueField="ArtistId" 
                    selectedvalue='<%# Bind("ArtistId") %>'></asp:DropDownList></td>
                <td><asp:TextBox Text='<%# Bind("ReleaseYear") %>' runat="server" ID="ReleaseYearLabel" /></td>
                <td><asp:TextBox Text='<%# Bind("ReleaseLabel") %>' runat="server" ID="ReleaseLabelLabel" /></td>
            </tr>
        </InsertItemTemplate>
        <ItemTemplate>
            <tr style="background-color: #E0FFFF; color: #333333;">
                <td><asp:Button runat="server" CommandName="Delete" Text="Delete" ID="DeleteButton" />
                    <asp:Button runat="server" CommandName="Edit" Text="Edit" ID="EditButton" /></td>
               
                <td><asp:Label Text='<%# Bind("AlbumId") %>' runat="server" ID="AlbumIdLabel" /></td>
                <td><asp:Label Text='<%# Bind("Title") %>' runat="server" ID="TitleLabel" /></td>
                <td><asp:DropDownList ID="DropDownList1" 
                    runat="server" 
                    DataSourceID="ArtistObjectDataSource" 
                    DataTextField="Name" 
                    DataValueField="ArtistId" 
                    selectedvalue='<%# Bind("ArtistId") %>'></asp:DropDownList></td>
                <td><asp:Label Text='<%# Bind("ReleaseYear") %>' runat="server" ID="ReleaseYearLabel" /></td>
                <td><asp:Label Text='<%# Bind("ReleaseLabel") %>' runat="server" ID="ReleaseLabelLabel" /></td>
            </tr>
        </ItemTemplate>
        <LayoutTemplate>
            <table runat="server">
                <tr runat="server">
                    <td runat="server">
                        <table runat="server" id="itemPlaceholderContainer" style="background-color: #FFFFFF; border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px; font-family: Verdana, Arial, Helvetica, sans-serif;" border="1">
                            <tr runat="server" style="background-color: #E0FFFF; color: #333333;">
                                <th runat="server"></th>
                                <th runat="server">Album</th>
                                <th runat="server">Title</th>
                                <th runat="server">Artist</th>
                                <th runat="server">ReleaseYear</th>
                                <th runat="server">ReleaseLabel</th>
                            </tr>
                            <tr runat="server" id="itemPlaceholder"></tr>
                        </table>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server" style="text-align: center; background-color: #5D7B9D; font-family: Verdana, Arial, Helvetica, sans-serif; color: #FFFFFF">
                        <asp:DataPager runat="server" ID="DataPager1">
                            <Fields>
                                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False"></asp:NextPreviousPagerField>
                                <asp:NumericPagerField></asp:NumericPagerField>
                                <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False"></asp:NextPreviousPagerField>
                            </Fields>
                        </asp:DataPager>
                    </td>
                </tr>
            </table>
        </LayoutTemplate>
       
    </asp:ListView>

    <asp:ObjectDataSource ID="ArtistObjectDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Artist_List" TypeName="ChinookSystem.BLL.ArtistController"></asp:ObjectDataSource>

    <asp:ObjectDataSource ID="AlbumObjectDataSource" runat="server" DataObjectTypeName="Chinook.Data.Entities.Album" DeleteMethod="Albums_Delete" InsertMethod="Album_Add" OldValuesParameterFormatString="original_{0}" SelectMethod="Album_List" TypeName="ChinookSystem.BLL.AlbumController" UpdateMethod="Album_Update"></asp:ObjectDataSource>

    
</asp:Content>