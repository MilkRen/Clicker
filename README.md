# Clicker
### <p align="center"> The clicker has two modes - Default, Adbanced </p>
##   <p align="center"> Default </p>
<p align="center">
<img src="https://raw.githubusercontent.com/MilkRen/Clicker/master/img_github/Screenshot1.png"></p>

##   <p align="center"> Adbanced </p>
<p align="center">
<img src="https://raw.githubusercontent.com/MilkRen/Clicker/master/img_github/Screenshot3.png"></p>

# Context menu
<p align="center">
<img src="https://raw.githubusercontent.com/MilkRen/Clicker/master/img_github/Screenshot2.png"></p>

<p align="center">
<img src="https://raw.githubusercontent.com/MilkRen/Clicker/master/img_github/Screenshot6.png"></p>

Inset "Window" - mode switching

Inset "Closing" - close program 

Inset "Help" - open Help Form

Inset "Reset" - standard settings

#  FormHelp 
<p align="center">
<img src="https://raw.githubusercontent.com/MilkRen/Clicker/master/img_github/Screenshot4.png" height=400></p>
<p align="center">
<img src="https://raw.githubusercontent.com/MilkRen/Clicker/master/img_github/Screenshot5.png" height=400></p>

# Framework

##   <p align="center"> Mouse </p>

<img src="https://raw.githubusercontent.com/MilkRen/Clicker/master/img_github/Screenshot7.png" ></p>

Using MouseHooks to track mouse clicks.

This is necessary for the best placement of program when launch

```
[DllImport("user32.dll", SetLastError = true)]
public static extern bool SetCursorPos(int X, int Y);
private IKeyboardMouseEvents m_Events;

[DllImport("user32.dll")]
static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);
```
"user32.dll" to simulate mouse clicks

##   <p align="center"> Keyboard </p>
Using KeyboardHooks. Found on youtube!
To register clicks on the background!

## Social: [![](https://img.shields.io/badge/YouTube-090909??style=for-the-badge&logo=youtube&logoColor=FF0000)](https://www.youtube.com/channel/UCB_7Js6N4JMTnhu9gshcZQw) [![](https://img.shields.io/badge/telegram-090909??style=for-the-badge&logo=telegram&)](https://t.me/MilkRen)