using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class adminpanel_registration_details : System.Web.UI.Page
{
    iClass c = new iClass();
    public string pgTitle;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["type"] == "var")
            {
                pgTitle = "Var Registration Information";
            }
            else if (Request.QueryString["type"] == "vadhu")
            {
                pgTitle = "Vadhu Registration Information";
            }
            else
            {
                pgTitle = "Registrations";
            }
            //pgTitle = "Registrations";
            FillGrid();


            // pgTitle = Request.QueryString["type"] == "new" ? "New Registration" : "Active Clients";

        }
    }

    private void FillGrid()
    {

        try
        {
            string strQuery = "";
            if (Request.QueryString["type"] != null)
            {
                switch (Request.QueryString["type"])
                {
                    case "var":
                        strQuery = "Select MemberID, Convert(varchar(20), MemJoinDate, 103) as MemJoinDate, MemFullName, MemCity, MemSubCast, MemMobile From MembersData where MemGender=1 AND DelMark=0 ORDER BY MemberID DESC";
                        break;

                    case "vadhu":
                        strQuery = "Select MemberID, Convert(varchar(20), MemJoinDate, 103) as MemJoinDate, MemFullName, MemCity, MemSubCast, MemMobile From MembersData where MemGender=2 AND DelMark=0 ORDER BY MemberID DESC";
                        break;
                }
            }
            else
            {
                strQuery = "Select MemberID, Convert(varchar(20), MemJoinDate, 103) as MemJoinDate, MemFullName, MemCity, MemSubCast, MemMobile From MembersData where DelMark=0 ORDER BY MemberID DESC";
                pgTitle = "All Registration";
            }

            using (DataTable dtreg = c.GetDataTable(strQuery))
            {
                gvregistration.DataSource = dtreg;
                gvregistration.DataBind();
                if (gvregistration.Rows.Count > 0)
                {
                    gvregistration.UseAccessibleHeader = true;
                    gvregistration.HeaderRow.TableSection = TableRowSection.TableHeader;
                }

            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "FillGrid", ex.Message.ToString());
            return;
        }
    }


    protected void gvregistration_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Literal litAnch = (Literal)e.Row.FindControl("litAnch");
                litAnch.Text = "<a href=\"reg-all-details.aspx?id=" + e.Row.Cells[0].Text + "\" class=\"gView\" title=\"View/Edit\"></a>";

                // New=0, Active=1 [HospStatus] from HospitalData

                //object status = c.GetReqData("HospitalData", "HospStatus", "HospID=" + e.Row.Cells[0].Text);

                //Literal litStatus = (Literal)e.Row.FindControl("litstatus");
                //switch (status.ToString())
                //{
                //    case "0":
                //        litStatus.Text = "<div class=\"PendAnch txtCenter\">New</div>";
                //        break;
                //    case "1":
                //        litStatus.Text = "<div class=\"ApprovAnch txtCenter\">Active</div>";
                //        break;
                //    case "2":
                //        litStatus.Text = "<div class=\"BlockAnch txtCenter\">Blocked</div>";
                //        break;

                //}

            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "gvregistration_RowDataBound", ex.Message.ToString());
            return;
        }

    }

}