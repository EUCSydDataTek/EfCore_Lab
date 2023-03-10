# Ef core Lab

Dette projekt skal køres i en polyglot notebook

For at bruge polyglot skal du have jupyterlab installeret.

> vscode vil komme med en popup om du vil installere extensions når du åbner mappen.

# Installation af Dotnet interactive

## Installationskrav
*  At den nyeste version af .net er installeret

## 1. installer Jupyterlab

### Windows
```pwsh
winget install ProjectJupyter.JupyterLab --source winget
```

### Linux (Debian baseret)
```bash
sudo apt install python3 python3-pip
sudo pip install jupyterlab
```

## 2. Installer .Net interactive

1. åbn jupyterlab

2. Vælg Other>Terminal på startskærmen.

3. Kør kommando for at installere .net interactive i jupyter.
```bash
dotnet interactive jupyter install
```



