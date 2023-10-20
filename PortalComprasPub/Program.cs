// Copyright (c) Portal de Compras Públicas. Todos os direitos reservados.
// Este arquivo é parte do projeto PortalCompras, e é um projeto privado.


using PortalComprasPub.Infrastructure.CrossCutting.IoC;

var builder = WebApplication.CreateBuilder(args);

NativeInjector.RegisterServices(builder.Services);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
