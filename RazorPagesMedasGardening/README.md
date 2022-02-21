# Monica_eda_WEB315Assignments
 
created a new repository in git hub and named as Monica_eda_WEB315Assignments
dotnet new webapp -o RazorPagesMedasGardening
dotnet dev-certs https --trust
A folder named Models is opened underr pages
A class file named Garden.cs is added to the Models folder
NuGet packages and EF tools are added using the commands
dotnet tool install --global dotnet-ef --version 5.*
dotnet tool install --global dotnet-aspnet-codegenerator --version 5.*
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.*
dotnet add package Microsoft.EntityFrameworkCore.SQLite --version 5.*
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.*
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.*
Garden model is scaffolded using the following caommand
dotnet-aspnet-codegenerator razorpage -m Garden -dc RazorPagesGardenContext -udl -outDir Pages/Gardens --referenceScriptLibraries -sqlite
migration feature
dotnet ef migrations add InitialCreate
dotnet ef database update
A new class named SeedData is created in the Models folder and coded
seed initializer is added by replacing the contents of the program.cs with required coding

