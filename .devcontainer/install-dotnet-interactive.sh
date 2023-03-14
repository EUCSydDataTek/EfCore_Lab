#!/bin/bash

# Update the package cache
apt-get update

# Install .NET7
apt-get install -y dotnet7 curl python3 jupyter git

dotnet new tool-manifest
dotnet tool install --local Microsoft.dotnet-interactive

dotnet restore