using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NpgsqlTypes;
using Mono.Security;
using System.Windows.Forms;

namespace CRM_AddIn
{
    class BusinessLayer
    {
        string connectionString = "Server=192.168.10.1;Port=5432;Database=as3;User Id=root;Password=root";
        

        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public BusinessLayer()
        {

            // connectionString = @"Data Source=PFS-SERVER\PFSLOCAL; Network Library=DBMSSOCN; Initial Catalog=ProfinDatabaseTesting;User ID=Test;Password=pfs";
        }

        #region WORKING CODE

        #region InsertEmail()
        public void InsertEmail(CRM_Comm_class crm_comm)
        {

            NpgsqlConnection conn = new NpgsqlConnection(connectionString);

            NpgsqlCommand cmdInsertEmail = new NpgsqlCommand("INSERT INTO tbl_crm_comm(\"crm_id\", \"crm_details\", \"crm_subject\", \"crm_type\", \"crm_date\", \"crm_date_followup\", \"cl_id\", \"usr_id\", \"cont_id\", \"tsk_id\", \"pol_id\", \"crmg_id\", \"req_id\", \"crm_date_created\") VALUES (@crmID, @details,@crmSubject,@crmType,@crmDate,@crmDateFollowUp, @clID, @usrID, @contID, @tskID, @polID,@crmgID, @reqID, @crmDateCreated)", conn);


            cmdInsertEmail.Parameters.Add(new NpgsqlParameter("@crmID", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters["@crmID"].Value = crm_comm.Crm_id;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter("@details", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters["@details"].Value = crm_comm.Crm_details;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter("@crmSubject", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters["@crmSubject"].Value = crm_comm.Crm_subject;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter("@crmDate", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters["@crmDate"].Value = crm_comm.Crm_date;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter("@clID", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters["@clID"].Value = crm_comm.Cl_id;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter("@polID", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters["@polID"].Value = crm_comm.Pol_id;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter("@crmgID", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters["@crmgID"].Value = crm_comm.Crmg_id;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter("@crmDateCreated", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters["@crmDateCreated"].Value = crm_comm.Crm_date_created;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter("@crmType", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters["@crmType"].Value = crm_comm.Crm_type;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter("@crmDateFollowUp", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters["@crmDateFollowUp"].Value = crm_comm.Crm_date_followup;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter("@usrID", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters["@usrID"].Value = crm_comm.Usr_id;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter("@contID", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters["@contID"].Value = crm_comm.Cont_id;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter("@tskID", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters["@tskID"].Value = crm_comm.Tsk_id;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter("@reqID", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters["@reqID"].Value = crm_comm.Req_id;

            try
            {
                conn.Open();
                cmdInsertEmail.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw new ApplicationException("Error Inserting Text \n" + ex.Message);

            }
            conn.Close();

        }
        #endregion

        #region InsertTask
        public void InsertTask(TaskClass task)
        {

            NpgsqlConnection conn = new NpgsqlConnection(connectionString);

            NpgsqlCommand cmdInsertEmail = new NpgsqlCommand("INSERT INTO tbl_task(\"tsk_id\",\"tsk_subject\",\"tsk_details\",\"tsk_date_start\",\"tsk_date_due\",\"tsk_private\",\"tsk_status\",\"tsk_priority\",\"tsk_perc_complete\",\"tsk_type\",\"usr_id\",\"cl_id\",\"cont_id\",\"req_id\",\"crmg_id\",\"crm_id\",\"tsk_update_usr_id\",\"tsk_update_date\") VALUES(:tsk_id,:tsk_subject,:tsk_details,:tsk_date_start,:tsk_date_due,:tsk_private,:tsk_status,:tsk_priority,:tsk_perc_complete,:tsk_type,:usr_id,:cl_id,:cont_id,:req_id,:crmg_id,:crm_id,:tsk_update_usr_id,:tsk_update_date)", conn);

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter(":tsk_id", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters[":tsk_id"].Value = task.Tsk_id;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter(":tsk_subject", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters[":tsk_subject"].Value = task.Tsk_subject;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter(":tsk_details", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters[":tsk_details"].Value = task.Tsk_details;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter(":tsk_date_start", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters[":tsk_date_start"].Value = task.Crm_date_start;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter(":tsk_date_due", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters[":tsk_date_due"].Value = task.Crm_date_due;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter(":tsk_private", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters[":tsk_private"].Value = task.Tsk_private;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter(":tsk_status", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters[":tsk_status"].Value = task.Tsk_status;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter(":tsk_priority", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters[":tsk_priority"].Value = task.Tsk_priority;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter(":tsk_perc_complete", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters[":tsk_perc_complete"].Value = task.Tsk_perc_complete;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter(":tsk_type", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters[":tsk_type"].Value = task.Tsk_type;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter(":usr_id", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters[":usr_id"].Value = task.Usr_id;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter(":cl_id", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters[":cl_id"].Value = task.Cl_id;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter(":cont_id", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters[":cont_id"].Value = task.Cont_id;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter(":req_id", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters[":req_id"].Value = task.Req_id;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter(":crmg_id", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters[":crmg_id"].Value = task.Crmg_id;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter(":crm_id", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters[":crm_id"].Value = task.Crm_id;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter(":tsk_update_usr_id", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters[":tsk_update_usr_id"].Value = task.Tsk_update_usr_id;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter(":tsk_update_date", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters[":tsk_update_date"].Value = task.Tsk_update_date;

            //try
            //{
            conn.Open();
            cmdInsertEmail.ExecuteNonQuery();
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    throw new ApplicationException("Error Inserting Text \n" + ex.Message);

            //}
            conn.Close();

        }
        #endregion

        #region UpdateTaskDates
        public void UpdateTaskDates(TaskClass task)
        {

            NpgsqlConnection conn = new NpgsqlConnection(connectionString);

            NpgsqlCommand cmdInsertEmail = new NpgsqlCommand("UPDATE tbl_task SET \"tsk_date_start\" = :start, \"tsk_date_due\" = :due, \"crm_id\" = :crm_id  WHERE \"tsk_id\" = :id", conn);


            cmdInsertEmail.Parameters.Add(new NpgsqlParameter(":start", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters[":start"].Value = task.Crm_date_start;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter(":due", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters[":due"].Value = task.Crm_date_due;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter(":id", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters[":id"].Value = task.Tsk_id;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter(":crm_id", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters[":crm_id"].Value = task.Crm_id;


            try
            {
                conn.Open();
                cmdInsertEmail.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw new ApplicationException("Error Inserting Text \n" + ex.Message);

            }
            conn.Close();

        }
        #endregion

        #region CheckTask
        public DataTable CheckTask(string crmg_id)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            DataTable dt = new DataTable();
            conn.Open();
            NpgsqlDataAdapter dtAdapter = new NpgsqlDataAdapter("SELECT * FROM tbl_task WHERE \"crmg_id\" = :crmgID ORDER BY tsk_update_date DESC", conn);
            dtAdapter.SelectCommand.Parameters.Add(":crmgID", crmg_id);

            dtAdapter.Fill(dt);
            conn.Close();
            return dt;
        }
        #endregion

        #region EndTask
        public void EndTask(TaskClass task)
        {

            NpgsqlConnection conn = new NpgsqlConnection(connectionString);

            NpgsqlCommand cmdInsertEmail = new NpgsqlCommand("UPDATE tbl_task SET \"tsk_perc_complete\" = :comp, \"tsk_status\" = :stat WHERE \"tsk_id\" = :id", conn);


            cmdInsertEmail.Parameters.Add(new NpgsqlParameter(":comp", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters[":comp"].Value = task.Tsk_perc_complete;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter(":id", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters[":id"].Value = task.Tsk_id;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter(":stat", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters[":stat"].Value = task.Tsk_status;

            try
            {
                conn.Open();
                cmdInsertEmail.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw new ApplicationException("Error Inserting Text \n" + ex.Message);

            }
            conn.Close();

        }

        #endregion

        #region DataTableGetCRMSubjectByCrmID
        public DataTable DataTableGetCRMSubjectByCrmID(string crmID)
        {

            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            DataTable dt = new DataTable();
            conn.Open();
            NpgsqlDataAdapter dtAdapter = new NpgsqlDataAdapter("SELECT * FROM tbl_crm_group WHERE \"crmg_id\" = :crmID", conn);
            dtAdapter.SelectCommand.Parameters.Add(":crmID", crmID);
            dtAdapter.Fill(dt);
            conn.Close();
            return dt;
        }
        #endregion

        #region DataTableGetClient
        public DataTable DataTableGetClient(string crm)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            DataTable dt = new DataTable();
            conn.Open();
            NpgsqlDataAdapter dtAdapter = new NpgsqlDataAdapter("SELECT tbl_client.cl_id, cl_firstName ||' ' || cl_surname as client, pol_id, tbl_crm_group.crmg_id, tbl_crm_group.crmg_subject FROM tbl_client, tbl_crm_group WHERE " +
                                                                "\"crmg_ref_num\" = :crm AND tbl_crm_group.\"cl_id\" = tbl_client.\"cl_id\" ", conn);
            dtAdapter.SelectCommand.Parameters.Add(":crm", crm);

            dtAdapter.Fill(dt);
            conn.Close();
            return dt;
        }
        #endregion

        #region DataTableGetPolicyProduct
        public DataTable DataTableGetPolicyProduct(string polID)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            DataTable dt = new DataTable();
            conn.Open();
            NpgsqlDataAdapter dtAdapter = new NpgsqlDataAdapter("SELECT tbl_product.prod_id, prod_code FROM tbl_policy, tbl_product WHERE tbl_policy.\"pol_id\" = :pol AND " +
                                                                "tbl_policy.\"prod_id\" = tbl_product.\"prod_id\" ", conn);
            dtAdapter.SelectCommand.Parameters.Add(":pol", polID);
            dtAdapter.Fill(dt);
            conn.Close();
            return dt;
        }
        #endregion

        #region DataTableGetCRMFollowupDate
        public DataTable DataTableGetCRMFollowupDate(string crmg_id)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            DataTable dt = new DataTable();
            conn.Open();
            NpgsqlDataAdapter dtAdapter = new NpgsqlDataAdapter("SELECT crm_date_followup FROM tbl_crm_comm WHERE \"crmg_id\" = :crmgID ORDER BY crm_date_followup DESC", conn);
            dtAdapter.SelectCommand.Parameters.Add(":crmgID", crmg_id);
            dtAdapter.Fill(dt);
            conn.Close();
            return dt;
        }
        #endregion

        #region InsertPolicyDoc()
        public void InsertPolicyDoc(Policy_Document pdoc)
        {

            NpgsqlConnection conn = new NpgsqlConnection(connectionString);

            NpgsqlCommand cmdInsertEmail = new NpgsqlCommand("INSERT INTO tbl_policy_document(\"pdoc_id\", \"pdoc_title\", \"pdoc_desc\", \"pdoc_path\", \"pdoc_date_added\", \"pol_id\", \"cl_id\", \"crmg_id\", \"crmg_ref_num\")" +
                                                                " VALUES (@pdoc_id, @pdoc_title,@pdoc_desc,@pdoc_path,@pdoc_date_added,@pol_id, @cl_id, @crmg_id, @crmg_ref_num)", conn);


            cmdInsertEmail.Parameters.Add(new NpgsqlParameter("@pdoc_id", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters["@pdoc_id"].Value = pdoc.Pdoc_id;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter("@pdoc_title", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters["@pdoc_title"].Value = pdoc.Pdoc_title;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter("@pdoc_desc", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters["@pdoc_desc"].Value = pdoc.Pdoc_desc;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter("@pdoc_path", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters["@pdoc_path"].Value = pdoc.Pdoc_path;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter("@pdoc_date_added", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters["@pdoc_date_added"].Value = pdoc.Pdoc_date_added;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter("@pol_id", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters["@pol_id"].Value = pdoc.Pol_id;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter("@cl_id", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters["@cl_id"].Value = pdoc.Cl_id;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter("@crmg_id", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters["@crmg_id"].Value = pdoc.Crmg_id;

            cmdInsertEmail.Parameters.Add(new NpgsqlParameter("@crmg_ref_num", NpgsqlDbType.Text));
            cmdInsertEmail.Parameters["@crmg_ref_num"].Value = pdoc.Crmg_ref_num;

            try
            {
                conn.Open();
                cmdInsertEmail.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw new ApplicationException("Error Inserting Text \n" + ex.Message);

            }
            conn.Close();

        }
        #endregion

        #endregion
    }
}
