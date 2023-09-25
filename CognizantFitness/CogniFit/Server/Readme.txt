 
 
 *                               DATABASE SETUP                                     *

To change the database: open appsettings.json in the CogniFit.Server project,
You'll see : 
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=aspnet-CogniFit.Server-2880d470-61ad-4b7d-a877-0c08237cc007;Trusted_Connection=True;MultipleActiveResultSets=true"
  },


You'll want to change this to : 
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=CogniFitDB;Trusted_Connection=True;"
  },


Package Manager Console
  dir
  cd .\CogniFit
  dir
  cd .\Server
  dotnet ef database update

  If you run into an error, either SQL is signed in or the application is running
  (close Windows console prompt if open)

  If the above commands were successful and you see a bunch of SQL commands execute in 
  Package Manager Console, and the last line says 'Done.'

  You should be able to log into SQL Server Management Studio (SSMS) and refresh your server,
  you'll see CogniFitDB listed in your DB.

 *                               DATABASE SETUP END                                    *





*                               Project Structure                                       *
 1. Client:
Purpose: This is where the Blazor WebAssembly code lives. It runs in the user's browser. The compiled code is delivered to the browser as WebAssembly, along with the .NET runtime required to execute it.
Contents:
Components, pages, and other UI-related logic.
Services that communicate with the backend API or other external services.
Any other logic that needs to be executed on the client side.
Execution: Runs directly in the browser using WebAssembly.

2. Server:
Purpose: This is a typical ASP.NET Core application that serves as the backend. It can serve the Blazor app, provide APIs for the Blazor app to communicate with, and handle things like authentication, data storage, or other server-side operations.
Contents:
Controllers and API endpoints.
Server-side configurations like middleware, services, etc.
Database context and Entity Framework logic (if you're using EF).
Server-side authentication and authorization logic.
Execution: Runs on a server (or cloud) and listens for incoming HTTP requests.

Shared:
Purpose: As the name implies, this project is meant to house code that is shared between both the Client and Server projects. By placing common code here, you can avoid duplication and ensure consistency between client and server.
Contents:
Data models or entities that both the client and server need to be aware of.
Constants or utility functions used by both client and server.
DTOs (Data Transfer Objects) used for communication between client and server.
Execution: Doesn't execute on its own. It's a library of shared resources that the other two projects reference.
*                               Project Structure End                                      *





*                               Login/ Registration                                         *
Still a work in progress, anything you create should reflect in SSMS, under the table dbo.AspNetUsers
currently email confirmation isn't setup so when you login with the registered user you will be met
with an ERROR. So go to that table, dbo.AspNetUsers, right-click and edit top 200 rows,
make the EmailConfirmation field 'True', Now you can login.


*                               Login/ Registration End                                         *