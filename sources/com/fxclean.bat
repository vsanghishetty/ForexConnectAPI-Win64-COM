if exist bin del bin\*.* /s /q > nul
if exist bin rmdir bin /s /q > nul
if exist obj del obj\*.* /s /q > nul
if exist obj rmdir obj /s /q > nul
del fxbuild.err /q > nul
