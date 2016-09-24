
@set msbuild="%ProgramFiles(x86)%\msbuild\14.0\Bin\MSBuild.exe"
@if not exist %msbuild% @set msbuild="%ProgramFiles%\MSBuild\14.0\Bin\MSBuild.exe"
@if not exist %msbuild% @set msbuild="%ProgramFiles(x86)%\MSBuild\12.0\Bin\MSBuild.exe"
@if not exist %msbuild% @set msbuild="%ProgramFiles%\MSBuild\12.0\Bin\MSBuild.exe"

@REM %msbuild% /m /nr:false /p:Platform="Any CPU" /v:M /p:COnfiguration=Debug NVNC.sln
%msbuild% /m /nr:false /p:Platform="x64" /v:M /p:COnfiguration=Debug NVNC.sln
%msbuild% /m /nr:false /p:Platform="x64" /v:M /p:COnfiguration=Debug "NVNC Example\NVNC Example.csproj"

@PAUSE 
@PAUSE