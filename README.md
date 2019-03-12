# dotnet giio
.NET Global Tool to generate .gitignore files using gitignore.io

[![Build status](https://dev.azure.com/liammoat/dotnet-giio/_apis/build/status/Build)](https://dev.azure.com/liammoat/dotnet-giio/_build/latest?definitionId=6)

## Install
Ensure you have the ```dotnet``` CLI installed. Install ```giio``` as a global tool:

```
dotnet tool install -g dotnet-giio
```

This will installed ```giio``` as a global tool. Find out more [here](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-tool-install).

## Available commands

```
dotnet giio --help
```

### List
List available types

```
dotnet giio list
```

```
dotnet giio list --query visualstudio
```

### Generate

```cmd
dotnet giio generate visualstudio node
```

### Preview

```cmd
dotnet giio preview visualstudio node
```

### Update

```cmd
dotnet tool update -g dotnet-giio
```

### Uninstall

```cmd
dotnet tool uninstall -g dotnet-giio
```

## License
Copyright (c) 2018 Liam Moat

Released under [the MIT license](https://github.com/liammoat/dotnet-giio/blob/master/LICENCE).