using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminpanel_Dashboard : System.Web.UI.Page
{
    iClass c = new iClass();
    public string[] arrCounts = new string[10];
    protected void Page_Load(object sender, EventArgs e)
    {
        GetCount();
    }

    protected void GetCount()
    {
        try
        {

            arrCounts[1] = c.returnAggregate("Select Count(MemberID) From MembersData where MemGender=1 AND DelMark=0").ToString();
            arrCounts[2] = c.returnAggregate("Select Count(MemberID) From MembersData where MemGender=2 AND DelMark=0").ToString();
            //arrCounts[4] = c.returnAggregate("Select Count(Hosp_ReqID) From HospRequirements where Hosp_ReqStatus=0 AND DelMark=0").ToString();
            //arrCounts[5] = c.returnAggregate("Select Count(ImageID) From ImagesData where DelMark=0 ").ToString();
            //arrCounts[6] = c.returnAggregate("Select Count(ReqID) From RequirementsData where DelMark=0").ToString();
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "FillGrid", ex.Message.ToString());
            return;

        }
    }
}