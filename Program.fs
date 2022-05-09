namespace Sample

open System
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Hosting

module Program =
    let exitCode = 0

    let port =
        if Environment.GetEnvironmentVariable("PORT") > ""
            then Environment.GetEnvironmentVariable("PORT")
            else "5000"
    let url = String.Concat("http://0.0.0.0:", port)

    let CreateHostBuilder args =
        let mutable port =
            Environment.GetEnvironmentVariable("PORT")

        if port = null then port <- "8080"

        let url =
            String.Concat("http://0.0.0.0:", port)

        Host
            .CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(fun webBuilder ->
                webBuilder.UseStartup<Startup>().UseUrls(url)
                |> ignore)

    [<EntryPoint>]
    let main args =
        CreateHostBuilder(args).Build().Run()

        exitCode
