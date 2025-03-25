#!/bin/bash

# Update the package cache
apt-get update

# Install .NET7
apt-get install -y dotnet9 curl python3 jupyter

dotnet new tool-manifest
dotnet tool install --local Microsoft.dotnet-interactive

dotnet restore