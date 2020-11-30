FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build-env
WORKDIR /app

COPY PrivateSell.sln /app
COPY /Api /app

WORKDIR /app/PrivateSellApi/
RUN dotnet publish -c Release -o out

WORKDIR /app/PrivateSellApi/out

ENV ASPNETCORE_URLS=https://+:5001
ENV ClientId=carsales
ENV ClientSecret=B9gQ4mRh5QgB

EXPOSE 5001

CMD ["dotnet", "PrivateSellApi.dll"]

