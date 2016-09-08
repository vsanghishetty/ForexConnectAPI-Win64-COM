@ECHO Unregister fxcore2.com library
set tgt_platform=win32
:Parse_Args
    @IF /I "%~1"=="x86"           SET "tgt_platform=win32"         & SHIFT & GOTO Parse_Args
    @IF /I "%~1"=="x64"           SET "tgt_platform=x64"           & SHIFT & GOTO Parse_Args
    @IF   "x%~1"=="x"             GOTO Done_Args
    ECHO Unknown command-line switch: %~1
:Done_Args

REGASM /u bin\%tgt_platform%\fxcore2.com.dll /tlb:bin\%tgt_platform%\fxcore2.com.tlb
