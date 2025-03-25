#!/bin/bash

# Update the package
apt-get update

#SDK
snap install dotnet-sdk --classic

# Install .NET9
apt-get install -y dotnet-sdk-9.0 aspnetcore-runtime-9.0 dotnet-runtime-9.0 curl python3 jupyter git

dotnet new tool-manifest
dotnet tool install --local Microsoft.dotnet-interactive

dotnet restore