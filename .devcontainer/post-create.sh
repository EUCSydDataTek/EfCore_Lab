#! /bin/bash
echo "---- Post create script ----"
sudo conda install jupyter

sudo dotnet tool install -g Microsoft.dotnet-interactive

sudo dotnet interactive jupyter install

sudo dotnet restore