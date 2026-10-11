@echo off
setlocal
if not exist "%~dp0Demo\DTET_Prototype.exe" (
    echo The demo files could not be found.
    echo Right-click the ZIP, choose Extract All, and run START_DEMO.cmd from the extracted folder.
    pause
    exit /b 1
)
start "" /D "%~dp0Demo" "%~dp0Demo\DTET_Prototype.exe" -screen-width 1600 -screen-height 900 -screen-fullscreen 0
if errorlevel 1 (
    echo Could not start the demo. Read READ_ME_FIRST.txt for troubleshooting.
    pause
    exit /b 1
)
exit /b 0
