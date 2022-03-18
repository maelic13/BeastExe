# BeastExe
This is a helper project for https://github.com/maelic13/beast

The goal is to compile an exe file, which will serve as translating layer between the python project and chess GUIs which expect UCI chess engines to be in exe format.

Compile yourself and copy the exe file from created "bin" folder to root in your Beast repo location (as instructed in Beast readme).

Or potentionally try using the release exe versions, but no guarantees there.

## Requrements
This project expects .NET Framework v4.8, or you can potentionally try another version of .NET Framework if you change it in project settings, the code is very simple and I would expect it working with other versions as well.

.NET Framework v4.8 download: https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48

Or edit BeastExe.csproj and it's property TargetFrameworkVersion to you preferred version.
