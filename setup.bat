@ECHO ON
dotnet add Team4FinalProject.csproj package Microsoft.EntityFrameworkCore --version 10.0.5
ECHO "Waiting 5 seconds"
timeout /T 5

dotnet add Team4FinalProject.csproj package Microsoft.AspNetCore.OpenApi --version 10.0.3
ECHO "Waiting 5 seconds"
timeout /T 5

dotnet add Team4FinalProject.csproj package NSwag.AspNetCore --version 14.7.0
ECHO "Waiting 5 seconds"
timeout /T 5

dotnet add Team4FinalProject.csproj package Microsoft.AspNetCore.Mvc.ViewFeatures --version 2.3.9
ECHO "Packages installed.  Review above for any errors."
pause