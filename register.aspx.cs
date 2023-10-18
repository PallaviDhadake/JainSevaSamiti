using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class register : System.Web.UI.Page
{
    iClass c = new iClass();
    public string fullname;
    protected void Page_Load(object sender, EventArgs e)
    {
        
            btnSubmit.Attributes.Add("onclick", "this.disabled=true; this.value='Processing...';" + ClientScript.GetPostBackEventReference(btnSubmit, null) + ";");
        // btnCancel.Attributes.Add("onclick", "this.disabled=true; this.value='Processing...';" + ClientScript.GetPostBackEventReference(btnCancel, null) + ";");

        if (!IsPostBack)
        {
            c.FillComboBox("stateName", "stateId", "StatesData", "", "stateName", 0, ddrState);

           // ScriptManager.RegisterClientScriptBlock(this, GetType(), "myCalendarScript", "myCalendar();", true);
        }

        fullname = txtFname.Text +" "+ txtMname.Text +" "+ txtLname.Text;

    }

    //protected void UpdatePanel1_Load(object sender, EventArgs e)
    //{
    //    ScriptManager.RegisterClientScriptBlock(this, GetType(), "myCalendarScript", "myCalendar();", true);
    //}

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            txtAddress.Text = txtAddress.Text.Trim().Replace("'", "");
            txtBirthPlace.Text = txtBirthPlace.Text.Trim().Replace("'", "");
            txtBirthTime.Text = txtBirthTime.Text.Trim().Replace("'", "");
            txtCity.Text = txtCity.Text.Trim().Replace("'", "");
            txtDistrict.Text = txtDistrict.Text.Trim().Replace("'", "");
            txtFather.Text = txtFather.Text.Trim().Replace("'", "");
            txtFname.Text = txtFname.Text.Trim().Replace("'", "");
            txtLname.Text = txtLname.Text.Trim().Replace("'", "");
            txtMname.Text = txtMname.Text.Trim().Replace("'", "");
            txtMobile.Text = txtMobile.Text.Trim().Replace("'", "");
            txtMother.Text = txtMother.Text.Trim().Replace("'", "");
            txtWhatsapp.Text = txtWhatsapp.Text.Trim().Replace("'", "");
            txtSubCast.Text = txtSubCast.Text.Trim().Replace("'", "");
            txtEducation.Text = txtEducation.Text.Trim().Replace("'", "");
            txtBirthDate.Text = txtBirthDate.Text.Trim().Replace("'", "");
            txtJobBusins.Text = txtJobBusins.Text.Trim().Replace("'", "");
            txtMonthIncom.Text= txtMonthIncom.Text.Trim().Replace("'", "");
            txtPartExcept.Text = txtPartExcept.Text.Trim().Replace("'", "");
            txtFarm.Text= txtFarm.Text.Trim().Replace("'", "");
            txtFullName.Text = txtFullName.Text.Trim().Replace("'", "");
            txtBrother.Text = txtBrother.Text.Trim().Replace("'", "");
            txtmarridbro.Text = txtmarridbro.Text.Trim().Replace("'", "");


            if (txtAddress.Text == "" || txtBirthPlace.Text == "" || txtBirthTime.Text == "" || txtCity.Text == ""|| txtDistrict.Text==""|| txtFather.Text==""|| txtFname.Text==""|| txtLname.Text==""|| txtMname.Text==""|| txtMobile.Text==""|| txtMother.Text==""|| txtWhatsapp.Text==""|| txtBirthDate.Text==""|| txtEducation.Text==""|| txtSubCast.Text==""|| txtMonthIncom.Text==""|| txtJobBusins.Text==""|| txtPartExcept.Text==""|| txtFullName.Text==""|| ddrGender.SelectedIndex==0|| ddrState.SelectedIndex==0||ddrColor.SelectedIndex==0||ddrGender.SelectedIndex==0 || fuimage.HasFile==false)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'All * marked fields are mandatory');", true);
                return;
            }

            else if (c.ValidateMobile(txtMobile.Text) == false)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Enter  Valid Mobile No');", true);
                return;
            }
            else if (c.ValidateMobile(txtWhatsapp.Text) == false)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Enter  Valid WhatsApp No');", true);
                return;
            }

            DateTime BrDate = DateTime.Now;
            string[] arrTDate = txtBirthDate.Text.Split('/');
            if (c.IsDate(arrTDate[1] + "/" + arrTDate[0] + "/" + arrTDate[2]) == false)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Enter Valid Birth Date');", true);
                return;
            }
            else
            {
                BrDate = Convert.ToDateTime(arrTDate[1] + "/" + arrTDate[0] + "/" + arrTDate[2]);
            }

            int maxId = c.NextId("MembersData", "MemberID");
            string fileName = "";

            if (fuimage.HasFile)
            {
                string fExt = Path.GetExtension(fuimage.FileName).ToString().ToLower();
                if (fExt == ".png" || fExt == ".jpg" || fExt == ".jpeg" || fExt == ".gif")
                {
                    fileName = "users-image" + maxId + fExt;
                    ImageUploadProcess(fileName);
                }
                else
                {
                    //ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "showNotification({message: 'Only .png, .jpg, .jpeg and .gif files are allowed', type: 'warning'});", true);
                   // return;
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Only .png, .jpg, .jpeg and .gif files are allowed');", true);
                    return;

                }
            }
            //c.ExecuteQuery("Insert Into MembersData(MemberID, MemJoinDate, MemBrothers, MemBrothersMarry, MemBrothersUnmarry, MemSisters, MemSistersMarry, MemSistersUnmarry, MemFarm, Delmark)Values(" + maxId + ", '" + DateTime.Now + "', '" + txtBrother.Text + "', '" + txtmarridbro.Text + "', '" + txtunmarridbro.Text + "', '" + txtSister.Text + "', '" + txtmarriedSis.Text + "','" + txtunmarriedSis.Text + "', N'" + txtFarm.Text + "', 0)");

            c.ExecuteQuery("Insert Into MembersData(MemberID, MemJoinDate, MemMaritalStatus, MemFName, MemMName, MemLName, MemFullName, MemGender, MemSubCast, MemFatherName, MemMotherName, MemAddress, MemState, MemDistrict, MemCity, MemMobile, MemWhatsApp, MemBirthDate, MemBirthTime, MemBirthPlace, MemHighEdu,  MemHeight, MemColor, MemJob, MemMonthlyIncome, MemPartnerExpectations, MemNameMarathi, MemBrothers, MemBrothersMarry, MemBrothersUnmarry, MemSisters, MemSistersMarry, MemSistersUnmarry, MemFarm, Delmark) Values(" + maxId + ", '" + DateTime.Now + "', 'Unmarried', N'" + txtFname.Text + "', N'" + txtMname.Text + "', N'" + txtLname.Text + "', N'" + fullname.ToString() + "', " + ddrGender.SelectedValue + ", N'" + txtSubCast.Text + "', N'" + txtFather.Text + "', N'" + txtMother.Text + "', N'" + txtAddress.Text + "', " + ddrState.SelectedValue + ", N'" + txtDistrict.Text + "', N'" + txtCity.Text + "', N'" + txtMobile.Text + "', N'" + txtWhatsapp.Text + "', '" + BrDate + "', N'" + txtBirthTime.Text + "', N'" + txtBirthPlace.Text + "', N'" + txtEducation.Text + "', '" + ddrHieght.SelectedItem.Text + "', '" + ddrColor.SelectedItem.Text + "', N'" + txtJobBusins.Text + "', N'" + txtMonthIncom.Text + "', N'" + txtPartExcept.Text + "', N'" + txtFullName.Text + "', '" + txtBrother.Text + "', '" + txtmarridbro.Text + "', '" + txtunmarridbro.Text + "', '" + txtSister.Text + "', '" + txtmarriedSis.Text + "', '" + txtunmarriedSis.Text + "', N'" + txtFarm.Text + "', 0)");

            if (fuimage.HasFile)
            {
                c.ExecuteQuery("Update MembersData Set MemPhoto='" + fileName + "' Where MemberID=" + maxId);
            }


            txtAddress.Text = txtBirthDate.Text = txtBirthPlace.Text = txtBirthTime.Text = txtCity.Text = txtDistrict.Text = txtEducation.Text = txtEducation.Text = txtFather.Text = txtFname.Text = txtLname.Text = txtMname.Text = txtMobile.Text = txtMother.Text = txtSubCast.Text = txtWhatsapp.Text = txtPartExcept.Text= txtJobBusins.Text= txtMonthIncom.Text= txtFullName.Text=txtBrother.Text=txtmarridbro.Text=txtunmarridbro.Text=txtSister.Text=txtmarriedSis.Text=txtunmarriedSis.Text=txtFarm.Text="";
            ddrGender.SelectedIndex =  ddrState.SelectedIndex = ddrHieght.SelectedIndex= ddrColor.SelectedIndex= 0;
           // fuimage.HasFile == false;

            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Your Registration submitted successfully.');", true);

        }
        catch(Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "btnSubmit_Click", ex.Message.ToString());
            return;
        }
    }


    private void ImageUploadProcess(string imgName)
    {
        try
        {
            string rootPath = c.ReturnHttp();
            string origImgPath = "~/Upload/users/original/";
            string thumbImgPath = "~/Upload/users/thumb/";
            string normalImgPath = "~/Upload/users/";

            fuimage.SaveAs(Server.MapPath(origImgPath) + imgName);
            c.ImageOptimizer(imgName, origImgPath, normalImgPath, 800, true);
            c.ImageOptimizer(imgName, normalImgPath, thumbImgPath, 400, true);
            //c.ImageOptimizer(imgName, origImgPath, thumbImgPath, 400, false);

            File.Delete(Server.MapPath(origImgPath) + imgName);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "btnSubmit_Click", ex.Message.ToString());
            return;
        }
    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("index.html");
    }
}