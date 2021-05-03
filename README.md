# GUI-program
This repo contains the C# program for use in the Smart-Track. The program uses a clock to track lap/checkpoint times and receives characters over USB from the mbed to signify when a checkpoint has been passed. It displays these for the user to see in-real-time what their race times are. It also claculates the "split" times compared to their personal best for evert porion of the track as well as the total lap times.

This was originally meant to run on the raspberry pi, but an issue with the serial port object through the Pi prevented this. Program requires running as admin in this iteration. This is for use with the leaderboard files to read/write.

Form1 - Application Window
  Main window that loads upon startup. Enables starting the race after a device is selected. Displays race times. Creates popup windows for the leaderboard to be tracked with text files. Waits for user to reset race and start another one.
  
Form2 - Initials Window
  Popup window that appears when the race is finished. Prompts the user to enter their initials for tracking on the leaderboard. Edits the leaderboard .txt files based on race times and initials entered. Waits for them to click enter before returning to the app window.
  
Form3 - Leaderboard
  Popup window that appears after the Initials Window is closed. This takes the information that was edited from Initials Window and reads it back to the user in a two-list form. Waits for user to close before returning to Application Window.
