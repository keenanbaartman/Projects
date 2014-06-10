namespace CRM_AddIn
{
    partial class ProfinRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public ProfinRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfinRibbon));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.btnProviderRecieved = this.Factory.CreateRibbonButton();
            this.btnProviderSend = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group2.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group2);
            this.tab1.Label = "Profin";
            this.tab1.Name = "tab1";
            // 
            // group2
            // 
            this.group2.Items.Add(this.btnProviderRecieved);
            this.group2.Items.Add(this.btnProviderSend);
            this.group2.Label = "Save CRM by Subject Line";
            this.group2.Name = "group2";
            // 
            // btnProviderRecieved
            // 
            this.btnProviderRecieved.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnProviderRecieved.Image = ((System.Drawing.Image)(resources.GetObject("btnProviderRecieved.Image")));
            this.btnProviderRecieved.Label = "Save Received Email";
            this.btnProviderRecieved.Name = "btnProviderRecieved";
            this.btnProviderRecieved.ScreenTip = "Save the selected text";
            this.btnProviderRecieved.ShowImage = true;
            this.btnProviderRecieved.SuperTip = "Save an email that was sent to your inbox from a Provider. Make sure that the sub" +
    "ject line contains the reply sign and CRM. eg, \'RE: CRM - 12345\'.";
            this.btnProviderRecieved.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnProviderRecieved_Click);
            // 
            // btnProviderSend
            // 
            this.btnProviderSend.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnProviderSend.Image = ((System.Drawing.Image)(resources.GetObject("btnProviderSend.Image")));
            this.btnProviderSend.Label = "Save Sent Email";
            this.btnProviderSend.Name = "btnProviderSend";
            this.btnProviderSend.ShowImage = true;
            this.btnProviderSend.SuperTip = "Save an email you sent to the Provider. Make sure that \'Sent\' is selected in the " +
    "side pane and that the Subject Line Format is \'CRM - xxxxx\', eg. CRM - 12345.";
            this.btnProviderSend.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnProviderSend_Click);
            // 
            // ProfinRibbon
            // 
            this.Name = "ProfinRibbon";
            this.RibbonType = resources.GetString("$this.RibbonType");
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.ProfinRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnProviderRecieved;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnProviderSend;
    }

    partial class ThisRibbonCollection
    {
        internal ProfinRibbon ProfinRibbon
        {
            get { return this.GetRibbon<ProfinRibbon>(); }
        }
    }
}
