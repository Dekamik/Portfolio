# Portfolio

This is my personal portfolio website. 

It's a Blazor Server app, with a frontend written in Blazor that communicates to the .NET Core backend using SignalR.
The backend is supported by EF Core, which sits atop of a Postgres database.
This application is also dockerized.

I'm planning to develop a back office for this application for editing my CV.

Is it over-engineered? - Oh yes. 
Does it double as a portfolio in and of itself? - Also yes.

# Docker image

This project gets pulled on Docker Hub and then built into a docker image.

## Environment variables

When `ASPNETCORE_ENVIRONMENT` is set to `Production`, the application will accept database connection data as environment variables.

These variables are exposed to the docker administrator:

* `DB_SERVER`: Hostname of database server
* `DB_PORT`: Port used to connect to database (default: 5432)
* `DB_NAME`: Name of database to connect to
* `DB_USER`: Name of database user to connect with
* `DB_PASS`: Database user password
* `DB_SSLMODE`: SSL mode to use (default: Require)
* `DB_TRUST_SERVER_CERTIFICATE`: Whether or not to trust the database servers certificate (default: false)

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

When the application runs, it will run pending migrations on startup. The migrations creates the database structure and seeds the database with some data. 
You don't need to run Update-Database at all, since the application runs it on startup.
