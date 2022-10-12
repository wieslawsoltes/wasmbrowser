## Browser application

## Build

You can build the application from Visual Studio or by dotnet cli

```
dotnet build -c Debug/Release
```

After building the application, the result is in the `bin/$(Configuration)/net7.0/browser-wasm/AppBundle` directory.

## Run

You can build the application from Visual Studio or by dotnet cli

```
dotnet run -c Debug/Release
```

Or you can start any static file server from the AppBundle directory

```
dotnet serve -h "Cross-Origin-Opener-Policy:same-origin" -h "Cross-Origin-Embedder-Policy:require-corp" -d:bin/Debug/net7.0/browser-wasm/AppBundle
dotnet serve -h "Cross-Origin-Opener-Policy:same-origin" -h "Cross-Origin-Embedder-Policy:require-corp" -d:bin/Release/net7.0/browser-wasm/AppBundle
```

https://github.com/lambdageek/hithread

https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/SharedArrayBuffer#security_requirements
