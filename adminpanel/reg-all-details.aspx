<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel/MasterAdmin.master" AutoEventWireup="true" CodeFile="reg-all-details.aspx.cs" Inherits="adminpanel_reg_all_details" %>
<%@ MasterType VirtualPath="~/adminpanel/MasterAdmin.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2 class="pgTitle">Registred Users Details</h2>
    <span class="space15"></span>
    <div id="Div1" runat="server">
        <div class="card">
            <div class="card-body">
                <%= mreq %>
                <div class="row">
                    <div class="col-md-10 col-xs-12">
                        <div class="card-header">
                            <h3 class="large colorLightBlue">Registred Users Details</h3>
                        </div>
                        <table class="form_table">
                            <tr>
                                <td><span class="formLable bold_weight">Marital Status :</span></td>
                                <td><span class="formLable"><%= orduserData[0] %></span> </td>
                            </tr>
                            <tr>    
                                <td><span class="formLable bold_weight">First Name :</span></td>
                                <td><span class="formLable"><%= orduserData[1] %></span> </td>
                            </tr>
                            <tr>
                                <td><span class="formLable bold_weight">Middle Name :</span></td>
                                <td><span class="formLable"><%= orduserData[2] %></span> </td>
                            </tr>

                            <tr>
                                <td><span class="formLable bold_weight">Last Name:</span></td>
                                <td><span class="formLable"><%= orduserData[3] %></span> </td>
                            </tr>
                            
                            <tr>
                                <td><span class="formLable bold_weight">Full Name:</span></td>
                                <td><span class="formLable"><%= orduserData[4] %></span> </td>
                            </tr>
                            <tr>
                                <td><span class="formLable bold_weight">Gender:</span></td>
                                <td><span class="formLable"><%= orduserData[5] %></span> </td>
                            </tr>
                            <%--<tr>
                                <td><span class="formLable bold_weight">Cast:</span></td>
                                <td><span class="formLable"><%= orduserData[6] %></span> </td>
                            </tr>--%>
                            <tr>
                                <td><span class="formLable bold_weight">Sub-Cast:</span></td>
                                <td><span class="formLable"><%= orduserData[7] %></span> </td>
                            </tr>
               
                            <tr>
                                <td><span class="formLable bold_weight">Father Name:</span></td>
                                <td><span class="formLable"><%= orduserData[8] %></span> </td>
                            </tr>
                            <tr>
                                <td><span class="formLable bold_weight">Mother Name:</span></td>
                                <td><span class="formLable"><%= orduserData[9] %></span> </td>
                            </tr>
                            <tr>
                                <td><span class="formLable bold_weight">Address:</span></td>
                                <td><span class="formLable"><%= orduserData[10] %></span> </td>
                            </tr>
                            <tr>
                                <td><span class="formLable bold_weight">State:</span></td>
                                <td><span class="formLable"><%= orduserData[11] %></span> </td>
                            </tr>
                     
                             <tr>
                                <td><span class="formLable bold_weight">District:</span></td>
                                <td><span class="formLable"><%= orduserData[12] %></span> </td>
                            </tr>
                             <tr>
                                <td><span class="formLable bold_weight">City:</span></td>
                                <td><span class="formLable"><%= orduserData[13] %></span> </td>
                            </tr>
                             <tr>
                                <td><span class="formLable bold_weight">Mobile No:</span></td>
                                <td><span class="formLable"><%= orduserData[14] %></span> </td>
                            </tr>
                             <tr>
                                <td><span class="formLable bold_weight">WhatsApp No:</span></td>
                                <td><span class="formLable"><%= orduserData[15] %></span> </td>
                            </tr>
                            
                             <tr>
                                <td><span class="formLable bold_weight">Birth Date:</span></td>
                                <td><span class="formLable"><%= orduserData[16] %></span> </td>
                            </tr>
                             <tr>
                                <td><span class="formLable bold_weight">Birth Time:</span></td>
                                <td><span class="formLable"><%= orduserData[17] %></span> </td>
                            </tr>
                            <tr>
                                <td><span class="formLable bold_weight">Birth Place:</span></td>
                                <td><span class="formLable"><%= orduserData[18] %></span> </td>
                            </tr>
                             <tr>
                                <td><span class="formLable bold_weight">Education:</span></td>
                                <td><span class="formLable"><%= orduserData[19] %></span> </td>
                            </tr>

                            <tr>
                                <td><span class="formLable bold_weight">Color:</span></td>
                                <td><span class="formLable"><%= orduserData[20] %></span> </td>
                            </tr>

                            <tr>
                                <td><span class="formLable bold_weight">Height:</span></td>
                                <td><span class="formLable"><%= orduserData[21] %></span> </td>
                            </tr>
                             
                             <tr>
                                <td><span class="formLable bold_weight">Job / Business:</span></td>
                                <td><span class="formLable"><%= orduserData[22] %></span> </td>
                            </tr>
                            <tr>
                                <td><span class="formLable bold_weight">Monthly Income:</span></td>
                                <td><span class="formLable"><%= orduserData[23] %></span> </td>
                            </tr>
                            <tr>
                                <td><span class="formLable bold_weight">Partner Exceptations:</span></td>
                                <td><span class="formLable"><%= orduserData[24] %></span> </td>
                            </tr>
                            <tr>
                                <td><span class="formLable bold_weight">Full Name Marathi:</span></td>
                                <td><span class="formLable"><%= orduserData[26] %></span> </td>
                            </tr>
                                <tr>
                                    <td><span class="formLable bold_weight">Total Brothers:</span></td>
                                    <td><span class="formLable"><%= orduserData[27] %></span> </td>

                                    <td><span class="formLable bold_weight">Married:</span></td>
                                    <td><span class="formLable"><%= orduserData[28] %></span> </td>

                                    <td><span class="formLable bold_weight">Unmarried:</span></td>
                                    <td><span class="formLable"><%= orduserData[29] %></span> </td>
                                </tr>
                            </tr>
                            <%--<tr>
                                <td><span class="formLable bold_weight">Married Brothers:</span></td>
                                <td><span class="formLable"><%= orduserData[28] %></span> </td>
                            </tr>
                            <tr>
                                <td><span class="formLable bold_weight">Unmarried Brothers:</span></td>
                                <td><span class="formLable"><%= orduserData[29] %></span> </td>
                            </tr>--%>
                                <tr>
                                    <td><span class="formLable bold_weight">Total Sisters:</span></td>
                                    <td><span class="formLable"><%= orduserData[30] %></span> </td>
                               
                                    <td><span class="formLable bold_weight">Married:</span></td>
                                    <td><span class="formLable"><%= orduserData[31] %></span></td>

                                    <td><span class="formLable bold_weight">Unmarried:</span></td>
                                    <td><span class="formLable"><%= orduserData[32] %></span> </td>
                                </tr>
                            </tr>
                           <%-- <tr>
                                <td><span class="formLable bold_weight">Married Sisters:</span></td>
                                <td><span class="formLable"><%= orduserData[31] %></span> </td>
                            </tr>
                            <tr>
                                <td><span class="formLable bold_weight">Unmarried Sisters:</span></td>
                                <td><span class="formLable"><%= orduserData[32] %></span> </td>
                            </tr>--%>
                            <tr>
                                <td><span class="formLable bold_weight">Farm:</span></td>
                                <td><span class="formLable"><%= orduserData[33] %></span> </td>
                            </tr>
                            <tr>
                                <td><span class="formLable bold_weight">Photo:</span></td>
                                <td><span class="formLable"><%= orduserData[25] %></span> </td>
                            </tr>
                            <%--<div class="form-check col-md-6">
						<span class="space30"></span>
						<div>
							<asp:CheckBox ID="chkbxpaymentflag" runat="server" TextAlign="Right" />
							<label class="form-check-label"><strong>Approve Payments?</strong> </label>
						</div>
					</div>--%>
                            <%--<tr>
                                <td colspan="2">
                                    <asp:CheckBox ID="chkbxpaymentflag" runat="server" TextAlign="Right" />
                                    <label class="form-check-label"><strong>Approve Payment</strong> </label>
                                </td>
                            </tr>--%>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <%--<asp:Button ID="btnApprove" runat="server" CssClass="btn btn-sm btn-info" Text="Approve" OnClick="btnApprove_Click" />
     <asp:Button ID="btnBlock" runat="server" CssClass="btn btn-sm btn-warning" Text="Block User" OnClick="btnBlock_Click"/>
     <asp:Button ID="btnDelete" runat="server" CssClass="btn btn-sm btn-outline-danger" Text="Delete" OnClick="btnDelete_Click" />--%>
    <asp:Button ID="btnBack" runat="server" CssClass="btn btn-secondary" Text="Back" OnClick="btnBack_Click"  /> 
    <asp:Button ID="btnDelete" runat="server" CssClass="btn btn-info" Text="Delete" OnClientClick="return confirm('Are you sure to delete?');" OnClick="btnDelete_Click" /> 
    <%--<a href="<%= AllDetails %>" runat="server" class="btn btn-success btn-md">View All Details</a>--%>
    <%--<%= AllDetails %>--%>
</asp:Content>

