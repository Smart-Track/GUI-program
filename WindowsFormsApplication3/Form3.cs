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

namespace WindowsFormsApplication3
{
    public partial class leaderboardWindow : Form
    {
        public leaderboardWindow()
        {
            InitializeComponent();

            // Open Leaderboard to edit values
            string[] singleLines = new string[22];    // only tracks top 10: [name, single lap time,...].
            string[] raceLines = new string[22];    // only tracks top 10: [name, three lap time,...].
            string[] lapInitials = new string[10];
            string[] raceInitials = new string[10];
            int[] lapTimes = new int[10];
            int[] raceTimes = new int[10];
            try
            {
                //Pass the filepath and filename to the StreamReader Constructor
                StreamReader singleSr = new StreamReader("C:\\SingleLapLeaderboard.txt");
                singleLines[0] = singleSr.ReadLine();
                singleLines[1] = singleSr.ReadLine(); // Throw out the first two
                singleLines[2] = singleSr.ReadLine();
                //Continue to read until you reach end of file
                int i = 2;  // first two lines aready full
                while (singleLines[i] != null)
                {
                    if (i % 2 == 0)   // initials
                    {
                        lapInitials[(i - 2) / 2] = singleLines[i];
                    }
                    if (i % 2 == 1) // lap time
                    {
                        lapTimes[(i - 3) / 2] = Int32.Parse(singleLines[i]);
                    }
                    if (i >= 22)    // stop at 30
                    {
                        break;
                    }
                    //Read the next line
                    singleLines[i + 1] = singleSr.ReadLine();
                    i++;
                }
                singleSr.Close();
            }
            catch (Exception ev)
            {
                Console.WriteLine("Exception: " + ev.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            try
            {
                //Pass the filepath and filename to the StreamReader Constructor
                StreamReader raceSr = new StreamReader("C:\\RaceTimeLeaderboard.txt");
                raceLines[0] = raceSr.ReadLine();
                raceLines[1] = raceSr.ReadLine(); // Throw out the first two
                raceLines[2] = raceSr.ReadLine();
                //Continue to read until you reach end of file
                int j = 2;
                while (raceLines[j] != null)
                {
                    if (j % 2 == 0)   // initials
                    {
                        raceInitials[(j - 2) / 2] = raceLines[j];
                    }
                    if (j % 2 == 1) // race time
                    {
                        raceTimes[(j - 3) / 2] = Int32.Parse(raceLines[j]);
                    }
                    if (j >= 22)    // stop at 30
                    {
                        break;
                    }
                    //Read the next line
                    raceLines[j + 1] = raceSr.ReadLine();
                    j++;
                }
                raceSr.Close();
            }
            catch (Exception ev)
            {
                Console.WriteLine("Exception: " + ev.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            // Display leaderboard results in label positions
            if(raceTimes[0] != 0)
            {
                totalPos1Name.Text = raceInitials[0];
                totalPos1Time.Text = (raceTimes[0] / 600).ToString() + " : " + ((raceTimes[0] / 10) % 60).ToString() + " . " + (raceTimes[0] % 10).ToString();
            }
            if (raceTimes[1] != 0)
            {
                totalPos2Name.Text = raceInitials[1];
                totalPos2Time.Text = (raceTimes[1] / 600).ToString() + " : " + ((raceTimes[1] / 10) % 60).ToString() + " . " + (raceTimes[1] % 10).ToString();
            }
            if (raceTimes[2] != 0)
            {
                totalPos3Name.Text = raceInitials[2];
                totalPos3Time.Text = (raceTimes[2] / 600).ToString() + " : " + ((raceTimes[2] / 10) % 60).ToString() + " . " + (raceTimes[2] % 10).ToString();
            }
            if (raceTimes[3] != 0)
            {
                totalPos4Name.Text = raceInitials[3];
                totalPos4Time.Text = (raceTimes[3] / 600).ToString() + " : " + ((raceTimes[3] / 10) % 60).ToString() + " . " + (raceTimes[3] % 10).ToString();
            }
            if (raceTimes[4] != 0)
            {
                totalPos5Name.Text = raceInitials[4];
                totalPos5Time.Text = (raceTimes[4] / 600).ToString() + " : " + ((raceTimes[4] / 10) % 60).ToString() + " . " + (raceTimes[4] % 10).ToString();
            }
            if (raceTimes[5] != 0)
            {
                totalPos6Name.Text = raceInitials[5];
                totalPos6Time.Text = (raceTimes[5] / 600).ToString() + " : " + ((raceTimes[5] / 10) % 60).ToString() + " . " + (raceTimes[5] % 10).ToString();
            }
            if (raceTimes[6] != 0)
            {
                totalPos7Name.Text = raceInitials[6];
                totalPos7Time.Text = (raceTimes[6] / 600).ToString() + " : " + ((raceTimes[6] / 10) % 60).ToString() + " . " + (raceTimes[6] % 10).ToString();
            }
            if (raceTimes[7] != 0)
            {
                totalPos8Name.Text = raceInitials[7];
                totalPos8Time.Text = (raceTimes[7] / 600).ToString() + " : " + ((raceTimes[7] / 10) % 60).ToString() + " . " + (raceTimes[7] % 10).ToString();
            }
            if (raceTimes[8] != 0)
            {
                totalPos9Name.Text = raceInitials[8];
                totalPos9Time.Text = (raceTimes[8] / 600).ToString() + " : " + ((raceTimes[8] / 10) % 60).ToString() + " . " + (raceTimes[8] % 10).ToString();
            }
            if (raceTimes[9] != 0)
            {
                totalPos10Name.Text = raceInitials[9];
                totalPos10Time.Text = (raceTimes[9] / 600).ToString() + " : " + ((raceTimes[9] / 10) % 60).ToString() + " . " + (raceTimes[9] % 10).ToString();
            }

            // Single lap
            if (lapTimes[0] != 0)
            {
                singlePos1Name.Text = lapInitials[0];
                singlePos1Time.Text = (lapTimes[0] / 600).ToString() + " : " + ((lapTimes[0] / 10) % 60).ToString() + " . " + (lapTimes[0] % 10).ToString();
            }
            if (lapTimes[1] != 0)
            {
                singlePos2Name.Text = lapInitials[1];
                singlePos2Time.Text = (lapTimes[1] / 600).ToString() + " : " + ((lapTimes[1] / 10) % 60).ToString() + " . " + (lapTimes[1] % 10).ToString();
            }
            if (lapTimes[2] != 0)
            {
                singlePos3Name.Text = lapInitials[2];
                singlePos3Time.Text = (lapTimes[2] / 600).ToString() + " : " + ((lapTimes[2] / 10) % 60).ToString() + " . " + (lapTimes[2] % 10).ToString();
            }
            if (lapTimes[3] != 0)
            {
                singlePos4Name.Text = lapInitials[3];
                singlePos4Time.Text = (lapTimes[3] / 600).ToString() + " : " + ((lapTimes[3] / 10) % 60).ToString() + " . " + (lapTimes[3] % 10).ToString();
            }
            if (lapTimes[4] != 0)
            {
                singlePos5Name.Text = lapInitials[4];
                singlePos5Time.Text = (lapTimes[4] / 600).ToString() + " : " + ((lapTimes[4] / 10) % 60).ToString() + " . " + (lapTimes[4] % 10).ToString();
            }
            if (lapTimes[5] != 0)
            {
                singlePos6Name.Text = lapInitials[5];
                singlePos6Time.Text = (lapTimes[5] / 600).ToString() + " : " + ((lapTimes[5] / 10) % 60).ToString() + " . " + (lapTimes[5] % 10).ToString();
            }
            if (lapTimes[6] != 0)
            {
                singlePos7Name.Text = lapInitials[6];
                singlePos7Time.Text = (lapTimes[6] / 600).ToString() + " : " + ((lapTimes[6] / 10) % 60).ToString() + " . " + (lapTimes[6] % 10).ToString();
            }
            if (lapTimes[7] != 0)
            {
                singlePos8Name.Text = lapInitials[7];
                singlePos8Time.Text = (lapTimes[7] / 600).ToString() + " : " + ((lapTimes[7] / 10) % 60).ToString() + " . " + (lapTimes[7] % 10).ToString();
            }
            if (lapTimes[8] != 0)
            {
                singlePos9Name.Text = lapInitials[8];
                singlePos9Time.Text = (lapTimes[8] / 600).ToString() + " : " + ((lapTimes[8] / 10) % 60).ToString() + " . " + (lapTimes[8] % 10).ToString();
            }
            if (lapTimes[9] != 0)
            {
                singlePos10Name.Text = lapInitials[9];
                singlePos10Time.Text = (lapTimes[9] / 600).ToString() + " : " + ((lapTimes[9] / 10) % 60).ToString() + " . " + (lapTimes[9] % 10).ToString();
            }
            // REALIZED THIS COULD HAVE BEEN DONE BY ITERATION.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
