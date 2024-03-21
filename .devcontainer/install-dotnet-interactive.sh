#!/bin/bash

# Update the package
apt-get update

# Install .NET7
apt-get install -y dotnet8 curl python3 jupyter git

dotnet new tool-manifest
dotnet tool install --local Microsoft.dotnet-interactive

dotnet restore