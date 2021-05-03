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
    public partial class initialsWindow : Form
    { 
        // Globals
        int lap_time;
        int race_time;
        int race_entries = 0;
        int lap_entries = 0;

        public initialsWindow(int lapTime, int raceTime)
        {
            InitializeComponent();
            lap_time = lapTime;
            race_time = raceTime;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Grab new initials from tetbox
            string newInitials = enteredInitials.Text;
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
                    if (i >= 21)    // stop at 30
                    {
                        break;
                    }
                    //Read the next line
                    singleLines[i+1] = singleSr.ReadLine();
                    i++;
                }
                lap_entries = (i-2)/2;
                singleSr.Dispose();
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
                    if (j >= 21)    // stop at 30
                    {
                        break;
                    }
                    //Read the next line
                    raceLines[j+1] = raceSr.ReadLine();
                    race_entries = (j - 2) / 2;
                    j++;
                }
                raceSr.Dispose();
            }
            catch (Exception ev)
            {
                Console.WriteLine("Exception: " + ev.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            // Leaderboard control
            if (singleLines[2] == null)    // leaderboard has no entries
            {
                lapInitials[0] = newInitials;
                lapTimes[0] = lap_time;
                raceInitials[0] = newInitials;
                raceTimes[0] = race_time;
            }
            else    // Leaderboard has entries
            {
                // Adjusting lap times
                int i = 0;
                if (lap_time < lapTimes[9] || lapTimes[9] == 0)    // if new lap time is on leaderboard or leaderboard is not full
                {
                    while (i < 9) // count backwards for single-lap comparison
                    {
                        if (lapTimes[8-i] != 0)
                        {
                            if (lap_time >= lapTimes[8 - i])    // if new lap time is slower than the indexed place 
                            {
                                break;
                            }
                        }
                        i++;
                    } // (9-i) is the index of the new lap time
                    if (i == 0) // edge case for the last index (bottom of the leaderboard)
                    {
                        lapInitials[9] = newInitials;
                        lapTimes[9] = lap_time;
                    } else // other cases, i > 0
                    {
                        int j = 0;
                        while ((9 - i + j) < 9)    // shifting all other times down
                        {
                            lapInitials[(8 - j)+1] = lapInitials[(8 - j)];
                            lapTimes[(8 - j)+1] = lapTimes[(8 - j)];
                            j++;
                        }
                        // Insert new lap time
                        lapInitials[9-i] = newInitials;
                        lapTimes[9-i] = lap_time;
                    }
                }

                // Adjusting race times
                i = 0;
                if (race_time < raceTimes[9] || raceTimes[9] == 0)    // if new race time is on leaderboard
                {
                    while (i < 9) // count backwards for race comparison
                    {
                        if (raceTimes[8 - i] != 0)
                        {
                            if (race_time >= raceTimes[8 - i])    // if new lap time is slower than the indexed place 
                            {
                                break;
                            }
                        }
                        i++;
                    } // (9-i) is the index of the new race time
                    if (i == 0) // edge case for the last index (bottom of the leaderboard)
                    {
                        raceInitials[9] = newInitials;
                        raceTimes[9] = race_time;
                    }
                    else // other cases, i > 0
                    {
                        int j = 0;
                        while ((9 - i + j) < 9)    // shifting all other times down
                        {
                            raceInitials[(8 - j + 1)] = raceInitials[(8 - j)];
                            raceTimes[(8 - j)+1] = raceTimes[(8 - j)];
                            j++;
                        }
                        // Insert new race time
                        raceInitials[9 - i] = newInitials;
                        raceTimes[9 - i] = race_time;
                    }
                }
                // at this point, the times are updated and ready to be inserted back into the files
            }

            // rewrite lap times and initials
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter singleSw = new StreamWriter("C:\\SingleLapLeaderboard.txt");
                //Rewrite first two lines of text
                singleSw.WriteLine("SmartTrack Leaderboard - Single Lap"); // index 0
                singleSw.WriteLine("Top 10:"); // index 1
                int i;
                for (i = 0; i < 10; i++)    // index 2-21
                {
                    singleSw.WriteLine(lapInitials[i]);
                    singleSw.WriteLine(lapTimes[i].ToString());
                }
                //Close the file
                singleSw.Close();
            }
            catch (Exception ev)
            {
                Console.WriteLine("Exception: " + ev.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            // rewrite race times and initials
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter raceSw = new StreamWriter("C:\\RaceTimeLeaderboard.txt");
                //Rewrite first two lines of text
                raceSw.WriteLine("SmartTrack Leaderboard -  Race Time"); // index 0
                raceSw.WriteLine("Top 10:"); // index 1
                int i;
                for (i = 0; i < 10; i++)    // index 2-21
                {
                    raceSw.WriteLine(raceInitials[i]);
                    raceSw.WriteLine(raceTimes[i].ToString());
                }
                //Close the file
                raceSw.Close();
            }
            catch (Exception ev)
            {
                Console.WriteLine("Exception: " + ev.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            this.Close();
        }
    }
}
