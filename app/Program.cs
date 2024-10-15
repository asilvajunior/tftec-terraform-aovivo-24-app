using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços ao contêiner.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); // Adicione isso para o Swagger
builder.Services.AddSwaggerGen(); // Adicione isso para o Swagger

var app = builder.Build();

// Configure o pipeline de solicitação HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger(); // Habilita o Swagger
    app.UseSwaggerUI(); // Habilita a interface do usuário do Swagger
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers(); // Mapeia os controladores

app.Run();
