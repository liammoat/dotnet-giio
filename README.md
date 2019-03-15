# dotnet giio
.NET global tool to create useful .gitignore files for your project using gitignore.io.

[![Build status][devops]][devops-badge] [![NuGet][nuget-badge]][nuget]

[devops-badge]: https://dev.azure.com/liammoat/dotnet-giio/_build/latest?definitionId=6
[devops]: https://dev.azure.com/liammoat/dotnet-giio/_apis/build/status/Build
[nuget]: https://www.nuget.org/packages/dotnet-giio/
[nuget-badge]: https://img.shields.io/nuget/v/dotnet-giio.svg?style=flat-square&label=nuget

## Install
Before you can install ```giio``` you will need to download and install .NET Core 2.1 from [dot.net](https://dot.net). Install ```giio``` as a global tool:

```
dotnet tool install --global dotnet-giio
```

## Usage

### ```dotnet giio generate [types]```
 Generate a .gitignore file.

```
dotnet giio generate visualstudio node
```

### ```dotnet giio list [--query]```
List available types from gitignore.io.

```
dotnet giio list --query visualstudio
```

### ```dotnet giio preview [types]```
Preview a generated a .gitignore file.

```cmd
dotnet giio preview visualstudio node
```

### Update
To update ```giio``` to the latest version:

```
dotnet tool update -g dotnet-giio
```

### Uninstall
To uninstall ```giio```:

```cmd
dotnet tool uninstall -g dotnet-giio
```

## License
Copyright (c) 2018 Liam Moat

Released under [the MIT license](https://github.com/liammoat/dotnet-giio/blob/master/LICENCE).