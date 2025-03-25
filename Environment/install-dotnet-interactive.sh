#!/bin/bash

# Update the package cache
apt-get update

# SDK
snap install dotnet-sdk --classic

# Install .NET7
apt-get install -y dotnet9 curl python3 jupyter

export DOTNET_ROOT=/usr/lib/dotnet

dotnet new tool-manifest
dotnet tool install --local Microsoft.dotnet-interactive

dotnet restore