@echo off
echo ############################
echo AudioPlayer.bat start
echo ----------------------------
echo Script directory: %~dp0
echo Audio directory%CD%
echo ----------------------------
echo ----------------------------
set sent=
set sentNo=
REM the first value will always be the folder name, 2nd value will be location of file(0 audio is in audio folder, 1 audio is in standalone directory), n++ will be whatever is passed
set noe=%1%
set HaRa=%~dp0sound.vbs
shift
set far=
if %1% EQU 0 (
  echo use standard
  set far=objShell.CurrentDirectory = ^".\..\..\audio\%noe%^"
) else (
  echo use standalone
  set far=objShell.CurrentDirectory = ^"%noe%^"
)
shift

copy /y NUL %HaRa% >NUL
 
:LOOP
if "%1"=="" goto ENDLOOP

set sent=%sent% %1%
set /a sentNo= %sentNo% +1
set file=%sent%
( echo Set Sound = CreateObject("WMPlayer.OCX.7"^)
  echo set objShell = WScript.CreateObject ("WScript.Shell"^)
  echo %far%
  echo Sound.URL = "%1%"
  echo Sound.Controls.play
  echo do while Sound.currentmedia.duration = 0
  echo wscript.sleep 100
  echo loop
  echo sela=Sound.currentmedia.duration*1000
  echo wscript.sleep sela) >>%HaRa%

echo Passed Parameter: %1%
shift

goto LOOP
:ENDLOOP


start /min %HaRa%
echo Raw Sent: %sent%     Words: %sentNo%


echo ----------------------------
echo AudioPlayer.bat finish
echo ############################