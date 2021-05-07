
namespace ServerManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selectROOTDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.validServersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveROOTDirLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearROOTDirLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPDATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPDATENOWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bACKUPExeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreExeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lROOTdir = new System.Windows.Forms.Label();
            this.rtbLIST = new System.Windows.Forms.RichTextBox();
            this.btnSHUTDOWN = new System.Windows.Forms.Button();
            this.btnREPLACE = new System.Windows.Forms.Button();
            this.btnREMOVE = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSELSTART = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnBULLY = new System.Windows.Forms.Button();
            this.lLIMIT = new System.Windows.Forms.Label();
            this.panelSELSTART = new System.Windows.Forms.Panel();
            this.panel_btnSave = new System.Windows.Forms.Button();
            this.panel_btnUNSAVE = new System.Windows.Forms.Button();
            this.panel_btnClear = new System.Windows.Forms.Button();
            this.panel_btnCancel = new System.Windows.Forms.Button();
            this.panel_btnSTART = new System.Windows.Forms.Button();
            this.dgvToStart = new System.Windows.Forms.DataGridView();
            this.dgvSELECT = new System.Windows.Forms.DataGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.availableServersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHELP = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelSELSTART.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSELECT)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectROOTDirToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem5,
            this.validServersToolStripMenuItem,
            this.saveROOTDirLocationToolStripMenuItem,
            this.clearROOTDirLocationToolStripMenuItem,
            this.uPDATEToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selectROOTDirToolStripMenuItem
            // 
            this.selectROOTDirToolStripMenuItem.Name = "selectROOTDirToolStripMenuItem";
            this.selectROOTDirToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.selectROOTDirToolStripMenuItem.Text = "Select ROOT dir";
            this.selectROOTDirToolStripMenuItem.Click += new System.EventHandler(this.selectROOTDirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(31, 20);
            this.toolStripMenuItem1.Text = "    ";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(175, 20);
            this.toolStripMenuItem5.Text = "                                                    ";
            // 
            // validServersToolStripMenuItem
            // 
            this.validServersToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.validServersToolStripMenuItem.Name = "validServersToolStripMenuItem";
            this.validServersToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.validServersToolStripMenuItem.Text = "Valid servers found:";
            // 
            // saveROOTDirLocationToolStripMenuItem
            // 
            this.saveROOTDirLocationToolStripMenuItem.Name = "saveROOTDirLocationToolStripMenuItem";
            this.saveROOTDirLocationToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.saveROOTDirLocationToolStripMenuItem.Text = "Save ROOT dir location";
            this.saveROOTDirLocationToolStripMenuItem.Click += new System.EventHandler(this.saveROOTDirLocationToolStripMenuItem_Click);
            // 
            // clearROOTDirLocationToolStripMenuItem
            // 
            this.clearROOTDirLocationToolStripMenuItem.Name = "clearROOTDirLocationToolStripMenuItem";
            this.clearROOTDirLocationToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.clearROOTDirLocationToolStripMenuItem.Text = "Clear ROOT dir location";
            this.clearROOTDirLocationToolStripMenuItem.Click += new System.EventHandler(this.clearROOTDirLocationToolStripMenuItem_Click);
            // 
            // uPDATEToolStripMenuItem
            // 
            this.uPDATEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uPDATENOWToolStripMenuItem,
            this.bACKUPExeToolStripMenuItem,
            this.restoreExeToolStripMenuItem});
            this.uPDATEToolStripMenuItem.Name = "uPDATEToolStripMenuItem";
            this.uPDATEToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.uPDATEToolStripMenuItem.Text = "UPDATE";
            // 
            // uPDATENOWToolStripMenuItem
            // 
            this.uPDATENOWToolStripMenuItem.Name = "uPDATENOWToolStripMenuItem";
            this.uPDATENOWToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uPDATENOWToolStripMenuItem.Text = "Update now";
            this.uPDATENOWToolStripMenuItem.Click += new System.EventHandler(this.uPDATEToolStripMenuItem_Click);
            // 
            // bACKUPExeToolStripMenuItem
            // 
            this.bACKUPExeToolStripMenuItem.Name = "bACKUPExeToolStripMenuItem";
            this.bACKUPExeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bACKUPExeToolStripMenuItem.Text = "Backup exe";
            this.bACKUPExeToolStripMenuItem.Click += new System.EventHandler(this.bACKUPExeToolStripMenuItem_Click);
            // 
            // restoreExeToolStripMenuItem
            // 
            this.restoreExeToolStripMenuItem.Name = "restoreExeToolStripMenuItem";
            this.restoreExeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restoreExeToolStripMenuItem.Text = "Restore exe";
            this.restoreExeToolStripMenuItem.Click += new System.EventHandler(this.restoreExeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(12, 20);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(12, 20);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ROOT Dir: ";
            // 
            // lROOTdir
            // 
            this.lROOTdir.AutoSize = true;
            this.lROOTdir.Location = new System.Drawing.Point(78, 24);
            this.lROOTdir.Name = "lROOTdir";
            this.lROOTdir.Size = new System.Drawing.Size(97, 13);
            this.lROOTdir.TabIndex = 2;
            this.lROOTdir.Text = "Folder not selected";
            // 
            // rtbLIST
            // 
            this.rtbLIST.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtbLIST.Location = new System.Drawing.Point(515, 24);
            this.rtbLIST.Name = "rtbLIST";
            this.rtbLIST.Size = new System.Drawing.Size(285, 426);
            this.rtbLIST.TabIndex = 3;
            this.rtbLIST.Text = "";
            // 
            // btnSHUTDOWN
            // 
            this.btnSHUTDOWN.Location = new System.Drawing.Point(39, 32);
            this.btnSHUTDOWN.Name = "btnSHUTDOWN";
            this.btnSHUTDOWN.Size = new System.Drawing.Size(86, 37);
            this.btnSHUTDOWN.TabIndex = 4;
            this.btnSHUTDOWN.Text = "SHUTDOWN";
            this.btnSHUTDOWN.UseVisualStyleBackColor = true;
            this.btnSHUTDOWN.Click += new System.EventHandler(this.btnSHUTDOWN_Click);
            // 
            // btnREPLACE
            // 
            this.btnREPLACE.Location = new System.Drawing.Point(39, 90);
            this.btnREPLACE.Name = "btnREPLACE";
            this.btnREPLACE.Size = new System.Drawing.Size(86, 37);
            this.btnREPLACE.TabIndex = 5;
            this.btnREPLACE.Tag = "Replace all files in \"addons\" folder with new files that you select via OPF";
            this.btnREPLACE.Text = "REPLACE";
            this.btnREPLACE.UseVisualStyleBackColor = true;
            this.btnREPLACE.Click += new System.EventHandler(this.btnREPLACE_Click);
            // 
            // btnREMOVE
            // 
            this.btnREMOVE.Location = new System.Drawing.Point(39, 148);
            this.btnREMOVE.Name = "btnREMOVE";
            this.btnREMOVE.Size = new System.Drawing.Size(86, 37);
            this.btnREMOVE.TabIndex = 6;
            this.btnREMOVE.Tag = "Remove all files and folders in \"addons\" folder in each server";
            this.btnREMOVE.Text = "REMOVE";
            this.btnREMOVE.UseVisualStyleBackColor = true;
            this.btnREMOVE.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSELSTART);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.btnSHUTDOWN);
            this.groupBox1.Controls.Add(this.btnREMOVE);
            this.groupBox1.Controls.Add(this.btnREPLACE);
            this.groupBox1.Location = new System.Drawing.Point(15, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 322);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servers";
            // 
            // btnSELSTART
            // 
            this.btnSELSTART.Location = new System.Drawing.Point(39, 264);
            this.btnSELSTART.Name = "btnSELSTART";
            this.btnSELSTART.Size = new System.Drawing.Size(86, 37);
            this.btnSELSTART.TabIndex = 8;
            this.btnSELSTART.Tag = "";
            this.btnSELSTART.Text = "Selective Start";
            this.btnSELSTART.UseVisualStyleBackColor = true;
            this.btnSELSTART.Click += new System.EventHandler(this.btnSELSTART_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(39, 206);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(86, 37);
            this.btnStart.TabIndex = 7;
            this.btnStart.Tag = "";
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnBULLY
            // 
            this.btnBULLY.Location = new System.Drawing.Point(100, 389);
            this.btnBULLY.Name = "btnBULLY";
            this.btnBULLY.Size = new System.Drawing.Size(75, 23);
            this.btnBULLY.TabIndex = 8;
            this.btnBULLY.Text = "Advanced";
            this.btnBULLY.UseVisualStyleBackColor = true;
            this.btnBULLY.Click += new System.EventHandler(this.btnBULLY_Click);
            // 
            // lLIMIT
            // 
            this.lLIMIT.AutoSize = true;
            this.lLIMIT.Location = new System.Drawing.Point(12, 428);
            this.lLIMIT.Name = "lLIMIT";
            this.lLIMIT.Size = new System.Drawing.Size(185, 13);
            this.lLIMIT.TabIndex = 9;
            this.lLIMIT.Text = "WARNING! 10 servers limit overriden!";
            this.lLIMIT.Visible = false;
            // 
            // panelSELSTART
            // 
            this.panelSELSTART.Controls.Add(this.panel_btnSave);
            this.panelSELSTART.Controls.Add(this.panel_btnUNSAVE);
            this.panelSELSTART.Controls.Add(this.panel_btnClear);
            this.panelSELSTART.Controls.Add(this.panel_btnCancel);
            this.panelSELSTART.Controls.Add(this.panel_btnSTART);
            this.panelSELSTART.Controls.Add(this.dgvToStart);
            this.panelSELSTART.Controls.Add(this.dgvSELECT);
            this.panelSELSTART.Controls.Add(this.menuStrip2);
            this.panelSELSTART.Location = new System.Drawing.Point(0, 24);
            this.panelSELSTART.Name = "panelSELSTART";
            this.panelSELSTART.Size = new System.Drawing.Size(800, 426);
            this.panelSELSTART.TabIndex = 10;
            this.panelSELSTART.Visible = false;
            this.panelSELSTART.Leave += new System.EventHandler(this.panelSELSTART_Leave);
            // 
            // panel_btnSave
            // 
            this.panel_btnSave.Location = new System.Drawing.Point(93, 404);
            this.panel_btnSave.Name = "panel_btnSave";
            this.panel_btnSave.Size = new System.Drawing.Size(75, 22);
            this.panel_btnSave.TabIndex = 7;
            this.panel_btnSave.Text = "Save";
            this.panel_btnSave.UseVisualStyleBackColor = true;
            this.panel_btnSave.Click += new System.EventHandler(this.panel_btnSave_Click);
            // 
            // panel_btnUNSAVE
            // 
            this.panel_btnUNSAVE.Location = new System.Drawing.Point(12, 404);
            this.panel_btnUNSAVE.Name = "panel_btnUNSAVE";
            this.panel_btnUNSAVE.Size = new System.Drawing.Size(75, 22);
            this.panel_btnUNSAVE.TabIndex = 6;
            this.panel_btnUNSAVE.Text = "Clear Save";
            this.panel_btnUNSAVE.UseVisualStyleBackColor = true;
            this.panel_btnUNSAVE.Click += new System.EventHandler(this.panel_btnUNSAVE_Click);
            // 
            // panel_btnClear
            // 
            this.panel_btnClear.Location = new System.Drawing.Point(525, 404);
            this.panel_btnClear.Name = "panel_btnClear";
            this.panel_btnClear.Size = new System.Drawing.Size(75, 22);
            this.panel_btnClear.TabIndex = 5;
            this.panel_btnClear.Text = "Clear";
            this.panel_btnClear.UseVisualStyleBackColor = true;
            this.panel_btnClear.Click += new System.EventHandler(this.panel_btnClear_Click);
            // 
            // panel_btnCancel
            // 
            this.panel_btnCancel.Location = new System.Drawing.Point(606, 404);
            this.panel_btnCancel.Name = "panel_btnCancel";
            this.panel_btnCancel.Size = new System.Drawing.Size(75, 22);
            this.panel_btnCancel.TabIndex = 4;
            this.panel_btnCancel.Text = "Cancel";
            this.panel_btnCancel.UseVisualStyleBackColor = true;
            this.panel_btnCancel.Click += new System.EventHandler(this.panel_btnCancel_Click);
            // 
            // panel_btnSTART
            // 
            this.panel_btnSTART.Location = new System.Drawing.Point(687, 403);
            this.panel_btnSTART.Name = "panel_btnSTART";
            this.panel_btnSTART.Size = new System.Drawing.Size(101, 23);
            this.panel_btnSTART.TabIndex = 3;
            this.panel_btnSTART.Text = "Start Selected";
            this.panel_btnSTART.UseVisualStyleBackColor = true;
            this.panel_btnSTART.Click += new System.EventHandler(this.panel_btnSTART_Click);
            // 
            // dgvToStart
            // 
            this.dgvToStart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToStart.Location = new System.Drawing.Point(419, 17);
            this.dgvToStart.Name = "dgvToStart";
            this.dgvToStart.ReadOnly = true;
            this.dgvToStart.Size = new System.Drawing.Size(378, 385);
            this.dgvToStart.TabIndex = 1;
            // 
            // dgvSELECT
            // 
            this.dgvSELECT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSELECT.Location = new System.Drawing.Point(6, 17);
            this.dgvSELECT.Name = "dgvSELECT";
            this.dgvSELECT.ReadOnly = true;
            this.dgvSELECT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSELECT.Size = new System.Drawing.Size(395, 385);
            this.dgvSELECT.TabIndex = 0;
            this.dgvSELECT.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSELECT_RowHeaderMouseDoubleClick);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.availableServersToolStripMenuItem,
            this.toolStripMenuItem2,
            this.selectedToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // availableServersToolStripMenuItem
            // 
            this.availableServersToolStripMenuItem.Name = "availableServersToolStripMenuItem";
            this.availableServersToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.availableServersToolStripMenuItem.Text = "Available servers";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(319, 20);
            this.toolStripMenuItem2.Text = "                                                                                 " +
    "                   ";
            // 
            // selectedToolStripMenuItem
            // 
            this.selectedToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.selectedToolStripMenuItem.Name = "selectedToolStripMenuItem";
            this.selectedToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.selectedToolStripMenuItem.Text = "Selected";
            // 
            // btnHELP
            // 
            this.btnHELP.Location = new System.Drawing.Point(19, 389);
            this.btnHELP.Name = "btnHELP";
            this.btnHELP.Size = new System.Drawing.Size(75, 23);
            this.btnHELP.TabIndex = 11;
            this.btnHELP.Text = "HELP";
            this.btnHELP.UseVisualStyleBackColor = true;
            this.btnHELP.Click += new System.EventHandler(this.btnHELP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHELP);
            this.Controls.Add(this.panelSELSTART);
            this.Controls.Add(this.lLIMIT);
            this.Controls.Add(this.btnBULLY);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtbLIST);
            this.Controls.Add(this.lROOTdir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CrownPitch Royal - BeamNG.drive Server Manager";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panelSELSTART.ResumeLayout(false);
            this.panelSELSTART.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSELECT)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectROOTDirToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lROOTdir;
        private System.Windows.Forms.RichTextBox rtbLIST;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem validServersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveROOTDirLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearROOTDirLocationToolStripMenuItem;
        private System.Windows.Forms.Button btnSHUTDOWN;
        private System.Windows.Forms.Button btnREPLACE;
        private System.Windows.Forms.Button btnREMOVE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnBULLY;
        private System.Windows.Forms.Label lLIMIT;
        private System.Windows.Forms.Button btnSELSTART;
        private System.Windows.Forms.Panel panelSELSTART;
        private System.Windows.Forms.DataGridView dgvToStart;
        private System.Windows.Forms.DataGridView dgvSELECT;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem availableServersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem selectedToolStripMenuItem;
        private System.Windows.Forms.Button panel_btnCancel;
        private System.Windows.Forms.Button panel_btnSTART;
        private System.Windows.Forms.Button panel_btnClear;
        private System.Windows.Forms.Button panel_btnSave;
        private System.Windows.Forms.Button panel_btnUNSAVE;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem uPDATEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uPDATENOWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bACKUPExeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreExeToolStripMenuItem;
        private System.Windows.Forms.Button btnHELP;
    }
}

