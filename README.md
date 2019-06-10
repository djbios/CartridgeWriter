Cartridge Writer (Multiplatform version)
================

# Quickstart guide:


## Windows:


Just run exe file, latest release located in bin/CartridgeWriterForms.exe
Link: https://github.com/djbios/CartridgeWriter/blob/master/bin/CartridgeWriterForms.exe
## Linux:


Compiled bundle located in bin/CartridgeWriter You should give it permission to run and use sudo (because of access rights to tty port)
One line run script (just run it in console):
`wget https://github.com/djbios/CartridgeWriter/blob/master/bin/CartridgeWriter -O ./CW && chmod +x ./CW && sudo ./CW`
## Mac:

1. Install mono framework https://www.mono-project.com/download/stable/
2. Download exe file https://github.com/djbios/CartridgeWriter/blob/master/bin/CartridgeWriterForms.exe
3. Run `sudo mono --arch=32 ./CartridgeWriterForms.exe` in terminal

# How to use
Connect device by USB cable to PC.
If driver not installed automaticly install it.
Start CartridgeWriterForms.exe
Insert chip to reader.
Choice a serial port (COM* in Device list) and your printer type in Printer type.
Press Read button.
Fields should be filled automaticlly after that.
At left column you'll get actual values on chip at right will be updated values for 100% refill.
If you want to refill chip without changes, just press Write button.
Remove chip from reader.
 __________________________
| Printer model	 - type    |
|--------------------------|
| FDM Titan	 - fox	   |
| FDM Maxum	 - quantum |
| Quantum	 - quantum |
| Dimension (all)- prodigy |
| Fortus 250mc	 - prodigy |
 --------------------------
