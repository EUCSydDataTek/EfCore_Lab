#!/bin/bash

# Update the package
apt-get update

# Install .NET9
apt-get install -y dotnet9 curl python3 jupyter git

dotnet new tool-manifest
dotnet tool install --local Microsoft.dotnet-interactive

dotnet restore