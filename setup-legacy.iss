; Script created by SparrOSDeveloperTeam
; https://github.com/SparrOSDeveloperTeam

; Setup program compiled in Inno Setup Compiler 5.5.9(a)

[Setup]
AppCopyright=Copyright © 2018-2019 SparrDrem
AppName=UPTIME (Beta)
AppPublisher=SparrDrem
AppPublisherURL=https://sparrdrem.github.io/
AppSupportURL=https://sparrdrem.github.io/gencode/support
AppUpdatesURL=https://sparrdrem.github.io/gencode/releases
AppVerName=UPTIME v1.0.284 (Beta)
AppVersion=Version 1.0.284 (Beta)
DefaultDirName={pf}\SparrDrem\UPTIME
DefaultGroupName=UPTIME
DisableWelcomePage=No
DisableStartupPrompt=No
LicenseFile=docfiles\license.rtf
MinVersion=4.0
OnlyBelowVersion=6.1
SetupIconFile=icofiles\setup.ico
UninstallIconFile=program\unins000.ico
WizardImageFile=bmpfiles\wizardimagefile.bmp
WizardSmallImageFile=bmpfiles\smallwizardimage.bmp
InfoBeforeFile=docfiles\recommends.txt

[Languages]
Name: en; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: desktopicon; Description: "Create a &desktop icon"
Name: quicklaunchicon; Description: "Create a &Quick Launch Icon"; Flags: unchecked

[Files]
Source: "program\legacy\uptime.exe"; DestDir: "{app}"
Source: "program\legacy\uptime.exe.config"; DestDir: "{app}"
Source: "program\legacy\uptime.pdb"; DestDir: "{app}"
Source: "program\legacy\uptime.xml"; DestDir: "{app}"
Source: "program\legacy\link.url"; DestDir: "{app}"
Source: "program\legacy\mit.txt"; DestDir: "{app}"
Source: "program\legacy\postinst-web.bat"; DestDir: "{app}"
Source: "program\legacy\unins000.ico"; DestDir: "{app}"

[Icons]
Name: "{commondesktop}\UPTIME"; Filename: "{app}\UPTIME.exe"; IconFilename: "{app}\UPTIME.exe"; Tasks: desktopicon
Name: "{group}\UPTIME"; Filename: "{app}\Gencode.exe"; IconFilename: "{app}\UPTIME.exe"
Name: "{group}\Visit UPTIME Official Site"; Filename: "{app}\link.url"
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\UPTIME"; Filename: "{app}\UPTIME.exe"; IconFilename: "{app}\UPTIME.exe"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\postinst-web.bat"; Description: "&Visit UPTIME Official Site"; Flags: postinstall nowait skipifsilent
Filename: "{app}\Gencode.exe"; Description: "Run &UPTIME"; Flags: postinstall nowait skipifsilent