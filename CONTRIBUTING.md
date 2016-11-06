# Contributing

## Building from Source

Minimum requirements:

* Visual Studio Community 2013
* Windows Phone SDK 8.0, available [here](https://www.microsoft.com/en-us/download/details.aspx?id=35471)

To do a quick sanity check, run one of the available sample projects from Visual Studio.

## Troubleshooting

**Could not find SDK "BehaviorsXamlSDKManaged, version=12.0"**

Make sure that Behaviors SDK is installed under Universal App Platform location.

If not already there, copy extension SDKs from the Windows 8.1 SDK location to the Windows 10 Universal App Platform location
(see Release Notes [here](https://go.microsoft.com/fwlink/p/?LinkId=526491)). That is, from:

```
%ProgramFiles(x86)%\Microsoft SDKs\Windows\v8.1\ExtensionSDKs
```

to:

```
%ProgramFiles(x86)%\Microsoft SDKs\UAP\v0.8.0.0\ExtensionSDKs
```
