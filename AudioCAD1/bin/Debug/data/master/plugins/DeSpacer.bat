@echo off

REM start date: 11-24-20
REM this will remove spaces from only files
REM idea to add this to the windows form as a custom button option
echo ############################
echo despacer.bat start
echo ----------------------------
echo Script directory: %~dp0
echo Passed Parameter: %1%
echo Audio directory%CD%
echo ----------------------------
echo ----------------------------
setlocal enabledelayedexpansion
for %%a in (* *) do (
  set file=%%a
  if not "!file!"=="!file: =!" ECHO Removed space from file: !file!
  ren "!file!" "!file: =_!"
  )
echo ----------------------------
echo despacer.bat finish
echo ############################