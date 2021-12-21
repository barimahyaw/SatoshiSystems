## Techniques used
- Docker
- .NET 5
- Microservices
- ASP.NET Core
- Entity Framework Core
- C#

## How to get started
1. Install the latest [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
2. Install the latest DOTNET & EF CLI Tools by using this command `dotnet tool install --global dotnet-ef` 
3. Install the latest version of Visual Studio IDE 2019 (v16.8 and above) 🚀
5. Create a folder for your solution and cd into it (the template will use it as project name)
6. Clone the source code to your desktop and open the solution in your installed visual studio
7. The Solution contains 3 microservices (Authentication, Command and Query services) and Web app as the client application, select multiple startup projects to enable you set all these as start up. The Authentication microservice is not implemented, hence was created for the purpose of presentation; Command service handles only database commands like add, update, delete whiles the Query as the name suggest handles all queries to the database which is according to CQRS pattern. 
