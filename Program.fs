namespace Sample

#nowarn "20"

open System
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Hosting

module Program =
    let exitCode = 0

    [<EntryPoint>]
    let main args =

        let builder = WebApplication.CreateBuilder(args)

        let port =
            if Environment.GetEnvironmentVariable("PORT") > "" then
                Environment.GetEnvironmentVariable("PORT")
            else
                "8080"
        let url = String.Concat("http://0.0.0.0:", port)
        builder.WebHost.UseUrls(url)

        builder.Services.AddControllers()

        let app = builder.Build()

        app.UseAuthorization()
        app.MapControllers()

        app.Run()

        exitCode
