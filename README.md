# dotnet giio
.NET global tool to create useful .gitignore files for your project using gitignore.io.

[![Build status][devops]][devops-badge] [![NuGet][nuget-badge]][nuget]

[devops-badge]: https://dev.azure.com/liammoat/dotnet-giio/_build/latest?definitionId=6
[devops]: https://dev.azure.com/liammoat/dotnet-giio/_apis/build/status/Build
[nuget]: https://www.nuget.org/packages/dotnet-giio/
[nuget-badge]: https://img.shields.io/nuget/v/dotnet-giio.svg?style=flat-square&label=nuget

![Demo of dotnet diio](https://github.com/liammoat/dotnet-giio/raw/master/assets/demo.gif)

## Installation
Download and install the [.NET Core 2.1 SDK](https://www.microsoft.com/net/download) or newer. Once installed, run the following command:

```
dotnet tool install --global dotnet-giio
```

If you already have a previous version of **dotnet-giio** installed, you can upgrade to the latest version using the following command:

```bash
dotnet tool update --global dotnet-giio
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

## License
Copyright (c) 2018 Liam Moat

Released under [the MIT license](https://github.com/liammoat/dotnet-giio/blob/master/LICENCE).