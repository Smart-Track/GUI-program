using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication3
{
    public partial class appWindow : Form
    {
        // Lap 1-3 ticks
        int t1 = 0;
        int t2 = 0;
        int t3 = 0;

        // Ticks for Personal Best, [min, sec, ds]
        int lapPb = 0;
        int cp1Pb = 0;
        int cp2Pb = 0;

        // Globals
        char[] startChar = { 'S' };
        char[] resetChar = { 'R' };
        bool portOpen = false;

        public appWindow()
        {
            // Form Init
            InitializeComponent();

            // Blank the Split placeholders
            Lap2Split.Text = " ";
            Lap2Cp1Split.Text = " ";
            Lap2Cp2Split.Text = " ";
            Lap3Split.Text = " ";
            Lap3Cp1Split.Text = " ";
            Lap3Cp2Split.Text = " ";
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            // Read char from serial port and move into textbox
            int read = serialPort1.ReadByte();
            dataIn.BeginInvoke(new Action(() => { dataIn.Text = read.ToString(); }));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Setup COM port when selected
            serialPort1.Close();
            List<String> tList = new List<String>();
            string[] portNames = System.IO.Ports.SerialPort.GetPortNames();
            serialPort1.PortName = portNames[comboBox1.SelectedIndex];
            serialPort1.Open();

            // Show COM Port in a separate area
            spLabel.Text = serialPort1.PortName + " Ready";
            portOpen = true;
        }

        // Lap 1 Tick
        private void appTimer_Tick(object sender, EventArgs e)
        {
            t1++;
            Lap1Label.Text = (t1 / 600).ToString() + " : " +  ((t1 / 10) % 60).ToString() + " . " + (t1 % 10).ToString();
        }

        private void appWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
            portOpen = false;
        }

        private void serialPort1_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
        {
            dataIn.BeginInvoke(new Action(() => { spLabel.Text = "ERROR: " + e.ToString(); }));
        }

        private void Lap2Timer_Tick(object sender, EventArgs e)
        {
            t2++;
            Lap2Label.Text = (t2 / 600).ToString() + " : " + ((t2 / 10) % 60).ToString() + " . " + (t2 % 10).ToString();
        }

        private void Lap3Timer_Tick(object sender, EventArgs e)
        {
            t3++;
            Lap3Label.Text = (t3 / 600).ToString() + " : " + ((t3 / 10) % 60).ToString() + " . " + (t3 % 10).ToString();
        }

        private void dataIn_TextChanged_1(object sender, EventArgs e)
        {
            // When serial port changes the data label, check char and respond
            switch (dataIn.Text)
            {
                case "48":  // char = 0, start lap 1
                    Lap1Timer.Enabled = true; 
                    break;
                case "49":  // // char = 1, Lap 1 pass checkpoint 1
                    Lap1Cp1Label.Text = Lap1Label.Text;
                    cp1Pb = t1; // Capture time for next split
                    break;
                case "50":  // // char = 2, Lap 1 pass checkpoint 2
                    Lap1Cp2Label.Text = Lap1Label.Text;
                    cp2Pb = t1; // Capture time for next split
                    break;
                case "51":  // char = 3, start lap 2
                    Lap2Timer.Enabled = true;
                    Lap1Timer.Enabled = false;
                    lapPb = t1; // Capture time for next split
                    break;
                case "52":  // // char = 4, Lap 2 pass checkpoint 1
                    Lap2Cp1Label.Text = Lap2Label.Text;
                    // Compare for cp1 split
                    if (t2 < cp1Pb) // if faster
                    {
                        Lap2Cp1Split.ForeColor = Color.FromArgb(255, 211, 25); // Yellow for faster
                        Lap2Cp1Split.Text = ( "- " + (cp1Pb - t2)/ 600).ToString() + " : " + (((cp1Pb - t2) / 10) % 60).ToString() + " . " + ((cp1Pb - t2) % 10).ToString();
                        cp1Pb = t2; // new pb
                    } else // if slower
                    {
                        Lap2Cp1Split.ForeColor = Color.FromArgb(255, 41, 117); // red for slower
                        Lap2Cp1Split.Text = ("+ " + (t2 - cp1Pb) / 600).ToString() + " : " + (((t2 - cp1Pb) / 10) % 60).ToString() + " . " + ((t2 - cp1Pb) % 10).ToString();
                    }
                    break;
                case "53":  // // char = 5, Lap 2 pass checkpoint 2
                    Lap2Cp2Label.Text = Lap2Label.Text;
                    // Compare for cp2 split
                    if (t2 < cp2Pb) // if faster
                    {
                        Lap2Cp2Split.ForeColor = Color.FromArgb(255, 211, 25); // Yellow for faster
                        Lap2Cp2Split.Text = ("- " + (cp2Pb - t2) / 600).ToString() + " : " + (((cp2Pb - t2) / 10) % 60).ToString() + " . " + ((cp2Pb - t2) % 10).ToString();
                        cp2Pb = t2; // new pb
                    }
                    else // if slower
                    {
                        Lap2Cp2Split.ForeColor = Color.FromArgb(255, 41, 117); // red for slower
                        Lap2Cp2Split.Text = ("+ " + (t2 - cp2Pb) / 600).ToString() + " : " + (((t2 - cp2Pb) / 10) % 60).ToString() + " . " + ((t2 - cp2Pb) % 10).ToString();
                    }
                    break;
                case "54":  // char = 6, start lap 3
                    Lap3Timer.Enabled = true;
                    Lap2Timer.Enabled = false;
                    // Compare for lap split
                    if (t2 < lapPb) // if faster
                    {
                        Lap2Split.ForeColor = Color.FromArgb(255, 211, 25); // Yellow for faster
                        Lap2Split.Text = ("- " + (lapPb - t2) / 600).ToString() + " : " + (((lapPb - t2) / 10) % 60).ToString() + " . " + ((lapPb - t2) % 10).ToString();
                        lapPb = t2; // new pb
                    }
                    else // if slower
                    {
                        Lap2Split.ForeColor = Color.FromArgb(255, 41, 117); // red for slower
                        Lap2Split.Text = ("+ " + (t2 - lapPb) / 600).ToString() + " : " + (((t2 - lapPb) / 10) % 60).ToString() + " . " + ((t2 - lapPb) % 10).ToString();
                    }
                    break;
                case "55":  // // char = 7, Lap 3 pass checkpoint 1
                    Lap3Cp1Label.Text = Lap3Label.Text;
                    // Compare for cp1 split
                    if (t3 < cp1Pb) // if faster
                    {
                        Lap3Cp1Split.ForeColor = Color.FromArgb(255, 211, 25); // Yellow for faster
                        Lap3Cp1Split.Text = ("- " + (cp1Pb - t3) / 600).ToString() + " : " + (((cp1Pb - t3) / 10) % 60).ToString() + " . " + ((cp1Pb - t3) % 10).ToString();
                        cp1Pb = t3; // new pb
                    }
                    else // if slower
                    {
                        Lap3Cp1Split.ForeColor = Color.FromArgb(255, 41, 117); // red for slower
                        Lap3Cp1Split.Text = ("+ " + (t3 - cp1Pb) / 600).ToString() + " : " + (((t3 - cp1Pb) / 10) % 60).ToString() + " . " + ((t3 - cp1Pb) % 10).ToString();
                    }
                    break;
                case "56":  // // char = 8, Lap 3 pass checkpoint 2
                    Lap3Cp2Label.Text = Lap3Label.Text;
                    // Compare for cp2 split
                    if (t3 < cp2Pb) // if faster
                    {
                        Lap3Cp2Split.ForeColor = Color.FromArgb(255, 211, 25); // Yellow for faster
                        Lap3Cp2Split.Text = ("- " + (cp2Pb - t3) / 600).ToString() + " : " + (((cp2Pb - t3) / 10) % 60).ToString() + " . " + ((cp2Pb - t3) % 10).ToString();
                        cp2Pb = t3; // new pb
                    }
                    else // if slower
                    {
                        Lap3Cp2Split.ForeColor = Color.FromArgb(255, 41, 117); // red for slower
                        Lap3Cp2Split.Text = ("+ " + (t3 - cp2Pb) / 600).ToString() + " : " + (((t3 - cp2Pb) / 10) % 60).ToString() + " . " + ((t3 - cp2Pb) % 10).ToString();
                    }
                    break;
                case "57":  // // char = 9, end race
                    Lap3Timer.Enabled = false;
                    // Compare for lap split
                    if (t3 < lapPb) // if faster
                    {
                        Lap3Split.ForeColor = Color.FromArgb(255, 211, 25); // Yellow for faster
                        Lap3Split.Text = ("- " + (lapPb - t3) / 600).ToString() + " : " + (((lapPb - t3) / 10) % 60).ToString() + " . " + ((lapPb - t3) % 10).ToString();
                        lapPb = t3; // new pb
                    }
                    else // if slower
                    {
                        Lap3Split.ForeColor = Color.FromArgb(255, 41, 117); // red for slower
                        Lap3Split.Text = ("+ " + (t3 - lapPb) / 600).ToString() + " : " + (((t3 - lapPb) / 10) % 60).ToString() + " . " + ((t3 - lapPb) % 10).ToString();
                    }
                    // Add up lap times to get race time
                    int raceTime = t1 + t2 + t3;
                    // Determine best single lap time
                    int lapTime = 0;
                    if (t1 <= t2 && t1 <= t3) // t1 fastest, had to use <= because if equal it would stay zero
                    {
                        lapTime = t1;
                    }
                    else if (t2 <= t1 && t2 <= t3)    // t2 fastest
                    {
                        lapTime = t2;
                    }
                    else if (t3 <= t1 && t3 <= t2)    // t3 fastest
                    {
                        lapTime = t3;
                    }
                    // Popup window to prompt for leaderboard initials
                    initialsWindow initials = new initialsWindow(lapTime, raceTime);
                    DialogResult dialogresult1 = initials.ShowDialog(); // Cannot interact with main menu until popup closes
                    initials.Dispose();    // get rid of initials window
                    // Popup window to display leaderboard
                    leaderboardWindow leaderboard = new leaderboardWindow();
                    DialogResult dialogresult2 = leaderboard.ShowDialog(); // Cannot interact with main menu until popup closes
                    leaderboard.Dispose();    // get rid of leaderboard window
                    break;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (portOpen)
            {
                // Write start char to port
                serialPort1.Write(startChar, 0, System.Text.ASCIIEncoding.ASCII.GetByteCount(startChar));
            } else
            {
                spLabel.Text = "NO DEVICE CHOSEN!";
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // Write reset char to port
            serialPort1.Write(resetChar, 0, System.Text.ASCIIEncoding.ASCII.GetByteCount(resetChar));
            // Wipe all time labels
            Lap1Label.Text = "-- : -- . -";
            Lap1Cp1Label.Text = "-- : -- . -";
            Lap1Cp2Label.Text = "-- : -- . -";
            Lap2Label.Text = "-- : -- . -";
            Lap2Cp1Label.Text = "-- : -- . -";
            Lap2Cp2Label.Text = "-- : -- . -";
            Lap2Split.Text = " ";
            Lap2Cp1Split.Text = " ";
            Lap2Cp2Split.Text = " ";
            Lap3Label.Text = "-- : -- . -";
            Lap3Cp1Label.Text = "-- : -- . -";
            Lap3Cp2Label.Text = "-- : -- . -";
            Lap3Split.Text = " ";
            Lap3Cp1Split.Text = " ";
            Lap3Cp2Split.Text = " ";
            // Wipe the timers
            t1 = 0;
            t2 = 0;
            t3 = 0;
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {

            // COM Port combo box setup
            List<String> tList = new List<String>();
            comboBox1.Items.Clear();
            string[] portNames = System.IO.Ports.SerialPort.GetPortNames();
            // If no devices available
            if (portNames == null || portNames.Length == 0)
            {
                tList.Add("NO DEVICE FOUND");
            }
            else
            {
                foreach (string s in portNames)
                {
                    tList.Add(s);
                }
                tList.Sort();
            }
            comboBox1.Items.AddRange(tList.ToArray());
        }
    }
}
