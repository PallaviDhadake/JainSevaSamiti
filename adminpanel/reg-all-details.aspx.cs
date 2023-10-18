using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class adminpanel_reg_all_details : System.Web.UI.Page
{
    iClass c = new iClass();
    public string mreq, hospdt, rdrUrl, rootPath;
    public string[] orduserData = new string[40];
    protected void Page_Load(object sender, EventArgs e)
    {
        GetUsersData(Convert.ToInt32(Request.QueryString["id"]));
    }


    public void GetUsersData(int Idx)
    {
        try
        {

            using (DataTable dtusers = c.GetDataTable("select * from MembersData where MemberID=" + Idx))

            {
                if (dtusers.Rows.Count > 0)
                {
                    DataRow row = dtusers.Rows[0];

                    
                    orduserData[0] = row["MemMaritalStatus"] != DBNull.Value && row["MemMaritalStatus"] != null && row["MemMaritalStatus"].ToString() != "" ? row["MemMaritalStatus"].ToString() : "NA";

                    orduserData[1] = row["MemFName"] != DBNull.Value && row["MemFName"] != null && row["MemFName"].ToString() != "" ? row["MemFName"].ToString() : "NA";

                    orduserData[2] = row["MemMName"] != DBNull.Value && row["MemMName"] != null && row["MemMName"].ToString() != "" ? row["MemMName"].ToString() : "NA";

                    orduserData[3] = row["MemLName"] != DBNull.Value && row["MemLName"] != null && row["MemLName"].ToString() != "" ? row["MemLName"].ToString() : "NA";


                    orduserData[4] = row["MemFullName"] != DBNull.Value && row["MemFullName"] != null && row["MemFullName"].ToString() != "" ? row["MemFullName"].ToString() : "NA";

                    if (row["MemGender"] != DBNull.Value && row["MemGender"] != null && row["MemGender"].ToString() != "")
                    {
                        if (row["MemGender"].ToString() == "1")
                        {
                            orduserData[5] = "Male";
                        }
                        else
                        {
                            orduserData[5] = "Female";
                        }
                    }
                    else
                    {
                        orduserData[5] = "NA";
                    }
                   
                  
                    orduserData[7] = row["MemSubCast"] != DBNull.Value && row["MemSubCast"] != null && row["MemSubCast"].ToString() != "" ? row["MemSubCast"].ToString() : "NA";

                    orduserData[8] = row["MemFatherName"] != DBNull.Value && row["MemFatherName"] != null && row["MemFatherName"].ToString() != "" ? row["MemFatherName"].ToString() : "NA";

                    orduserData[9] = row["MemMotherName"] != DBNull.Value && row["MemMotherName"] != null && row["MemMotherName"].ToString() != "" ? row["MemMotherName"].ToString() : "NA";

                    orduserData[10] = row["MemAddress"] != DBNull.Value && row["MemAddress"] != null && row["MemAddress"].ToString() != "" ? row["MemAddress"].ToString() : "NA";

                    if (row["MemState"] != DBNull.Value && row["MemState"] != null && row["MemState"].ToString() != "")
                    {
                        string state = c.GetReqData("StatesData", "StateName", "stateId=" + row["MemState"]).ToString();
                        orduserData[11] = state.ToString();
                    }
                    else
                    {
                        orduserData[11] = "NA";
                    }


                    orduserData[12] = row["MemDistrict"] != DBNull.Value && row["MemDistrict"] != null && row["MemDistrict"].ToString() != "" ? row["MemDistrict"].ToString() : "NA";

                    orduserData[13] = row["MemCity"] != DBNull.Value && row["MemCity"] != null && row["MemCity"].ToString() != "" ? row["MemCity"].ToString() : "NA";

                    orduserData[14] = row["MemMobile"] != DBNull.Value && row["MemMobile"] != null && row["MemMobile"].ToString() != "" ? row["MemMobile"].ToString() : "NA";

                    orduserData[15] = row["MemWhatsApp"] != DBNull.Value && row["MemWhatsApp"] != null && row["MemWhatsApp"].ToString() != "" ? row["MemWhatsApp"].ToString() : "NA";

                    orduserData[16] = row["MemBirthDate"] != DBNull.Value && row["MemBirthDate"] != null && row["MemBirthDate"].ToString() != "" ? Convert.ToDateTime(row["MemBirthDate"]).ToString("dd/MM/yyyy") : "NA";

                    orduserData[17] = row["MemBirthTime"] != DBNull.Value && row["MemBirthTime"] != null && row["MemBirthTime"].ToString() != "" ? row["MemBirthTime"].ToString() : "NA";

                    orduserData[18] = row["MemBirthPlace"] != DBNull.Value && row["MemBirthPlace"] != null && row["MemBirthPlace"].ToString() != "" ? row["MemBirthPlace"].ToString() : "NA";

                    orduserData[19] = row["MemHighEdu"] != DBNull.Value && row["MemHighEdu"] != null && row["MemHighEdu"].ToString() != "" ? row["MemHighEdu"].ToString() : "NA";

                    orduserData[21] = row["MemHeight"] != DBNull.Value && row["MemHeight"] != null && row["MemHeight"].ToString() != "" ? row["MemHeight"].ToString() : "NA";
                    
                    orduserData[20] = row["MemColor"] != DBNull.Value && row["MemColor"] != null && row["MemColor"].ToString() != "" ? row["MemColor"].ToString() : "NA";

                    orduserData[22] = row["MemJob"] != DBNull.Value && row["MemJob"] != null && row["MemJob"].ToString() != "" ? row["MemJob"].ToString() : "NA";

                    orduserData[23] = row["MemMonthlyIncome"] != DBNull.Value && row["MemMonthlyIncome"] != null && row["MemMonthlyIncome"].ToString() != "" ? row["MemMonthlyIncome"].ToString() : "NA";

                    orduserData[24] = row["MemPartnerExpectations"] != DBNull.Value && row["MemPartnerExpectations"] != null && row["MemPartnerExpectations"].ToString() != "" ? row["MemPartnerExpectations"].ToString() : "NA";

                    if (row["MemPhoto"] != DBNull.Value && row["MemPhoto"] != null && row["MemPhoto"].ToString() != "")
                    {
                        //string state = c.GetReqData("StatesData", "StateName", "stateId=" + row["MemState"]).ToString();
                        orduserData[25] = "<img src=\""+ Master.rootPath + "Upload/users/thumb/" + row["MemPhoto"].ToString() + "\" alt=\"" + row["MemPhoto"].ToString() + "\" class=\"\" style=\"width:300px; height:auto;\" />";
                    }   
                    else
                    {
                        orduserData[25] = "NA";
                    }

                    orduserData[26] = row["MemNameMarathi"] != DBNull.Value && row["MemNameMarathi"] != null && row["MemNameMarathi"].ToString() != "" ? row["MemNameMarathi"].ToString() : "NA";

                    orduserData[27] = row["MemBrothers"] != DBNull.Value && row["MemBrothers"] != null && row["MemBrothers"].ToString() != "" ? row["MemBrothers"].ToString() : "NA";

                    orduserData[28] = row["MemBrothersMarry"] != DBNull.Value && row["MemBrothersMarry"] != null && row["MemBrothersMarry"].ToString() != "" ? row["MemBrothersMarry"].ToString() : "NA";

                    orduserData[29] = row["MemBrothersUnmarry"] != DBNull.Value && row["MemBrothersUnmarry"] != null && row["MemBrothersUnmarry"].ToString() != "" ? row["MemBrothersUnmarry"].ToString() : "NA";

                    orduserData[30] = row["MemSisters"] != DBNull.Value && row["MemSisters"] != null && row["MemSisters"].ToString() != "" ? row["MemSisters"].ToString() : "NA";

                    orduserData[31] = row["MemSistersMarry"] != DBNull.Value && row["MemSistersMarry"] != null && row["MemSistersMarry"].ToString() != "" ? row["MemSistersMarry"].ToString() : "NA";

                    orduserData[32] = row["MemSistersUnmarry"] != DBNull.Value && row["MemSistersUnmarry"] != null && row["MemSistersUnmarry"].ToString() != "" ? row["MemSistersUnmarry"].ToString() : "NA";

                    orduserData[33] = row["MemFarm"] != DBNull.Value && row["MemFarm"] != null && row["MemFarm"].ToString() != "" ? row["MemFarm"].ToString() : "NA";

                }
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "GetUsersData", ex.Message.ToString());
            return;

        }
    }


    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("registration.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            c.ExecuteQuery("Update MembersData set DelMark=1 where MemberID=" + Request.QueryString["id"]);

            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Record Deleted ');", true);

            ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "waitAndMove('Dashboard.aspx', 2000);", true);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "btnDelete_Click", ex.Message.ToString());
            return;
        }
    }
}