[Setup]
AppID={{2A53A3FB-EEC0-4852-9B27-2FB1542E288B}
AppName=USB Programmer
AppVersion=1.0.3.0
AppPublisher=eLabtronics
AppPublisherURL=http://elabtronics.com
AppSupportURL=http://corechart.elabtronics.com/corechart/programmer
AppUpdatesURL=http://corechart.elabtronics.com/corechart/programmer
DefaultDirName={pf}\USB Programmer
DefaultGroupName=USB Programmer
DisableProgramGroupPage=yes
LicenseFile=LICENSE.txt
InfoAfterFile=README.txt
OutputBaseFilename=setup
Compression=lzma/Max
SolidCompression=true
ChangesAssociations=true
WizardImageFile=sideimg.bmp
WizardSmallImageFile=smallimg.bmp
ExtraDiskSpaceRequired=1
PrivilegesRequired=poweruser
DisableWelcomePage=false
DisableFinishedPage=false
MinVersion=,5.1.2600
AppCopyright=eLabtronics
AppVerName=1.0.3.0
VersionInfoVersion=1.0.3.0
VersionInfoCompany=eLabtronics
VersionInfoDescription=Programmer
VersionInfoCopyright=(C) eLabtronics
VersionInfoProductName=Programmer
VersionInfoProductVersion=1.0.3.0

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Files]
Source: ..\programmer\bin\Debug\ASM\*.*; DestDir: "{app}\ASM"; 
Source: corechart.ico; DestDir: "{app}"; 
Source: CoreChart.url; DestDir: "{app}"; 
Source: ..\programmer\icon.ico; DestDir: "{app}"; 
Source: LICENSE.txt; DestDir: "{app}"; 
Source: ..\programmer\bin\Release\programmer.exe; DestDir: "{app}"; 
Source: README.txt; DestDir: "{app}"; 
Source: ..\programmer\bin\Debug\USBezChart.exe; DestDir: "{app}"; Flags: ignoreversion; 
Source: giveio.sys; DestDir: {sys}\drivers; Flags: onlyifdoesntexist uninsremovereadonly; 

[Icons]
Name: "{group}\Programmer"; Filename: "{app}\programmer.exe"; IconFilename: "{app}\icon.ico"
Name: "{group}\CoreChart Mobile"; Filename: "{app}\CoreChart.url"; IconFilename: "{app}\corechart.ico"
Name: "{group}\{cm:UninstallProgram,USB Programmer}"; Filename: "{uninstallexe}"

[Registry]
Root: HKCR; Subkey: ".usb"; ValueType: string; ValueName: ""; ValueData: "USBProgrammerFile"; Flags: uninsdeletevalue
Root: HKCR; Subkey: "USBProgrammerFile"; ValueType: string; ValueName: ""; ValueData: "USB Programmer Script"; Flags: uninsdeletekey
Root: HKCR; Subkey: "USBProgrammerFile\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\programmer.exe,0"
Root: HKCR; Subkey: "USBProgrammerFile\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\programmer.exe"" ""%1"""
