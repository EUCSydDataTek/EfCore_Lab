#! /bin/bash
echo "---- Post create script ----"
sudo apt-get update && sudo apt-get install python3 jupyter -y

dotnet tool install -g Microsoft.dotnet-interactive

dotnet interactive jupyter install

dotnet restore && dotnet build
echo "---- Post create script ----"