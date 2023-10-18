<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/MasterAdmin.master" AutoEventWireup="true" CodeFile="registration.aspx.cs" Inherits="adminpanel_registration_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
	<script type="text/javascript">
        $(function () {
            var prm = Sys.WebForms.PageRequestManager.getInstance();
            if (prm != null) {
                prm.add_endRequest(function (sender, e) {
                    if (sender._postBackSettings.panelsToUpdate != null) {
                        createDataTable();
                    }
                });
            };

            createDataTable();
            function createDataTable() {
                $('#<%= gvregistration.ClientID %>').prepend($("<thead></thead>").append($('#<%= gvregistration.ClientID %>').find("tr:first"))).DataTable({

                    columnDefs: [
                        { orderable: false, targets: [0, 1, 2, 3, 4, 5, 6, 7, 8] }
                    ],
                    order: [[0, 'desc']]
                });

            }
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2 class="pgTitle"><%= pgTitle %></h2>
	<span class="space20"></span>
<%-- Gridview to save data strat here --%>
    <div id="viewinfo" runat="server">
		<%--<a href="contactdata.aspx?action=new" runat="server" class="btn btn-primary btn-md">Add New</a>--%>
		<span class="space20"></span>
		<div class="formPanel table-responsive-md">
			<asp:GridView ID="gvregistration" runat="server" CssClass="table table-striped table-bordered table-hover" GridLines="None" 
				AutoGenerateColumns="false" OnRowDataBound="gvregistration_RowDataBound">
				 <HeaderStyle CssClass="thead-dark" />
				<RowStyle CssClass="" />
				<AlternatingRowStyle CssClass="alt" />
				<Columns>
					 <asp:BoundField DataField="MemberID">
						<HeaderStyle CssClass="HideCol" />
						<ItemStyle  CssClass="HideCol"/>
					</asp:BoundField>
					  <asp:BoundField DataField="MemJoinDate" HeaderText="Date">
						<ItemStyle Width="5%" />
					</asp:BoundField>
					 <asp:BoundField DataField="MemFullName" HeaderText="Name">
						<ItemStyle Width="30%" />
					</asp:BoundField>
					<%-- <asp:BoundField DataField="FK_StateID" HeaderText="State">
						<ItemStyle Width="5%" />
					</asp:BoundField>--%>
                     <asp:BoundField DataField="MemCity" HeaderText="City">
						<ItemStyle Width="10%" />
					</asp:BoundField>
					   <asp:BoundField DataField="MemSubCast" HeaderText="Sub Cast">
						<ItemStyle Width="8%" />
					</asp:BoundField>
					    <asp:BoundField DataField="MemMobile" HeaderText="Mobile No">
						<ItemStyle Width="10%" />
					</asp:BoundField>
                    
						<%--<asp:templatefield headertext="Status">
						<itemstyle width="5%" />
						<itemtemplate>
							<asp:literal id="litstatus" runat="server"></asp:literal>
						</itemtemplate>
					</asp:templatefield>--%>   

                   	<asp:TemplateField HeaderText="Views">
						<ItemStyle Width="5%" />
						<ItemTemplate>
							<asp:Literal ID="litAnch" runat="server"></asp:Literal>
						</ItemTemplate>
					</asp:TemplateField>   
					
				</Columns>
				<EmptyDataTemplate>
					<span class="warning">Its Empty Here... :(</span>
				</EmptyDataTemplate>
				<PagerStyle CssClass="" />
			</asp:GridView>
			<span class="space30"></span>
			<%--<asp:Button ID="btnExport" CssClass="btn btn-md btn-info" runat="server" Text="Export To Pdf" OnClick="btnExport_Click" />--%>
		</div>
	</div>
</asp:Content>

