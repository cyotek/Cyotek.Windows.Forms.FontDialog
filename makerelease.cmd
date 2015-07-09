@ECHO OFF

SETLOCAL

CALL ..\..\..\build\set35vars.bat

%msbuildexe% Cyotek.Windows.Forms.FontDialog.sln /p:Configuration=Release /verbosity:minimal /nologo /t:Clean,Build
CALL signcmd src\Cyotek.Windows.Forms.FontDialog\bin\Release\Cyotek.Windows.Forms.FontDialog.dll

PUSHD
MD releases
CD releases

NUGET pack ..\src\Cyotek.Windows.Forms.FontDialog\Cyotek.Windows.Forms.FontDialog.csproj -Prop Configuration=Release

%zipexe% -a Cyotek.Windows.Forms.FontDialog.x.x.x.x.zip ..\src\Cyotek.Windows.Forms.FontDialog\bin\Release\Cyotek.Windows.Forms.FontDialog.dll ..\src\Cyotek.Windows.Forms.FontDialog\bin\Release\Cyotek.Windows.Forms.FontDialog.xml -ex

POPD

ENDLOCAL
