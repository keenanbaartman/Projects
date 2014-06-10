using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace CRM_AddIn
{
    public partial class frmCrmProvider : Form
    {
        string eAdress, eDetails, eSubject, eCrm;
        DateTime eDate;
        BusinessLayer bl = new BusinessLayer();
        CRM_Comm_class crm_comm = new CRM_Comm_class();
        PolicyClass pol = new PolicyClass();
        TaskClass task = new TaskClass();
        Policy_Document pDoc = new Policy_Document();

        
        string newFileName;
        List<string> fileNamesList = new List<string>();
        string tempPath = @"\\192.168.10.1\TempDocs\";

        public frmCrmProvider(string emailDetails, string emailSubject, DateTime emailDate, string crm, List<string> names)
        {  
            eDetails = emailDetails;
            eSubject = emailSubject;
            eDate = emailDate;
            eCrm = crm;
            fileNamesList = names;
            InitializeComponent();
        }

        private void tlsSubmit_Click(object sender, EventArgs e)
        {
            crm_comm.Crm_date_followup = dtpFollowup.Text + " " + cmbHours.Text + ":" + cmbMinutes.Text;
            task.Crm_date_due = crm_comm.Crm_date_followup;
            task.Crm_date_start = crm_comm.Crm_date_followup;

            //pol.PolDateFollowup = crm_comm.Crm_date_followup;
            //pol.PolID = crm_comm.Pol_id;
            //bl.UpdatePolicyFollowUpDate(pol);

            if (chkFollowUp.Checked == true)
            {
                DataTable dtCheckTask = new DataTable();
                dtCheckTask = bl.CheckTask(crm_comm.Crmg_id);

                DataTable dtSubject = new DataTable();
                dtSubject = bl.DataTableGetCRMSubjectByCrmID(crm_comm.Crmg_id);
                string crmSubject = dtSubject.Rows[0]["crmg_subject"].ToString();
                task.Tsk_subject = "FollowUp on: " + crmSubject;
                task.Tsk_details = "FollowUp on: " + crmSubject;

                if (dtCheckTask.Rows.Count > 0)
                {
                    string tskID = dtCheckTask.Rows[0]["tsk_id"].ToString();
                    crm_comm.Tsk_id = tskID;
                    task.Tsk_id = tskID;
                    task.Tsk_update_date = DateTime.Now.ToString("MM-dd-yyyy HH:mm");
                    task.Crm_id = crm_comm.Crm_id;

                    bl.UpdateTaskDates(task);
                    bl.InsertEmail(crm_comm);
                }
                else
                {

                    bl.InsertEmail(crm_comm);
                    Guid gd = Guid.NewGuid();
                    task.Tsk_id = gd.ToString();
                    task.Tsk_subject = "FollowUp on: " + crmSubject;
                    task.Tsk_details = "FollowUp on: " + crmSubject;
                    task.Tsk_update_date = DateTime.Now.ToString("MM-dd-yyyy HH:mm");
                    task.Crmg_id = crm_comm.Crmg_id;
                    task.Crm_id = crm_comm.Crmg_id;
                    bl.InsertTask(task);
                }

                #region Save Attachment

                if(fileNamesList.Count != 0)
                {

                    for (int i = 0; i < fileNamesList.Count; i++)
                    {
                        newFileName = @"\\192.168.10.1\AS3 Documents\" + fileNamesList[i];

                        if(File.Exists(newFileName = @"\\192.168.10.1\AS3 Documents\" + fileNamesList[i]) == true)
                        {
                            newFileName = @"\\192.168.10.1\AS3 Documents\" + eCrm + " - " + fileNamesList[i];
                        }

                        File.Copy(@"\\192.168.10.1\TempDocs\" + fileNamesList[i], newFileName, true);

                        Guid pdocGui = Guid.NewGuid();
                        pDoc.Pdoc_id = pdocGui.ToString();
                        pDoc.Pdoc_title = txtTitle.Text;
                        pDoc.Pdoc_desc = rchDescription.Text;
                        pDoc.Pdoc_path = "Documents/" + fileNamesList[i];
                        pDoc.Pdoc_date_added = DateTime.Now.ToString("MM-dd-yyyy HH:mm");
                        pDoc.Pol_id = crm_comm.Pol_id;
                        pDoc.Cl_id = crm_comm.Cl_id;
                        pDoc.Crmg_id = crm_comm.Crmg_id;
                        pDoc.Crmg_ref_num = eCrm;
                        try
                        {
                            bl.InsertPolicyDoc(pDoc);
                            File.Delete(tempPath + fileNamesList[i]);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred while trying to save your attachment.\n\n" + ex.Message, "Attachment Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //MessageBox.Show("The attachment has been saved", "Attachment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                #endregion

                this.Close();
                MessageBox.Show("Email Successfully Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (chkFollowUp.Checked == false)
            {
                crm_comm.Crm_date_followup = "1900-01-01";

                #region Save Attachment

                if (fileNamesList.Count != 0)
                {

                    for (int i = 0; i < fileNamesList.Count; i++)
                    {
                        newFileName = @"\\192.168.10.1\AS3 Documents\" + fileNamesList[i];

                        if (File.Exists(newFileName = @"\\192.168.10.1\AS3 Documents\" + fileNamesList[i]) == true)
                        {
                            newFileName = @"\\192.168.10.1\AS3 Documents\" + eCrm + " - " + fileNamesList[i];
                        }

                        File.Copy(@"\\192.168.10.1\TempDocs\" + fileNamesList[i], newFileName, true);

                        Guid pdocGui = Guid.NewGuid();
                        pDoc.Pdoc_id = pdocGui.ToString();
                        pDoc.Pdoc_title = txtTitle.Text;
                        pDoc.Pdoc_desc = rchDescription.Text;
                        pDoc.Pdoc_path = "Documents/" + fileNamesList[i];
                        pDoc.Pdoc_date_added = DateTime.Now.ToString("MM-dd-yyyy HH:mm");
                        pDoc.Pol_id = crm_comm.Pol_id;
                        pDoc.Cl_id = crm_comm.Cl_id;
                        pDoc.Crmg_id = crm_comm.Crmg_id;
                        pDoc.Crmg_ref_num = eCrm;
                        try
                        {
                            bl.InsertPolicyDoc(pDoc);
                            File.Delete(tempPath + fileNamesList[i]);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred while trying to save your attachment.\n\n" + ex.Message, "Attachment Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //MessageBox.Show("The attachment has been saved", "Attachment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                #endregion

                bl.InsertEmail(crm_comm);
                this.Close();
                MessageBox.Show("Email Successfully Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmCrmProvider_Load(object sender, EventArgs e)
        {
            //dtpFollowup.Format = DateTimePickerFormat.Custom;
            //dtpFollowup.CustomFormat = "MM-dd-yyyy";

            DataTable dtClient = new DataTable();
            dtClient = bl.DataTableGetClient(eCrm);
            crm_comm.Cl_id = dtClient.Rows[0]["cl_id"].ToString();
            txtClient.Text = dtClient.Rows[0]["client"].ToString();
            crm_comm.Pol_id = dtClient.Rows[0]["pol_id"].ToString();
            crm_comm.Crmg_id = dtClient.Rows[0]["crmg_id"].ToString();
            txtCrm.Text = eCrm + " - " + dtClient.Rows[0]["crmg_subject"].ToString();

            DataTable dtpolicyProd = new DataTable();
            dtpolicyProd = bl.DataTableGetPolicyProduct(crm_comm.Pol_id);
            //txtPolicy.Text = dtpolicyProd.Rows[0]["prod_code"].ToString();

            DataTable dtFollowup = new DataTable();
            dtFollowup = bl.DataTableGetCRMFollowupDate(crm_comm.Crmg_id);
            crm_comm.Crm_date_followup = dtFollowup.Rows[0]["crm_date_followup"].ToString();

            dtpFollowup.Text = Convert.ToDateTime(crm_comm.Crm_date_followup).ToShortDateString(); //SPLITTING OLD FOLLOWUP DATE INTO CONTROLS
            string currentFollowup = Convert.ToDateTime(crm_comm.Crm_date_followup).ToShortTimeString();
            string[] timeArray = currentFollowup.Split(':');
            cmbHours.Text = timeArray[0];
            cmbMinutes.Text = timeArray[1];




            txtEmail.Text = eDetails;
            crm_comm.Crm_subject = eSubject;
            crm_comm.Crm_details = eDetails;

            crm_comm.Crm_date_created = DateTime.Now.ToString("MM-dd-yyyy HH:mm");
            crm_comm.Crm_date = DateTime.Now.ToString("MM-dd-yyyy HH:mm");


            Guid crmGuid = Guid.NewGuid();
            crm_comm.Crm_id = crmGuid.ToString();
            crm_comm.Crm_type = "99";


            crm_comm.Usr_id = "b5e3bbb5-2ea1-4c3e-b047-f107b8886ae6";
            crm_comm.Cont_id = "null";
            crm_comm.Tsk_id = "null";
            crm_comm.Req_id = "b5e3bbb5-2ea1-4c3e-b047-f107b8886ae6";

            #region Checks If Theres a Task
            DataTable dtCheckTask = new DataTable();
            dtCheckTask = bl.CheckTask(crm_comm.Crmg_id);

            if (dtCheckTask.Rows.Count > 0)
            {
                chkFollowUp.Checked = true;
                string tskID = dtCheckTask.Rows[0]["tsk_id"].ToString();
                task.Tsk_id = tskID;
            }
            else
            {
                chkFollowUp.Checked = false;
            }
            #endregion
            
            for (int i = 0; i < fileNamesList.Count; i++)
            {
                lstAttach.Items.Add(fileNamesList[i]);
            }

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            if (fileNamesList.Count == 0)
            {
                grpAttachment.Enabled = false;

                chkSaveAttachment.Checked = false;
                this.Height = 340;

                //frm.Height = 323;
            }
            else
            {
                chkSaveAttachment.Checked = true;
            }
            //Minette - c858988d-e06f-4616-8b68-cb10f0c7224f
            //Santana - 93d85beb-d01b-47d9-b3d3-112cff42076d
            //Rob - 558943fb-3b4e-48f4-9741-79edaaf96c2e
            //Morne - eebe277f-8d92-40d4-8ba2-9632b7854d6d
        }

        private void tlsQuit_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < fileNamesList.Count; i++)
                {
                    File.Delete(tempPath + fileNamesList[i]);
                }
            }
            catch { }
            this.Close();
        }

        private void chkFollowUp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFollowUp.Checked == true)
            {
                label1.Visible = true;
                label6.Visible = true;
                dtpFollowup.Visible = true;
                cmbHours.Visible = true;
                cmbMinutes.Visible = true;
                //cmbHours.SelectedIndex = 13;
                //cmbMinutes.SelectedIndex = 0;
                lable.Visible = true;
                label5.Visible = true;
                //btnCloseTask.Visible = true;
                //CREATE TASK

                task.Tsk_private = "FALSE";
                task.Tsk_status = "TSK_STAT_InProg";
                task.Tsk_priority = "Medium";
                task.Tsk_perc_complete = "0";
                task.Tsk_type = "99";
                task.Usr_id = crm_comm.Usr_id;
                task.Cl_id = crm_comm.Cl_id;
                task.Cont_id = "''";
                task.Req_id = crm_comm.Usr_id;
                task.Tsk_update_usr_id = crm_comm.Usr_id;
            }
            else if (chkFollowUp.Checked == false)
            {
                label1.Visible = false;
                label6.Visible = false;
                dtpFollowup.Visible = false;
                cmbHours.Visible = false;
                cmbMinutes.Visible = false;
                lable.Visible = false;
                label5.Visible = false;
                //btnCloseTask.Visible = false;
            }

        }

        private void btnCloseTask_Click(object sender, EventArgs e)
        {

        }

        private void frmCrmProvider_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                for (int i = 0; i < fileNamesList.Count; i++)
                {
                    File.Delete(tempPath + fileNamesList[i]);
                }
            }
            catch { }
            //this.Close();
        }

        private void chkSaveAttachment_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSaveAttachment.Checked == true)
            {
                grpAttachment.Enabled = true;
                this.Height = 546;
            }
            else
            {
                grpAttachment.Enabled = false;
                this.Height = 340;
            }
        }

        private void btnCloseTSK_Click(object sender, EventArgs e)
        {
            task.Tsk_perc_complete = "100";
            task.Tsk_status = "TSK_STAT_Complete";
            bl.EndTask(task);
            MessageBox.Show("Task Successfully Closed", "Task Closed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnCloseTSK.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                fileNamesList.Remove(lstAttach.SelectedItem.ToString());
                File.Delete(tempPath + lstAttach.SelectedItem.ToString());
                lstAttach.Items.Clear();
            }
            catch (NullReferenceException ex)
            {
                lstAttach.Items.Clear();
                MessageBox.Show("Nothing was select", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            for (int i = 0; i < fileNamesList.Count; i++)
            {
                lstAttach.Items.Add(fileNamesList[i]);
            }

        }


    }
}
