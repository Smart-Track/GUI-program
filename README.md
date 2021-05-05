# Smart Track - GUI Program

Smart Track is a modular race track for RC cars controlled by an ARM Mbed and C# GUI. This repo contains the GUI Code. For the mbed code, see [the Smart Track mbed repo](https://github.com/Smart-Track/mbed-program).

Smart Track has three checkpoints, including one starting line checkpoint. These detect passing objects using sonar and can be placed anywhere to define the shape of the track. All hardware is controlled by the Mbed, which must be connected to a device running the GUI program. The GUI starts the race and resets the Mbed when the race is over. It also runs the race timer and keeps a record of past races.

# Setup

## GUI Application

Either compile the contents of `/Smart-Track/GUI-program/` in Microsoft Visual Studio or download `g` to a computer running Windows and open the executable. Both of these methods require running the application as administrator (right click VS or the .exe and "Run as Administrator").

## Hardware Requirements

As stated above, this program requires a Windows machine to run due to being built as a Windows Form. The PC running the application requires a keyboard and mouse for Leaderboard entry.

# Communication

The Mbed and GUI communicate with each other by sending certain ASCII characters over the USB cable, as shown in the tables below.

## Mbed to PC

| Character    | Meaning |
|:-------------:|:--------:|
| '0' | lap 1, past starting line |
| '1' | lap 1, past checkpoint 1 |
| '2' | lap 1, past checkpoint 2 |
| '3' | lap 2, past starting line |
| '4' | lap 2, past checkpoint 1 |
| '5' | lap 2, past checkpoint 2 |
| '6' | lap 3, past starting line |
| '7' | lap 3, past checkpoint 1 |
| '8' | lap 3, past checkpoint 2 |
| '9' | end race |

## PC to Mbed

| Character    | Meaning |
|:-------------:|:--------:|
| 'S' | start race |
| 'R' | reset |

# Race

After setting up the hardware, connect the Mbed to a PC using a USB cable and run the Smart Track GUI program. Select the appropriate COM port for the Mbed in the upper left corner. On startup, give one or two seconds for the Mbed to perform calibration. 

After that, you can start a race by clicking the "Start Race" button, which will begin a countdown sequence on the 7-segment display and RGB LEDs. The GUI keeps time, but doesn't start the timer until the player first crosses the starting line. During the race, the player must cross all of the checkpoints in order, and upon crossing a checkpoint, a sound will play and the checkpoint's LEDs will turn on to indicate that the checkpoint has been passed. The current lap is displayed on the starting line's RGB LEDs, and the race is finished after completing three laps, at which point the GUI will prompt the player to enter their initials and record their times on an internal leaderboard. The system can then be reset by clicking the "Reset" button in the bottom right corner.

# GUI Application Overview

The program uses a clock to track lap/checkpoint times and receives characters over USB from the mbed to signify when a checkpoint has been passed. It displays these for the user to see in-real-time what their race times are. It also claculates the "split" times compared to their personal best for evert porion of the track as well as the total lap times.

This was originally meant to run on the raspberry pi, but an issue with the serial port object through the Pi prevented this. Program requires running as admin in this iteration. This is for use with the leaderboard files to read/write.

Form1 - Application Window
  Main window that loads upon startup. Enables starting the race after a device is selected. Displays race times. Creates popup windows for the leaderboard to be tracked with text files. Waits for user to reset race and start another one.
  
Form2 - Initials Window
  Popup window that appears when the race is finished. Prompts the user to enter their initials for tracking on the leaderboard. Edits the leaderboard .txt files based on race times and initials entered. Waits for them to click enter before returning to the app window.
  
Form3 - Leaderboard
  Popup window that appears after the Initials Window is closed. This takes the information that was edited from Initials Window and reads it back to the user in a two-list form. Waits for user to close before returning to Application Window.

# Image Gallery

![image-20210430-154437-a2d73727](https://user-images.githubusercontent.com/68122426/117200580-9ed13d80-adb9-11eb-9073-e2c98b634fc8.jpeg)
![image-20210430-154442-ae8883db](https://user-images.githubusercontent.com/68122426/117200600-a4c71e80-adb9-11eb-86b8-e8b59b56cfc7.jpeg)
![image-20210430-154551-0cab5338](https://user-images.githubusercontent.com/68122426/117200744-d50ebd00-adb9-11eb-89c5-c27a4092294a.jpeg)
![image-20210430-154625-e53be03d](https://user-images.githubusercontent.com/68122426/117200785-e1931580-adb9-11eb-9723-2b6e393c90b3.jpeg)
![20210420_120333(1)](https://user-images.githubusercontent.com/68122426/117200971-1acb8580-adba-11eb-9041-938fc7d0b57d.jpg)
![App Window](https://user-images.githubusercontent.com/68122426/117201116-46e70680-adba-11eb-9292-a83ecacb23c9.JPG)
![Initials WIndow](https://user-images.githubusercontent.com/68122426/117201130-4b132400-adba-11eb-8110-bc6d730320f5.JPG)
![Leaderboard](https://user-images.githubusercontent.com/68122426/117201138-4c445100-adba-11eb-9f4e-5460ec7a69e3.JPG)

# Authors

* [Aaron Hoffman](https://github.com/ahoffman41)
* [Dan Tran](https://github.com/dtran76)
* [Greg Lanier](https://github.com/glanier9)
