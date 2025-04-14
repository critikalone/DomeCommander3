namespace ASCOM.pod
{
    partial class Network
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
            this.group_connectNetwork = new System.Windows.Forms.GroupBox();
            this.btn_netDisconnect = new System.Windows.Forms.Button();
            this.btn_serverIp = new System.Windows.Forms.Button();
            this.lbl_serverIp = new System.Windows.Forms.Label();
            this.txtBox_serverIp = new System.Windows.Forms.TextBox();
            this.group_diagnostics = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_netDomeControls = new System.Windows.Forms.Label();
            this.btn_netGetConfigIni = new System.Windows.Forms.Button();
            this.btn_netDownloadLog = new System.Windows.Forms.Button();
            this.btn_netCloseFlap = new System.Windows.Forms.Button();
            this.lbl_netLog = new System.Windows.Forms.Label();
            this.btn_netOpenFlap = new System.Windows.Forms.Button();
            this.btn_slotPowerOff = new System.Windows.Forms.Button();
            this.btn_slotPowerOn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_slotShortDiag = new System.Windows.Forms.Button();
            this.btn_netSlotFullDiag = new System.Windows.Forms.Button();
            this.lvl_netSlotDiagnostics = new System.Windows.Forms.Label();
            this.btn_netSlotShutdown = new System.Windows.Forms.Button();
            this.btn_netSlotReboot = new System.Windows.Forms.Button();
            this.btn_netSlotFullClose = new System.Windows.Forms.Button();
            this.btn_slotFullOpen = new System.Windows.Forms.Button();
            this.btn_netPark = new System.Windows.Forms.Button();
            this.btn_netHome = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSCOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callibrateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.group_connectNetwork.SuspendLayout();
            this.group_diagnostics.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_connectNetwork
            // 
            this.group_connectNetwork.Controls.Add(this.btn_netDisconnect);
            this.group_connectNetwork.Controls.Add(this.btn_serverIp);
            this.group_connectNetwork.Controls.Add(this.lbl_serverIp);
            this.group_connectNetwork.Controls.Add(this.txtBox_serverIp);
            this.group_connectNetwork.Location = new System.Drawing.Point(0, 31);
            this.group_connectNetwork.Name = "group_connectNetwork";
            this.group_connectNetwork.Size = new System.Drawing.Size(404, 62);
            this.group_connectNetwork.TabIndex = 9;
            this.group_connectNetwork.TabStop = false;
            this.group_connectNetwork.Text = "Connect to Dome Server";
            // 
            // btn_netDisconnect
            // 
            this.btn_netDisconnect.Enabled = false;
            this.btn_netDisconnect.Location = new System.Drawing.Point(252, 27);
            this.btn_netDisconnect.Name = "btn_netDisconnect";
            this.btn_netDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btn_netDisconnect.TabIndex = 3;
            this.btn_netDisconnect.Text = "Disconnect";
            this.btn_netDisconnect.UseVisualStyleBackColor = true;
            // 
            // btn_serverIp
            // 
            this.btn_serverIp.Location = new System.Drawing.Point(171, 27);
            this.btn_serverIp.Name = "btn_serverIp";
            this.btn_serverIp.Size = new System.Drawing.Size(75, 23);
            this.btn_serverIp.TabIndex = 2;
            this.btn_serverIp.Text = "Connect";
            this.btn_serverIp.UseVisualStyleBackColor = true;
            // 
            // lbl_serverIp
            // 
            this.lbl_serverIp.AutoSize = true;
            this.lbl_serverIp.Location = new System.Drawing.Point(7, 34);
            this.lbl_serverIp.Name = "lbl_serverIp";
            this.lbl_serverIp.Size = new System.Drawing.Size(51, 13);
            this.lbl_serverIp.TabIndex = 1;
            this.lbl_serverIp.Text = "Server IP";
            // 
            // txtBox_serverIp
            // 
            this.txtBox_serverIp.Location = new System.Drawing.Point(64, 31);
            this.txtBox_serverIp.Name = "txtBox_serverIp";
            this.txtBox_serverIp.Size = new System.Drawing.Size(100, 20);
            this.txtBox_serverIp.TabIndex = 0;
            // 
            // group_diagnostics
            // 
            this.group_diagnostics.Controls.Add(this.button2);
            this.group_diagnostics.Controls.Add(this.button1);
            this.group_diagnostics.Controls.Add(this.textBox1);
            this.group_diagnostics.Controls.Add(this.label2);
            this.group_diagnostics.Controls.Add(this.lbl_netDomeControls);
            this.group_diagnostics.Controls.Add(this.btn_netGetConfigIni);
            this.group_diagnostics.Controls.Add(this.btn_netDownloadLog);
            this.group_diagnostics.Controls.Add(this.btn_netCloseFlap);
            this.group_diagnostics.Controls.Add(this.lbl_netLog);
            this.group_diagnostics.Controls.Add(this.btn_netOpenFlap);
            this.group_diagnostics.Controls.Add(this.btn_slotPowerOff);
            this.group_diagnostics.Controls.Add(this.btn_slotPowerOn);
            this.group_diagnostics.Controls.Add(this.label1);
            this.group_diagnostics.Controls.Add(this.btn_slotShortDiag);
            this.group_diagnostics.Controls.Add(this.btn_netSlotFullDiag);
            this.group_diagnostics.Controls.Add(this.lvl_netSlotDiagnostics);
            this.group_diagnostics.Controls.Add(this.btn_netSlotShutdown);
            this.group_diagnostics.Controls.Add(this.btn_netSlotReboot);
            this.group_diagnostics.Controls.Add(this.btn_netSlotFullClose);
            this.group_diagnostics.Controls.Add(this.btn_slotFullOpen);
            this.group_diagnostics.Controls.Add(this.btn_netPark);
            this.group_diagnostics.Controls.Add(this.btn_netHome);
            this.group_diagnostics.Location = new System.Drawing.Point(0, 104);
            this.group_diagnostics.Name = "group_diagnostics";
            this.group_diagnostics.Size = new System.Drawing.Size(405, 342);
            this.group_diagnostics.TabIndex = 8;
            this.group_diagnostics.TabStop = false;
            this.group_diagnostics.Text = "Diagnostic Data";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Upload";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Firmware Update";
            // 
            // lbl_netDomeControls
            // 
            this.lbl_netDomeControls.AutoSize = true;
            this.lbl_netDomeControls.Location = new System.Drawing.Point(8, 133);
            this.lbl_netDomeControls.Name = "lbl_netDomeControls";
            this.lbl_netDomeControls.Size = new System.Drawing.Size(76, 13);
            this.lbl_netDomeControls.TabIndex = 18;
            this.lbl_netDomeControls.Text = "Dome Controls";
            // 
            // btn_netGetConfigIni
            // 
            this.btn_netGetConfigIni.Location = new System.Drawing.Point(98, 306);
            this.btn_netGetConfigIni.Name = "btn_netGetConfigIni";
            this.btn_netGetConfigIni.Size = new System.Drawing.Size(79, 23);
            this.btn_netGetConfigIni.TabIndex = 17;
            this.btn_netGetConfigIni.Text = "Get Config.ini";
            this.btn_netGetConfigIni.UseVisualStyleBackColor = true;
            // 
            // btn_netDownloadLog
            // 
            this.btn_netDownloadLog.Location = new System.Drawing.Point(2, 306);
            this.btn_netDownloadLog.Name = "btn_netDownloadLog";
            this.btn_netDownloadLog.Size = new System.Drawing.Size(90, 23);
            this.btn_netDownloadLog.TabIndex = 16;
            this.btn_netDownloadLog.Text = "Download Log";
            this.btn_netDownloadLog.UseVisualStyleBackColor = true;
            // 
            // btn_netCloseFlap
            // 
            this.btn_netCloseFlap.Location = new System.Drawing.Point(248, 15);
            this.btn_netCloseFlap.Name = "btn_netCloseFlap";
            this.btn_netCloseFlap.Size = new System.Drawing.Size(75, 23);
            this.btn_netCloseFlap.TabIndex = 15;
            this.btn_netCloseFlap.Text = "Close Flap";
            this.btn_netCloseFlap.UseVisualStyleBackColor = true;
            // 
            // lbl_netLog
            // 
            this.lbl_netLog.AutoSize = true;
            this.lbl_netLog.Location = new System.Drawing.Point(7, 287);
            this.lbl_netLog.Name = "lbl_netLog";
            this.lbl_netLog.Size = new System.Drawing.Size(45, 13);
            this.lbl_netLog.TabIndex = 14;
            this.lbl_netLog.Text = "Logging";
            // 
            // btn_netOpenFlap
            // 
            this.btn_netOpenFlap.Location = new System.Drawing.Point(171, 15);
            this.btn_netOpenFlap.Name = "btn_netOpenFlap";
            this.btn_netOpenFlap.Size = new System.Drawing.Size(75, 23);
            this.btn_netOpenFlap.TabIndex = 12;
            this.btn_netOpenFlap.Text = "Open Flap";
            this.btn_netOpenFlap.UseVisualStyleBackColor = true;
            // 
            // btn_slotPowerOff
            // 
            this.btn_slotPowerOff.Location = new System.Drawing.Point(87, 101);
            this.btn_slotPowerOff.Name = "btn_slotPowerOff";
            this.btn_slotPowerOff.Size = new System.Drawing.Size(75, 23);
            this.btn_slotPowerOff.TabIndex = 11;
            this.btn_slotPowerOff.Text = "OFF";
            this.btn_slotPowerOff.UseVisualStyleBackColor = true;
            // 
            // btn_slotPowerOn
            // 
            this.btn_slotPowerOn.Location = new System.Drawing.Point(10, 101);
            this.btn_slotPowerOn.Name = "btn_slotPowerOn";
            this.btn_slotPowerOn.Size = new System.Drawing.Size(75, 23);
            this.btn_slotPowerOn.TabIndex = 10;
            this.btn_slotPowerOn.Text = "ON";
            this.btn_slotPowerOn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Slot Power";
            // 
            // btn_slotShortDiag
            // 
            this.btn_slotShortDiag.Location = new System.Drawing.Point(87, 58);
            this.btn_slotShortDiag.Name = "btn_slotShortDiag";
            this.btn_slotShortDiag.Size = new System.Drawing.Size(75, 23);
            this.btn_slotShortDiag.TabIndex = 8;
            this.btn_slotShortDiag.Text = "Short";
            this.btn_slotShortDiag.UseVisualStyleBackColor = true;
            // 
            // btn_netSlotFullDiag
            // 
            this.btn_netSlotFullDiag.Location = new System.Drawing.Point(10, 58);
            this.btn_netSlotFullDiag.Name = "btn_netSlotFullDiag";
            this.btn_netSlotFullDiag.Size = new System.Drawing.Size(75, 23);
            this.btn_netSlotFullDiag.TabIndex = 7;
            this.btn_netSlotFullDiag.Text = "Full";
            this.btn_netSlotFullDiag.UseVisualStyleBackColor = true;
            // 
            // lvl_netSlotDiagnostics
            // 
            this.lvl_netSlotDiagnostics.AutoSize = true;
            this.lvl_netSlotDiagnostics.Location = new System.Drawing.Point(6, 41);
            this.lvl_netSlotDiagnostics.Name = "lvl_netSlotDiagnostics";
            this.lvl_netSlotDiagnostics.Size = new System.Drawing.Size(83, 13);
            this.lvl_netSlotDiagnostics.TabIndex = 6;
            this.lvl_netSlotDiagnostics.Text = "Slot Diagnostics";
            // 
            // btn_netSlotShutdown
            // 
            this.btn_netSlotShutdown.Location = new System.Drawing.Point(237, 101);
            this.btn_netSlotShutdown.Name = "btn_netSlotShutdown";
            this.btn_netSlotShutdown.Size = new System.Drawing.Size(86, 23);
            this.btn_netSlotShutdown.TabIndex = 5;
            this.btn_netSlotShutdown.Text = "Slot Shutdown";
            this.btn_netSlotShutdown.UseVisualStyleBackColor = true;
            // 
            // btn_netSlotReboot
            // 
            this.btn_netSlotReboot.Location = new System.Drawing.Point(163, 101);
            this.btn_netSlotReboot.Name = "btn_netSlotReboot";
            this.btn_netSlotReboot.Size = new System.Drawing.Size(75, 23);
            this.btn_netSlotReboot.TabIndex = 4;
            this.btn_netSlotReboot.Text = "Slot Reboot";
            this.btn_netSlotReboot.UseVisualStyleBackColor = true;
            // 
            // btn_netSlotFullClose
            // 
            this.btn_netSlotFullClose.Location = new System.Drawing.Point(90, 15);
            this.btn_netSlotFullClose.Name = "btn_netSlotFullClose";
            this.btn_netSlotFullClose.Size = new System.Drawing.Size(82, 23);
            this.btn_netSlotFullClose.TabIndex = 3;
            this.btn_netSlotFullClose.Text = "Slot Full Close";
            this.btn_netSlotFullClose.UseVisualStyleBackColor = true;
            // 
            // btn_slotFullOpen
            // 
            this.btn_slotFullOpen.Location = new System.Drawing.Point(10, 15);
            this.btn_slotFullOpen.Name = "btn_slotFullOpen";
            this.btn_slotFullOpen.Size = new System.Drawing.Size(81, 23);
            this.btn_slotFullOpen.TabIndex = 2;
            this.btn_slotFullOpen.Text = "Slot Full Open";
            this.btn_slotFullOpen.UseVisualStyleBackColor = true;
            // 
            // btn_netPark
            // 
            this.btn_netPark.Location = new System.Drawing.Point(90, 150);
            this.btn_netPark.Name = "btn_netPark";
            this.btn_netPark.Size = new System.Drawing.Size(75, 23);
            this.btn_netPark.TabIndex = 1;
            this.btn_netPark.Text = "Park";
            this.btn_netPark.UseVisualStyleBackColor = true;
            // 
            // btn_netHome
            // 
            this.btn_netHome.Location = new System.Drawing.Point(9, 150);
            this.btn_netHome.Name = "btn_netHome";
            this.btn_netHome.Size = new System.Drawing.Size(75, 23);
            this.btn_netHome.TabIndex = 0;
            this.btn_netHome.Text = "Home";
            this.btn_netHome.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolboxToolStripMenuItem,
            this.callibrateToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(406, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolboxToolStripMenuItem
            // 
            this.toolboxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aSCOMToolStripMenuItem,
            this.networkToolStripMenuItem});
            this.toolboxToolStripMenuItem.Name = "toolboxToolStripMenuItem";
            this.toolboxToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.toolboxToolStripMenuItem.Text = "Connection";
            // 
            // aSCOMToolStripMenuItem
            // 
            this.aSCOMToolStripMenuItem.Name = "aSCOMToolStripMenuItem";
            this.aSCOMToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.aSCOMToolStripMenuItem.Text = "ASCOM";
            // 
            // networkToolStripMenuItem
            // 
            this.networkToolStripMenuItem.Name = "networkToolStripMenuItem";
            this.networkToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.networkToolStripMenuItem.Text = "Network";
            // 
            // callibrateToolStripMenuItem
            // 
            this.callibrateToolStripMenuItem.Name = "callibrateToolStripMenuItem";
            this.callibrateToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.callibrateToolStripMenuItem.Text = "Utilities";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Network
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.group_connectNetwork);
            this.Controls.Add(this.group_diagnostics);
            this.Name = "Network";
            this.Text = "Form1";
            this.group_connectNetwork.ResumeLayout(false);
            this.group_connectNetwork.PerformLayout();
            this.group_diagnostics.ResumeLayout(false);
            this.group_diagnostics.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox group_connectNetwork;
        private System.Windows.Forms.Button btn_netDisconnect;
        private System.Windows.Forms.Button btn_serverIp;
        private System.Windows.Forms.Label lbl_serverIp;
        private System.Windows.Forms.TextBox txtBox_serverIp;
        private System.Windows.Forms.GroupBox group_diagnostics;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_netDomeControls;
        private System.Windows.Forms.Button btn_netGetConfigIni;
        private System.Windows.Forms.Button btn_netDownloadLog;
        private System.Windows.Forms.Button btn_netCloseFlap;
        private System.Windows.Forms.Label lbl_netLog;
        private System.Windows.Forms.Button btn_netOpenFlap;
        private System.Windows.Forms.Button btn_slotPowerOff;
        private System.Windows.Forms.Button btn_slotPowerOn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_slotShortDiag;
        private System.Windows.Forms.Button btn_netSlotFullDiag;
        private System.Windows.Forms.Label lvl_netSlotDiagnostics;
        private System.Windows.Forms.Button btn_netSlotShutdown;
        private System.Windows.Forms.Button btn_netSlotReboot;
        private System.Windows.Forms.Button btn_netSlotFullClose;
        private System.Windows.Forms.Button btn_slotFullOpen;
        private System.Windows.Forms.Button btn_netPark;
        private System.Windows.Forms.Button btn_netHome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aSCOMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem networkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callibrateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}