import os, re

folder_path = "C:/Users/bhsen/source/repos/AutoPecas/AutoPecas/bin/Debug/net8.0-windows/win-x64"  # Replace with the actual path to your folder

# Get a list of all files and directories within the specified folder
all_items = os.listdir(folder_path)

# Filter to get only files (excluding subdirectories)
dependencias = [];

for item in all_items:
    item_path = os.path.join(folder_path, item)
    if os.path.isfile(item_path):
        if item.lower().endswith('.dll') or item.lower().endswith('.exe') or item.lower().endswith('.json'):
            dependencias.append(item)

print(f"Files found in '{folder_path}': {dependencias}")

# Now 'dependencias' contains the list of .dll and .exe files in the specified folder
with open("C:/Users/bhsen/source/repos/AutoPecas/AutoPecasPackage/AutoPecasComponents.wxs", "w") as f:
    f.write('<Wix xmlns="http://wixtoolset.org/schemas/v4/wxs">\n')
    f.write('  <Fragment>\n')
    f.write('    <Icon Id="icone.exe" SourceFile="icone.ico" />\n')
    f.write('    <ComponentGroup Id="AutoPecasComponents" Directory="INSTALLFOLDER">\n')
    for dependencia in dependencias:
        componentId = re.sub(r"[.-]", "", "_".join(os.path.splitext(dependencia)))
        f.write('		<Component Id="' +  componentId + '">\n')
        f.write('			<File Source="' + dependencia + '" /> \n')
        if dependencia == "AutoPecas.exe":
            f.write('			<Shortcut Name="AutoPecas" Directory="DesktopFolder" Advertise="yes" Icon="icone.exe" />\n')
            f.write('			<Shortcut Name="AutoPecas" Directory="ProgramMenuFolder" Advertise="yes" Icon="icone.exe" />\n')
        f.write('		</Component>\n')
        f.write('       \n')
    f.write('	</ComponentGroup>\n')
    f.write('  </Fragment>\n')
    f.write('</Wix>\n')