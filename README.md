# Blazor dual model

A Blazor app setup for server-side hosting in development and client-side hosting in production.

In development in Visual Studio the project will run as a server-side Blazor app so you can debug.

If you switch the environment to Production (i.e. by setting the ASPNETCORE_ENVIRONMENT environment variable to "Production") the app will run as a client-side Blazor app on WebAssembly.

