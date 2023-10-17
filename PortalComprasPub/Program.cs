// Copyright (c) Portal de Compras Públicas. Todos os direitos reservados.
// Este arquivo é parte do projeto PortalCompras, e é um projeto privado.


var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();


app.MapGet("/", () => "Hello World!");

app.Run();
