using System;
using System.Collections;
using System.Windows.Forms;
using ASCOM.DeviceInterface;

namespace ASCOM.pod
{
    public partial class DC : Form
    {

        private ASCOM.DriverAccess.Dome driver;
        private ShutterState slotStatus;
        public DomeLink netDriver;
        public bool netConnected = false;

        public DC()
        {
            InitializeComponent();
            netDriver = new DomeLink();
            SetUIState();
        }

        private void DC_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsConnected)
                driver.Connected = false;

            Properties.Settings.Default.Save();
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DriverId = ASCOM.DriverAccess.Dome.Choose(Properties.Settings.Default.DriverId);
            SetUIState();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (IsConnected)
            {
                driver.Connected = false;
            }
            else
            {
                driver = new ASCOM.DriverAccess.Dome(Properties.Settings.Default.DriverId)
                {
                    Connected = true
                };
            }
            SetUIState();
        }

        private void SetUIState()
        {
            buttonConnect.Enabled = !string.IsNullOrEmpty(Properties.Settings.Default.DriverId);
            buttonChoose.Enabled = !IsConnected;
            buttonConnect.Text = IsConnected ? "Disconnect" : "Connect";
            group_ascomControls.Enabled = buttonConnect.Text == "Disconnect";

            if (IsConnected)
            {
                String slotStatus = driver.ShutterStatus.ToString();
                if (slotStatus == "shutterOpen")
                {
                    txtBox_slotStatus.Text = "Open";
                }
                else
                {
                    txtBox_slotStatus.Text = "Closed";
                }
                String slewingStatus = driver.Slewing.ToString();
                if (slewingStatus == "False")
                {
                    txtBox_status.Text = "Stopped";
                    if (driver.AtHome)
                    {
                        btn_home.ForeColor = System.Drawing.Color.Red;
                        btn_park.ForeColor = System.Drawing.Color.Black;
                    }
                    else if (driver.AtPark)
                    {
                        btn_home.ForeColor = System.Drawing.Color.Black;
                        btn_park.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        btn_home.ForeColor = System.Drawing.Color.Black;
                        btn_park.ForeColor = System.Drawing.Color.Black;
                    }
                }
                txtBox_azimuth.Text = driver.Azimuth.ToString();
            }
            if (netConnected)
            {
                group_Diagnostics.Enabled = true;
                group_debugging.Enabled = true;
                group_network_dome_controls.Enabled = true;
                btn_serverIp.Enabled = false;
                btn_netDisconnect.Enabled = true;
                txtBox_serverIp.Enabled = false;

            }
            else
            {
                group_Diagnostics.Enabled = false;
                group_debugging.Enabled = false;
                group_network_dome_controls.Enabled = false;
                btn_serverIp.Enabled = true;
                btn_netDisconnect.Enabled = false;
                txtBox_serverIp.Enabled = true;

            }
        }


        private bool IsConnected
        {
            get
            {
                return ((this.driver != null) && (driver.Connected == true));
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //Code action for the home button
        private void btn_home_Click(object sender, EventArgs e)
        {
            driver.FindHome();
            while (driver.Slewing)
            {
                txtBox_status.Text = "Slewing";
                txtBox_azimuth.Text = driver.Azimuth.ToString();
            }
            SetUIState();
        }

        //Code action for the park button
        private void btn_park_Click(object sender, EventArgs e)
        {
            driver.Park();
            while (driver.Slewing)
            {
                txtBox_status.Text = "Slewing";
                txtBox_azimuth.Text = driver.Azimuth.ToString();
            }
            SetUIState();
        }

        //Code action for the stop button
        private void btn_stop_Click(object sender, EventArgs e)
        {
            driver.AbortSlew();
            SetUIState();
        }

        //Code action for the open slot button
        private void btn_openSlot_Click(object sender, EventArgs e)
        {
            if (driver.ShutterStatus.ToString() == "shutterOpen") 
            {
                txtBox_slotStatus.Text = "Open";
            } 
            else
            {
                driver.OpenShutter();
                txtBox_slotStatus.Text = "Opening";
                while (driver.ShutterStatus.ToString() == "shutterOpening")
                {
                    txtBox_slotStatus.Text = "Opening";
                }
                txtBox_slotStatus.Text = "Open";
            }

            SetUIState();
        }

        //Code action for the close slot button
        private void btn_closeSlot_Click(object sender, EventArgs e)
        {
            if (driver.ShutterStatus.ToString() == "shutterClosed")
            {
                txtBox_slotStatus.Text = "Closed";
            }
            else
            {
                driver.CloseShutter();
                txtBox_slotStatus.Text = "Closing";
                while (driver.ShutterStatus.ToString() == "shutterClosing")
                {
                    txtBox_slotStatus.Text = "Closing";
                }
                txtBox_slotStatus.Text = "Closed";
            }

            SetUIState();
        }

        //Code action for the go to button
        private void btn_goTo_Click(object sender, EventArgs e)
        {
            Double azimuth = Convert.ToDouble(txtBox_goTo.Text);
            if (azimuth == 2001)
            {
                //Show ASCOM hidden menu
                group_advancedControls.Visible = true;
                lbl_driverVersionText.Text = driver.DriverVersion;
                lbl_driverInfoText.Text = driver.DriverInfo;
                ArrayList words = driver.SupportedActions;
                String commands = "";
                for (int i = 0; i < words.Count; i++)
                {
                    commands += words[i] + " ";
                }
                lbl_commandsText.Text = commands;
                return;
            }
            else if (azimuth < 0 || azimuth > 359)
            {
                txtBox_status.Text = "Invalid Az";
                return;
            }
            driver.SlewToAzimuth(azimuth);
            SetUIState();
            while (driver.Slewing)
            {
                txtBox_status.Text = "Slewing";
                txtBox_azimuth.Text = driver.Azimuth.ToString();
            }
            txtBox_status.Text = "Stopped";
            txtBox_azimuth.Text = driver.Azimuth.ToString();
            SetUIState();
        }

        private void txtBox_slotStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_status_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cw_Click(object sender, EventArgs e)
        {
            double azimuth = driver.Azimuth;
            azimuth += 1;
            if (azimuth > 359)
            {
                azimuth = 0;
            }
            driver.SlewToAzimuth(azimuth);
            while (driver.Slewing)
            {
                txtBox_status.Text = "Slewing";
            }
            txtBox_status.Text = "Stopped";
            txtBox_azimuth.Text = driver.Azimuth.ToString();
            SetUIState();
        }

        private void btn_ccw_Click(object sender, EventArgs e)
        {
            double azimuth = driver.Azimuth;
            azimuth -= 1;
            if (azimuth < 0)
            {
                azimuth = 359;
            }
            driver.SlewToAzimuth(azimuth);
            while (driver.Slewing)
            {
                txtBox_status.Text = "Slewing";
            }
            txtBox_status.Text = "Stopped";
            txtBox_azimuth.Text = driver.Azimuth.ToString();
            SetUIState();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_setPark_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBox_setPark.Text, out int parkVal))
            {
                if (parkVal < 0 || parkVal > 359)
                {
                    txtBox_status.Text = "Invalid Park Value";
                }
                else
                {
                    driver.SlewToAzimuth(parkVal);
                    while (driver.Slewing)
                    {
                        txtBox_status.Text = "Slewing";
                        txtBox_azimuth.Text = driver.Azimuth.ToString();
                    }
                    driver.SetPark();
                    txtBox_status.Text = "Park Set";
                }
            }
            else
            {
                // Handle the case where the text is not a valid integer
                txtBox_status.Text = "Invalid Park Value";
            }
        }

        private void btn_sendCommand_Click(object sender, EventArgs e)
        {
            ArrayList actions = driver.SupportedActions;
            if (actions.Contains(txtBox_sendCommand.Text))
            {
                driver.Action(txtBox_sendCommand.Text.ToString(), txtBox_param.Text.ToString());
                txtBox_status.Text = "Command Sent";
            }
            else
            {
                txtBox_status.Text = "Invalid Command";
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_serverIp_Click(object sender, EventArgs e)
        {
            netConnected = netDriver.Connect(txtBox_serverIp.Text);
            SetUIState();
            
        }

        private void btn_netHome_Click(object sender, EventArgs e)
        {
            netDriver.home();
        }

        private void btn_netPark_Click(object sender, EventArgs e)
        {
            netDriver.park();
        }

        private void btn_slotFullOpen_Click(object sender, EventArgs e)
        {
            netDriver.fullopen();
        }

        private void btn_netSlotFullClose_Click(object sender, EventArgs e)
        {
            netDriver.fullclose();
        }

        private void btn_netSlotReboot_Click(object sender, EventArgs e)
        {
            netDriver.slotreboot();
        }

        private void btn_netSlotShutdown_Click(object sender, EventArgs e)
        {
            netDriver.slotshutdown();
            //group_ascomControls.Enabled = false;
            //group_advancedControls.Enabled = false;
            //group_diagnostics.Enabled = false;
            //netConnected = false;
            //txtBox_serverIp.Enabled = true;
            //btn_serverIp.Enabled = true;
        }

        private void btn_netSlotFullDiag_Click(object sender, EventArgs e)
        {
            netDriver.runslotfulldiagnostics();
        }

        private void btn_slotShortDiag_Click(object sender, EventArgs e)
        {
            netDriver.runslotshortldiagnostics();
        }

        private void btn_slotPowerOn_Click(object sender, EventArgs e)
        {
            netDriver.setslotpoweron();
        }

        private void btn_slotPowerOff_Click(object sender, EventArgs e)
        {
            netDriver.setslotpoweroff();
        }

        private void btn_netOpenFlap_Click(object sender, EventArgs e)
        {
            netDriver.openlower();
        }

        private void btn_netCloseFlap_Click(object sender, EventArgs e)
        {
            netDriver.closelower();
        }

        private void btn_netDownloadLog_Click(object sender, EventArgs e)
        {
            netDriver.getactivity();
        }

        private void btn_netGetConfigIni_Click(object sender, EventArgs e)
        {
            netDriver.getconfigini();
        }

        private void btn_netDisconnect_Click(object sender, EventArgs e)
        {
            bool disconnected = netDriver.disconnect();
            if (disconnected)
            {
                netConnected = false;
            }
            SetUIState();
        }

        private void button1_Click(object sender, EventArgs e)
        {
   
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolboxToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void networkToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Change the visibility of things
            group_connectNetwork.Visible = true;
            group_connectAscom.Visible = false;
            group_network_dome_controls.Visible = true;
            group_ascomControls.Visible = false;
            group_advancedControls.Visible = false;
            group_Diagnostics.Visible = false;
            group_debugging.Visible = false;

            // Switch the checked state of the menu items
            networkToolStripMenuItem.Checked = true;
            aSCOMToolStripMenuItem.Checked = false;
            diagnosticsToolStripMenuItem.Checked = false;

            // Switch the items around
            group_connectNetwork.Location = new System.Drawing.Point(3, 32);
            group_connectAscom.Location = new System.Drawing.Point(403, 32);
            group_Diagnostics.Location = new System.Drawing.Point(813, 32);
            group_debugging.Location = new System.Drawing.Point(403, 209);

            group_network_dome_controls.Location = new System.Drawing.Point(3, 106);
            group_ascomControls.Location = new System.Drawing.Point(403, 106);
        }

        private void aSCOMToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Change the visibility of things
            group_connectNetwork.Visible = false;
            group_connectAscom.Visible = true;
            group_network_dome_controls.Visible = false;
            group_ascomControls.Visible = true;
            group_advancedControls.Visible = false;
            group_Diagnostics.Visible = false;
            group_debugging.Visible = false;

            group_connectNetwork.Location = new System.Drawing.Point(403, 32);
            group_connectAscom.Location = new System.Drawing.Point(3, 32);
            group_Diagnostics.Location = new System.Drawing.Point(813, 32);
            group_network_dome_controls.Location = new System.Drawing.Point(403, 106);
            group_ascomControls.Location = new System.Drawing.Point(3, 106);
            group_debugging.Location = new System.Drawing.Point(403, 209);

            networkToolStripMenuItem.Checked = false;
            aSCOMToolStripMenuItem.Checked = true;
            diagnosticsToolStripMenuItem.Checked = false;
        }

        private void group_advancedControls_Enter(object sender, EventArgs e)
        {

        }

        private void DC_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void group_diagnostics_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            netDriver.turnCW();
        }

        private void network_CCW_btn_Click(object sender, EventArgs e)
        {
            netDriver.turnCCW();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void diagnosticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Change the visibility of things
            group_connectNetwork.Visible = false;
            group_connectAscom.Visible = false;
            group_network_dome_controls.Visible = false;
            group_ascomControls.Visible = false;
            group_advancedControls.Visible = false;
            group_Diagnostics.Visible = true;
            group_debugging.Visible = true;

            group_connectNetwork.Location = new System.Drawing.Point(403, 32);
            group_connectAscom.Location = new System.Drawing.Point(813, 32);
            group_Diagnostics.Location = new System.Drawing.Point(3, 32);
            group_network_dome_controls.Location = new System.Drawing.Point(403, 106);
            group_ascomControls.Location = new System.Drawing.Point(813, 106);
            group_debugging.Location = new System.Drawing.Point(3, 209);

            networkToolStripMenuItem.Checked = false;
            aSCOMToolStripMenuItem.Checked = false;
            diagnosticsToolStripMenuItem.Checked = true;
        }

        private void dome_reboot_btn_Click(object sender, EventArgs e)
        {
            netDriver.domeReboot();
        }

        private void dome_shutdown_btn_Click(object sender, EventArgs e)
        {
            netDriver.domeShutdown();
        }

        private void down_btn_Click(object sender, EventArgs e)
        {
            netDriver.down();
        }

        private void up_btn_Click(object sender, EventArgs e)
        {
            netDriver.up();
        }

        private void stop_btn2_Click(object sender, EventArgs e)
        {
            netDriver.stop();
        }

        private void north_btn_Click(object sender, EventArgs e)
        {
            netDriver.north();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            netDriver.sysShutdown();
        }

        private void sys_reboot_btn_Click(object sender, EventArgs e)
        {
            netDriver.sysReboot();
        }

        private void log_file_btn_Click(object sender, EventArgs e)
        {
            netDriver.logfile();
        }

        private void log_serial_btn_Click(object sender, EventArgs e)
        {
            netDriver.logserial();
        }

        private void clr_msg_btn_Click(object sender, EventArgs e)
        {
            netDriver.clearMSG();
        }

        private void dump_debug_btn_Click(object sender, EventArgs e)
        {
            netDriver.dumpDebug();
        }

        private void dump_internal_btn_Click(object sender, EventArgs e)
        {
            netDriver.dumpInternal();
        }

        private void dump_msg_btn_Click(object sender, EventArgs e)
        {
            netDriver.dumpMSG();
        }

        private void get_estatus_btn_Click(object sender, EventArgs e)
        {
            netDriver.getEstatus();
        }

        private void inc_pot_btn_Click(object sender, EventArgs e)
        {
            netDriver.incPot();
        }

        private void dec_pot_btn_Click(object sender, EventArgs e)
        {
            netDriver.decPot();
        }

        private void reset_debug_btn_Click(object sender, EventArgs e)
        {
            netDriver.resetDebug();
        }

        private void set_debug_btn_Click(object sender, EventArgs e)
        {
            netDriver.resetDebug();
        }
    }
}