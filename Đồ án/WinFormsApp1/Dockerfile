FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app
EXPOSE 5000
ENV ASPNETCORE_URLS=http://0.0.0.0:5000

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["WinFormsApp1.csproj", "./"]
RUN dotnet restore "WinFormsApp1.csproj"
COPY . .
RUN dotnet publish "WinFormsApp1.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM runtime AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "DoAnCryptoWeb.dll"]
