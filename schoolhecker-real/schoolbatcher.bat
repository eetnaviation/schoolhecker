@echo off
set origdirectory=%cd%
:start
title schoolbatcher v1.0 by slimegamer - LOGIN
cls
goto start

:main
cls
title schoolbatcher v1.0 by slimegamer - MAIN
echo.
echo 1. GameOfBatch
echo 2. Minecraft (TL LEGACY)
echo 3. Baldi's basics in education and learning
echo 4. Baldi's basics challenge DEMO
echo 5. Peter's house (HORROR)
echo 6. Squidward's Shadow (HORROR)
echo 7. The Touch (HORROR)
set /p cho="> "
if %cho%==1 goto GameOfBatch
if %cho%==2 goto TL
if %cho%==3 goto baldiEduLearn
if %cho%==4 goto baldiDemo
if %cho%==5 goto peter
if %cho%==6 goto squid
if %cho%==7 goto touch
goto main

:GameOfBatch
cd %cd%\game\GameOfBatch
start GameOfBatch
cd %origdirectory%
goto main

:TL
cd %cd%\game\tlegacy
start TL.exe
cd %origdirectory%
goto main

:baldiEduLearn
cd %cd%\game\baldiedu
start BALDI.exe
cd %origdirectory%
goto main

:baldiDemo
cd %cd%\game\baldidemo
start BALDIDEMO.exe
cd %origdirectory%
goto main

:peter
cd %cd%\game\peter
start peter.exe
cd %origdirectory%
goto main

:squid
cd %cd%\game\squid
start squid.exe
cd %origdirectory%
goto main

:touch
cd %cd%\game\touch
start TheTouch.exe
cd %origdirectory%
goto main