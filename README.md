## Overview

This project integrates Velopack with Inno Setup and Revit add-ins, supporting versions 2023 and 2024 of Revit. The setup includes the following components and relationships:

### Class Libraries

1. **Revit2023 and Revit2024 Class Libraries**: 
   - Two separate class libraries for Revit 2023 and Revit 2024.
   - Each library contains code specific to the corresponding Revit version.

2. **Inno Class Library**:
   - Contains the setup logic for creating the installer using Inno Setup.
   - Handles the generation of the .exe installer file.

3. **Velopack Class Library**:
   - Contains the code related to Velopack.
   - This code is called from the External Application and External Command in Revit.
   - The External Application initializes Velopack.
   - The External Command executes the updater.

### Relationships

- **Inno Setup**:
  - Compiles the files and generates the .exe installer.
- **Velopack**:
  - Creates a package from the .exe file generated by Inno.

### Issues
- Issue when Update manager is called from External Application.
  
### Update Functionality

- The update works when the .exe file is called directly.

