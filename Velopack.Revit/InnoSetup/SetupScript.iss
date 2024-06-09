[Setup]
AppId= 2C4F1F11-6522-4F7D-A1D8-5744AA4392B6
AppName=Velopack
AppVersion=1.0.0
AppVerName=Velopack
OutputBaseFilename=Velopack
OutputDir=output
Compression=lzma
SolidCompression=yes
WizardStyle=modern
DefaultDirName={autopf}\Velopack

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Files] 

; 2024 Files
Source: "..\Velopack.Revit.2024\bin\Release\*"; DestDir: "{userappdata}\Autodesk\Revit\Addins\2024"; Flags: recursesubdirs createallsubdirs
Source: "..\Velopack.Revit.2024\Velopack.Revit.2024.addin"; DestDir: "{userappdata}\Autodesk\Revit\Addins\2024"; Flags: ignoreversion

; 2023 Files
Source: "..\Velopack.Revit.2023\bin\Release\*"; DestDir: "{userappdata}\Autodesk\Revit\Addins\2023"; Flags: recursesubdirs createallsubdirs
Source: "..\Velopack.Revit.2023\Velopack.Revit.2023.addin"; DestDir: "{userappdata}\Autodesk\Revit\Addins\2023"; Flags: ignoreversion
