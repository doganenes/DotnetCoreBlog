## DotnetCoreBlog - Overview
This repository contains a multi-layered ASP.NET Core blog application with API and web UI components. The solution follows a modular architecture with separation of concerns across different projects.

## Solution Structure

### CoreBlog.API
The main API project for the blog application.

### CoreBlog.BusinessLayer
Business logic layer containing service implementations and validation rules.

### CoreBlog.CoreLayer
Core abstractions and cross-cutting concerns.

### CoreBlog.DataAccessLayer
Data access implementations with Entity Framework.

### CoreBlog.EntityLayer
Domain entities and models.

### CoreBlog.JwtAPI
JWT authentication API project.

### CoreBlog.UI
ASP.NET Core MVC web application.

## Development Setup

1. **Clone the repository**
   ```bash
   git clone https://github.com/doganenes/DotnetCoreBlog
   cd DotnetCoreBlog
   ```

2. **Restore NuGet packages**
   ```bash
   dotnet restore
   ```

3. **Update connection strings**
   - Configure database connection strings in `appsettings.json` files
   - Update JWT settings in authentication projects

4. **Run database migrations**
   ```bash
   dotnet ef database update
   ```

5. **Build and run**
   ```bash
   # For API
   dotnet run --project CoreBlog.API
   
   # For Web UI
   dotnet run --project CoreBlog.UI
   
   # For JWT API
   dotnet run --project CoreBlog.JwtAPI
   ```

## Architecture Overview

The project follows a **layered architecture** pattern:

- **Presentation Layer**: `CoreBlog.UI` and `CoreBlog.API`
- **Business Layer**: `CoreBlog.BusinessLayer`
- **Data Access Layer**: `CoreBlog.DataAccessLayer`
- **Entity Layer**: `CoreBlog.EntityLayer`
- **Core Layer**: `CoreBlog.CoreLayer`
- **Authentication**: `CoreBlog.JwtAPI`

## Key Features

- Multi-layered architecture
- JWT authentication support
- Entity Framework Core data access
- ASP.NET Core Web API
- MVC web interface
- Separation of concerns
- Repository pattern implementation
- Business logic validation

## Technology Stack

- **.NET Core 6.0+**
- **Entity Framework Core** - ORM for data access
- **JWT Bearer Authentication** - Token-based authentication
- **ASP.NET Core MVC** - Web application framework
- **ASP.NET Core Web API** - RESTful API services

## Project Dependencies

Each layer has specific responsibilities and dependencies:

| Project                | Purpose                    |
|------------------------|----------------------------|
| CoreBlog.UI            | Web interface              |
| CoreBlog.API           | REST API endpoints         |
| CoreBlog.JwtAPI        | Authentication services    |
| CoreBlog.BusinessLayer | Business rules             |
| CoreBlog.DataAccessLayer | Data operations          |
| CoreBlog.EntityLayer   | Domain models              |
| CoreBlog.CoreLayer     | Cross-cutting concerns     |

## Getting Started

1. Ensure you have .NET 8.0 or later installed
2. Set up your database connection string
3. Run migrations to create the database schema
4. Start with either the API or UI project based on your needs
5. Use the JWT API for authentication token generation
