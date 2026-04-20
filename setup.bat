@ECHO ON
REM "Adding EntityFrameworkCore 10.0.5"
dotnet add Team4FinalProject.csproj package Microsoft.EntityFrameworkCore --version 10.0.5
REM "Waiting 5 seconds"
timeout /T 5

REM "Adding OpenAPI package 10.0.3"
dotnet add Team4FinalProject.csproj package Microsoft.AspNetCore.OpenApi --version 10.0.3
REM "Waiting 5 seconds"
timeout /T 5

REM "Adding NSwag 14.7.0"
dotnet add Team4FinalProject.csproj package NSwag.AspNetCore --version 14.7.0
REM "Waiting 5 seconds"
timeout /T 5

REM "Using Entity Framework to migrate an initial database"
dotnet ef migrations add Initial
REM "Waiting 5 seconds"
timeout /T 5
REM "Using Entity Frameowrk to update the database
dotnet ef database update

REM "Waiting 5 seconds"
timeout /T 5

REM "Packages installed.  Review above for any errors."
pause