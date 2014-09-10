echo installiing solution wide nuget packages
.nuget\NuGet.exe install .nuget\packages.config -o packages

echo build solution
%WINDIR%\Microsoft.NET\Framework\v4.0.30319\MSBuild ManipulateCommits.sln

echo run unit tests
packages\NUnit.Runners.2.6.3\tools\nunit-console "ManipulateCommits.Tests/bin/Debug/ManipulateCommits.Tests.dll" /labels
