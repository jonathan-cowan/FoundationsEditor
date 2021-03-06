﻿namespace FoundationsEditor
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtPrimaryIP = new System.Windows.Forms.TextBox();
            this.lblIPSegment = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.txtPrimaryRG = new System.Windows.Forms.TextBox();
            this.lblResourceGrp = new System.Windows.Forms.Label();
            this.txtPrimaryVnet = new System.Windows.Forms.TextBox();
            this.lblVnetName = new System.Windows.Forms.Label();
            this.txtSubscriptionID = new System.Windows.Forms.TextBox();
            this.lblSubscriptionID = new System.Windows.Forms.Label();
            this.txtSubnetName0 = new System.Windows.Forms.TextBox();
            this.lblSubnet = new System.Windows.Forms.Label();
            this.txtSecIP0 = new System.Windows.Forms.TextBox();
            this.txtSecIP1 = new System.Windows.Forms.TextBox();
            this.txtSubnetName1 = new System.Windows.Forms.TextBox();
            this.txtSecIP2 = new System.Windows.Forms.TextBox();
            this.txtSubnetName2 = new System.Windows.Forms.TextBox();
            this.txtSecIP3 = new System.Windows.Forms.TextBox();
            this.txtSubnetName3 = new System.Windows.Forms.TextBox();
            this.txtSecIP4 = new System.Windows.Forms.TextBox();
            this.txtSubnetName4 = new System.Windows.Forms.TextBox();
            this.txtSecIP5 = new System.Windows.Forms.TextBox();
            this.txtSubnetName5 = new System.Windows.Forms.TextBox();
            this.txtSecIP6 = new System.Windows.Forms.TextBox();
            this.txtSubnetName6 = new System.Windows.Forms.TextBox();
            this.txtSecIP7 = new System.Windows.Forms.TextBox();
            this.txtSubnetName7 = new System.Windows.Forms.TextBox();
            this.ckbAutoIP = new System.Windows.Forms.CheckBox();
            this.pnlDeployment = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.radBoth = new System.Windows.Forms.RadioButton();
            this.radPrimary = new System.Windows.Forms.RadioButton();
            this.txtSecondaryRG = new System.Windows.Forms.TextBox();
            this.cboPrimaryLocation = new System.Windows.Forms.ComboBox();
            this.cboSecondaryLocation = new System.Windows.Forms.ComboBox();
            this.txtSecondaryVnet = new System.Windows.Forms.TextBox();
            this.txtSecondaryIP = new System.Windows.Forms.TextBox();
            this.lblPrimaryIP = new System.Windows.Forms.Label();
            this.txtPriIP0 = new System.Windows.Forms.TextBox();
            this.txtPriIP1 = new System.Windows.Forms.TextBox();
            this.txtPriIP2 = new System.Windows.Forms.TextBox();
            this.txtPriIP3 = new System.Windows.Forms.TextBox();
            this.txtPriIP4 = new System.Windows.Forms.TextBox();
            this.txtPriIP5 = new System.Windows.Forms.TextBox();
            this.txtPriIP6 = new System.Windows.Forms.TextBox();
            this.txtPriIP7 = new System.Windows.Forms.TextBox();
            this.lblPrimary = new System.Windows.Forms.Label();
            this.lblSecondary = new System.Windows.Forms.Label();
            this.lblSecondaryIP = new System.Windows.Forms.Label();
            this.ckbCreateGateway = new System.Windows.Forms.CheckBox();
            this.ckbCreateConnection = new System.Windows.Forms.CheckBox();
            this.lblLocalGWName = new System.Windows.Forms.Label();
            this.txtLocalGWName = new System.Windows.Forms.TextBox();
            this.lblEdgeIP = new System.Windows.Forms.Label();
            this.txtEdgeIP = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pnlEnvironment = new System.Windows.Forms.Panel();
            this.lblEnvironment = new System.Windows.Forms.Label();
            this.radMAG = new System.Windows.Forms.RadioButton();
            this.radMAC = new System.Windows.Forms.RadioButton();
            this.txtMessages = new System.Windows.Forms.Label();
            this.lblBuild = new System.Windows.Forms.Label();
            this.txtOPAddress = new System.Windows.Forms.TextBox();
            this.lblOPAddress = new System.Windows.Forms.Label();
            this.picAzure = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ckbPS = new System.Windows.Forms.CheckBox();
            this.lblPS = new System.Windows.Forms.Label();
            this.pnlDeployment.SuspendLayout();
            this.pnlEnvironment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAzure)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrimaryIP
            // 
            this.txtPrimaryIP.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimaryIP.Location = new System.Drawing.Point(18, 313);
            this.txtPrimaryIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrimaryIP.Name = "txtPrimaryIP";
            this.txtPrimaryIP.Size = new System.Drawing.Size(284, 29);
            this.txtPrimaryIP.TabIndex = 11;
            this.toolTip1.SetToolTip(this.txtPrimaryIP, "10.128.0.0/20");
            // 
            // lblIPSegment
            // 
            this.lblIPSegment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPSegment.ForeColor = System.Drawing.Color.Blue;
            this.lblIPSegment.Location = new System.Drawing.Point(314, 312);
            this.lblIPSegment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIPSegment.Name = "lblIPSegment";
            this.lblIPSegment.Size = new System.Drawing.Size(304, 35);
            this.lblIPSegment.TabIndex = 58;
            this.lblIPSegment.Text = "IP Segment";
            this.lblIPSegment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRegion
            // 
            this.lblRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegion.ForeColor = System.Drawing.Color.Blue;
            this.lblRegion.Location = new System.Drawing.Point(314, 175);
            this.lblRegion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(304, 35);
            this.lblRegion.TabIndex = 55;
            this.lblRegion.Text = "Region";
            this.lblRegion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPrimaryRG
            // 
            this.txtPrimaryRG.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimaryRG.Location = new System.Drawing.Point(18, 221);
            this.txtPrimaryRG.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrimaryRG.Name = "txtPrimaryRG";
            this.txtPrimaryRG.Size = new System.Drawing.Size(284, 29);
            this.txtPrimaryRG.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtPrimaryRG, "rg-vnet-prod-{region}");
            // 
            // lblResourceGrp
            // 
            this.lblResourceGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResourceGrp.ForeColor = System.Drawing.Color.Blue;
            this.lblResourceGrp.Location = new System.Drawing.Point(314, 219);
            this.lblResourceGrp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResourceGrp.Name = "lblResourceGrp";
            this.lblResourceGrp.Size = new System.Drawing.Size(304, 35);
            this.lblResourceGrp.TabIndex = 56;
            this.lblResourceGrp.Text = "Resource Group";
            this.lblResourceGrp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPrimaryVnet
            // 
            this.txtPrimaryVnet.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimaryVnet.Location = new System.Drawing.Point(18, 267);
            this.txtPrimaryVnet.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrimaryVnet.Name = "txtPrimaryVnet";
            this.txtPrimaryVnet.Size = new System.Drawing.Size(284, 29);
            this.txtPrimaryVnet.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtPrimaryVnet, "vnet-prod-{region}");
            // 
            // lblVnetName
            // 
            this.lblVnetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVnetName.ForeColor = System.Drawing.Color.Blue;
            this.lblVnetName.Location = new System.Drawing.Point(314, 267);
            this.lblVnetName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVnetName.Name = "lblVnetName";
            this.lblVnetName.Size = new System.Drawing.Size(304, 35);
            this.lblVnetName.TabIndex = 57;
            this.lblVnetName.Text = "VNet Name";
            this.lblVnetName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSubscriptionID
            // 
            this.txtSubscriptionID.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubscriptionID.Location = new System.Drawing.Point(256, 10);
            this.txtSubscriptionID.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubscriptionID.Name = "txtSubscriptionID";
            this.txtSubscriptionID.Size = new System.Drawing.Size(654, 29);
            this.txtSubscriptionID.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtSubscriptionID, "{GUID-Subscription ID}");
            // 
            // lblSubscriptionID
            // 
            this.lblSubscriptionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubscriptionID.ForeColor = System.Drawing.Color.Blue;
            this.lblSubscriptionID.Location = new System.Drawing.Point(12, 10);
            this.lblSubscriptionID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubscriptionID.Name = "lblSubscriptionID";
            this.lblSubscriptionID.Size = new System.Drawing.Size(236, 35);
            this.lblSubscriptionID.TabIndex = 50;
            this.lblSubscriptionID.Text = "Subscription ID";
            this.lblSubscriptionID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSubnetName0
            // 
            this.txtSubnetName0.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubnetName0.Location = new System.Drawing.Point(326, 444);
            this.txtSubnetName0.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubnetName0.Name = "txtSubnetName0";
            this.txtSubnetName0.ReadOnly = true;
            this.txtSubnetName0.Size = new System.Drawing.Size(278, 29);
            this.txtSubnetName0.TabIndex = 34;
            // 
            // lblSubnet
            // 
            this.lblSubnet.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblSubnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubnet.ForeColor = System.Drawing.Color.Blue;
            this.lblSubnet.Location = new System.Drawing.Point(326, 412);
            this.lblSubnet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubnet.Name = "lblSubnet";
            this.lblSubnet.Size = new System.Drawing.Size(282, 29);
            this.lblSubnet.TabIndex = 61;
            this.lblSubnet.Text = "Subnet Name";
            this.lblSubnet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSecIP0
            // 
            this.txtSecIP0.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecIP0.Location = new System.Drawing.Point(626, 444);
            this.txtSecIP0.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecIP0.Name = "txtSecIP0";
            this.txtSecIP0.Size = new System.Drawing.Size(284, 29);
            this.txtSecIP0.TabIndex = 14;
            // 
            // txtSecIP1
            // 
            this.txtSecIP1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecIP1.Location = new System.Drawing.Point(626, 490);
            this.txtSecIP1.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecIP1.Name = "txtSecIP1";
            this.txtSecIP1.Size = new System.Drawing.Size(284, 29);
            this.txtSecIP1.TabIndex = 16;
            // 
            // txtSubnetName1
            // 
            this.txtSubnetName1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubnetName1.Location = new System.Drawing.Point(326, 490);
            this.txtSubnetName1.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubnetName1.Name = "txtSubnetName1";
            this.txtSubnetName1.Size = new System.Drawing.Size(278, 29);
            this.txtSubnetName1.TabIndex = 35;
            // 
            // txtSecIP2
            // 
            this.txtSecIP2.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecIP2.Location = new System.Drawing.Point(626, 537);
            this.txtSecIP2.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecIP2.Name = "txtSecIP2";
            this.txtSecIP2.Size = new System.Drawing.Size(284, 29);
            this.txtSecIP2.TabIndex = 18;
            // 
            // txtSubnetName2
            // 
            this.txtSubnetName2.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubnetName2.Location = new System.Drawing.Point(326, 537);
            this.txtSubnetName2.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubnetName2.Name = "txtSubnetName2";
            this.txtSubnetName2.Size = new System.Drawing.Size(278, 29);
            this.txtSubnetName2.TabIndex = 36;
            // 
            // txtSecIP3
            // 
            this.txtSecIP3.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecIP3.Location = new System.Drawing.Point(626, 583);
            this.txtSecIP3.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecIP3.Name = "txtSecIP3";
            this.txtSecIP3.Size = new System.Drawing.Size(284, 29);
            this.txtSecIP3.TabIndex = 20;
            // 
            // txtSubnetName3
            // 
            this.txtSubnetName3.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubnetName3.Location = new System.Drawing.Point(324, 583);
            this.txtSubnetName3.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubnetName3.Name = "txtSubnetName3";
            this.txtSubnetName3.Size = new System.Drawing.Size(278, 29);
            this.txtSubnetName3.TabIndex = 37;
            // 
            // txtSecIP4
            // 
            this.txtSecIP4.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecIP4.Location = new System.Drawing.Point(626, 629);
            this.txtSecIP4.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecIP4.Name = "txtSecIP4";
            this.txtSecIP4.Size = new System.Drawing.Size(284, 29);
            this.txtSecIP4.TabIndex = 22;
            // 
            // txtSubnetName4
            // 
            this.txtSubnetName4.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubnetName4.Location = new System.Drawing.Point(324, 629);
            this.txtSubnetName4.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubnetName4.Name = "txtSubnetName4";
            this.txtSubnetName4.Size = new System.Drawing.Size(278, 29);
            this.txtSubnetName4.TabIndex = 38;
            // 
            // txtSecIP5
            // 
            this.txtSecIP5.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecIP5.Location = new System.Drawing.Point(626, 675);
            this.txtSecIP5.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecIP5.Name = "txtSecIP5";
            this.txtSecIP5.Size = new System.Drawing.Size(284, 29);
            this.txtSecIP5.TabIndex = 24;
            // 
            // txtSubnetName5
            // 
            this.txtSubnetName5.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubnetName5.Location = new System.Drawing.Point(324, 675);
            this.txtSubnetName5.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubnetName5.Name = "txtSubnetName5";
            this.txtSubnetName5.Size = new System.Drawing.Size(278, 29);
            this.txtSubnetName5.TabIndex = 39;
            // 
            // txtSecIP6
            // 
            this.txtSecIP6.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecIP6.Location = new System.Drawing.Point(626, 721);
            this.txtSecIP6.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecIP6.Name = "txtSecIP6";
            this.txtSecIP6.Size = new System.Drawing.Size(284, 29);
            this.txtSecIP6.TabIndex = 26;
            // 
            // txtSubnetName6
            // 
            this.txtSubnetName6.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubnetName6.Location = new System.Drawing.Point(324, 721);
            this.txtSubnetName6.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubnetName6.Name = "txtSubnetName6";
            this.txtSubnetName6.Size = new System.Drawing.Size(278, 29);
            this.txtSubnetName6.TabIndex = 40;
            // 
            // txtSecIP7
            // 
            this.txtSecIP7.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecIP7.Location = new System.Drawing.Point(624, 767);
            this.txtSecIP7.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecIP7.Name = "txtSecIP7";
            this.txtSecIP7.Size = new System.Drawing.Size(284, 29);
            this.txtSecIP7.TabIndex = 28;
            // 
            // txtSubnetName7
            // 
            this.txtSubnetName7.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubnetName7.Location = new System.Drawing.Point(324, 767);
            this.txtSubnetName7.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubnetName7.Name = "txtSubnetName7";
            this.txtSubnetName7.Size = new System.Drawing.Size(278, 29);
            this.txtSubnetName7.TabIndex = 41;
            // 
            // ckbAutoIP
            // 
            this.ckbAutoIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAutoIP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckbAutoIP.Location = new System.Drawing.Point(18, 362);
            this.ckbAutoIP.Margin = new System.Windows.Forms.Padding(4);
            this.ckbAutoIP.Name = "ckbAutoIP";
            this.ckbAutoIP.Size = new System.Drawing.Size(304, 44);
            this.ckbAutoIP.TabIndex = 59;
            this.ckbAutoIP.Text = "Automatic IP Range";
            this.ckbAutoIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.ckbAutoIP, "Automatically Calculate CIDR");
            this.ckbAutoIP.UseVisualStyleBackColor = true;
            this.ckbAutoIP.CheckedChanged += new System.EventHandler(this.ckbAutoIP_CheckedChanged);
            // 
            // pnlDeployment
            // 
            this.pnlDeployment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDeployment.Controls.Add(this.label10);
            this.pnlDeployment.Controls.Add(this.radBoth);
            this.pnlDeployment.Controls.Add(this.radPrimary);
            this.pnlDeployment.Location = new System.Drawing.Point(558, 56);
            this.pnlDeployment.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDeployment.Name = "pnlDeployment";
            this.pnlDeployment.Size = new System.Drawing.Size(354, 71);
            this.pnlDeployment.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(4, 4);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(344, 27);
            this.label10.TabIndex = 4;
            this.label10.Text = "Region Deployment";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radBoth
            // 
            this.radBoth.AutoSize = true;
            this.radBoth.Checked = true;
            this.radBoth.Location = new System.Drawing.Point(232, 35);
            this.radBoth.Margin = new System.Windows.Forms.Padding(4);
            this.radBoth.Name = "radBoth";
            this.radBoth.Size = new System.Drawing.Size(87, 29);
            this.radBoth.TabIndex = 4;
            this.radBoth.TabStop = true;
            this.radBoth.Text = "Both";
            this.toolTip1.SetToolTip(this.radBoth, "Deploy Both Regions");
            this.radBoth.UseVisualStyleBackColor = true;
            this.radBoth.CheckedChanged += new System.EventHandler(this.radBoth_CheckedChanged);
            // 
            // radPrimary
            // 
            this.radPrimary.AutoSize = true;
            this.radPrimary.Location = new System.Drawing.Point(34, 35);
            this.radPrimary.Margin = new System.Windows.Forms.Padding(4);
            this.radPrimary.Name = "radPrimary";
            this.radPrimary.Size = new System.Drawing.Size(166, 29);
            this.radPrimary.TabIndex = 3;
            this.radPrimary.TabStop = true;
            this.radPrimary.Text = "Primary Only";
            this.toolTip1.SetToolTip(this.radPrimary, "Deploy only the Primary Region");
            this.radPrimary.UseVisualStyleBackColor = true;
            this.radPrimary.CheckedChanged += new System.EventHandler(this.radPrimary_CheckedChanged);
            // 
            // txtSecondaryRG
            // 
            this.txtSecondaryRG.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondaryRG.Location = new System.Drawing.Point(626, 223);
            this.txtSecondaryRG.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecondaryRG.Name = "txtSecondaryRG";
            this.txtSecondaryRG.Size = new System.Drawing.Size(284, 29);
            this.txtSecondaryRG.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtSecondaryRG, "rg-vnet-prod-{region}");
            // 
            // cboPrimaryLocation
            // 
            this.cboPrimaryLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrimaryLocation.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPrimaryLocation.FormattingEnabled = true;
            this.cboPrimaryLocation.Location = new System.Drawing.Point(18, 173);
            this.cboPrimaryLocation.Margin = new System.Windows.Forms.Padding(4);
            this.cboPrimaryLocation.Name = "cboPrimaryLocation";
            this.cboPrimaryLocation.Size = new System.Drawing.Size(284, 30);
            this.cboPrimaryLocation.TabIndex = 5;
            this.toolTip1.SetToolTip(this.cboPrimaryLocation, "Select the Primary Azure Region");
            this.cboPrimaryLocation.SelectedIndexChanged += new System.EventHandler(this.cboPrimaryLocation_SelectedIndexChanged);
            // 
            // cboSecondaryLocation
            // 
            this.cboSecondaryLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSecondaryLocation.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSecondaryLocation.FormattingEnabled = true;
            this.cboSecondaryLocation.Location = new System.Drawing.Point(626, 175);
            this.cboSecondaryLocation.Margin = new System.Windows.Forms.Padding(4);
            this.cboSecondaryLocation.Name = "cboSecondaryLocation";
            this.cboSecondaryLocation.Size = new System.Drawing.Size(284, 30);
            this.cboSecondaryLocation.TabIndex = 6;
            this.toolTip1.SetToolTip(this.cboSecondaryLocation, "Select the Secondary Azure Region");
            this.cboSecondaryLocation.SelectedIndexChanged += new System.EventHandler(this.cboSecondaryLocation_SelectedIndexChanged);
            // 
            // txtSecondaryVnet
            // 
            this.txtSecondaryVnet.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondaryVnet.Location = new System.Drawing.Point(626, 269);
            this.txtSecondaryVnet.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecondaryVnet.Name = "txtSecondaryVnet";
            this.txtSecondaryVnet.Size = new System.Drawing.Size(284, 29);
            this.txtSecondaryVnet.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txtSecondaryVnet, "vnet-prod-{region}");
            // 
            // txtSecondaryIP
            // 
            this.txtSecondaryIP.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondaryIP.Location = new System.Drawing.Point(626, 315);
            this.txtSecondaryIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecondaryIP.Name = "txtSecondaryIP";
            this.txtSecondaryIP.Size = new System.Drawing.Size(284, 29);
            this.txtSecondaryIP.TabIndex = 12;
            this.toolTip1.SetToolTip(this.txtSecondaryIP, "10.128.8.0/21");
            // 
            // lblPrimaryIP
            // 
            this.lblPrimaryIP.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPrimaryIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimaryIP.ForeColor = System.Drawing.Color.Blue;
            this.lblPrimaryIP.Location = new System.Drawing.Point(18, 412);
            this.lblPrimaryIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrimaryIP.Name = "lblPrimaryIP";
            this.lblPrimaryIP.Size = new System.Drawing.Size(288, 29);
            this.lblPrimaryIP.TabIndex = 60;
            this.lblPrimaryIP.Text = "IP Segment";
            this.lblPrimaryIP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPriIP0
            // 
            this.txtPriIP0.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriIP0.Location = new System.Drawing.Point(18, 444);
            this.txtPriIP0.Margin = new System.Windows.Forms.Padding(4);
            this.txtPriIP0.Name = "txtPriIP0";
            this.txtPriIP0.Size = new System.Drawing.Size(284, 29);
            this.txtPriIP0.TabIndex = 13;
            // 
            // txtPriIP1
            // 
            this.txtPriIP1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriIP1.Location = new System.Drawing.Point(18, 490);
            this.txtPriIP1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPriIP1.Name = "txtPriIP1";
            this.txtPriIP1.Size = new System.Drawing.Size(284, 29);
            this.txtPriIP1.TabIndex = 15;
            // 
            // txtPriIP2
            // 
            this.txtPriIP2.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriIP2.Location = new System.Drawing.Point(18, 537);
            this.txtPriIP2.Margin = new System.Windows.Forms.Padding(4);
            this.txtPriIP2.Name = "txtPriIP2";
            this.txtPriIP2.Size = new System.Drawing.Size(284, 29);
            this.txtPriIP2.TabIndex = 17;
            // 
            // txtPriIP3
            // 
            this.txtPriIP3.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriIP3.Location = new System.Drawing.Point(18, 583);
            this.txtPriIP3.Margin = new System.Windows.Forms.Padding(4);
            this.txtPriIP3.Name = "txtPriIP3";
            this.txtPriIP3.Size = new System.Drawing.Size(284, 29);
            this.txtPriIP3.TabIndex = 19;
            // 
            // txtPriIP4
            // 
            this.txtPriIP4.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriIP4.Location = new System.Drawing.Point(18, 629);
            this.txtPriIP4.Margin = new System.Windows.Forms.Padding(4);
            this.txtPriIP4.Name = "txtPriIP4";
            this.txtPriIP4.Size = new System.Drawing.Size(284, 29);
            this.txtPriIP4.TabIndex = 21;
            // 
            // txtPriIP5
            // 
            this.txtPriIP5.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriIP5.Location = new System.Drawing.Point(18, 675);
            this.txtPriIP5.Margin = new System.Windows.Forms.Padding(4);
            this.txtPriIP5.Name = "txtPriIP5";
            this.txtPriIP5.Size = new System.Drawing.Size(284, 29);
            this.txtPriIP5.TabIndex = 23;
            // 
            // txtPriIP6
            // 
            this.txtPriIP6.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriIP6.Location = new System.Drawing.Point(18, 721);
            this.txtPriIP6.Margin = new System.Windows.Forms.Padding(4);
            this.txtPriIP6.Name = "txtPriIP6";
            this.txtPriIP6.Size = new System.Drawing.Size(284, 29);
            this.txtPriIP6.TabIndex = 25;
            // 
            // txtPriIP7
            // 
            this.txtPriIP7.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriIP7.Location = new System.Drawing.Point(18, 767);
            this.txtPriIP7.Margin = new System.Windows.Forms.Padding(4);
            this.txtPriIP7.Name = "txtPriIP7";
            this.txtPriIP7.Size = new System.Drawing.Size(284, 29);
            this.txtPriIP7.TabIndex = 27;
            // 
            // lblPrimary
            // 
            this.lblPrimary.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPrimary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimary.ForeColor = System.Drawing.Color.Blue;
            this.lblPrimary.Location = new System.Drawing.Point(18, 135);
            this.lblPrimary.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrimary.Name = "lblPrimary";
            this.lblPrimary.Size = new System.Drawing.Size(288, 35);
            this.lblPrimary.TabIndex = 53;
            this.lblPrimary.Text = "PRIMARY";
            this.lblPrimary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecondary
            // 
            this.lblSecondary.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblSecondary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondary.ForeColor = System.Drawing.Color.Blue;
            this.lblSecondary.Location = new System.Drawing.Point(626, 135);
            this.lblSecondary.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSecondary.Name = "lblSecondary";
            this.lblSecondary.Size = new System.Drawing.Size(288, 35);
            this.lblSecondary.TabIndex = 54;
            this.lblSecondary.Text = "SECONDARY";
            this.lblSecondary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecondaryIP
            // 
            this.lblSecondaryIP.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblSecondaryIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondaryIP.ForeColor = System.Drawing.Color.Blue;
            this.lblSecondaryIP.Location = new System.Drawing.Point(626, 412);
            this.lblSecondaryIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecondaryIP.Name = "lblSecondaryIP";
            this.lblSecondaryIP.Size = new System.Drawing.Size(288, 29);
            this.lblSecondaryIP.TabIndex = 62;
            this.lblSecondaryIP.Text = "IP Segment";
            this.lblSecondaryIP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ckbCreateGateway
            // 
            this.ckbCreateGateway.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCreateGateway.Location = new System.Drawing.Point(332, 362);
            this.ckbCreateGateway.Margin = new System.Windows.Forms.Padding(6);
            this.ckbCreateGateway.Name = "ckbCreateGateway";
            this.ckbCreateGateway.Size = new System.Drawing.Size(274, 44);
            this.ckbCreateGateway.TabIndex = 29;
            this.ckbCreateGateway.Text = "Create Gateway(s)";
            this.toolTip1.SetToolTip(this.ckbCreateGateway, "Create VNet Gateways");
            this.ckbCreateGateway.UseVisualStyleBackColor = true;
            this.ckbCreateGateway.CheckedChanged += new System.EventHandler(this.ckbCreateGateway_CheckedChanged);
            // 
            // ckbCreateConnection
            // 
            this.ckbCreateConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCreateConnection.Location = new System.Drawing.Point(626, 362);
            this.ckbCreateConnection.Margin = new System.Windows.Forms.Padding(6);
            this.ckbCreateConnection.Name = "ckbCreateConnection";
            this.ckbCreateConnection.Size = new System.Drawing.Size(286, 44);
            this.ckbCreateConnection.TabIndex = 30;
            this.ckbCreateConnection.Text = "Create Connection(s)";
            this.toolTip1.SetToolTip(this.ckbCreateConnection, "Create VPN Connections");
            this.ckbCreateConnection.UseVisualStyleBackColor = true;
            this.ckbCreateConnection.Visible = false;
            this.ckbCreateConnection.CheckedChanged += new System.EventHandler(this.ckbCreateConnection_CheckedChanged);
            // 
            // lblLocalGWName
            // 
            this.lblLocalGWName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalGWName.ForeColor = System.Drawing.Color.Blue;
            this.lblLocalGWName.Location = new System.Drawing.Point(32, 806);
            this.lblLocalGWName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLocalGWName.Name = "lblLocalGWName";
            this.lblLocalGWName.Size = new System.Drawing.Size(274, 38);
            this.lblLocalGWName.TabIndex = 63;
            this.lblLocalGWName.Text = "Local Gateway Name";
            this.lblLocalGWName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLocalGWName.Visible = false;
            // 
            // txtLocalGWName
            // 
            this.txtLocalGWName.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalGWName.Location = new System.Drawing.Point(324, 812);
            this.txtLocalGWName.Margin = new System.Windows.Forms.Padding(6);
            this.txtLocalGWName.Name = "txtLocalGWName";
            this.txtLocalGWName.Size = new System.Drawing.Size(422, 29);
            this.txtLocalGWName.TabIndex = 31;
            this.toolTip1.SetToolTip(this.txtLocalGWName, "gw-local");
            this.txtLocalGWName.Visible = false;
            // 
            // lblEdgeIP
            // 
            this.lblEdgeIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdgeIP.ForeColor = System.Drawing.Color.Blue;
            this.lblEdgeIP.Location = new System.Drawing.Point(26, 852);
            this.lblEdgeIP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEdgeIP.Name = "lblEdgeIP";
            this.lblEdgeIP.Size = new System.Drawing.Size(280, 38);
            this.lblEdgeIP.TabIndex = 64;
            this.lblEdgeIP.Text = "On-Premises Edge IP";
            this.lblEdgeIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEdgeIP.Visible = false;
            // 
            // txtEdgeIP
            // 
            this.txtEdgeIP.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdgeIP.Location = new System.Drawing.Point(326, 858);
            this.txtEdgeIP.Margin = new System.Windows.Forms.Padding(6);
            this.txtEdgeIP.Name = "txtEdgeIP";
            this.txtEdgeIP.Size = new System.Drawing.Size(420, 29);
            this.txtEdgeIP.TabIndex = 32;
            this.toolTip1.SetToolTip(this.txtEdgeIP, "61.72.83.94");
            this.txtEdgeIP.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(720, 1058);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(192, 75);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "SAVE";
            this.toolTip1.SetToolTip(this.btnSave, "Save Configuration and Create Script");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(18, 1058);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(6);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(192, 75);
            this.btnLoad.TabIndex = 80;
            this.btnLoad.Text = "LOAD";
            this.toolTip1.SetToolTip(this.btnLoad, "Load Existing Configuration");
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pnlEnvironment
            // 
            this.pnlEnvironment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEnvironment.Controls.Add(this.lblEnvironment);
            this.pnlEnvironment.Controls.Add(this.radMAG);
            this.pnlEnvironment.Controls.Add(this.radMAC);
            this.pnlEnvironment.Location = new System.Drawing.Point(18, 56);
            this.pnlEnvironment.Margin = new System.Windows.Forms.Padding(6);
            this.pnlEnvironment.Name = "pnlEnvironment";
            this.pnlEnvironment.Size = new System.Drawing.Size(354, 71);
            this.pnlEnvironment.TabIndex = 51;
            // 
            // lblEnvironment
            // 
            this.lblEnvironment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnvironment.ForeColor = System.Drawing.Color.Blue;
            this.lblEnvironment.Location = new System.Drawing.Point(4, 4);
            this.lblEnvironment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnvironment.Name = "lblEnvironment";
            this.lblEnvironment.Size = new System.Drawing.Size(344, 25);
            this.lblEnvironment.TabIndex = 7;
            this.lblEnvironment.Text = "Environment";
            this.lblEnvironment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radMAG
            // 
            this.radMAG.AutoSize = true;
            this.radMAG.Location = new System.Drawing.Point(208, 33);
            this.radMAG.Margin = new System.Windows.Forms.Padding(4);
            this.radMAG.Name = "radMAG";
            this.radMAG.Size = new System.Drawing.Size(91, 29);
            this.radMAG.TabIndex = 2;
            this.radMAG.Text = "MAG";
            this.toolTip1.SetToolTip(this.radMAG, "Microsoft Azure Government");
            this.radMAG.UseVisualStyleBackColor = true;
            this.radMAG.CheckedChanged += new System.EventHandler(this.radMAG_CheckedChanged);
            // 
            // radMAC
            // 
            this.radMAC.AutoSize = true;
            this.radMAC.Location = new System.Drawing.Point(50, 35);
            this.radMAC.Margin = new System.Windows.Forms.Padding(4);
            this.radMAC.Name = "radMAC";
            this.radMAC.Size = new System.Drawing.Size(90, 29);
            this.radMAC.TabIndex = 1;
            this.radMAC.TabStop = true;
            this.radMAC.Text = "MAC";
            this.toolTip1.SetToolTip(this.radMAC, "Microsoft Azure Commercial");
            this.radMAC.UseVisualStyleBackColor = true;
            this.radMAC.CheckedChanged += new System.EventHandler(this.radMAC_CheckedChanged_1);
            // 
            // txtMessages
            // 
            this.txtMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessages.ForeColor = System.Drawing.Color.Blue;
            this.txtMessages.Location = new System.Drawing.Point(20, 963);
            this.txtMessages.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.Size = new System.Drawing.Size(892, 88);
            this.txtMessages.TabIndex = 83;
            this.txtMessages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBuild
            // 
            this.lblBuild.Location = new System.Drawing.Point(222, 1058);
            this.lblBuild.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBuild.Name = "lblBuild";
            this.lblBuild.Size = new System.Drawing.Size(486, 75);
            this.lblBuild.TabIndex = 84;
            this.lblBuild.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOPAddress
            // 
            this.txtOPAddress.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOPAddress.Location = new System.Drawing.Point(326, 904);
            this.txtOPAddress.Margin = new System.Windows.Forms.Padding(6);
            this.txtOPAddress.Name = "txtOPAddress";
            this.txtOPAddress.Size = new System.Drawing.Size(420, 29);
            this.txtOPAddress.TabIndex = 85;
            this.toolTip1.SetToolTip(this.txtOPAddress, "10.0.0.0/9");
            this.txtOPAddress.Visible = false;
            // 
            // lblOPAddress
            // 
            this.lblOPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOPAddress.ForeColor = System.Drawing.Color.Blue;
            this.lblOPAddress.Location = new System.Drawing.Point(20, 898);
            this.lblOPAddress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOPAddress.Name = "lblOPAddress";
            this.lblOPAddress.Size = new System.Drawing.Size(286, 38);
            this.lblOPAddress.TabIndex = 86;
            this.lblOPAddress.Text = "On-Premises IP Range";
            this.lblOPAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOPAddress.Visible = false;
            // 
            // picAzure
            // 
            this.picAzure.Image = ((System.Drawing.Image)(resources.GetObject("picAzure.Image")));
            this.picAzure.Location = new System.Drawing.Point(388, 54);
            this.picAzure.Margin = new System.Windows.Forms.Padding(6);
            this.picAzure.Name = "picAzure";
            this.picAzure.Size = new System.Drawing.Size(156, 150);
            this.picAzure.TabIndex = 87;
            this.picAzure.TabStop = false;
            this.picAzure.Click += new System.EventHandler(this.picAzure_Click);
            // 
            // ckbPS
            // 
            this.ckbPS.AutoSize = true;
            this.ckbPS.Location = new System.Drawing.Point(820, 815);
            this.ckbPS.Margin = new System.Windows.Forms.Padding(6);
            this.ckbPS.Name = "ckbPS";
            this.ckbPS.Size = new System.Drawing.Size(28, 27);
            this.ckbPS.TabIndex = 88;
            this.toolTip1.SetToolTip(this.ckbPS, "Check to Create PowerShell Only");
            this.ckbPS.UseVisualStyleBackColor = true;
            this.ckbPS.Visible = false;
            this.ckbPS.CheckedChanged += new System.EventHandler(this.ckbPS_CheckedChanged);
            // 
            // lblPS
            // 
            this.lblPS.Location = new System.Drawing.Point(762, 848);
            this.lblPS.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPS.Name = "lblPS";
            this.lblPS.Size = new System.Drawing.Size(150, 44);
            this.lblPS.TabIndex = 89;
            this.lblPS.Text = "PowerShell";
            this.lblPS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPS.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(931, 1156);
            this.Controls.Add(this.lblPS);
            this.Controls.Add(this.ckbPS);
            this.Controls.Add(this.picAzure);
            this.Controls.Add(this.txtOPAddress);
            this.Controls.Add(this.lblOPAddress);
            this.Controls.Add(this.lblBuild);
            this.Controls.Add(this.txtMessages);
            this.Controls.Add(this.pnlEnvironment);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEdgeIP);
            this.Controls.Add(this.lblEdgeIP);
            this.Controls.Add(this.txtLocalGWName);
            this.Controls.Add(this.lblLocalGWName);
            this.Controls.Add(this.ckbCreateConnection);
            this.Controls.Add(this.ckbCreateGateway);
            this.Controls.Add(this.lblSecondaryIP);
            this.Controls.Add(this.lblSecondary);
            this.Controls.Add(this.lblPrimary);
            this.Controls.Add(this.txtPriIP7);
            this.Controls.Add(this.txtPriIP6);
            this.Controls.Add(this.txtPriIP5);
            this.Controls.Add(this.txtPriIP4);
            this.Controls.Add(this.txtPriIP3);
            this.Controls.Add(this.txtPriIP2);
            this.Controls.Add(this.txtPriIP1);
            this.Controls.Add(this.txtPriIP0);
            this.Controls.Add(this.lblPrimaryIP);
            this.Controls.Add(this.txtSecondaryIP);
            this.Controls.Add(this.txtSecondaryVnet);
            this.Controls.Add(this.cboSecondaryLocation);
            this.Controls.Add(this.txtSecondaryRG);
            this.Controls.Add(this.pnlDeployment);
            this.Controls.Add(this.ckbAutoIP);
            this.Controls.Add(this.txtSecIP7);
            this.Controls.Add(this.txtSubnetName7);
            this.Controls.Add(this.txtSecIP6);
            this.Controls.Add(this.txtSubnetName6);
            this.Controls.Add(this.txtSecIP5);
            this.Controls.Add(this.txtSubnetName5);
            this.Controls.Add(this.txtSecIP4);
            this.Controls.Add(this.txtSubnetName4);
            this.Controls.Add(this.txtSecIP3);
            this.Controls.Add(this.txtSubnetName3);
            this.Controls.Add(this.txtSecIP2);
            this.Controls.Add(this.txtSubnetName2);
            this.Controls.Add(this.txtSecIP1);
            this.Controls.Add(this.txtSubnetName1);
            this.Controls.Add(this.txtSecIP0);
            this.Controls.Add(this.txtSubnetName0);
            this.Controls.Add(this.lblSubnet);
            this.Controls.Add(this.txtSubscriptionID);
            this.Controls.Add(this.lblSubscriptionID);
            this.Controls.Add(this.txtPrimaryIP);
            this.Controls.Add(this.lblIPSegment);
            this.Controls.Add(this.cboPrimaryLocation);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.txtPrimaryRG);
            this.Controls.Add(this.lblResourceGrp);
            this.Controls.Add(this.txtPrimaryVnet);
            this.Controls.Add(this.lblVnetName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Azure Foundations Editor";
            this.pnlDeployment.ResumeLayout(false);
            this.pnlDeployment.PerformLayout();
            this.pnlEnvironment.ResumeLayout(false);
            this.pnlEnvironment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAzure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPrimaryIP;
        private System.Windows.Forms.Label lblIPSegment;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.TextBox txtPrimaryRG;
        private System.Windows.Forms.Label lblResourceGrp;
        private System.Windows.Forms.TextBox txtPrimaryVnet;
        private System.Windows.Forms.Label lblVnetName;
        private System.Windows.Forms.TextBox txtSubscriptionID;
        private System.Windows.Forms.Label lblSubscriptionID;
        private System.Windows.Forms.TextBox txtSubnetName0;
        private System.Windows.Forms.Label lblSubnet;
        private System.Windows.Forms.TextBox txtSecIP0;
        private System.Windows.Forms.TextBox txtSecIP1;
        private System.Windows.Forms.TextBox txtSubnetName1;
        private System.Windows.Forms.TextBox txtSecIP2;
        private System.Windows.Forms.TextBox txtSubnetName2;
        private System.Windows.Forms.TextBox txtSecIP3;
        private System.Windows.Forms.TextBox txtSubnetName3;
        private System.Windows.Forms.TextBox txtSecIP4;
        private System.Windows.Forms.TextBox txtSubnetName4;
        private System.Windows.Forms.TextBox txtSecIP5;
        private System.Windows.Forms.TextBox txtSubnetName5;
        private System.Windows.Forms.TextBox txtSecIP6;
        private System.Windows.Forms.TextBox txtSubnetName6;
        private System.Windows.Forms.TextBox txtSecIP7;
        private System.Windows.Forms.TextBox txtSubnetName7;
        private System.Windows.Forms.CheckBox ckbAutoIP;
        private System.Windows.Forms.Panel pnlDeployment;
        private System.Windows.Forms.RadioButton radBoth;
        private System.Windows.Forms.RadioButton radPrimary;
        private System.Windows.Forms.TextBox txtSecondaryRG;
        private System.Windows.Forms.ComboBox cboPrimaryLocation;
        private System.Windows.Forms.ComboBox cboSecondaryLocation;
        private System.Windows.Forms.TextBox txtSecondaryVnet;
        private System.Windows.Forms.TextBox txtSecondaryIP;
        private System.Windows.Forms.Label lblPrimaryIP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPriIP0;
        private System.Windows.Forms.TextBox txtPriIP1;
        private System.Windows.Forms.TextBox txtPriIP2;
        private System.Windows.Forms.TextBox txtPriIP3;
        private System.Windows.Forms.TextBox txtPriIP4;
        private System.Windows.Forms.TextBox txtPriIP5;
        private System.Windows.Forms.TextBox txtPriIP6;
        private System.Windows.Forms.TextBox txtPriIP7;
        private System.Windows.Forms.Label lblPrimary;
        private System.Windows.Forms.Label lblSecondary;
        private System.Windows.Forms.Label lblSecondaryIP;
        private System.Windows.Forms.CheckBox ckbCreateGateway;
        private System.Windows.Forms.CheckBox ckbCreateConnection;
        private System.Windows.Forms.Label lblLocalGWName;
        private System.Windows.Forms.TextBox txtLocalGWName;
        private System.Windows.Forms.Label lblEdgeIP;
        private System.Windows.Forms.TextBox txtEdgeIP;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel pnlEnvironment;
        private System.Windows.Forms.Label lblEnvironment;
        private System.Windows.Forms.RadioButton radMAG;
        private System.Windows.Forms.RadioButton radMAC;
        private System.Windows.Forms.Label txtMessages;
        private System.Windows.Forms.Label lblBuild;
        private System.Windows.Forms.TextBox txtOPAddress;
        private System.Windows.Forms.Label lblOPAddress;
        private System.Windows.Forms.PictureBox picAzure;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox ckbPS;
        private System.Windows.Forms.Label lblPS;
    }
}

