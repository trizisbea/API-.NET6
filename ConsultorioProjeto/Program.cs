using ConsultorioProjeto.Context;
using ConsultorioProjeto.Repository.Interfaces;
using ConsultorioProjeto.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// add do newtonsoft para loops infinitos
builder.Services.AddControllers().AddNewtonsoftJson(options =>
{
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
}
);

// injeção de dependência 
builder.Services.AddScoped<IBaseRepository, BaseRepository>();
builder.Services.AddScoped<IPacienteRepository, PacienteRepository>();
builder.Services.AddAutoMapper(typeof(IStartup)); 

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// setar a comunicação com o banco de dados - postgres nesse caso
// necessário instalar um pacote no nuget galery (ctrl + shft + p)
builder.Services.AddDbContext<ConsultorioContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("Default"),
    assembly => assembly.MigrationsAssembly(typeof(ConsultorioContext).Assembly.FullName)
    );
});

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
//builder.Services.AddAutoMapper(Assembly.Load();
//builder.Services.AddAutoMapper(typeof(ConsultorioProfile));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
