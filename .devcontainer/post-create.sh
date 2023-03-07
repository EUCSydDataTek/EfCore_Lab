#! /bin/bash
echo "---- Post create script ----"
sudo apt-get update && sudo apt-get install python3 jupyter -y

sudo dotnet tool install -g Microsoft.dotnet-interactive

sudo dotnet interactive jupyter install

sudo dotnet restore
echo "---- Post create script ----"