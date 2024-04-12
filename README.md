# Complete Developer Network (CDN) - Freelancer Directory API

CDN is a fictional company that provides a platform for listing freelancers based on their skills and hobbies. This project implements a RESTful API using ASP.NET Core Web API to manage freelancer registrations, updates, and deletions.

## Features

- RESTful API endpoints for registering, updating, deleting, and retrieving user information.
- Utilizes HTTP verbs such as GET, POST, PUT, and DELETE for CRUD operations.
- Stores user data in a relational database using Entity Framework Core.

## Freelancer Model Attributes

- Username: The unique username of the freelancer.
- Email: The email address of the freelancer.
- PhoneNumber: The phone number of the freelancer.
- Skillsets: The skills possessed by the freelancer.
- Hobby: The hobbies or interests of the freelancer.

## Video Demo

Watch a demo of the API in action:

[![Demo Video](http://img.youtube.com/vi/YOUR_VIDEO_ID_HERE/0.jpg)](https://youtu.be/EXBj2fo6aCw?feature=shared)


## Getting Started

1. Clone the repository
2. Navigate to the project directory: `cd CDNwebapi`
3. Install dependencies: `dotnet restore`
4. Configure the database connection in `appsettings.json`.
5. Run the application: `dotnet run`

## API Endpoints

- **GET /api/freelancers**: Retrieve all freelancers.
- **GET /api/freelancers/{id}**: Retrieve a freelancer by ID.
- **POST /api/freelancers**: Register a new freelancer.
- **PUT /api/freelancers/{id}**: Update an existing freelancer.
- **DELETE /api/freelancers/{id}**: Delete a freelancer.

## Technologies Used

- ASP.NET Core Web API
- Entity Framework Core
- C#
- RESTful API principles
- Relational Database (Microsoft SQL Server)
- IDE (Microsoft Visual Studio 2022)


