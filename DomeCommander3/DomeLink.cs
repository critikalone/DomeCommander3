using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ASCOM.pod
{
    public class DomeLink
    {
        public bool netConnected = false;
        private static readonly Regex ipRegex = new Regex(
            @"^((25[0-5]|2[0-4]\d|1\d\d|\d{1,2})\.){3}(25[0-5=|2[0-4]\d|1\d\d|\d{1,2})$",
            RegexOptions.Compiled);
        public static bool ValidateIP(String address)
        {
            return ipRegex.IsMatch(address);
        }
        // Stub for connecting to the dome
        public bool Connect(String address)
        {
            if (!ValidateIP(address))
            {
                //throw new ArgumentException("Invalid IP address");
                return false;
            }
            else
            {
                Console.WriteLine($"Connecting to {address}...");
                
                Console.WriteLine("Connected!");
                netConnected = true;
                return true;                
            }
                
        }

        // Stub for disconnecting from the dome
        public bool disconnect()
        {
            if (!netConnected)
            {
                return false;
            }
            Console.WriteLine("Disconnecting...");
            netConnected = false;
            Console.WriteLine("Disconnected!");
            return true;
        }
        // Stub for home command
        public async Task home()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Going home...");
            await Task.Delay(1000);
            Console.WriteLine("Home!");
        }
        // Stub for dome reboot command
        public async Task domeReboot()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Rebooting dome...");
            await Task.Delay(1000);
            Console.WriteLine("Rebooted!");
        }
        // Stub for dome dome shutdown command
        public async Task domeShutdown()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Shutting down dome...");
            await Task.Delay(1000);
            Console.WriteLine("Dome shutdown!");
        }
        // Stub for down command
        public async Task down()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Moving down...");
            await Task.Delay(1000);
            Console.WriteLine("Done!");
        }
        // Stub for up command
        public async Task up()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Moving up...");
            await Task.Delay(1000);
            Console.WriteLine("Done!");
        }
        // Stub for up command
        public async Task stop()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Stopping...");
            await Task.Delay(1000);
            Console.WriteLine("Done!");
        }
        // Stub for north command
        public async Task north()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Turning to North...");
            await Task.Delay(1000);
            Console.WriteLine("Done!");
        }
        // Stub for system shutdown command
        public async Task sysShutdown()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Shutting down system...");
            await Task.Delay(1000);
            Console.WriteLine("Done!");
        }
        // Stub for system reboot command
        public async Task sysReboot()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Rebooting system...");
            await Task.Delay(1000);
            Console.WriteLine("Done!");
        }
        // Stub for logfile command
        public async Task logfile()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Set to log to file...");
            await Task.Delay(1000);
            Console.WriteLine("Done!");
        }
        // Stub for logserial command
        public async Task logserial()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Set to log to serial...");
            await Task.Delay(1000);
            Console.WriteLine("Done!");
        }
        // Stub for clearMSG command
        public async Task clearMSG()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Clearning Messages...");
            await Task.Delay(1000);
            Console.WriteLine("Done!");
        }
        // Stub for dumpDebug command
        public async Task dumpDebug()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Dumping debug flags...");
            await Task.Delay(1000);
            Console.WriteLine("Done!");
        }
        // Stub for dumpDebug command
        public async Task dumpInternal()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Dumping internal flags...");
            await Task.Delay(1000);
            Console.WriteLine("Done!");
        }
        // Stub for dumpMSG command
        public async Task dumpMSG()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Dumping Messages...");
            await Task.Delay(1000);
            Console.WriteLine("Done!");
        }
        // Stub for getEstatus command
        public async Task getEstatus()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Getting EStatus...");
            await Task.Delay(1000);
            Console.WriteLine("Done!");
        }
        // Stub for incPot command
        public async Task incPot()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Increasing the turning speed...");
            await Task.Delay(1000);
            Console.WriteLine("Done!");
        }
        // Stub for decPot command
        public async Task decPot()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Decreasing the turning speed...");
            await Task.Delay(1000);
            Console.WriteLine("Done!");
        }
        // Stub for resetDebug command
        public async Task resetDebug()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Resetting debug flags...");
            await Task.Delay(1000);
            Console.WriteLine("Done!");
        }
        // Stub for setDebug command
        public async Task setDebug()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Setting debug flags...");
            await Task.Delay(1000);
            Console.WriteLine("Done!");
        }
        // Stub for CW command
        public async Task turnCW()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Turning CW...");
            await Task.Delay(1000);
            Console.WriteLine("Done!");
        }
        // Stub for CCW command
        public async Task turnCCW()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Turning CCW...");
            await Task.Delay(1000);
            Console.WriteLine("Done!");
        }
        // Stub for park command
        public async Task park()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Parking...");
            await Task.Delay(1000);
            Console.WriteLine("Parked!");
        }
        // Stub for full open command
        public async Task fullopen()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Opening...");
            await Task.Delay(1000);
            Console.WriteLine("Opened!");
        }
        // Stub for full close command
        public async Task fullclose()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Closing...");
            await Task.Delay(1000);
            Console.WriteLine("Closed!");
        }
        // Stub for open lower command
        public async Task openlower()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Opening lower shutter...");
            await Task.Delay(1000);
            Console.WriteLine("Opened lower shutter!");
        }
        // Stub for close lower command
        public async Task closelower()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Closing lower shutter...");
            await Task.Delay(1000);
            Console.WriteLine("Closed lower shutter!");
        }
        // Stub for slot reboot command
        public async Task slotreboot()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Rebooting...");
            await Task.Delay(1000);
            Console.WriteLine("Rebooted!");
        }
        // Stub for slot shutdown command
        public async Task slotshutdown()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Shutting down...");
            await Task.Delay(1000);
            Console.WriteLine("Shutdown!");
            //netConnected = false;
            
        }
        // Stub for run slot full diagnostics command
        public async Task runslotfulldiagnostics()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Running full slot diagnostics...");
            await Task.Delay(1000);
            Console.WriteLine("Diagnostics complete!");
        }
        // Stub for run slot short diagnostics command
        public async Task runslotshortldiagnostics()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Running short slot diagnostics...");
            await Task.Delay(1000);
            Console.WriteLine("Diagnostics complete!");
        }
        // Stub for set slot power off
        public async Task setslotpoweroff()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Powering off...");
            await Task.Delay(1000);
            Console.WriteLine("Powered off!");
        }
        // Stub for set slot power on
        public async Task setslotpoweron()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Powering on...");
            await Task.Delay(1000);
            Console.WriteLine("Powered on!");
        }
        // Stub for getting activity logs
        public async Task getactivity()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Getting activity logs...");
            await Task.Delay(1000);
            Console.WriteLine("Logs retrieved!");
        }
        // Stub for getting config.ini
        public async Task getconfigini()
        {
            if (!netConnected)
            {
                throw new InvalidOperationException("Not connected to the dome");
            }
            Console.WriteLine("Getting config.ini...");
            await Task.Delay(1000);
            Console.WriteLine("Config.ini retrieved!");
        }
    }
}
