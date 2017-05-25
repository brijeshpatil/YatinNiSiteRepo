<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ManageLocation.aspx.cs" Inherits="YatinNiSite.Admin.ManageLocation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderTitle" runat="Server">
    Manage Location
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="Server">

    <h1>Manage State</h1>

    <table>
        <tr>
            <td>State Name</td>
            <td>
                <asp:TextBox ID="txtSName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnState" runat="server" Text="ADD" OnClick="btnState_Click" />
            </td>
        </tr>
    </table>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" DataKeyNames="StateID" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
        <Columns>
            <asp:TemplateField HeaderText="StateID">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%#Bind("StateID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="StateName">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%#Bind("StateName") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%#Bind("StateName") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ShowEditButton="true" />
            <asp:CommandField ShowDeleteButton="true" />
        </Columns>
    </asp:GridView>
    <div class="alert alert-success">
        <strong>
            <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label></strong>
    </div>
    <br />
    <br />
    <br />
    <h1>Manage City</h1>
    <table>
        <tr>
            <td>
                <asp:DropDownList ID="drpState" runat="server"></asp:DropDownList></td>
            <td>
                <asp:TextBox ID="txtCName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnCity" runat="server" Text="ADD" OnClick="btnCity_Click" />
            </td>
        </tr>
    </table>
    <br /><br />
    <asp:GridView ID="GridCity" runat="server" AutoGenerateColumns="false" DataKeyNames="CityID" OnRowEditing="GridCity_RowEditing" OnRowCancelingEdit="GridCity_RowCancelingEdit" OnRowDeleting="GridCity_RowDeleting" OnRowUpdating="GridCity_RowUpdating">
        <Columns>
            <asp:TemplateField HeaderText="City ID">
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%#Bind("CityID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="State Name">
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%#Bind("StateName") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="City Name">
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("CityName")%>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%#Bind("CityName") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ShowEditButton="true" />
            <asp:CommandField ShowDeleteButton="true" />
        </Columns>
    </asp:GridView>
</asp:Content>


