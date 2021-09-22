# F# Sample Accelerator

A sample accelerator for F#.

This sample is the Weather Forecast RESTful API application made available from Microsoft.  It provides a single endpoint, `/weatherforecast`, that returns a mock forecast for the upcoming several days.

The starting source for this sample was created using:
```
$ dotnet new webapi --language F#
```

If the _Dockerfile_ option is elected, the generated project will include a Dockerfile that can be used to create a Docker image for the sample application.

To run the sample application:

```
$ dotnet run
```

Once running, access the endpoint at https://localhost:5001/weatherforecast

```
$ http --verify=no https://localhost:5001/weatherforecast
```
