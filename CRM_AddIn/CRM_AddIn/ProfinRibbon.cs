using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Word;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Data;
using System.Windows.Forms;

namespace CRM_AddIn
{
    public partial class ProfinRibbon
    {
        BusinessLayer bl = new BusinessLayer();
        EmailClass email = new EmailClass();
        string crm;
        string crmFormatSend = "CRM - ";
        string crmFormatReceive = "RE: CRM - ";
        string crmFormatForward = "FW: CRM - ";
        //bool ErrorShowed = false;

        private void ProfinRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnProviderRecieved_Click(object sender, RibbonControlEventArgs e)
        {
            //Get the current ActiveExplorer 
            Microsoft.Office.Interop.Outlook.Explorer objExplorer = Globals.ThisAddIn.Application.ActiveExplorer();

            //Get the current MailItem 
            Microsoft.Office.Interop.Outlook.MailItem mailItem = objExplorer.Selection[1] as Microsoft.Office.Interop.Outlook.MailItem;

            //Get the current TaskItem
            Microsoft.Office.Interop.Outlook.TaskItem taskItem = objExplorer.Selection[1] as Microsoft.Office.Interop.Outlook.TaskItem;

            //Get current ContactItem 
            Microsoft.Office.Interop.Outlook.ContactItem contactItem = objExplorer.Selection[1] as Microsoft.Office.Interop.Outlook.ContactItem;

            //Get the current AppointmentItem
            Microsoft.Office.Interop.Outlook.AppointmentItem appointmentItem = objExplorer.Selection[1] as Microsoft.Office.Interop.Outlook.AppointmentItem;

            Microsoft.Office.Interop.Outlook.Inspector inspector = null;

            if (mailItem != null)
            {
                //Obtain Inspector object for the current MailItem
                inspector = mailItem.GetInspector;
            }
            else if (taskItem != null)
            {
                //Obtain Inspector object for the current TaskItem
                inspector = taskItem.GetInspector;
            }
            else if (contactItem != null)
            {
                //Obtain Inspector object for the current NoteItem
                inspector = contactItem.GetInspector;
            }
            else if (appointmentItem != null)
            {
                //obtain Inspector object for the current AppointmentItem
                inspector = appointmentItem.GetInspector;
            }

            // Obtain the Document object from the Inspector object
            Document document = (Document)inspector.WordEditor;
            //Store the selected text to a variable
            email.Body = document.Application.Selection.Text;

            email.SenderEmailAddress = mailItem.SenderEmailAddress;
            email.Subject = mailItem.Subject;
            email.EmailDate = Convert.ToDateTime(DateTime.Now.ToString("MM-dd-yyyy HH:mm"));
            //Random random = new Random();
            string bodyLength = Convert.ToString(email.Body.Length);

            try
            {
                crm = email.Subject.Substring(10, 5);
            }
            catch
            {
                MessageBox.Show("Cannot enter CRM: Subject line was in an incorrect format.\n\nFormat: 'RE: CRM - 12345'.\nOR: 'FW: CRM - 12345'", "Incorrect Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string subjectFormat = email.Subject.Substring(0, 10);



            if (subjectFormat == crmFormatReceive || subjectFormat == crmFormatForward)
            {
                #region Attachment

                int attachCount = mailItem.Attachments.Count;
                List<string> fileNames = new List<string>();
                int i = 0;
                if (mailItem.Attachments.Count != 0)
                {
                    foreach (Outlook.Attachment attachment in mailItem.Attachments)
                    {
                        string name = attachment.FileName;
                        string tempPath = @"\\192.168.10.1\TempDocs\";

                        if (mailItem.HTMLBody.Contains(name))
                        {

                        }
                        else
                        {
                            fileNames.Add(name);
                            attachment.SaveAsFile(tempPath + fileNames[i]);
                            i++;
                        }
                    }
                }

                #endregion

                if (bodyLength != "1")
                {
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dt = bl.DataTableGetClient(crm);

                    if (dt.Rows.Count > 0)//CHECKING IF THE CLIENT EXISTS
                    {
                        //frmSelectClient selectClient = new frmSelectClient(email.SenderEmailAddress, email.Body, email.Subject, email.EmailDate);
                        frmCrmProvider crmProv = new frmCrmProvider(email.Body, email.Subject, email.EmailDate, crm, fileNames);
                        crmProv.ShowDialog();
                        //bl.InsertEmail(email);
                        //MessageBox.Show("Text Successfully Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("CRM does not exist", "No CRM Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dt = bl.DataTableGetClient(crm);

                    if (dt.Rows.Count > 0)//CHECKING IF THE CLIENT EXISTS
                    {

                        email.Body = mailItem.Body;
                        frmCrmProvider crmProv = new frmCrmProvider(email.Body, email.Subject, email.EmailDate, crm, fileNames);
                        crmProv.ShowDialog();
                        //MessageBox.Show("Nothing was selected.\n\nPlease select text from the email body.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        MessageBox.Show("CRM does not exist", "No CRM Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Cannot enter CRM: Subject line was in an incorrect format.\n\nFormat: 'RE: CRM - 12345'.\nOR: 'FW: CRM - 12345'", "Incorrect Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProviderSend_Click(object sender, RibbonControlEventArgs e)
        {
            //Get the current ActiveExplorer 
            Microsoft.Office.Interop.Outlook.Explorer objExplorer = Globals.ThisAddIn.Application.ActiveExplorer();

            //Get the current MailItem 
            Microsoft.Office.Interop.Outlook.MailItem mailItem = objExplorer.Selection[1] as Microsoft.Office.Interop.Outlook.MailItem;

            //Get the current TaskItem
            Microsoft.Office.Interop.Outlook.TaskItem taskItem = objExplorer.Selection[1] as Microsoft.Office.Interop.Outlook.TaskItem;

            //Get current ContactItem 
            Microsoft.Office.Interop.Outlook.ContactItem contactItem = objExplorer.Selection[1] as Microsoft.Office.Interop.Outlook.ContactItem;

            //Get the current AppointmentItem
            Microsoft.Office.Interop.Outlook.AppointmentItem appointmentItem = objExplorer.Selection[1] as Microsoft.Office.Interop.Outlook.AppointmentItem;

            Microsoft.Office.Interop.Outlook.Inspector inspector = null;

            if (mailItem != null)
            {
                //Obtain Inspector object for the current MailItem
                inspector = mailItem.GetInspector;
            }
            else if (taskItem != null)
            {
                //Obtain Inspector object for the current TaskItem
                inspector = taskItem.GetInspector;
            }
            else if (contactItem != null)
            {
                //Obtain Inspector object for the current NoteItem
                inspector = contactItem.GetInspector;
            }
            else if (appointmentItem != null)
            {
                //obtain Inspector object for the current AppointmentItem
                inspector = appointmentItem.GetInspector;
            }

            // Obtain the Document object from the Inspector object
            Document document = (Document)inspector.WordEditor;
            //Store the selected text to a variable
            email.Body = document.Application.Selection.Text;

            //email.SenderEmailAddress = mailItem.SenderEmailAddress;
            email.Subject = mailItem.Subject;
            email.EmailDate = Convert.ToDateTime(DateTime.Now.ToString("MM-dd-yyyy hh:mm"));
            //Random random = new Random();
            string bodyLength = Convert.ToString(email.Body.Length);

            try
            {
                crm = email.Subject.Substring(6, 5);
            }
            catch
            {
                MessageBox.Show("Cannot enter CRM: Subject line was in an incorrect format.\n\nFormat: CRM - 12345.\n\n", "Incorrect Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string subjectFormat = email.Subject.Substring(0, 6);




            if (subjectFormat == crmFormatSend)
            {
                #region Attachment

                int attachCount = mailItem.Attachments.Count;
                List<string> fileNames = new List<string>();
                int i = 0;
                if (mailItem.Attachments.Count != 0)
                {
                    foreach (Outlook.Attachment attachment in mailItem.Attachments)
                    {
                        string name = attachment.FileName;
                        string tempPath = @"\\192.168.10.1\TempDocs\";

                        if (mailItem.HTMLBody.Contains(name))
                        {

                        }
                        else
                        {
                            fileNames.Add(name);
                            attachment.SaveAsFile(tempPath + fileNames[i]);
                            i++;
                        }
                    }
                }

                #endregion

                if (bodyLength != "1")
                {
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dt = bl.DataTableGetClient(crm);

                    if (dt.Rows.Count > 0)//CHECKING IF THE CLIENT EXISTS
                    {


                        //frmSelectClient selectClient = new frmSelectClient(email.SenderEmailAddress, email.Body, email.Subject, email.EmailDate);
                        frmCrmProvider crmProv = new frmCrmProvider(email.Body, email.Subject, email.EmailDate, crm,fileNames);
                        crmProv.ShowDialog();
                        //bl.InsertEmail(email);
                        //MessageBox.Show("Text Successfully Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("CRM does not exist", "No CRM Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dt = bl.DataTableGetClient(crm);

                    if (dt.Rows.Count > 0)//CHECKING IF THE CLIENT EXISTS
                    {

                        email.Body = mailItem.Body;
                        frmCrmProvider crmProv = new frmCrmProvider(email.Body, email.Subject, email.EmailDate, crm,fileNames);
                        crmProv.ShowDialog();
                        //MessageBox.Show("Nothing was selected.\n\nPlease select text from the email body.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        MessageBox.Show("CRM does not exist", "No CRM Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Cannot enter CRM: Subject line was in an incorrect format.\n\nFormat: CRM - 12345.", "Incorrect Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        }
    }

