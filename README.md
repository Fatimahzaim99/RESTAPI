# Complete Developer Network (CDN) - Freelancer Directory API

CDN is a fictional company that provides a platform for listing freelancers based on their skills and hobbies. This project implements a RESTful API using ASP.NET Core Web API to manage user registrations, updates, and deletions.

## Features

- RESTful API endpoints for registering, updating, deleting, and retrieving user information.
- Utilizes HTTP verbs such as GET, POST, PUT, and DELETE for CRUD operations.
- Stores user data in a relational database using Entity Framework Core.

## User Model Attributes

- Username: The unique username of the user.
- Email: The email address of the user.
- PhoneNumber: The phone number of the user.
- Skillsets: The skills possessed by the user.
- Hobby: The hobbies or interests of the user.

## Video Demo

Watch a demo of the API in action:

[![Demo Video](http://img.youtube.com/vi/YOUR_VIDEO_ID_HERE/0.jpg)](http://www.youtube.com/watch?v=YOUR_VIDEO_ID_HERE)


## Getting Started

1. Clone the repository: `git clone https://github.com/your/repository.git`
2. Navigate to the project directory: `cd CDN-Freelancer-Directory-API`
3. Install dependencies: `dotnet restore`
4. Configure the database connection in `appsettings.json`.
5. Run the application: `dotnet run`

## API Endpoints

- **GET /api/users**: Retrieve all users.
- **GET /api/users/{id}**: Retrieve a user by ID.
- **POST /api/users**: Register a new user.
- **PUT /api/users/{id}**: Update an existing user.
- **DELETE /api/users/{id}**: Delete a user.

## Technologies Used

- ASP.NET Core Web API
- Entity Framework Core
- C#
- RESTful API principles
- Relational Database (Microsoft SQL Server)


