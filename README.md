# IT-3045C Final Project for Team 4
Team 4 is:
 - William Boulle
 - Robert Mays
 - Grant Willis

## Usage
  This program allows CRUD (Create, Read, Update, and Deletion) operations on four tables:
  1. Game
  2. Hobby
  3. Language
  4. TeamMember


## Requirements and pre-requisites

### Requirements
`.NET 10.0`
`EntityFrameworkCore 10.0`

### Pre-requistes

While in the project folder, enter the following in terminal:

`dotnet add Team4FinalProject.csproj package Microsoft.EntityFrameworkCore --version 10.0.5`
  This will install the Microsoft Entity Framework Core for interfacing with the database files.

`dotnet add Team4FinalProject.csproj package Microsoft.AspNetCore.OpenApi --version 10.0.3`
  This will install the package that allows OpenAPI support

`dotnet add Team4FinalProject.csproj package NSwag.AspNetCore --version 14.7.0`
  This will install the Swagger package to generate documentation about the OpenAPI

`dotnet add Team4FinalProject.csproj package Microsoft.AspNetCore.Mvc.ViewFeatures --version 2.3.9`
  This will install the MVC ViewFeatures for displaying web pages
  
Alternatively, you can run `setup.bat` which will run all the commands listed above with a 5 second pause in between each command

## Operation
