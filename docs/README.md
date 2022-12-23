# Assignment implemented with the Clean architecture template
<br />
### Reference

* [Clean Architecture by Robert C. Martin (Uncle Bob)](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html)

## About The Project

This project provides complete solution which is built on Clean Architecture with all essentia,  feature CI/CD, best practice, testing Strategy using .NET Core.

![image](img/clean-architecture.png)

The solution for the assignment is created using the following architecture:

![image](img/customerdata-architecture.png)

## Instructions

Open the solution in Visual Studio 2022. Set multiple running projects and select CustomerData.Transaction.Api and CustomerData.Account.Api.
Run multiple projects.
The swagger documentation api will open in the browser.
Inspect the database to find the userId, use the UserId to call the api to create the account or other apis.

The projects also contain the Docker files and deployment.yaml files. These files can be used to build the docker images and deploy them to minikube.
However, there is an error yet that has to be solved:

 ---> System.DllNotFoundException: Unable to load shared library 'e_sqlite3' or one of its dependencies. In order to help diagnose loading problems, consider setting the LD_DEBUG environment variable: libe_sqlite3: cannot open shared object file: No such file or directory
   at SQLitePCL.SQLite3Provider_e_sqlite3.NativeMethods.sqlite3_libversion_number()

This error is a dependency that cannot be found in the docker image. 

## Technology stack

Architecture Pattern

- [x] Clean architecture
- [x] (Includes)
    - [x] Screaming architecture-[Functional organisation design](http://blog.cleancoder.com/uncle-bob/2011/09/30/Screaming-Architecture.html)
    - [x] Onion archhitecture

Design Pattern
- [x] CQRS design pattern
- [ ] Decorator design pattern
- [x] Mediator design pattern
- [x] Repository design pattern
- [x] Unit of work 
- [x] Factory design pattern
 
Backend
- [x] Language: C#
- [x] Framework: dotnet core 6, ASP.NET Core

UI
- [ ] Blazor, Asp.NetCore Mvc

Database
- [x] SQLLite
- [x] DB Connectivity : Entityframework Core - Code First

Cloud server
- [x] MiniKube deployment files
- [x] Docker files

Service
- [x] Web API (Restful service)

Feature
- [x] Dataseeding
- [x] Custom Exceptionn Handler
- [x] Automapper
- [x] Fluent validation
- [x] Serilog
- [x] Swagger UI
- [x] API Versioning
- [x] Mailkit (Mail service)


Testing
- [x] Unit testing (Nunit)


CI/CD
- [ ] Docker images 

## Licence Used

[![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/Amitpnk/Clean-architecture-ASP.NET-Core/blob/develop/LICENSE)

See the contents of the LICENSE file for details

