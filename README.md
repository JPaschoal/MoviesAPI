# MoviesAPI

- [MoviesAPI](#MoviesAPI)
    - [Description](#Description)
    - [Technologies](#Technologies)
    - [Usage](#Usage)
    - [API Endpoints](#API-Endpoints)
        - [Address](#Address)
            - [Create address](#Create-address)
            - [Get list of address](#Get-list-of-address)
            - [Get address by id](#Get-address-by-id)
            - [Update address](#Update-address)
            - [Delete address](#Delete-address)
        - [Cinema](#Cinema)
            - [Create cinema](#Create-cinema)
            - [Get list of cinema](#Get-list-of-cinema)
            - [Get cinema by id](#Get-cinema-by-id)
            - [Update cinema](#Update-cinema)
            - [Delete cinema](#Delete-cinema)
        - [Session](#Session)
            - [Get list of sessions](#Get-list-of-sessions)
            - [Create session](#Create-session)
            - [Get session by movie id and cinema id](#Get-session-by-movie-id-and-cinema-id)
        - [Movie](#Movie)
            - [Create movie](#Create-movie)
            - [Get list of movies](#Get-list-of-movies)
            - [Get movie by id](#Get-movie-by-id)
            - [Update movie](#Update-movie)
            - [Partial update movie](#Partial-update-movie)
            - [Delete movie](#Delete-movie)
    - [Author](#Author)

## Description

MoviesAPI is a .NET 8.0 project that provides a API for managing movies. Created with objective of learning and practicing .NET 8.0, C#, Entity Framework Core, and SQL Server.

## Technologies

- .NET 8.0
- C#
- Entity Framework Core
- SQL Server

## Usage
First clone the repository 

```
git clone https://github.com/JPaschoal/MoviesAPI.git
cd MoviesAPI
```

To run the project, use the following command:

```console
dotnet restore
dotnet run --project MoviesAPI/MoviesAPI.csproj
```

The API will be available at 
```url
http://localhost:5173
```

## API Endpoints

## Address

### Create address

```js
GET {{host}}/api/address 
```

#### Register address request body:

```json
{
  "street": "string",
  "number": "string",
  "city": "string",
  "zipCode": "string",
  "country": "string"
}
```

#### Register address response:

```js
200 OK
```

```json
{
  "id": 0,
  "street": "string",
  "number": "string",
  "city": "string",
  "zipCode": "string",
  "country": "string"
}
```

### Get list of address

```js
GET {{host}}/api/address?skip=0&take=10
```

#### Get list of address response:

```js
200 OK
```

```json
[
  {
    "id": 0,
    "street": "string",
    "number": "string",
    "city": "string",
    "zipCode": "string",
    "country": "string"
  }
]
```

### Get address by id

```js
GET {{host}}/api/address/{id}
```

#### Get address by id response:

```js
200 OK
```

```json
{
  "id": 0,
  "street": "string",
  "number": "string",
  "city": "string",
  "zipCode": "string",
  "country": "string"
}
```

### Update address

```js
PUT {{host}}/api/address/{id}
```

#### Update address request body:

```json
{
  "street": "string",
  "number": "string",
  "city": "string",
  "zipCode": "string",
  "country": "string"
}
```

#### Update address response:

```js
200 OK
```

```json
{
  "id": 0,
  "street": "string",
  "number": "string",
  "city": "string",
  "zipCode": "string",
  "country": "string"
}
```

### Delete address

```js
DELETE {{host}}/api/address/{id}
```

#### Delete address response:

```js
204 No Content
```

## Cinema

### Create cinema

```js
GET {{host}}/api/cinema 
```

#### Register cinema request body:

```json
{
  "name": "string",
  "addressId": 0
}
```

#### Register cinema response:

```js
200 OK
```

```json
{
  "id": 0,
  "name": "string",
  "addressId": 0
}
```

### Get list of cinema

```js
GET {{host}}/api/cinema?skip=0&take=10
```

#### Get list of cinema response:

```js
200 OK
```

```json
[
  {
    "id": 0,
    "name": "string",
    "addressId": 0
  }
]
```

### Get cinema by id

```js
GET {{host}}/api/cinema/{id}
```

#### Get cinema by id response:

```js
200 OK
```

```json
{
  "id": 0,
  "name": "string",
  "addressId": 0
}
```

### Update cinema

```js
PUT {{host}}/api/cinema/{id}
```

#### Update cinema request body:

```json
{
  "name": "string",
  "addressId": 0
}
```

#### Update cinema response:

```js
200 OK
```

```json
{
  "id": 0,
  "name": "string",
  "addressId": 0
}
```

### Delete cinema

```js
DELETE {{host}}/api/cinema/{id}
```

#### Delete cinema response:

```js
204 No Content
```

## Session

### Get list of sessions

```js
GET {{host}}/api/session 
```

#### Get list of session response:

```js
200 OK
```

```json
[
  {
    "movieId": 0,
    "cinemaId": 0
  }
]
```

### Create session

```js
POST {{host}}/api/session 
```

#### Register session request body:

```json
{
  "movieId": 0,
  "cinemaId": 0
}
```

#### Register session response:

```js
200 OK
```

```json
{
  "movieId": 0,
  "cinemaId": 0
}
```

### Get session by movie id and cinema id



```js
GET {{host}}/api/session/{movieId}/{cinemaId}
```

#### Get session by movie id and cinema id response:

```js
200 OK
```

```json
{
  "movieId": 0,
  "cinemaId": 0
}
```

## Movie

### Create movie

```js
POST {{host}}/api/movie 
```

#### Register movie request body:

```json
{
  "title": "string",
  "description": "string",
  "duration": 0
}
```

#### Register movie response:

```js
200 OK
```

```json
{
  "id": 0,
  "title": "string",
  "description": "string",
  "duration": 0
}
```

### Get list of movies

```js
GET {{host}}/api/movie?skip=0&take=10
```

#### Get list of movies response:

```js
200 OK
```

```json
[
  {
    "id": 0,
    "title": "string",
    "description": "string",
    "duration": 0
  }
]
```

### Get movie by id

```js
GET {{host}}/api/movie/{id}
```

#### Get movie by id response:

```js
200 OK
```

```json
{
  "id": 0,
  "title": "string",
  "description": "string",
  "duration": 0
}
```

### Update movie

```js
PUT {{host}}/api/movie/{id}
```

#### Update movie request body:

```json
{
  "title": "string",
  "description": "string",
  "duration": 0
}
```

#### Update movie response:

```js
204 OK
```

```json
{
  "id": 0,
  "title": "string",
  "description": "string",
  "duration": 0
}
```

### Partial update movie

```js
PATCH {{host}}/api/movie/{id}
```

#### Partial update movie request body:

```json
{
  "title": "string",
  "description": "string",
  "duration": 0
}
```

#### Partial update movie response:

```js
204 OK
```

```json
{
  "id": 0,
  "title": "string",
  "description": "string",
  "duration": 0
}
```

### Delete movie

```js
DELETE {{host}}/api/movie/{id}
```

#### Delete movie response:

```js
204 No Content
```

## Author
- Jhonatan Paschoal
