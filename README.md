<p align="center">
  <img width="200px" height="200px" src="https://i.imgur.com/9eD84sP.png" />
</p>
<p align="center">
  <img alt="GitHub" src="https://img.shields.io/github/license/hmz777/New-File-Tool?color=blue&style=flat-square">
  <img alt="GitHub release (latest by date)" src="https://img.shields.io/github/v/release/hmz777/New-File-Tool?color=orange&label=latest%20release&style=flat-square">
  <img alt="GitHub Release Date" src="https://img.shields.io/github/release-date/hmz777/New-File-Tool?color=yellow&style=flat-square">
  <img alt="GitHub last commit" src="https://img.shields.io/github/last-commit/hmz777/New-File-Tool?color=green&style=flat-square">
</p>

# New File Tool
Basically, this is a tool that lets you create empty files on the fly wherever you want.

# Why?
Well since Windows 10 v2004, Microsoft removed the txt file from the "New" Context menu and I always find myself creating .bat and .ps1 files beside .txt files and other file types
that aren't present in the New Context menu and adding every file that I want to the menu using the registry ShellNew key was ugly so I created this tool.

# How?
The app uses Pinvoke to grab the **Active Windows Explorer** window you're working in, get the path that is open in it, and set it as the path that you'll be creating paths relative to.
If it doesn't find an **Active** "explorer.exe" window, it creates your file on the desktop directory.

# Features
- The app registers a System-wide Hot Key (L-Shift + Q), a combination of keys that when pressed can activate the app and bring it to the topmost.
- Can create full paths, not just files i.e, "dir\file.txt" creates a directory with the name "dir" and "file.txt" inside it. 
- You can add file attribute flags so you can mark the file as `hidden`, `system`, or `readonly`.
Something like this: ***\dir1\dir2\file.txt > -h -s -r***.
- If you don't have an **active** "explorer.exe" window or you're in a special system folder like the root directory "This PC" or "Recycle Bin" the app creates your file on the desktop directory.
- The app starts minimized with a tray icon and can be brought to the front via the tray context menu with the "Show" button or via the defined HotKey.

# Binaries
[Download NewFileTool](https://github.com/hmz777/New-File-Tool/releases/download/v1.1/NewFileTool.zip)

# Notes
Most of the code that you'll see in this repository is from [Pinvoke](http://www.pinvoke.net/) and StackOverflow. I only stitched them together and added some code of my own to create this tool.

# Development Notes
This project references the following COM libraries:
- Microsoft Shell Controls And Automation
- Microsoft Internet Controls

You don't have to reference them, I only did it to expose the **Shell, ShellWindows, and InternetExplorer** types in the [Tools](https://github.com/hmz777/New-File-Tool/blob/master/Helpers/Tools.cs) Class for IntelliSense purposes only, you can just leave them as dynamic and compile. See [here](https://github.com/hmz777/New-File-Tool/blob/33dbba8669db3ca1067573a9ce17839c6b3471a2/Helpers/Tools.cs#L32).

# Upcoming Features
- ~~I will be adding file attribute flags so you can mark the file as `hidden`, `system`, or `readonly`. Something like this: ***\dir1\dir2\file.txt > -h -s -r***~~ Done! :white_check_mark:
- An option for entering absolute paths instead of relative ones. 

# Author
Hamzi Alsheikh

Website: [https://www.hamzialsheikh.tk](https://www.hamzialsheikh.tk)
