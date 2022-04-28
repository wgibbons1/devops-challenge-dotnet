# Set the base image as the .NET 6.0 SDK (this includes the runtime)
FROM mcr.microsoft.com/dotnet/sdk:6.0 as build-env

# Copy everything and publish the release (publish implicitly restores and builds)
WORKDIR /app
COPY . ./
RUN dotnet publish ./src/DevOpsChallenge.SalesApi/DevOpsChallenge.SalesApi.csproj -c Release -o out --no-self-contained

# Label as GitHub action
LABEL com.github.actions.name="devops-challenge-dotnet"

# Relayer the .NET SDK, anew with the build output
FROM mcr.microsoft.com/dotnet/sdk:6.0
COPY --from=build-env /app/out .
ENTRYPOINT [ "dotnet", "/DevOpsChallenge.SalesApi.dll" ]