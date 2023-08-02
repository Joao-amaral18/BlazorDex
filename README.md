# BlazorDex

## Prerequisites
Make sure you have either of the following:

- .NET SDK 7.0: You can download and install it from the official .NET website.
- Docker: If you prefer to use Docker, make sure it is installed on your system.

### Start the project with docker
If you have Docker installed, you can easily build and run the BlazorDex project with the following steps:
``` 
docker build -t blazordex .
docker run --name blazordex -d -p 5002:8080 blazordex --rm
```

### Starting the project without docker
If you prefer to run the project without using Docker, follow these steps:
``` 
dotnet restore 
dotnet run 
```
