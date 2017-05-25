<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMasterPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="YatinNiSite.User.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="Server">
    <div class="comments1">
        <div class="well">
            <h4>Leave a Comment:</h4>

            <div class="form-group">
                <asp:TextBox ID="txtPostData" runat="server" TextMode="MultiLine" Height="100" Width="100%"></asp:TextBox>
            </div>
            <asp:Button ID="btnPost" runat="server" CssClass="btn btn-primary" Text="POST" Height="30" Width="100" OnClick="btnPost_Click" />

        </div>
        <hr>
        <asp:DataList ID="DataList1" runat="server" DataKeyField="PostID" OnItemCommand="DataList1_ItemCommand" OnItemDataBound="DataList1_ItemDataBound">
            <ItemTemplate>
                <div class="media">
                    <a class="pull-left" href="#">
                        <img class="media-object" src="../patros-web/web/images/avatar1.png" alt="">
                    </a>
                    <div class="media-body">
                        <h4 class="media-heading">
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("Fname")+" "+Eval("Lname") %>'></asp:Label>
                            <small>
                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("PostDate") %>'></asp:Label></small>
                        </h4>
                        <asp:Label ID="Label3" runat="server" Text='<%#Bind("PostData") %>'></asp:Label>
                        <br />
                        <asp:LinkButton ID="lnkLike" runat="server" CommandName="Like" CommandArgument='<%#Bind("PostID") %>'>Like</asp:LinkButton>&nbsp;
                        <asp:LinkButton ID="lnkComment" runat="server" CommandName="Comment">Comment</asp:LinkButton>
                        <br />
                        <div class="well">
                            <div class="form-group">
                                <asp:Panel ID="Panel1" runat="server" Visible="false">
                                    <asp:TextBox ID="txtCommentData" runat="server" TextMode="MultiLine" Height="50" Width="100%"></asp:TextBox>
                                    <asp:Button ID="btnComment" runat="server" CssClass="btn btn-primary" Text="POST" CommandName="PostComment" CommandArgument='<%#Bind("PostID") %>' />
                                </asp:Panel>
                            </div>
                            <asp:DataList ID="DataList2" runat="server">
                                <ItemTemplate>
                                    <div class="media-body">
                                        <h4 class="media-heading">
                                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("Fname")+" "+Eval("Lname") %>'></asp:Label>
                                            <small>
                                                <asp:Label ID="Label5" runat="server" Text='<%#Bind("CmntDate") %>'></asp:Label></small>
                                        </h4>
                                        <asp:Label ID="Label6" runat="server" Text='<%#Bind("CmntData") %>'></asp:Label>
                                    </div>
                                </ItemTemplate>
                            </asp:DataList>
                        </div>

                    </div>
            </ItemTemplate>
        </asp:DataList>

        <%--<div class="media">
            <a class="pull-left" href="#">
                <img class="media-object" src="../patros-web/web/images/avatar1.png" alt="">
            </a>
            <div class="media-body">
                <h4 class="media-heading">Author Name
									<small>August 25, 2014 at 9:30 PM</small>
                </h4>
                Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin commodo. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla.
								<div class="media">
                                    <a class="pull-left" href="#">
                                        <img class="media-object" src="../patros-web/web/images/avatar1.png" alt="">
                                    </a>
                                    <div class="media-body">
                                        <h4 class="media-heading">Author Name
											<small>August 25, 2014 at 9:30 PM</small>
                                        </h4>
                                        Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin commodo. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.
                                    </div>
                                </div>
            </div>
        </div>--%>
    </div>
</asp:Content>


