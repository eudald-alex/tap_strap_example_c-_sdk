# Tap_Strap_example_c#_sdk
App with visual basic to show the valors that you can obtain with the Tap Strap v2

## What Is This ?
TAP WINDOWS SDK allows you to build a a native Windows application that can receive input from TAP devices, In a way that each tap is being interpreted as an array or fingers that are tapped, or a binary combination integer (explanation follows), Thus allowing the TAP device to act as a controller for your app!

## Compilation
Download the SDK open-source code from github, and compile it to create TAPWin.dll file. The SDK is written in C#.

You may need a reference to windows.winmd file. To add the reference: In the solution explorer, under TAPWinSDK, right click the "References" item and choose "Add reference". On the left pane of the popup choose "Browse" and click the "Browse" button. Navigate to windows.winmd file location: C:\Program Files (x86)\Windows Kits\10\UnionMetadata\10.0....(windows sdk version)
And add it as a reference.

*Make sure you download Windows Kits 10, older versions don't work cause to bluetooth especifications.*

Add TAPWIn.dll as a reference to your project.

Importing TAPWin into your source code:

using TAPWin;

## More information:

https://github.com/TapWithUs/tap-standalonewin-sdk
