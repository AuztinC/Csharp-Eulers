# Csharp-Eulers
From the solution root, run: 
`dotnet test`

Useful variants:

Run via solution explicitly
dotnet test Euler.sln

Run only the test project
dotnet test Euler.Tests.csproj

Run one test by name
dotnet test --filter "FullyQualifiedName~Problem001"

Show detailed output
dotnet test -v normal

Auto Runner!
From the solution root, run:
dotnet watch test