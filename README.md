# Portfolio

This is my personal portfolio website. 

It's a Blazor Server app, with a frontend written in Blazor that communicates to the .NET Core backend using SignalR.
The backend is supported by EF Core, which sits atop of a Postgres database.
This application is also dockerized.

I'm planning to develop a back office for this application for editing my CV.

# FAQ

* Is it over-engineered? - Oh yes. 
* Does it double as a portfolio in and of itself? - Also yes.

# New developer

Getting started on this project is easy.

## Required tools

* Visual Studio 2019 (VS2019)
* Docker

## Getting started

1. Clone this git repo
2. Open Portfolio.sln in VS2019
3. In Solution Explorer, right-click the `docker-compose` project and select `Set as Startup Project`
4. Start application, either by clicking the green arrow or pressing `F5`
