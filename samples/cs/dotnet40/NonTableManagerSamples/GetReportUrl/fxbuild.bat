@echo off

IF /i "%1" == "debug" (
    set config=Debug
) ELSE (
    set config=Release
)
@set platf_env=x64

call "%VS100COMNTOOLS%vsvars32.bat"
msbuild GetReport.csproj /p:Configuration=%config% /p:platform=x64
