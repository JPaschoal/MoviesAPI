# MoviesAPI

## Description

MoviesAPI is a .NET 8.0 project that provides a RESTful API for managing movies.

## Installation

To install the project, follow these steps:

```
git clone https://github.com/JPaschoal/MoviesAPI.git
cd MoviesAPI
dotnet restore
```

## Usage
To run the project, use the following command:

```dotnet run --project MoviesAPI/MoviesAPI.csproj```

The API will be available at http://localhost:5173/swagger/index.html.

## API Endpoints
POST ```/api/movie```: Add a new movie
GET ```/api/movie```: Get a list of movies
GET ```/api/movie/{id}```: Get a movie by its ID
PUT ```/api/movie/{id}```: Update a movie by its ID
PATCH ```/api/movie/{id}```: Partially update a movie by its ID
DELETE ```/api/movie/{id}```: Delete a movie by its ID
Contributing
Instructions on how to contribute to the project.

## Author
- Jhonatan Paschoal