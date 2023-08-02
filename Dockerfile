# Use the official .NET SDK image as the base image
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

COPY BlazorDex.sln ./
COPY BlazorDex.csproj ./

RUN dotnet restore
COPY . ./
RUN dotnet publish -c Release -o out

FROM nginx:1.23.0-alpine
WORKDIR /app
EXPOSE 8080
COPY nginx.conf /ect/nginx/nginx.conf
COPY --from=build /app/out/wwwroot /usr/share/nginx/html