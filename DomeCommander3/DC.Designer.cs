namespace ASCOM.pod
{
    partial class DC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DC));
            this.buttonChoose = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelDriverId = new System.Windows.Forms.Label();
            this.group_connectAscom = new System.Windows.Forms.GroupBox();
            this.group_ascomControls = new System.Windows.Forms.GroupBox();
            this.btn_ccw = new System.Windows.Forms.Button();
            this.btn_cw = new System.Windows.Forms.Button();
            this.txtBox_azimuth = new System.Windows.Forms.TextBox();
            this.txtBox_slotStatus = new System.Windows.Forms.TextBox();
            this.txtBox_status = new System.Windows.Forms.TextBox();
            this.txtBox_goTo = new System.Windows.Forms.TextBox();
            this.btn_goTo = new System.Windows.Forms.Button();
            this.btn_closeSlot = new System.Windows.Forms.Button();
            this.btn_openSlot = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_park = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.group_advancedControls = new System.Windows.Forms.GroupBox();
            this.lbl_commandsText = new System.Windows.Forms.Label();
            this.lbl_commands = new System.Windows.Forms.Label();
            this.txtBox_param = new System.Windows.Forms.TextBox();
            this.btn_sendCommand = new System.Windows.Forms.Button();
            this.txtBox_sendCommand = new System.Windows.Forms.TextBox();
            this.lvl_sendCommand = new System.Windows.Forms.Label();
            this.lbl_driverInfoText = new System.Windows.Forms.Label();
            this.lbl_driverInfo = new System.Windows.Forms.Label();
            this.btn_setPark = new System.Windows.Forms.Button();
            this.txtBox_setPark = new System.Windows.Forms.TextBox();
            this.lbl_setPark = new System.Windows.Forms.Label();
            this.lbl_driverVersionText = new System.Windows.Forms.Label();
            this.lbl_driverVersion = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSCOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callibrateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_netHome = new System.Windows.Forms.Button();
            this.btn_netPark = new System.Windows.Forms.Button();
            this.btn_slotFullOpen = new System.Windows.Forms.Button();
            this.btn_netSlotFullClose = new System.Windows.Forms.Button();
            this.btn_netSlotReboot = new System.Windows.Forms.Button();
            this.btn_netSlotShutdown = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_slotPowerOn = new System.Windows.Forms.Button();
            this.btn_slotPowerOff = new System.Windows.Forms.Button();
            this.btn_netOpenFlap = new System.Windows.Forms.Button();
            this.btn_netCloseFlap = new System.Windows.Forms.Button();
            this.lbl_netDomeControls = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.group_network_dome_controls = new System.Windows.Forms.GroupBox();
            this.dec_pot_btn = new System.Windows.Forms.Button();
            this.inc_pot_btn = new System.Windows.Forms.Button();
            this.sys_reboot_btn = new System.Windows.Forms.Button();
            this.system_shutdown_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.north_btn = new System.Windows.Forms.Button();
            this.stop_btn2 = new System.Windows.Forms.Button();
            this.up_btn = new System.Windows.Forms.Button();
            this.down_btn = new System.Windows.Forms.Button();
            this.dome_shutdown_btn = new System.Windows.Forms.Button();
            this.dome_reboot_btn = new System.Windows.Forms.Button();
            this.network_CCW_btn = new System.Windows.Forms.Button();
            this.networkCW_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_serverIp = new System.Windows.Forms.TextBox();
            this.lbl_serverIp = new System.Windows.Forms.Label();
            this.btn_serverIp = new System.Windows.Forms.Button();
            this.btn_netDisconnect = new System.Windows.Forms.Button();
            this.group_connectNetwork = new System.Windows.Forms.GroupBox();
            this.group_Diagnostics = new System.Windows.Forms.GroupBox();
            this.get_estatus_btn = new System.Windows.Forms.Button();
            this.log_serial_btn = new System.Windows.Forms.Button();
            this.log_file_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_netGetConfigIni = new System.Windows.Forms.Button();
            this.btn_netDownloadLog = new System.Windows.Forms.Button();
            this.lbl_netLog = new System.Windows.Forms.Label();
            this.btn_slotShortDiag = new System.Windows.Forms.Button();
            this.btn_netSlotFullDiag = new System.Windows.Forms.Button();
            this.lvl_netSlotDiagnostics = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.group_debugging = new System.Windows.Forms.GroupBox();
            this.set_debug_btn = new System.Windows.Forms.Button();
            this.reset_debug_btn = new System.Windows.Forms.Button();
            this.dump_msg_btn = new System.Windows.Forms.Button();
            this.dump_internal_btn = new System.Windows.Forms.Button();
            this.dump_debug_btn = new System.Windows.Forms.Button();
            this.clr_msg_btn = new System.Windows.Forms.Button();
            this.group_ascomControls.SuspendLayout();
            this.group_advancedControls.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.group_network_dome_controls.SuspendLayout();
            this.group_connectNetwork.SuspendLayout();
            this.group_Diagnostics.SuspendLayout();
            this.group_debugging.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(309, 37);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(72, 23);
            this.buttonChoose.TabIndex = 0;
            this.buttonChoose.Text = "Choose";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(309, 66);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(72, 23);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelDriverId
            // 
            this.labelDriverId.BackColor = System.Drawing.Color.Silver;
            this.labelDriverId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDriverId.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ASCOM.pod.Properties.Settings.Default, "DriverId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labelDriverId.Location = new System.Drawing.Point(12, 67);
            this.labelDriverId.Name = "labelDriverId";
            this.labelDriverId.Size = new System.Drawing.Size(291, 21);
            this.labelDriverId.TabIndex = 2;
            this.labelDriverId.Text = global::ASCOM.pod.Properties.Settings.Default.DriverId;
            this.labelDriverId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // group_connectAscom
            // 
            this.group_connectAscom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.group_connectAscom.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.group_connectAscom.Location = new System.Drawing.Point(3, 32);
            this.group_connectAscom.Name = "group_connectAscom";
            this.group_connectAscom.Size = new System.Drawing.Size(394, 79);
            this.group_connectAscom.TabIndex = 3;
            this.group_connectAscom.TabStop = false;
            this.group_connectAscom.Text = "Connect to ASCOM Device";
            this.group_connectAscom.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // group_ascomControls
            // 
            this.group_ascomControls.Controls.Add(this.btn_ccw);
            this.group_ascomControls.Controls.Add(this.btn_cw);
            this.group_ascomControls.Controls.Add(this.txtBox_azimuth);
            this.group_ascomControls.Controls.Add(this.txtBox_slotStatus);
            this.group_ascomControls.Controls.Add(this.txtBox_status);
            this.group_ascomControls.Controls.Add(this.txtBox_goTo);
            this.group_ascomControls.Controls.Add(this.btn_goTo);
            this.group_ascomControls.Controls.Add(this.btn_closeSlot);
            this.group_ascomControls.Controls.Add(this.btn_openSlot);
            this.group_ascomControls.Controls.Add(this.btn_stop);
            this.group_ascomControls.Controls.Add(this.btn_park);
            this.group_ascomControls.Controls.Add(this.btn_home);
            this.group_ascomControls.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.group_ascomControls.Location = new System.Drawing.Point(3, 117);
            this.group_ascomControls.Name = "group_ascomControls";
            this.group_ascomControls.Size = new System.Drawing.Size(394, 113);
            this.group_ascomControls.TabIndex = 4;
            this.group_ascomControls.TabStop = false;
            this.group_ascomControls.Text = "ASCOM Dome Controls";
            // 
            // btn_ccw
            // 
            this.btn_ccw.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_ccw.Location = new System.Drawing.Point(286, 78);
            this.btn_ccw.Name = "btn_ccw";
            this.btn_ccw.Size = new System.Drawing.Size(75, 23);
            this.btn_ccw.TabIndex = 10;
            this.btn_ccw.Text = "CCW";
            this.btn_ccw.UseVisualStyleBackColor = true;
            this.btn_ccw.Click += new System.EventHandler(this.btn_ccw_Click);
            // 
            // btn_cw
            // 
            this.btn_cw.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_cw.Location = new System.Drawing.Point(286, 49);
            this.btn_cw.Name = "btn_cw";
            this.btn_cw.Size = new System.Drawing.Size(75, 23);
            this.btn_cw.TabIndex = 9;
            this.btn_cw.Text = "CW";
            this.btn_cw.UseVisualStyleBackColor = true;
            this.btn_cw.Click += new System.EventHandler(this.btn_cw_Click);
            // 
            // txtBox_azimuth
            // 
            this.txtBox_azimuth.Location = new System.Drawing.Point(234, 47);
            this.txtBox_azimuth.Name = "txtBox_azimuth";
            this.txtBox_azimuth.ReadOnly = true;
            this.txtBox_azimuth.Size = new System.Drawing.Size(45, 20);
            this.txtBox_azimuth.TabIndex = 8;
            // 
            // txtBox_slotStatus
            // 
            this.txtBox_slotStatus.Location = new System.Drawing.Point(169, 19);
            this.txtBox_slotStatus.Name = "txtBox_slotStatus";
            this.txtBox_slotStatus.ReadOnly = true;
            this.txtBox_slotStatus.Size = new System.Drawing.Size(110, 20);
            this.txtBox_slotStatus.TabIndex = 7;
            this.txtBox_slotStatus.TextChanged += new System.EventHandler(this.txtBox_slotStatus_TextChanged);
            // 
            // txtBox_status
            // 
            this.txtBox_status.Location = new System.Drawing.Point(168, 48);
            this.txtBox_status.Name = "txtBox_status";
            this.txtBox_status.ReadOnly = true;
            this.txtBox_status.Size = new System.Drawing.Size(59, 20);
            this.txtBox_status.TabIndex = 6;
            this.txtBox_status.TextChanged += new System.EventHandler(this.txtBox_status_TextChanged);
            // 
            // txtBox_goTo
            // 
            this.txtBox_goTo.Location = new System.Drawing.Point(169, 78);
            this.txtBox_goTo.Name = "txtBox_goTo";
            this.txtBox_goTo.Size = new System.Drawing.Size(110, 20);
            this.txtBox_goTo.TabIndex = 6;
            // 
            // btn_goTo
            // 
            this.btn_goTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_goTo.Location = new System.Drawing.Point(88, 75);
            this.btn_goTo.Name = "btn_goTo";
            this.btn_goTo.Size = new System.Drawing.Size(75, 23);
            this.btn_goTo.TabIndex = 5;
            this.btn_goTo.Text = "Go To";
            this.btn_goTo.UseVisualStyleBackColor = false;
            this.btn_goTo.Click += new System.EventHandler(this.btn_goTo_Click);
            // 
            // btn_closeSlot
            // 
            this.btn_closeSlot.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_closeSlot.Location = new System.Drawing.Point(88, 19);
            this.btn_closeSlot.Name = "btn_closeSlot";
            this.btn_closeSlot.Size = new System.Drawing.Size(75, 23);
            this.btn_closeSlot.TabIndex = 4;
            this.btn_closeSlot.Text = "Close Slot";
            this.btn_closeSlot.UseVisualStyleBackColor = true;
            this.btn_closeSlot.Click += new System.EventHandler(this.btn_closeSlot_Click);
            // 
            // btn_openSlot
            // 
            this.btn_openSlot.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_openSlot.Location = new System.Drawing.Point(7, 19);
            this.btn_openSlot.Name = "btn_openSlot";
            this.btn_openSlot.Size = new System.Drawing.Size(75, 23);
            this.btn_openSlot.TabIndex = 3;
            this.btn_openSlot.Text = "Open Slot";
            this.btn_openSlot.UseVisualStyleBackColor = true;
            this.btn_openSlot.Click += new System.EventHandler(this.btn_openSlot_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.Red;
            this.btn_stop.ForeColor = System.Drawing.Color.White;
            this.btn_stop.Location = new System.Drawing.Point(7, 75);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_park
            // 
            this.btn_park.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_park.Location = new System.Drawing.Point(88, 48);
            this.btn_park.Name = "btn_park";
            this.btn_park.Size = new System.Drawing.Size(75, 23);
            this.btn_park.TabIndex = 1;
            this.btn_park.Text = "Park";
            this.btn_park.UseVisualStyleBackColor = true;
            this.btn_park.Click += new System.EventHandler(this.btn_park_Click);
            // 
            // btn_home
            // 
            this.btn_home.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_home.Location = new System.Drawing.Point(7, 48);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(75, 23);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // group_advancedControls
            // 
            this.group_advancedControls.Controls.Add(this.lbl_commandsText);
            this.group_advancedControls.Controls.Add(this.lbl_commands);
            this.group_advancedControls.Controls.Add(this.txtBox_param);
            this.group_advancedControls.Controls.Add(this.btn_sendCommand);
            this.group_advancedControls.Controls.Add(this.txtBox_sendCommand);
            this.group_advancedControls.Controls.Add(this.lvl_sendCommand);
            this.group_advancedControls.Controls.Add(this.lbl_driverInfoText);
            this.group_advancedControls.Controls.Add(this.lbl_driverInfo);
            this.group_advancedControls.Controls.Add(this.btn_setPark);
            this.group_advancedControls.Controls.Add(this.txtBox_setPark);
            this.group_advancedControls.Controls.Add(this.lbl_setPark);
            this.group_advancedControls.Controls.Add(this.lbl_driverVersionText);
            this.group_advancedControls.Controls.Add(this.lbl_driverVersion);
            this.group_advancedControls.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.group_advancedControls.Location = new System.Drawing.Point(3, 236);
            this.group_advancedControls.Name = "group_advancedControls";
            this.group_advancedControls.Size = new System.Drawing.Size(394, 181);
            this.group_advancedControls.TabIndex = 6;
            this.group_advancedControls.TabStop = false;
            this.group_advancedControls.Text = "Advanced ASCOM Controls";
            this.group_advancedControls.Visible = false;
            this.group_advancedControls.Enter += new System.EventHandler(this.group_advancedControls_Enter);
            // 
            // lbl_commandsText
            // 
            this.lbl_commandsText.AutoSize = true;
            this.lbl_commandsText.Location = new System.Drawing.Point(95, 143);
            this.lbl_commandsText.Name = "lbl_commandsText";
            this.lbl_commandsText.Size = new System.Drawing.Size(103, 13);
            this.lbl_commandsText.TabIndex = 12;
            this.lbl_commandsText.Text = "no information found";
            // 
            // lbl_commands
            // 
            this.lbl_commands.AutoSize = true;
            this.lbl_commands.Location = new System.Drawing.Point(10, 143);
            this.lbl_commands.Name = "lbl_commands";
            this.lbl_commands.Size = new System.Drawing.Size(59, 13);
            this.lbl_commands.TabIndex = 11;
            this.lbl_commands.Text = "Commands";
            // 
            // txtBox_param
            // 
            this.txtBox_param.Location = new System.Drawing.Point(204, 116);
            this.txtBox_param.Name = "txtBox_param";
            this.txtBox_param.Size = new System.Drawing.Size(100, 20);
            this.txtBox_param.TabIndex = 10;
            // 
            // btn_sendCommand
            // 
            this.btn_sendCommand.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_sendCommand.Location = new System.Drawing.Point(310, 114);
            this.btn_sendCommand.Name = "btn_sendCommand";
            this.btn_sendCommand.Size = new System.Drawing.Size(75, 23);
            this.btn_sendCommand.TabIndex = 9;
            this.btn_sendCommand.Text = "Send Cmd";
            this.btn_sendCommand.UseVisualStyleBackColor = true;
            this.btn_sendCommand.Click += new System.EventHandler(this.btn_sendCommand_Click);
            // 
            // txtBox_sendCommand
            // 
            this.txtBox_sendCommand.Location = new System.Drawing.Point(98, 116);
            this.txtBox_sendCommand.Name = "txtBox_sendCommand";
            this.txtBox_sendCommand.Size = new System.Drawing.Size(100, 20);
            this.txtBox_sendCommand.TabIndex = 8;
            // 
            // lvl_sendCommand
            // 
            this.lvl_sendCommand.AutoSize = true;
            this.lvl_sendCommand.Location = new System.Drawing.Point(10, 119);
            this.lvl_sendCommand.Name = "lvl_sendCommand";
            this.lvl_sendCommand.Size = new System.Drawing.Size(82, 13);
            this.lvl_sendCommand.TabIndex = 7;
            this.lvl_sendCommand.Text = "Send Command";
            // 
            // lbl_driverInfoText
            // 
            this.lbl_driverInfoText.AutoSize = true;
            this.lbl_driverInfoText.Location = new System.Drawing.Point(104, 41);
            this.lbl_driverInfoText.Name = "lbl_driverInfoText";
            this.lbl_driverInfoText.Size = new System.Drawing.Size(103, 13);
            this.lbl_driverInfoText.TabIndex = 6;
            this.lbl_driverInfoText.Text = "no information found";
            // 
            // lbl_driverInfo
            // 
            this.lbl_driverInfo.AutoSize = true;
            this.lbl_driverInfo.Location = new System.Drawing.Point(10, 43);
            this.lbl_driverInfo.Name = "lbl_driverInfo";
            this.lbl_driverInfo.Size = new System.Drawing.Size(56, 13);
            this.lbl_driverInfo.TabIndex = 5;
            this.lbl_driverInfo.Text = "Driver Info";
            // 
            // btn_setPark
            // 
            this.btn_setPark.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_setPark.Location = new System.Drawing.Point(143, 88);
            this.btn_setPark.Name = "btn_setPark";
            this.btn_setPark.Size = new System.Drawing.Size(58, 23);
            this.btn_setPark.TabIndex = 4;
            this.btn_setPark.Text = "Set";
            this.btn_setPark.UseVisualStyleBackColor = true;
            this.btn_setPark.Click += new System.EventHandler(this.btn_setPark_Click);
            // 
            // txtBox_setPark
            // 
            this.txtBox_setPark.Location = new System.Drawing.Point(98, 90);
            this.txtBox_setPark.Name = "txtBox_setPark";
            this.txtBox_setPark.Size = new System.Drawing.Size(39, 20);
            this.txtBox_setPark.TabIndex = 3;
            // 
            // lbl_setPark
            // 
            this.lbl_setPark.AutoSize = true;
            this.lbl_setPark.Location = new System.Drawing.Point(10, 95);
            this.lbl_setPark.Name = "lbl_setPark";
            this.lbl_setPark.Size = new System.Drawing.Size(88, 13);
            this.lbl_setPark.TabIndex = 2;
            this.lbl_setPark.Text = "Set Park Position";
            this.lbl_setPark.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_driverVersionText
            // 
            this.lbl_driverVersionText.AutoSize = true;
            this.lbl_driverVersionText.Location = new System.Drawing.Point(104, 20);
            this.lbl_driverVersionText.Name = "lbl_driverVersionText";
            this.lbl_driverVersionText.Size = new System.Drawing.Size(103, 13);
            this.lbl_driverVersionText.TabIndex = 1;
            this.lbl_driverVersionText.Text = "no information found";
            // 
            // lbl_driverVersion
            // 
            this.lbl_driverVersion.AutoSize = true;
            this.lbl_driverVersion.Location = new System.Drawing.Point(10, 20);
            this.lbl_driverVersion.Name = "lbl_driverVersion";
            this.lbl_driverVersion.Size = new System.Drawing.Size(73, 13);
            this.lbl_driverVersion.TabIndex = 0;
            this.lbl_driverVersion.Text = "Driver Version";
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
            this.menuStrip1.Size = new System.Drawing.Size(401, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolboxToolStripMenuItem
            // 
            this.toolboxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aSCOMToolStripMenuItem,
            this.networkToolStripMenuItem});
            this.toolboxToolStripMenuItem.Name = "toolboxToolStripMenuItem";
            this.toolboxToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.toolboxToolStripMenuItem.Text = "Connection";
            this.toolboxToolStripMenuItem.Click += new System.EventHandler(this.toolboxToolStripMenuItem_Click);
            // 
            // aSCOMToolStripMenuItem
            // 
            this.aSCOMToolStripMenuItem.Checked = true;
            this.aSCOMToolStripMenuItem.CheckOnClick = true;
            this.aSCOMToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aSCOMToolStripMenuItem.Name = "aSCOMToolStripMenuItem";
            this.aSCOMToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.aSCOMToolStripMenuItem.Text = "ASCOM";
            this.aSCOMToolStripMenuItem.Click += new System.EventHandler(this.aSCOMToolStripMenuItem_Click);
            // 
            // networkToolStripMenuItem
            // 
            this.networkToolStripMenuItem.CheckOnClick = true;
            this.networkToolStripMenuItem.Name = "networkToolStripMenuItem";
            this.networkToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.networkToolStripMenuItem.Text = "Network";
            this.networkToolStripMenuItem.Click += new System.EventHandler(this.networkToolStripMenuItem_Click);
            // 
            // callibrateToolStripMenuItem
            // 
            this.callibrateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diagnosticsToolStripMenuItem,
            this.advancedToolStripMenuItem});
            this.callibrateToolStripMenuItem.Name = "callibrateToolStripMenuItem";
            this.callibrateToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.callibrateToolStripMenuItem.Text = "Utilities";
            // 
            // diagnosticsToolStripMenuItem
            // 
            this.diagnosticsToolStripMenuItem.Name = "diagnosticsToolStripMenuItem";
            this.diagnosticsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.diagnosticsToolStripMenuItem.Text = "Diagnostics";
            this.diagnosticsToolStripMenuItem.Click += new System.EventHandler(this.diagnosticsToolStripMenuItem_Click);
            // 
            // advancedToolStripMenuItem
            // 
            this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
            this.advancedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.advancedToolStripMenuItem.Text = "Advanced";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // btn_netHome
            // 
            this.btn_netHome.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_netHome.Location = new System.Drawing.Point(10, 138);
            this.btn_netHome.Name = "btn_netHome";
            this.btn_netHome.Size = new System.Drawing.Size(75, 23);
            this.btn_netHome.TabIndex = 0;
            this.btn_netHome.Text = "Home";
            this.btn_netHome.UseVisualStyleBackColor = true;
            this.btn_netHome.Click += new System.EventHandler(this.btn_netHome_Click);
            // 
            // btn_netPark
            // 
            this.btn_netPark.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_netPark.Location = new System.Drawing.Point(91, 138);
            this.btn_netPark.Name = "btn_netPark";
            this.btn_netPark.Size = new System.Drawing.Size(75, 23);
            this.btn_netPark.TabIndex = 1;
            this.btn_netPark.Text = "Park";
            this.btn_netPark.UseVisualStyleBackColor = true;
            this.btn_netPark.Click += new System.EventHandler(this.btn_netPark_Click);
            // 
            // btn_slotFullOpen
            // 
            this.btn_slotFullOpen.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_slotFullOpen.Location = new System.Drawing.Point(10, 86);
            this.btn_slotFullOpen.Name = "btn_slotFullOpen";
            this.btn_slotFullOpen.Size = new System.Drawing.Size(81, 23);
            this.btn_slotFullOpen.TabIndex = 2;
            this.btn_slotFullOpen.Text = "Slot Full Open";
            this.btn_slotFullOpen.UseVisualStyleBackColor = true;
            this.btn_slotFullOpen.Click += new System.EventHandler(this.btn_slotFullOpen_Click);
            // 
            // btn_netSlotFullClose
            // 
            this.btn_netSlotFullClose.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_netSlotFullClose.Location = new System.Drawing.Point(95, 86);
            this.btn_netSlotFullClose.Name = "btn_netSlotFullClose";
            this.btn_netSlotFullClose.Size = new System.Drawing.Size(82, 23);
            this.btn_netSlotFullClose.TabIndex = 3;
            this.btn_netSlotFullClose.Text = "Slot Full Close";
            this.btn_netSlotFullClose.UseVisualStyleBackColor = true;
            this.btn_netSlotFullClose.Click += new System.EventHandler(this.btn_netSlotFullClose_Click);
            // 
            // btn_netSlotReboot
            // 
            this.btn_netSlotReboot.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_netSlotReboot.Location = new System.Drawing.Point(165, 36);
            this.btn_netSlotReboot.Name = "btn_netSlotReboot";
            this.btn_netSlotReboot.Size = new System.Drawing.Size(75, 23);
            this.btn_netSlotReboot.TabIndex = 4;
            this.btn_netSlotReboot.Text = "Slot Reboot";
            this.btn_netSlotReboot.UseVisualStyleBackColor = true;
            this.btn_netSlotReboot.Click += new System.EventHandler(this.btn_netSlotReboot_Click);
            // 
            // btn_netSlotShutdown
            // 
            this.btn_netSlotShutdown.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_netSlotShutdown.Location = new System.Drawing.Point(242, 36);
            this.btn_netSlotShutdown.Name = "btn_netSlotShutdown";
            this.btn_netSlotShutdown.Size = new System.Drawing.Size(86, 23);
            this.btn_netSlotShutdown.TabIndex = 5;
            this.btn_netSlotShutdown.Text = "Slot Shutdown";
            this.btn_netSlotShutdown.UseVisualStyleBackColor = true;
            this.btn_netSlotShutdown.Click += new System.EventHandler(this.btn_netSlotShutdown_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Slot Power";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btn_slotPowerOn
            // 
            this.btn_slotPowerOn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_slotPowerOn.Location = new System.Drawing.Point(10, 36);
            this.btn_slotPowerOn.Name = "btn_slotPowerOn";
            this.btn_slotPowerOn.Size = new System.Drawing.Size(75, 23);
            this.btn_slotPowerOn.TabIndex = 10;
            this.btn_slotPowerOn.Text = "ON";
            this.btn_slotPowerOn.UseVisualStyleBackColor = true;
            this.btn_slotPowerOn.Click += new System.EventHandler(this.btn_slotPowerOn_Click);
            // 
            // btn_slotPowerOff
            // 
            this.btn_slotPowerOff.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_slotPowerOff.Location = new System.Drawing.Point(88, 36);
            this.btn_slotPowerOff.Name = "btn_slotPowerOff";
            this.btn_slotPowerOff.Size = new System.Drawing.Size(75, 23);
            this.btn_slotPowerOff.TabIndex = 11;
            this.btn_slotPowerOff.Text = "OFF";
            this.btn_slotPowerOff.UseVisualStyleBackColor = true;
            this.btn_slotPowerOff.Click += new System.EventHandler(this.btn_slotPowerOff_Click);
            // 
            // btn_netOpenFlap
            // 
            this.btn_netOpenFlap.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_netOpenFlap.Location = new System.Drawing.Point(181, 86);
            this.btn_netOpenFlap.Name = "btn_netOpenFlap";
            this.btn_netOpenFlap.Size = new System.Drawing.Size(75, 23);
            this.btn_netOpenFlap.TabIndex = 12;
            this.btn_netOpenFlap.Text = "Open Flap";
            this.btn_netOpenFlap.UseVisualStyleBackColor = true;
            this.btn_netOpenFlap.Click += new System.EventHandler(this.btn_netOpenFlap_Click);
            // 
            // btn_netCloseFlap
            // 
            this.btn_netCloseFlap.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_netCloseFlap.Location = new System.Drawing.Point(261, 86);
            this.btn_netCloseFlap.Name = "btn_netCloseFlap";
            this.btn_netCloseFlap.Size = new System.Drawing.Size(75, 23);
            this.btn_netCloseFlap.TabIndex = 15;
            this.btn_netCloseFlap.Text = "Close Flap";
            this.btn_netCloseFlap.UseVisualStyleBackColor = true;
            this.btn_netCloseFlap.Click += new System.EventHandler(this.btn_netCloseFlap_Click);
            // 
            // lbl_netDomeControls
            // 
            this.lbl_netDomeControls.AutoSize = true;
            this.lbl_netDomeControls.Location = new System.Drawing.Point(9, 121);
            this.lbl_netDomeControls.Name = "lbl_netDomeControls";
            this.lbl_netDomeControls.Size = new System.Drawing.Size(76, 13);
            this.lbl_netDomeControls.TabIndex = 18;
            this.lbl_netDomeControls.Text = "Dome Controls";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Firmware Update";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 312);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(163, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(242, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Upload";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // group_network_dome_controls
            // 
            this.group_network_dome_controls.Controls.Add(this.dec_pot_btn);
            this.group_network_dome_controls.Controls.Add(this.inc_pot_btn);
            this.group_network_dome_controls.Controls.Add(this.sys_reboot_btn);
            this.group_network_dome_controls.Controls.Add(this.system_shutdown_btn);
            this.group_network_dome_controls.Controls.Add(this.label4);
            this.group_network_dome_controls.Controls.Add(this.north_btn);
            this.group_network_dome_controls.Controls.Add(this.stop_btn2);
            this.group_network_dome_controls.Controls.Add(this.up_btn);
            this.group_network_dome_controls.Controls.Add(this.down_btn);
            this.group_network_dome_controls.Controls.Add(this.dome_shutdown_btn);
            this.group_network_dome_controls.Controls.Add(this.dome_reboot_btn);
            this.group_network_dome_controls.Controls.Add(this.network_CCW_btn);
            this.group_network_dome_controls.Controls.Add(this.networkCW_btn);
            this.group_network_dome_controls.Controls.Add(this.label3);
            this.group_network_dome_controls.Controls.Add(this.button2);
            this.group_network_dome_controls.Controls.Add(this.button1);
            this.group_network_dome_controls.Controls.Add(this.textBox1);
            this.group_network_dome_controls.Controls.Add(this.label2);
            this.group_network_dome_controls.Controls.Add(this.lbl_netDomeControls);
            this.group_network_dome_controls.Controls.Add(this.btn_netCloseFlap);
            this.group_network_dome_controls.Controls.Add(this.btn_netOpenFlap);
            this.group_network_dome_controls.Controls.Add(this.btn_slotPowerOff);
            this.group_network_dome_controls.Controls.Add(this.btn_slotPowerOn);
            this.group_network_dome_controls.Controls.Add(this.label1);
            this.group_network_dome_controls.Controls.Add(this.btn_netSlotShutdown);
            this.group_network_dome_controls.Controls.Add(this.btn_netSlotReboot);
            this.group_network_dome_controls.Controls.Add(this.btn_netSlotFullClose);
            this.group_network_dome_controls.Controls.Add(this.btn_slotFullOpen);
            this.group_network_dome_controls.Controls.Add(this.btn_netPark);
            this.group_network_dome_controls.Controls.Add(this.btn_netHome);
            this.group_network_dome_controls.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.group_network_dome_controls.Location = new System.Drawing.Point(403, 106);
            this.group_network_dome_controls.Name = "group_network_dome_controls";
            this.group_network_dome_controls.Size = new System.Drawing.Size(392, 342);
            this.group_network_dome_controls.TabIndex = 5;
            this.group_network_dome_controls.TabStop = false;
            this.group_network_dome_controls.Text = "Network Dome Controls";
            this.group_network_dome_controls.Visible = false;
            this.group_network_dome_controls.Enter += new System.EventHandler(this.group_diagnostics_Enter);
            // 
            // dec_pot_btn
            // 
            this.dec_pot_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.dec_pot_btn.Location = new System.Drawing.Point(255, 197);
            this.dec_pot_btn.Name = "dec_pot_btn";
            this.dec_pot_btn.Size = new System.Drawing.Size(75, 23);
            this.dec_pot_btn.TabIndex = 36;
            this.dec_pot_btn.Text = "Dec Pot";
            this.dec_pot_btn.UseVisualStyleBackColor = true;
            this.dec_pot_btn.Click += new System.EventHandler(this.dec_pot_btn_Click);
            // 
            // inc_pot_btn
            // 
            this.inc_pot_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.inc_pot_btn.Location = new System.Drawing.Point(173, 197);
            this.inc_pot_btn.Name = "inc_pot_btn";
            this.inc_pot_btn.Size = new System.Drawing.Size(75, 23);
            this.inc_pot_btn.TabIndex = 35;
            this.inc_pot_btn.Text = "Inc Pot";
            this.inc_pot_btn.UseVisualStyleBackColor = true;
            this.inc_pot_btn.Click += new System.EventHandler(this.inc_pot_btn_Click);
            // 
            // sys_reboot_btn
            // 
            this.sys_reboot_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.sys_reboot_btn.Location = new System.Drawing.Point(91, 242);
            this.sys_reboot_btn.Name = "sys_reboot_btn";
            this.sys_reboot_btn.Size = new System.Drawing.Size(75, 23);
            this.sys_reboot_btn.TabIndex = 34;
            this.sys_reboot_btn.Text = "Reboot";
            this.sys_reboot_btn.UseVisualStyleBackColor = true;
            this.sys_reboot_btn.Click += new System.EventHandler(this.sys_reboot_btn_Click);
            // 
            // system_shutdown_btn
            // 
            this.system_shutdown_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.system_shutdown_btn.Location = new System.Drawing.Point(12, 242);
            this.system_shutdown_btn.Name = "system_shutdown_btn";
            this.system_shutdown_btn.Size = new System.Drawing.Size(75, 23);
            this.system_shutdown_btn.TabIndex = 33;
            this.system_shutdown_btn.Text = "Shutdown";
            this.system_shutdown_btn.UseVisualStyleBackColor = true;
            this.system_shutdown_btn.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "System Controls";
            // 
            // north_btn
            // 
            this.north_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.north_btn.Location = new System.Drawing.Point(91, 196);
            this.north_btn.Name = "north_btn";
            this.north_btn.Size = new System.Drawing.Size(75, 23);
            this.north_btn.TabIndex = 31;
            this.north_btn.Text = "North";
            this.north_btn.UseVisualStyleBackColor = true;
            this.north_btn.Click += new System.EventHandler(this.north_btn_Click);
            // 
            // stop_btn2
            // 
            this.stop_btn2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.stop_btn2.Location = new System.Drawing.Point(10, 196);
            this.stop_btn2.Name = "stop_btn2";
            this.stop_btn2.Size = new System.Drawing.Size(75, 23);
            this.stop_btn2.TabIndex = 30;
            this.stop_btn2.Text = "Stop";
            this.stop_btn2.UseVisualStyleBackColor = true;
            this.stop_btn2.Click += new System.EventHandler(this.stop_btn2_Click);
            // 
            // up_btn
            // 
            this.up_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.up_btn.Location = new System.Drawing.Point(255, 167);
            this.up_btn.Name = "up_btn";
            this.up_btn.Size = new System.Drawing.Size(75, 23);
            this.up_btn.TabIndex = 29;
            this.up_btn.Text = "Up";
            this.up_btn.UseVisualStyleBackColor = true;
            this.up_btn.Click += new System.EventHandler(this.up_btn_Click);
            // 
            // down_btn
            // 
            this.down_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.down_btn.Location = new System.Drawing.Point(173, 167);
            this.down_btn.Name = "down_btn";
            this.down_btn.Size = new System.Drawing.Size(75, 23);
            this.down_btn.TabIndex = 28;
            this.down_btn.Text = "Down";
            this.down_btn.UseVisualStyleBackColor = true;
            this.down_btn.Click += new System.EventHandler(this.down_btn_Click);
            // 
            // dome_shutdown_btn
            // 
            this.dome_shutdown_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.dome_shutdown_btn.Location = new System.Drawing.Point(91, 167);
            this.dome_shutdown_btn.Name = "dome_shutdown_btn";
            this.dome_shutdown_btn.Size = new System.Drawing.Size(75, 23);
            this.dome_shutdown_btn.TabIndex = 27;
            this.dome_shutdown_btn.Text = "Shutdown";
            this.dome_shutdown_btn.UseVisualStyleBackColor = true;
            this.dome_shutdown_btn.Click += new System.EventHandler(this.dome_shutdown_btn_Click);
            // 
            // dome_reboot_btn
            // 
            this.dome_reboot_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.dome_reboot_btn.Location = new System.Drawing.Point(10, 167);
            this.dome_reboot_btn.Name = "dome_reboot_btn";
            this.dome_reboot_btn.Size = new System.Drawing.Size(75, 23);
            this.dome_reboot_btn.TabIndex = 26;
            this.dome_reboot_btn.Text = "Reboot";
            this.dome_reboot_btn.UseVisualStyleBackColor = true;
            this.dome_reboot_btn.Click += new System.EventHandler(this.dome_reboot_btn_Click);
            // 
            // network_CCW_btn
            // 
            this.network_CCW_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.network_CCW_btn.Location = new System.Drawing.Point(255, 138);
            this.network_CCW_btn.Name = "network_CCW_btn";
            this.network_CCW_btn.Size = new System.Drawing.Size(75, 23);
            this.network_CCW_btn.TabIndex = 25;
            this.network_CCW_btn.Text = "CCW";
            this.network_CCW_btn.UseVisualStyleBackColor = true;
            this.network_CCW_btn.Click += new System.EventHandler(this.network_CCW_btn_Click);
            // 
            // networkCW_btn
            // 
            this.networkCW_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.networkCW_btn.Location = new System.Drawing.Point(173, 138);
            this.networkCW_btn.Name = "networkCW_btn";
            this.networkCW_btn.Size = new System.Drawing.Size(75, 23);
            this.networkCW_btn.TabIndex = 24;
            this.networkCW_btn.Text = "CW";
            this.networkCW_btn.UseVisualStyleBackColor = true;
            this.networkCW_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Slot Control";
            // 
            // txtBox_serverIp
            // 
            this.txtBox_serverIp.Location = new System.Drawing.Point(64, 31);
            this.txtBox_serverIp.Name = "txtBox_serverIp";
            this.txtBox_serverIp.Size = new System.Drawing.Size(100, 20);
            this.txtBox_serverIp.TabIndex = 0;
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
            // btn_serverIp
            // 
            this.btn_serverIp.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_serverIp.Location = new System.Drawing.Point(171, 27);
            this.btn_serverIp.Name = "btn_serverIp";
            this.btn_serverIp.Size = new System.Drawing.Size(75, 23);
            this.btn_serverIp.TabIndex = 2;
            this.btn_serverIp.Text = "Connect";
            this.btn_serverIp.UseVisualStyleBackColor = true;
            this.btn_serverIp.Click += new System.EventHandler(this.btn_serverIp_Click);
            // 
            // btn_netDisconnect
            // 
            this.btn_netDisconnect.Enabled = false;
            this.btn_netDisconnect.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_netDisconnect.Location = new System.Drawing.Point(252, 27);
            this.btn_netDisconnect.Name = "btn_netDisconnect";
            this.btn_netDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btn_netDisconnect.TabIndex = 3;
            this.btn_netDisconnect.Text = "Disconnect";
            this.btn_netDisconnect.UseVisualStyleBackColor = true;
            this.btn_netDisconnect.Click += new System.EventHandler(this.btn_netDisconnect_Click);
            // 
            // group_connectNetwork
            // 
            this.group_connectNetwork.Controls.Add(this.btn_netDisconnect);
            this.group_connectNetwork.Controls.Add(this.btn_serverIp);
            this.group_connectNetwork.Controls.Add(this.lbl_serverIp);
            this.group_connectNetwork.Controls.Add(this.txtBox_serverIp);
            this.group_connectNetwork.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.group_connectNetwork.Location = new System.Drawing.Point(403, 33);
            this.group_connectNetwork.Name = "group_connectNetwork";
            this.group_connectNetwork.Size = new System.Drawing.Size(391, 62);
            this.group_connectNetwork.TabIndex = 7;
            this.group_connectNetwork.TabStop = false;
            this.group_connectNetwork.Text = "Connect to Dome Server";
            this.group_connectNetwork.Visible = false;
            this.group_connectNetwork.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // group_Diagnostics
            // 
            this.group_Diagnostics.Controls.Add(this.get_estatus_btn);
            this.group_Diagnostics.Controls.Add(this.log_serial_btn);
            this.group_Diagnostics.Controls.Add(this.log_file_btn);
            this.group_Diagnostics.Controls.Add(this.label5);
            this.group_Diagnostics.Controls.Add(this.btn_netGetConfigIni);
            this.group_Diagnostics.Controls.Add(this.btn_netDownloadLog);
            this.group_Diagnostics.Controls.Add(this.lbl_netLog);
            this.group_Diagnostics.Controls.Add(this.btn_slotShortDiag);
            this.group_Diagnostics.Controls.Add(this.btn_netSlotFullDiag);
            this.group_Diagnostics.Controls.Add(this.lvl_netSlotDiagnostics);
            this.group_Diagnostics.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.group_Diagnostics.Location = new System.Drawing.Point(813, 37);
            this.group_Diagnostics.Name = "group_Diagnostics";
            this.group_Diagnostics.Size = new System.Drawing.Size(389, 178);
            this.group_Diagnostics.TabIndex = 9;
            this.group_Diagnostics.TabStop = false;
            this.group_Diagnostics.Text = "Diagnostics";
            this.group_Diagnostics.Visible = false;
            // 
            // get_estatus_btn
            // 
            this.get_estatus_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.get_estatus_btn.Location = new System.Drawing.Point(194, 135);
            this.get_estatus_btn.Name = "get_estatus_btn";
            this.get_estatus_btn.Size = new System.Drawing.Size(75, 23);
            this.get_estatus_btn.TabIndex = 24;
            this.get_estatus_btn.Text = "eStatus";
            this.get_estatus_btn.UseVisualStyleBackColor = true;
            this.get_estatus_btn.Click += new System.EventHandler(this.get_estatus_btn_Click);
            // 
            // log_serial_btn
            // 
            this.log_serial_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.log_serial_btn.Location = new System.Drawing.Point(95, 90);
            this.log_serial_btn.Name = "log_serial_btn";
            this.log_serial_btn.Size = new System.Drawing.Size(75, 23);
            this.log_serial_btn.TabIndex = 23;
            this.log_serial_btn.Text = "Log to serial";
            this.log_serial_btn.UseVisualStyleBackColor = true;
            this.log_serial_btn.Click += new System.EventHandler(this.log_serial_btn_Click);
            // 
            // log_file_btn
            // 
            this.log_file_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.log_file_btn.Location = new System.Drawing.Point(13, 90);
            this.log_file_btn.Name = "log_file_btn";
            this.log_file_btn.Size = new System.Drawing.Size(75, 23);
            this.log_file_btn.TabIndex = 22;
            this.log_file_btn.Text = "Log to file";
            this.log_file_btn.UseVisualStyleBackColor = true;
            this.log_file_btn.Click += new System.EventHandler(this.log_file_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Logging Options";
            // 
            // btn_netGetConfigIni
            // 
            this.btn_netGetConfigIni.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_netGetConfigIni.Location = new System.Drawing.Point(108, 135);
            this.btn_netGetConfigIni.Name = "btn_netGetConfigIni";
            this.btn_netGetConfigIni.Size = new System.Drawing.Size(79, 23);
            this.btn_netGetConfigIni.TabIndex = 20;
            this.btn_netGetConfigIni.Text = "Get Config.ini";
            this.btn_netGetConfigIni.UseVisualStyleBackColor = true;
            // 
            // btn_netDownloadLog
            // 
            this.btn_netDownloadLog.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_netDownloadLog.Location = new System.Drawing.Point(12, 135);
            this.btn_netDownloadLog.Name = "btn_netDownloadLog";
            this.btn_netDownloadLog.Size = new System.Drawing.Size(90, 23);
            this.btn_netDownloadLog.TabIndex = 19;
            this.btn_netDownloadLog.Text = "Download Log";
            this.btn_netDownloadLog.UseVisualStyleBackColor = true;
            // 
            // lbl_netLog
            // 
            this.lbl_netLog.AutoSize = true;
            this.lbl_netLog.Location = new System.Drawing.Point(10, 116);
            this.lbl_netLog.Name = "lbl_netLog";
            this.lbl_netLog.Size = new System.Drawing.Size(45, 13);
            this.lbl_netLog.TabIndex = 18;
            this.lbl_netLog.Text = "Logging";
            // 
            // btn_slotShortDiag
            // 
            this.btn_slotShortDiag.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_slotShortDiag.Location = new System.Drawing.Point(87, 40);
            this.btn_slotShortDiag.Name = "btn_slotShortDiag";
            this.btn_slotShortDiag.Size = new System.Drawing.Size(75, 23);
            this.btn_slotShortDiag.TabIndex = 11;
            this.btn_slotShortDiag.Text = "Short";
            this.btn_slotShortDiag.UseVisualStyleBackColor = true;
            // 
            // btn_netSlotFullDiag
            // 
            this.btn_netSlotFullDiag.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_netSlotFullDiag.Location = new System.Drawing.Point(10, 40);
            this.btn_netSlotFullDiag.Name = "btn_netSlotFullDiag";
            this.btn_netSlotFullDiag.Size = new System.Drawing.Size(75, 23);
            this.btn_netSlotFullDiag.TabIndex = 10;
            this.btn_netSlotFullDiag.Text = "Full";
            this.btn_netSlotFullDiag.UseVisualStyleBackColor = true;
            // 
            // lvl_netSlotDiagnostics
            // 
            this.lvl_netSlotDiagnostics.AutoSize = true;
            this.lvl_netSlotDiagnostics.Location = new System.Drawing.Point(6, 23);
            this.lvl_netSlotDiagnostics.Name = "lvl_netSlotDiagnostics";
            this.lvl_netSlotDiagnostics.Size = new System.Drawing.Size(83, 13);
            this.lvl_netSlotDiagnostics.TabIndex = 9;
            this.lvl_netSlotDiagnostics.Text = "Slot Diagnostics";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Firmware update";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // group_debugging
            // 
            this.group_debugging.Controls.Add(this.set_debug_btn);
            this.group_debugging.Controls.Add(this.reset_debug_btn);
            this.group_debugging.Controls.Add(this.dump_msg_btn);
            this.group_debugging.Controls.Add(this.dump_internal_btn);
            this.group_debugging.Controls.Add(this.dump_debug_btn);
            this.group_debugging.Controls.Add(this.clr_msg_btn);
            this.group_debugging.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.group_debugging.Location = new System.Drawing.Point(815, 236);
            this.group_debugging.Name = "group_debugging";
            this.group_debugging.Size = new System.Drawing.Size(387, 209);
            this.group_debugging.TabIndex = 10;
            this.group_debugging.TabStop = false;
            this.group_debugging.Text = "Debugging";
            this.group_debugging.Visible = false;
            // 
            // set_debug_btn
            // 
            this.set_debug_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.set_debug_btn.Location = new System.Drawing.Point(97, 50);
            this.set_debug_btn.Name = "set_debug_btn";
            this.set_debug_btn.Size = new System.Drawing.Size(88, 23);
            this.set_debug_btn.TabIndex = 5;
            this.set_debug_btn.Text = "Set debug";
            this.set_debug_btn.UseVisualStyleBackColor = true;
            this.set_debug_btn.Click += new System.EventHandler(this.set_debug_btn_Click);
            // 
            // reset_debug_btn
            // 
            this.reset_debug_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.reset_debug_btn.Location = new System.Drawing.Point(11, 49);
            this.reset_debug_btn.Name = "reset_debug_btn";
            this.reset_debug_btn.Size = new System.Drawing.Size(82, 23);
            this.reset_debug_btn.TabIndex = 4;
            this.reset_debug_btn.Text = "Reset debug";
            this.reset_debug_btn.UseVisualStyleBackColor = true;
            this.reset_debug_btn.Click += new System.EventHandler(this.reset_debug_btn_Click);
            // 
            // dump_msg_btn
            // 
            this.dump_msg_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.dump_msg_btn.Location = new System.Drawing.Point(284, 20);
            this.dump_msg_btn.Name = "dump_msg_btn";
            this.dump_msg_btn.Size = new System.Drawing.Size(75, 23);
            this.dump_msg_btn.TabIndex = 3;
            this.dump_msg_btn.Text = "Dump MSG";
            this.dump_msg_btn.UseVisualStyleBackColor = true;
            this.dump_msg_btn.Click += new System.EventHandler(this.dump_msg_btn_Click);
            // 
            // dump_internal_btn
            // 
            this.dump_internal_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.dump_internal_btn.Location = new System.Drawing.Point(196, 20);
            this.dump_internal_btn.Name = "dump_internal_btn";
            this.dump_internal_btn.Size = new System.Drawing.Size(81, 23);
            this.dump_internal_btn.TabIndex = 2;
            this.dump_internal_btn.Text = "Dump internal";
            this.dump_internal_btn.UseVisualStyleBackColor = true;
            this.dump_internal_btn.Click += new System.EventHandler(this.dump_internal_btn_Click);
            // 
            // dump_debug_btn
            // 
            this.dump_debug_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.dump_debug_btn.Location = new System.Drawing.Point(97, 20);
            this.dump_debug_btn.Name = "dump_debug_btn";
            this.dump_debug_btn.Size = new System.Drawing.Size(92, 23);
            this.dump_debug_btn.TabIndex = 1;
            this.dump_debug_btn.Text = "Dump debug";
            this.dump_debug_btn.UseVisualStyleBackColor = true;
            this.dump_debug_btn.Click += new System.EventHandler(this.dump_debug_btn_Click);
            // 
            // clr_msg_btn
            // 
            this.clr_msg_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.clr_msg_btn.Location = new System.Drawing.Point(11, 20);
            this.clr_msg_btn.Name = "clr_msg_btn";
            this.clr_msg_btn.Size = new System.Drawing.Size(82, 23);
            this.clr_msg_btn.TabIndex = 0;
            this.clr_msg_btn.Text = "Clear MSG";
            this.clr_msg_btn.UseVisualStyleBackColor = true;
            this.clr_msg_btn.Click += new System.EventHandler(this.clr_msg_btn_Click);
            // 
            // DC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(401, 457);
            this.Controls.Add(this.group_debugging);
            this.Controls.Add(this.group_Diagnostics);
            this.Controls.Add(this.group_connectNetwork);
            this.Controls.Add(this.group_advancedControls);
            this.Controls.Add(this.group_network_dome_controls);
            this.Controls.Add(this.group_ascomControls);
            this.Controls.Add(this.labelDriverId);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.group_connectAscom);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DC";
            this.Text = "SkyShed - Dome Commander";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DC_FormClosing);
            this.Load += new System.EventHandler(this.DC_Load);
            this.group_ascomControls.ResumeLayout(false);
            this.group_ascomControls.PerformLayout();
            this.group_advancedControls.ResumeLayout(false);
            this.group_advancedControls.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.group_network_dome_controls.ResumeLayout(false);
            this.group_network_dome_controls.PerformLayout();
            this.group_connectNetwork.ResumeLayout(false);
            this.group_connectNetwork.PerformLayout();
            this.group_Diagnostics.ResumeLayout(false);
            this.group_Diagnostics.PerformLayout();
            this.group_debugging.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelDriverId;
        private System.Windows.Forms.GroupBox group_connectAscom;
        private System.Windows.Forms.GroupBox group_ascomControls;
        private System.Windows.Forms.Button btn_park;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_openSlot;
        private System.Windows.Forms.Button btn_closeSlot;
        private System.Windows.Forms.TextBox txtBox_goTo;
        private System.Windows.Forms.Button btn_goTo;
        private System.Windows.Forms.TextBox txtBox_slotStatus;
        private System.Windows.Forms.TextBox txtBox_status;
        private System.Windows.Forms.TextBox txtBox_azimuth;
        private System.Windows.Forms.GroupBox group_advancedControls;
        private System.Windows.Forms.Button btn_ccw;
        private System.Windows.Forms.Button btn_cw;
        private System.Windows.Forms.Label lbl_driverVersion;
        private System.Windows.Forms.Label lbl_driverVersionText;
        private System.Windows.Forms.Label lbl_setPark;
        private System.Windows.Forms.Button btn_setPark;
        private System.Windows.Forms.TextBox txtBox_setPark;
        private System.Windows.Forms.Label lbl_driverInfoText;
        private System.Windows.Forms.Label lbl_driverInfo;
        private System.Windows.Forms.Button btn_sendCommand;
        private System.Windows.Forms.TextBox txtBox_sendCommand;
        private System.Windows.Forms.Label lvl_sendCommand;
        private System.Windows.Forms.TextBox txtBox_param;
        private System.Windows.Forms.Label lbl_commandsText;
        private System.Windows.Forms.Label lbl_commands;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aSCOMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callibrateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btn_netHome;
        private System.Windows.Forms.Button btn_netPark;
        private System.Windows.Forms.Button btn_slotFullOpen;
        private System.Windows.Forms.Button btn_netSlotFullClose;
        private System.Windows.Forms.Button btn_netSlotReboot;
        private System.Windows.Forms.Button btn_netSlotShutdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_slotPowerOn;
        private System.Windows.Forms.Button btn_slotPowerOff;
        private System.Windows.Forms.Button btn_netOpenFlap;
        private System.Windows.Forms.Button btn_netCloseFlap;
        private System.Windows.Forms.Label lbl_netDomeControls;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox group_network_dome_controls;
        private System.Windows.Forms.Label lbl_serverIp;
        private System.Windows.Forms.Button btn_serverIp;
        private System.Windows.Forms.Button btn_netDisconnect;
        private System.Windows.Forms.GroupBox group_connectNetwork;
        private System.Windows.Forms.ToolStripMenuItem networkToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBox_serverIp;
        private System.Windows.Forms.GroupBox group_Diagnostics;
        private System.Windows.Forms.Button btn_netGetConfigIni;
        private System.Windows.Forms.Button btn_netDownloadLog;
        private System.Windows.Forms.Label lbl_netLog;
        private System.Windows.Forms.Button btn_slotShortDiag;
        private System.Windows.Forms.Button btn_netSlotFullDiag;
        private System.Windows.Forms.Label lvl_netSlotDiagnostics;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button network_CCW_btn;
        private System.Windows.Forms.Button networkCW_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem diagnosticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedToolStripMenuItem;
        private System.Windows.Forms.Button dome_reboot_btn;
        private System.Windows.Forms.Button dome_shutdown_btn;
        private System.Windows.Forms.Button down_btn;
        private System.Windows.Forms.Button up_btn;
        private System.Windows.Forms.Button stop_btn2;
        private System.Windows.Forms.Button north_btn;
        private System.Windows.Forms.Button system_shutdown_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sys_reboot_btn;
        private System.Windows.Forms.Button log_file_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button log_serial_btn;
        private System.Windows.Forms.GroupBox group_debugging;
        private System.Windows.Forms.Button clr_msg_btn;
        private System.Windows.Forms.Button dump_debug_btn;
        private System.Windows.Forms.Button dump_internal_btn;
        private System.Windows.Forms.Button dump_msg_btn;
        private System.Windows.Forms.Button get_estatus_btn;
        private System.Windows.Forms.Button inc_pot_btn;
        private System.Windows.Forms.Button dec_pot_btn;
        private System.Windows.Forms.Button reset_debug_btn;
        private System.Windows.Forms.Button set_debug_btn;
    }
}

