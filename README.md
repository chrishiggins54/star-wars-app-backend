
# Star Wars Character Explorer

## Introduction
Welcome to the Star Wars Character Explorer, a web application that connects to the Star Wars API (SWAPI). This project represents my initial exploration of .NET Core and Vue.js, combining these technologies to create an engaging user experience.

## Project Overview
Developed as part of a technical assessment for a .NET Developer role, this application demonstrates my skills in .NET 6, C#, Vue.js, and API integration.

## Features

List of Characters: Displays characters from the Star Wars universe.
Character Search: Users can search for characters by name.
Character Details: Detailed information about selected characters is shown.

## Technology Stack

Backend: .NET 6 (or newer) Web API
Frontend: Vue.js
API: SWAPI - SWAPI Documentation
Additional Tools: Swagger for API testing

## Prerequisites

.NET 5 SDK or later
Node.js and npm
Vue CLI
Git

## Setting up the Project

#Backend/API Setup

## Clone the Repository
```
git clone https://github.com/chrishiggins54/star-wars-app-backend
```

# Backend Setup
## Navigate to the backend project directory.
```
cd StarWarsApp\star-wars-app-backend
```

## Restore the .NET packages:
```
dotnet restore
```

## Start the backend API using:
```
dotnet run
```
# Frontend Setup
## Navigate to the frontend project directory e.g:
```
cd D:\Projects\StarWarsApp\star-wars-app-frontend
```
## Install npm packages:
```
npm install
```

## Start the Vue.js development server:
```
npm run serve
```
## Environment Configuration
Configure the .env file in the frontend project to point to the correct backend URL. The .env file should contain:

```
VUE_APP_API_URL=http://localhost:5287
```
Replace the URL/port as necessary. This file allows easy management of environment-specific variables.

## API Testing with Swagger
Swagger is integrated for backend API testing. Access Swagger UI at https://localhost:44395/swagger.
