# AudioCAD1
Audio Combined All Directories
November-December 2020

Easily construct sentences with over one hunded words to choose from.

Important files to be preserved along with application:
1. about.txt - how else would you be able to read this if this does not exist with the exe...
2. The audio folder, The MaxxSteele audio should be present/default
3. AudioPlayer.bat This is a 2 in 1 script. Generates a VBS script either during application run or for export purposes.
	Independent run as: AudioPlayer.bat <Audio File location> [0-1] <Audio1, Audio2, ...)
					[0/1 controls the VBS audio script location, Always use 0 if running in independent]
4. DeSpacer.bat - if audio has spaces, run this to remove spaces and put in _
	Independent run as: Despacer.bat <DIRECTORY>
The application won't hard error out if any of these are missing, in fact it will create the folder directories if they are missing. Mileage may vary if any of these elements are missing.


-----------------------------------
settings.conf

data\audio\MaxxSteele	<-----This is the audio location
E	<---------------------This word does not exist in the audio definition
*	<---------------------This word exists in the audio definition

-----------------------------------


History of the audio files: 
Recorded in Fall 2014 and was used in a windows 8 metro application. The app was a screen that had over 100 buttons on it. Did not really like it, you would spend more time looking for words (if they existed)
Transition to now, this app uses text based search to bring words up and export them for independent use of application.
