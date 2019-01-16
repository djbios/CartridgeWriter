cd .\CartridgeWriterForms
call "C:\Program Files (x86)\MSBuild\14.0\Bin\MSBuild.exe" /p:Configuration=Release
copy .\bin\Release\CartridgeWriterForms.exe ..\bin\CartridgeWriterForms.exe