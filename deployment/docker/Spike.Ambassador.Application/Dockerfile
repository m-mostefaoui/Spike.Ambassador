FROM microsoft/dotnet:2.0-runtime
WORKDIR /app
COPY ./publish ./
EXPOSE 8020
ENTRYPOINT ["dotnet", "Spike.Ambassador.Application.dll"]
