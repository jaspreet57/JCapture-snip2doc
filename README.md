# JCapture-snip2doc

This project is started to prepare tools or scripts in various languages like java, c#, batch script, visual basic script, etc. that can be used to easily take screenshots and paste them in word document or save them in some folder. It will include some other functionalities that can be helpful.

### Q- is it required? We have print screen key and snipping tools in every operating system then why this?
> Well it can be helpful in office use and in projects like testing where taking screenshots is heavily done. And if printscreen key is not working or disabled by administrator (for some reason or policy)

> If you are not allowed to download any exe file and install any program. You can download or copy C# code and can compile yourself by using preinstalled C# compiler CSC which is there in almost every winodows.

### Project contains following tools which are working till date:
- Java class that take screenshot and return image.
- Java Standalone program that take screenshot and add to clipboard so you can paste it anywhere. (you can invoke this program by assigning any shortcut key like alt+0  - see below)
- C# class that take screenshot and return image.
- C# standalone program that take screenshot and add to clipboard so you can paste it anywhere. (you can invoke this program by assigning any shortcut key like alt+0  - see below)
- C# GUI Application that can take screenshot and paste it in provided word file automatically by just clicking one button which remains at top always.


### Version for C# GUI Application
1.0

### Prerequisite:
- If you have java installed in your system, you just need to download compiled classes from java folder. Read readme file in java folder for more details.
- If you have jdk installed you can compile java source code yourself also.
- If you don’t have java, then go for c#.
- In case of c# application, I prefer you to download code and compile yourself. Because it is using some reference that could be different for your system.



### How to compile yourself code?
- I am using c# compiler which comes preinstalled with .net framework. So if you have .net framework installed in your windows, then c# compiler is also there for sure.
- I am also using reference to Microsoft.Office.Interop.Word.dll which is part of office tools and gets installed when you install MS Office.
- So finally open cmd and go to folder in which your source code is. And compile by typing below syntax:
```sh
Path\to\c# compiler\csc sourceCode.cs /r:path\to\Microsoft.Office.Interop.Word.dll
```
Example in my case:
```sh
C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc jcapture.cs /r:C:\Windows\assembly\GAC_MSIL\Microsoft.Office.Interop.Word\15.0.0.0__71e9bce111e9429c\Microsoft.Office.Interop.Word.dll
```
- That's it.
- Run exe file and you got it.

### How to use any shortcut key like alt+0 to invoke screenshot class or exe file.
##### in case of c# program:
- compile it first.
- then right click on exe file and create shortcut on desktop.
- right click shortcut and open properties.
- in properties you can find shortcut tab.
- there is one shortcut key field. now just assign any key combination in that.
- you can use that key combination to run that program while doing you work.
 
##### in case of java class:
- procedure is same but first you to write batch file that can run java class.
- for example write : java YourClass
- then create shortcut of batch file and assigned key combination to that shortcut. that's it.
