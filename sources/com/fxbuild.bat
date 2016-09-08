@echo off

setlocal

rem Set default options
set localconfig=Release
set build_action=Build
set tgt_platform=win32

rem --------------------------------------------------------------------------------------------
rem Parse command line argument values.
rem Note: For ambiguous arguments the last one wins (ex: debug release)
rem --------------------------------------------------------------------------------------------
:Parse_Args
    @IF /I "%~1"=="Debug"         SET "localconfig=Debug"          & SHIFT & GOTO Parse_Args
    @IF /I "%~1"=="Release"       SET "localconfig=Release"        & SHIFT & GOTO Parse_Args
    @IF /I "%~1"=="Build"         SET "build_action=Build"         & SHIFT & GOTO Parse_Args
    @IF /I "%~1"=="Rebuild"       SET "build_action=Rebuild"       & SHIFT & GOTO Parse_Args
    @IF /I "%~1"=="x86"           SET "tgt_platform=win32"         & SHIFT & GOTO Parse_Args
    @IF /I "%~1"=="x64"           SET "tgt_platform=x64"           & SHIFT & GOTO Parse_Args
    @IF   "x%~1"=="x"             GOTO Done_Args
    ECHO Unknown command-line switch: %~1
:Done_Args

call "%VS80COMNTOOLS%vsvars32.bat"
call generate_key.bat
call msbuild fxcore2.com.sln /p:Configuration=%localconfig% /p:platform=%tgt_platform% /t:%build_action%
