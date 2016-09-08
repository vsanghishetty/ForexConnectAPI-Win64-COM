ForexConnect API 
COM wrapper Building Guide (for Windows OS only)


1 Prerequisites

The section contains information about the environment you must have to correctly perform the COM wrapper building on Windows OS.
The following prerequisites must be satisfied:
1. The building can be performed either on Win32 or Win64 OS;
2. The building can only be performed on a system where the required software is installed (see 1.1);
3. The required system variables must be defined (see 1.2).

1.1 Required Software

The following software must be installed on the system where the COM wrapper is to be built:
- ForexConnect API version 1.3.0 or later. You can install it from http://fxcodebase.com/wiki/index.php/Download
- .NET Framework 2.0 or .NET Framework 4.0. You can install it from: http://www.microsoft.com/downloads/en/details.aspx?FamilyID=9CFB2D51-5FF4-4491-B0E5-B386F32C0992
- Visual Studio 2005 Standard/Professional Edition or Visual Studio 2010 Standard/Professional Edition
Note: You can use the Visual Studio snapshot instead of Visual Studio 2005 Standard/Professional Edition
Note: You can use Windows SDK 7.1 instead of Visual Studio 2010 Standard/Professional Edition. You can install it from: http://www.microsoft.com/downloads/en/details.aspx?FamilyID=6B6C21D2-2006-4AFA-9702-529FA782D63B

1.2 Environment Variables

The script for building the ForexConnect API COM wrapper uses the VS80COMNTOOLS and VS100ENV_SETUP environment variables. Therefore these environment variables must be defined.

1.3 Configuring Environment when Using Snapshot

By default, the build script is configured for the default Visual Studio 2005 SP1 installation. 
If you use another installation (a snapshot), the system variable VS80COMNTOOLS must be added.
For example: 
You have a snapshot in c:\vc2005sp1_ss\ with setup.bat which sets Visual Studio 2005 environment variables:
1. Rename the file c:\vc2005sp1_ss\setup.bat to c:\vc2005sp1_ss\vsvars32.bat;
2. Add the system variable VS80COMNTOOLS. Its value must equal to c:\vc2005sp1_ss (the path to the vsvars32.bat file).
For instructions on how to add a system variable, see Appendix 1.

2 Building Procedure

From the command prompt, run the fxbuild.bat file located in the following path: Candleworks\ForexConnectAPI\sources\com
The following parameter of the build script must be specified: Target platform (x86 or x64).
Note that attempting to use the Win32 version of the API for a 64-bit application, and vise versa, will result in a runtime error.
To build the 32-bit version of the ForexConnect API COM wrapper, execute the command:
fxbuild.bat x86
To build the 64-bit version of the ForexConnect API COM wrapper, execute the command:
fxbuild.bat x64
Note: The file generate_key.bat is used to generate key for signing an assembly with a strong name.

3 Results of Building

As a result of the building procedure, the bin\{platform} folder is created (where {platform} is Win32 or x64) in the folder on your local hard drive where the source files are located. The folder contains the following files:
1. The library fxcore2.com.dll;
2. Type library file fxcore2.com.tlb;
3. Required ForexConnectAPI libraries.
For instructions on how to check if the COM wrapper has been built correctly, see Appendix 2.

4 Appendices

Appendix 1. Adding System Variables for Windows

To add a system variable:
1. On your desktop, right-click My Computer icon. In the context menu click Properties. The System Properties dialog box will appear;
2. In the dialog box, choose the Advanced tab and then click the Environment Variables button. The Environment Variables dialog box will appear;
3. In the Environment Variables dialog box, click New in the System variables section. The New User Variable dialog box will appear;
4. Specify the variable name and value, and click OK.

Appendix 2. How to Check that ForexConnect API COM wrapper is Built Correctly

To check that the ForexConnect API COM wrapper for Windows OS has been built correctly, do the following:
1. Check if the COM wrapper is registered on your computer. If it is registered, unregister it. For this purpose run unregisterCom.bat from the folder with the ForexConnect API COM wrapper. By default the path is:
%ProgramFiles%\Candleworks\ForexConnectAPI\bin-com
2. Register the new version of the fxcore2.com library received as the result of building (see 3) for using via COM. For this purpose run registerCom.bat from the following path: Candleworks\ForexConnectAPI\sources\com. The following parameter must be specified: Target platform (x86 or x64);
3. Go to the samples located in the folder with the ForexConnect API. By default the path is:
%ProgramFiles%\Candleworks\ForexConnectAPI\samples\com
4. Check that any of the VBS samples works correctly:
4.1. Start Command Prompt;
4.2. Go to the folder samples\com\VBS;
4.3. Run the login.vbs file with parameters: login, password.
The sample should be started. You should be successfully logged in and logged out.
