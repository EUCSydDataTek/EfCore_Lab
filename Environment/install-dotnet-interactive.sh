#!/bin/bash

# Update the package cache
apt-get update

# Install .NET7
apt-get install -y dotnet8 dotnet-sdk-9.0 aspnetcore-runtime-9.0 dotnet-runtime-9.0 curl python3 jupyter

export DOTNET_ROOT=/usr/lib/dotnet

dotnet new tool-manifest
dotnet tool install --local Microsoft.dotnet-interactive

dotnet restore