# Caliburn.Micro.AutofacBootstrap

Home of the [Caliburn.Micro.AutofacBootstrap](http://nuget.org/packages/Caliburn.Micro.AutofacBootstrap) nuget package.
Integrates [Caliburn.Micro](https://github.com/Caliburn-Micro/Caliburn.Micro) bootstrapping phase with [Autofac](https://github.com/autofac/Autofac) IoC container,
so that you can register dependencies at application starts up and make them available to view-models and other components.

[![NuGet](http://img.shields.io/nuget/v/Caliburn.Micro.AutofacBootstrap.svg)](https://www.nuget.org/packages/Caliburn.Micro.AutofacBootstrap/)
[![Build status](https://ci.appveyor.com/api/projects/status/github/brendankowitz/Caliburn.Micro.Autofac?svg=true)](https://ci.appveyor.com/api/projects/status/github/brendankowitz/Caliburn.Micro.Autofac)

## Installing

From Visual Studio Package Manager Console - or from a PowerShell console positioned on your project directory - run:

```
PM> Install-Package Caliburn.Micro.AutofacBootstrap
```

## Usage

Please refer to [sample projects](./tree/master/samples) on different platforms found in Visual Studio solution.

## Contributing

Please refer to [CONTRIBUTING](./CONTRIBUTING.md) page.

## Acknowledgments

The Caliburn.Micro.Autofac project is making use of the following OSS projects:

* [Autofac](http://autofac.org/) - under the [MIT license](https://github.com/autofac/Autofac/blob/develop/LICENSE)
* [Caliburn.Micro](http://caliburnmicro.com/) - under the [MIT license](https://github.com/Caliburn-Micro/Caliburn.Micro/blob/master/License.txt)

## License

This project is licensed under the [MIT license](./License.txt).
