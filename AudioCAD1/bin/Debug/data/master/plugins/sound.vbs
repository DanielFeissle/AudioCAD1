Set Sound = CreateObject("WMPlayer.OCX.7")
set objShell = WScript.CreateObject ("WScript.Shell")
objShell.CurrentDirectory = ".\..\..\audio\MaxxSteele"
Sound.URL = "hello.wav"
Sound.Controls.play
do while Sound.currentmedia.duration = 0
wscript.sleep 100
loop
sela=Sound.currentmedia.duration*1000
wscript.sleep sela
Set Sound = CreateObject("WMPlayer.OCX.7")
set objShell = WScript.CreateObject ("WScript.Shell")
objShell.CurrentDirectory = ".\..\..\audio\MaxxSteele"
Sound.URL = "what.wav"
Sound.Controls.play
do while Sound.currentmedia.duration = 0
wscript.sleep 100
loop
sela=Sound.currentmedia.duration*1000
wscript.sleep sela
Set Sound = CreateObject("WMPlayer.OCX.7")
set objShell = WScript.CreateObject ("WScript.Shell")
objShell.CurrentDirectory = ".\..\..\audio\MaxxSteele"
Sound.URL = "can.wav"
Sound.Controls.play
do while Sound.currentmedia.duration = 0
wscript.sleep 100
loop
sela=Sound.currentmedia.duration*1000
wscript.sleep sela
