namespace CRM_AddIn
{
    partial class frmCrmProvider
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrmProvider));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tlsQuit = new System.Windows.Forms.ToolStripButton();
            this.tlsSubmit = new System.Windows.Forms.ToolStripButton();
            this.lblHeading = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.txtCrm = new System.Windows.Forms.TextBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.chkFollowUp = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMinutes = new System.Windows.Forms.ComboBox();
            this.cmbHours = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFollowup = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grpAttachment = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lstAttach = new System.Windows.Forms.ListBox();
            this.rchDescription = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpCRM = new System.Windows.Forms.GroupBox();
            this.btnCloseTSK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chkSaveAttachment = new System.Windows.Forms.CheckBox();
            this.tsMenu.SuspendLayout();
            this.grpAttachment.SuspendLayout();
            this.grpCRM.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.AllowMerge = false;
            this.tsMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsMenu.BackgroundImage")));
            this.tsMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsQuit,
            this.tlsSubmit});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(832, 54);
            this.tsMenu.TabIndex = 96;
            // 
            // tlsQuit
            // 
            this.tlsQuit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tlsQuit.Image = ((System.Drawing.Image)(resources.GetObject("tlsQuit.Image")));
            this.tlsQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsQuit.Name = "tlsQuit";
            this.tlsQuit.Size = new System.Drawing.Size(36, 51);
            this.tlsQuit.Text = "Quit";
            this.tlsQuit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlsQuit.Click += new System.EventHandler(this.tlsQuit_Click);
            // 
            // tlsSubmit
            // 
            this.tlsSubmit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tlsSubmit.Image = ((System.Drawing.Image)(resources.GetObject("tlsSubmit.Image")));
            this.tlsSubmit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsSubmit.Name = "tlsSubmit";
            this.tlsSubmit.Size = new System.Drawing.Size(49, 51);
            this.tlsSubmit.Text = "Submit";
            this.tlsSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlsSubmit.Click += new System.EventHandler(this.tlsSubmit_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(315, 54);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(167, 25);
            this.lblHeading.TabIndex = 103;
            this.lblHeading.Text = "CRM Summary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 102;
            this.label3.Text = "CRM:";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(11, 19);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(41, 15);
            this.lblClient.TabIndex = 100;
            this.lblClient.Text = "Client:";
            // 
            // txtCrm
            // 
            this.txtCrm.Enabled = false;
            this.txtCrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrm.Location = new System.Drawing.Point(146, 45);
            this.txtCrm.Name = "txtCrm";
            this.txtCrm.Size = new System.Drawing.Size(258, 20);
            this.txtCrm.TabIndex = 99;
            // 
            // txtClient
            // 
            this.txtClient.Enabled = false;
            this.txtClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClient.Location = new System.Drawing.Point(146, 19);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(258, 20);
            this.txtClient.TabIndex = 97;
            // 
            // chkFollowUp
            // 
            this.chkFollowUp.AutoSize = true;
            this.chkFollowUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chkFollowUp.Location = new System.Drawing.Point(15, 78);
            this.chkFollowUp.Name = "chkFollowUp";
            this.chkFollowUp.Size = new System.Drawing.Size(81, 19);
            this.chkFollowUp.TabIndex = 125;
            this.chkFollowUp.Text = "Follow Up";
            this.chkFollowUp.UseVisualStyleBackColor = true;
            this.chkFollowUp.CheckedChanged += new System.EventHandler(this.chkFollowUp_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 124;
            this.label6.Text = "Follow Up Time:";
            this.label6.Visible = false;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(281, 147);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(23, 13);
            this.lable.TabIndex = 123;
            this.lable.Text = "mm";
            this.lable.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 122;
            this.label5.Text = "hh :";
            this.label5.Visible = false;
            // 
            // cmbMinutes
            // 
            this.cmbMinutes.FormattingEnabled = true;
            this.cmbMinutes.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.cmbMinutes.Location = new System.Drawing.Point(229, 139);
            this.cmbMinutes.Name = "cmbMinutes";
            this.cmbMinutes.Size = new System.Drawing.Size(46, 21);
            this.cmbMinutes.TabIndex = 121;
            this.cmbMinutes.Visible = false;
            // 
            // cmbHours
            // 
            this.cmbHours.FormattingEnabled = true;
            this.cmbHours.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbHours.Location = new System.Drawing.Point(146, 139);
            this.cmbHours.Name = "cmbHours";
            this.cmbHours.Size = new System.Drawing.Size(46, 21);
            this.cmbHours.TabIndex = 120;
            this.cmbHours.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(426, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 119;
            this.label4.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 118;
            this.label1.Text = "Follow Up Date:";
            this.label1.Visible = false;
            // 
            // dtpFollowup
            // 
            this.dtpFollowup.CustomFormat = "";
            this.dtpFollowup.Location = new System.Drawing.Point(146, 112);
            this.dtpFollowup.Name = "dtpFollowup";
            this.dtpFollowup.Size = new System.Drawing.Size(199, 20);
            this.dtpFollowup.TabIndex = 117;
            this.dtpFollowup.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(426, 31);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(356, 129);
            this.txtEmail.TabIndex = 127;
            this.txtEmail.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // grpAttachment
            // 
            this.grpAttachment.Controls.Add(this.btnDelete);
            this.grpAttachment.Controls.Add(this.label9);
            this.grpAttachment.Controls.Add(this.lstAttach);
            this.grpAttachment.Controls.Add(this.rchDescription);
            this.grpAttachment.Controls.Add(this.label8);
            this.grpAttachment.Controls.Add(this.txtTitle);
            this.grpAttachment.Controls.Add(this.label7);
            this.grpAttachment.Location = new System.Drawing.Point(15, 333);
            this.grpAttachment.Name = "grpAttachment";
            this.grpAttachment.Size = new System.Drawing.Size(809, 170);
            this.grpAttachment.TabIndex = 130;
            this.grpAttachment.TabStop = false;
            this.grpAttachment.Text = "Save Attachment";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(670, 62);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(32, 27);
            this.btnDelete.TabIndex = 136;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.Location = new System.Drawing.Point(423, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 15);
            this.label9.TabIndex = 135;
            this.label9.Text = "Attachment List";
            // 
            // lstAttach
            // 
            this.lstAttach.FormattingEnabled = true;
            this.lstAttach.Location = new System.Drawing.Point(426, 62);
            this.lstAttach.Name = "lstAttach";
            this.lstAttach.Size = new System.Drawing.Size(237, 95);
            this.lstAttach.TabIndex = 134;
            // 
            // rchDescription
            // 
            this.rchDescription.Location = new System.Drawing.Point(131, 60);
            this.rchDescription.Name = "rchDescription";
            this.rchDescription.Size = new System.Drawing.Size(225, 97);
            this.rchDescription.TabIndex = 133;
            this.rchDescription.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(10, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 132;
            this.label8.Text = "Description:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(133, 34);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(223, 20);
            this.txtTitle.TabIndex = 131;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(9, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 130;
            this.label7.Text = "Title:";
            // 
            // grpCRM
            // 
            this.grpCRM.Controls.Add(this.btnCloseTSK);
            this.grpCRM.Controls.Add(this.txtClient);
            this.grpCRM.Controls.Add(this.txtCrm);
            this.grpCRM.Controls.Add(this.txtEmail);
            this.grpCRM.Controls.Add(this.lblClient);
            this.grpCRM.Controls.Add(this.label3);
            this.grpCRM.Controls.Add(this.chkFollowUp);
            this.grpCRM.Controls.Add(this.dtpFollowup);
            this.grpCRM.Controls.Add(this.label6);
            this.grpCRM.Controls.Add(this.label1);
            this.grpCRM.Controls.Add(this.lable);
            this.grpCRM.Controls.Add(this.label4);
            this.grpCRM.Controls.Add(this.label5);
            this.grpCRM.Controls.Add(this.cmbHours);
            this.grpCRM.Controls.Add(this.cmbMinutes);
            this.grpCRM.Location = new System.Drawing.Point(15, 82);
            this.grpCRM.Name = "grpCRM";
            this.grpCRM.Size = new System.Drawing.Size(809, 188);
            this.grpCRM.TabIndex = 134;
            this.grpCRM.TabStop = false;
            this.grpCRM.Text = "CRM";
            // 
            // btnCloseTSK
            // 
            this.btnCloseTSK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCloseTSK.Location = new System.Drawing.Point(146, 78);
            this.btnCloseTSK.Name = "btnCloseTSK";
            this.btnCloseTSK.Size = new System.Drawing.Size(75, 23);
            this.btnCloseTSK.TabIndex = 128;
            this.btnCloseTSK.Text = "Close Task";
            this.btnCloseTSK.UseVisualStyleBackColor = true;
            this.btnCloseTSK.Click += new System.EventHandler(this.btnCloseTSK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 135;
            this.label2.Text = "Save Attachment";
            // 
            // chkSaveAttachment
            // 
            this.chkSaveAttachment.AutoSize = true;
            this.chkSaveAttachment.Location = new System.Drawing.Point(15, 276);
            this.chkSaveAttachment.Name = "chkSaveAttachment";
            this.chkSaveAttachment.Size = new System.Drawing.Size(108, 17);
            this.chkSaveAttachment.TabIndex = 136;
            this.chkSaveAttachment.Text = "Save Attachment";
            this.chkSaveAttachment.UseVisualStyleBackColor = true;
            this.chkSaveAttachment.CheckedChanged += new System.EventHandler(this.chkSaveAttachment_CheckedChanged);
            // 
            // frmCrmProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 507);
            this.Controls.Add(this.chkSaveAttachment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpCRM);
            this.Controls.Add(this.grpAttachment);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.tsMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCrmProvider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save CRM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCrmProvider_FormClosing);
            this.Load += new System.EventHandler(this.frmCrmProvider_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.grpAttachment.ResumeLayout(false);
            this.grpAttachment.PerformLayout();
            this.grpCRM.ResumeLayout(false);
            this.grpCRM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tlsQuit;
        private System.Windows.Forms.ToolStripButton tlsSubmit;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.TextBox txtCrm;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.CheckBox chkFollowUp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMinutes;
        private System.Windows.Forms.ComboBox cmbHours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFollowup;
        private System.Windows.Forms.RichTextBox txtEmail;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox grpAttachment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rchDescription;
        private System.Windows.Forms.GroupBox grpCRM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstAttach;
        private System.Windows.Forms.CheckBox chkSaveAttachment;
        private System.Windows.Forms.Button btnCloseTSK;
        private System.Windows.Forms.Button btnDelete;
    }
}