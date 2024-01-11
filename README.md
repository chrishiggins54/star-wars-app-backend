-Star Wars Character Explorer

-Introduction
Welcome to the Star Wars Character Explorer, a web application that connects to the Star Wars API (SWAPI). This project represents my initial exploration of .NET Core and Vue.js, combining these technologies to create an engaging user experience.

-Project Overview
Developed as part of a technical assessment for a .NET Developer role, this application demonstrates capabilities in .NET Core, C#, Vue.js, and API integration.

-Features
List of Characters: Displays characters from the Star Wars universe.
Character Search: Users can search for characters by name.
Character Details: Detailed information about selected characters is shown.
Technology Stack
Backend: .NET 6 (or newer) Web API
Frontend: Vue.js
API: SWAPI - https://swapi.dev/
Additional Tools: Swagger for API testing
Getting Started
These steps will guide you through setting up the project for development and testing on your local machine.

-Prerequisites
.NET 5 SDK or later
Node.js and npm
Vue CLI
Git

Setting up the Project

Clone the Repository:

--git clone https://github.com/chrishiggins54/star-wars-app-backend
Backend Setup:

Navigate to the backend project directory.
Restore the .NET packages:

--dotnet restore

Start the backend API using:


--dotnet run
The backend will be running on http://localhost:5287 (adjust as needed).

-Frontend Setup:

Navigate to the frontend project directory.

-Install npm packages:

--npm install

Start the Vue.js development server:

--npm run serve

Access the frontend at http://localhost:8080.

-Environment Configuration

Configure the .env file in the frontend project to point to the correct backend URL.
The .env file should contain VUE_APP_API_URL=http://localhost:5287 (replace the URL/port as necessary).
This file allows easy management of environment-specific variables.

-API Testing with Swagger
Swagger is integrated for backend API testing.
Access Swagger UI at https://localhost:44395/swagger.


-Author
Chris Higgins
