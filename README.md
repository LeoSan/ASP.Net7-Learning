# .NET 7: ASP.NET Core esencial

- Este es el repositorio del curso de LinkedIn Learning `.NET 7: ASP.NET Core esencial`. 
- Consulta el archivo Readme en la rama main para obtener instrucciones e información actualizadas.
- Comprende los conceptos fundamentales de la plataforma de desarrollo ASP.NET Core 7 con este contenido formativo. Al finalizar el curso, serás capaz de identificar los componentes más importantes de ASP.NET Core 7, sus diferentes tipos de proyectos y las herramientas necesarias para construir este tipo de soluciones, destacando el uso de las web API mínimas, así como las páginas Razor para la creación de aplicaciones web.

## Instalación

1. Para utilizar estos archivos de ejercicios, debes tener descargado lo siguiente:
   - SDK de .NET 7
   - Visual Studio Code
   - Visual Studio 2022


# Introducción ASP.dot.net Core 7 

# Modulo  1 : concepto básicos 
## Instalar 
- Descargar 7 o 8 .Net 
- Descargar Visual Studio 2022 


##Generar Proyectos. 

**Por comandos**
- Entrar a consola validar si esta instalado > `dotnet --version`
- Crear proyecto tipo web > dotnet new wev -n Holamuno
 -	se ejcuta y compila  y abre un navegador hola mundo 
- >  `dotnet run -lp http`  -> esjecuta el proyecto dependiendo el perfil 
- >  `dotnet run -lp https` -> esjecuta el proyecto dependiendo el perfil launchSettings.json  profile 
- >  `dotnet --list-sdks`   ->   
- >  `dotnet new web -n ejemplo` ->  Genera proyecto a la version antigua < Dot net version 5 -> program.cs,  Stattup.cs     
- >  `dotnet run --environment Staging ` ->  Correr rapido      
 
##

# Modulo 2: Comprendiendo la estrcutura de los proyectos ASP.net core 

## Anatomía de un proyecto de ASP.net Core basado en la plantilla core 
**Nota**
- Aqui genera una estructura muy básica aqui es la plantilla empty 
- aqui se puede genera la plantilla empty

## Anatomía de un proyecto de ASP.net Core basado en aplicaciones web 

**Nota**
- Usa  modelo Vista controlador 
- usa el principio de Convesión sobre la confiuguración: simplemente usa las configuraciones para para generar por defecto 
	- View -> ViewNombre.cshtml 
	- Controller -> HomeController.cs  
	- Model      -> ErrorViewModel.cs   
## Anatomía de un proyecto de ASP.net Core basado WEB API
 
**Nota**
- Esta forma es para crear una api.
- Se maneja dos directorios principales 
	- Properties 
	- Controllers
- Swagger -> es un estandar de exponer este esquema y consumir API 
	
	
## Tipos Host en ASP.NET Core 
- Definir tipo de anfitrion 
- Usamos el objeto WebAplication -> para las app 
- WorkerServers-> Host Generico -> Objeto Host.CreateDefaultBuilder -> no sirve para una aplicación web ya que se usa para correr aplicaciones en segunda plano 
- `dotnet new web -n ejemplo` ->  Genera proyecto a la version antigua < Dot net version 5 -> Genera estos dos archivos,  program.cs,  Stattup.cs anfitrion para compactibilidad 

## Ambiente en ASP.Net Core 
 
**Nota** 
- Se usan variable de ambiente en el launchSettings.json  para deifnir ciertos valores 
- Podemos configurar desde la opción del proycto clieck derecho propiedades podemos editar los valores json 
- En código podemos usar el objeto `public IHostEnviroment HostEnvironment {get;}`
- `dotnet run --environment Staging ` ->  Correr rapido    


# Modulo 3: Inyección de dependencias en ASP.Net Core 

## Introducción ala Inyecciónde dependencias es un patron de diseño 

**Nota**
- Usamos este patron para crear clases y no depender de tu alguien al momento de generar proyecto  
- Podemos usar la propiedad click derecho y definir `extract Interface` esto se gace desde el constructor 
- en la clase principal vamos solicitar que pase la instancia  
- Se basa tambien en el patron Singleton -> Programs.cs -> builder.Services.AddSingleton<IGuidinator, Guidinator>(); ->  esto ayuda para que se generen una sola instancia durante la vida del proyecto 
 - Hace un mapeo entre una Interfaz abstratac y una clase concreta 
 

## Inyeccion de Dependencias 

- Podemos recibir el Objeto configurado como una inyección 

```
using Microsoft.AspNetCore.Mvc;

namespace demoinyeccion.Controllers;
[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    public WeatherForecastController(IGuidinator guidinator)
    {

    }

    [HttpGet]
    public string Get(IGuidinator guidinator)
    {
        return guidinator.Value;
    }
}
```

## Tiempo de Vida de los objetos al usar inyección de dependencias 

- Usamos el Metodo Scope 
- builder.Services.AddScoped<IGuidinator, Guidinator>();
- Permite que se ejecute el metodo de la inyección cada vez que se haga una petición 
- El AddScoped Cuando el request termina el permite generar otra instancia 

- El builder.Services.AddTransient<IGuidinator guidinator> -> Permite gestuionar y administrar las instancias de las clases inyectadas  
- Cuando usar  AddScoped y cuando AddTransient 
  - Primera opción es AddScoped
  - AddSingleton -> Permite implementar la inyección durante todo el proyecto 
  - AddScoped -> Permite implementar la inyección durante todo el proyecto pero este mide, valida, gestiona los request durante todo el proyecto 
  - AddTransient -> Gestiona mejor el uso de las inyecciones por ejemplo si esta se ejecuta en varias distintas partes del proyecto este realiza una nueva instancia y genera una nueva información por cada invocación bien sea desde el constructor o algun metodo. 

## Creando un metódo de extensión para registrar objetos en el contenedor 

- Programs.cs no va ejecutando linea por linea realmente realiza un pool de metodos hasta el final como lo define la siguiente linea de código 

```
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCurso();
```

```
﻿namespace demoinyeccion.Helpers;

public static class DemoInyeccionExtensionsHelper
{
    public static void AddCurso(this IServiceCollection services)
    {
        services.AddScoped<IGuidinator, Guidinator>();
    }
}
```

# Modulo 4: Configuración en APS.NET Core 

## Infraestrucuta base de configuración 

**Nota**
- dot.net tenemos un abanico de configuración sin tocar el Program.cs 
- Podemos usar `appsettings.json`
- nombreCurso = configuration.GetValue("Clave"); nombre colocalo en el appseting 
- nombreCurso = configuration.GetValue<string>("Clave"); nombre colocalo en el appseting 
  
  
## Proveedor de configuración de archivos fisicos 

**Nota**
- Se basa en proveedores que nos puede proporcionar configuraciones 
- Como ejemplo el `appsettings.json`
- Nos poyamos con `launchSettings.json` para poder usar el `appsettings.json` ya que este archivo podemos onfifgurar varios entornos por ejemplo uno para Developer o setting 
- `appsettings.Development.json`
- `appsettings.Staging.json`

##  Proveedor de configuración de variables de ambiente 
- Podemos usar el `launchSettings.json` para configurar variables de ambiente 
- Podemos crear variables de entorno pero esta sustituye a la variable de entrono del sistema operativo 



## Proveedor de configuración de secretos 
- Podemos hacer los siguiente pasos: 
- Paso 1: Clic derecho en el proyecto, buscar la opcion `Manage Use Secret`
- Paso 2: Esta opcion agiliza que el proyecto se genere un archivo secreto en tu maquina local solo para desarrolladores esto se ignora cuando se ejecuta el proyecto en producción 
- Paso 3: se piensa para que no se suba al codigo fuente esto se gurdar en AppData\Microsoft\UserSecrests\aqui nombre del archivo  


## Personalización de los proveedores de configuración 
- Tener control de nuestra configuraciones 
- Podemos usar el objeto builder 
- explicitamente podemos limpiar los proveedores de configuración: `builder.Confuguration.sources.Clear()`
- creamos el que necesitamos `builder.Configuration.AddEnviromnmentVariables()` ó 
- creamos el que necesitamos `builder.Configuration.AddJsonFile("appsettings.json", true)`
- creamos el que necesitamos `builder.Configuration.AssUserSrecrets(Assembly.GetExecutingAssembly())`


## Cuando variable de entorno que expresan una estructura  
- Podemos desde el launchSettings.json realizar redifinir o sustituir las variables del appsettings.js 
- Podemos aplanar de la siguiente forma `"Logging:LogLevel:Microsoft.AspNetCore": "Debug"`

- Podemos aplanar launchSettings.json
```
  "profiles": {
    "http": {
      "commandName": "Project",
      "dotnetRunMessages": true,
      "launchBrowser": true,
      "applicationUrl": "http://localhost:5275",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development",
        "Logging:LogLevel:Microsoft.AspNetCore": "Debug"   -> Windows 
        "Logging__LogLevel__Microsoft.AspNetCore": "Debug" -> Linux 
      }
    },
```	
- appsettings.js
```
 "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  }, 	
``` 	

# Modulo 5: Loggin en ASP.NET Core 

## Infraestructura Base de Logging }

- Podemos usar la interfaz `Ilogger` para administrar nuestro arbol de error tu sabes un Log 
```
using Microsoft.AspNetCore.Mvc;

namespace demologging.Controllers;
[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        _logger.LogDebug("Esto es Debug");
        _logger.LogInformation("Hemos recibido la petición"); //Imprime esta cadena desde la consola de comando 
        return null;
    }
}  
```

- Se configura desde el `builder`

## Implementación del proveedor de Log de Serialog 
- Podemos ver desde el visual estudu la cosola -> Debug/Windows/OutPut
- Registrar un nuevo proveedor de log llamado SeriaLog 
- Paso 1: Clic en depedencia/Manage Nutget Packages / abre una interfaz y buscamos SeriaLog.ASPNetCore se instala  
- Paso 2: Configuramos 
```
using Serilog;//Paso 1

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Logging.AddSerilog(new LoggerConfiguration() 
                            .WriteTo.File("log.txt")
                            .CreateLogger()); // Paso 2

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
```
## Entendiendo los diferentes niveles de logging 

- Existen varios niveles y con eso los niveles que estemos utelizando y a partir de ese  nivel se mostrará en el LOG 
- Lo configurmos en el archivo `appseting`
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information ó Debug ó Trace ó Warning",
      "Microsoft.AspNetCore": "Information ó Debug ó Trace ó Warning"
    }
  },
  "AllowedHosts": "*"
}
```

ó en codigo 
```
    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        _logger.LogDebug("Esto es Debug");
        _logger.LogInformation("Hemos recibido la petición");
        return null;
    }
```

# Modulo 6: Middleware en ASP.NET Core

## Introducción a la infraestructura de Middleware en ASP.NET Core
 [Proyecto Middleware](https://github.com/LinkedInLearning/.NET7-ASP.NET-core-esencial-2493369/tree/main/demomiddleware)
 - Hay cientos de objetos Middleware en ASP.NET Core 
 - Middleware Nos apoyan en ejecutar ciertas tareas 
 
## Implementación de código que ejecute en el pipeline de Middleware 

> Como podemos ver podemos implementar los Middleware uno tras otro 
 
```
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseStopwatch();

app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();
app.Run(); 
``` 

## Creación de una clase de tipo Middleware

- Cuando generamos código Middleware lo generamos en una clase y no en los use 
- Paso 1: Podemos crear nuestra clase 

```
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseStopwatch();

//opcion 1 
app.UseMiddleware<StopwatchMiddleware>();//Encaosulamos el codigo en una clase 

// opcion 2 
app.UseStopwatch();

app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();
app.Run();





public Class StopwatchMiddleware {

	//Patron de Diseño  : Inyeccion o Siglenton
	public StopwatchMiddleware(RequestDelegate requestDelegate, ILogger<StopwatchMiddleware> logger)
	{
		this.requestDelegate = requestDelegate;
		this.logger = logger; 
	}
	
	public async Task Invoke(HttpContext context)
	{
		var sw = new Stopwatch(); 
		sw.start();
		await requestDelegate.Invoke();
		sw.Stop();
		logger.LogInformation($"Tiempo: {sw.ElapsedMilliseconds}")
	
	}
	
	

}


public static class StopwatchMiddlewareHelpers 
{
	public static void UseStopwatch(this WebAplication app)
	{
		app.UseMiddleware<StopwatchMiddleware>();
	
	}

}
```

# Modulo 7. ASP.NET Core Web API
## Creación de un proyecto de tipo web API 
- podemos usar la plantilla de ASP.NET Core Web API 
- [Proyecto Middleware](https://github.com/LinkedInLearning/.NET7-ASP.NET-core-esencial-2493369/tree/main/demowebapi)

https://www.linkedin.com/learning/dot-net-7-asp-dot-net-core-esencial/creacion-de-un-proyecto-de-tipo-web-api?autoSkip=true&resume=false&u=2130338

## Implementación de las clases de dominio
- Implementa DTOs Data transfer  objeto

## Implementación del DbContext y configuración del contenedor de inyección de dependencias
- Pues un Migrate en pocas palabras 
- [WpmDbContext](https://github.com/LinkedInLearning/.NET7-ASP.NET-core-esencial-2493369/blob/main/demowebapi/Dal/WpmDbContext.cs)

- Paso 1: 
```
﻿using demowebapi.Domain;
using Microsoft.EntityFrameworkCore;

namespace demowebapi.Dal;

public class WpmDbContext : DbContext
{
    public DbSet<Species> Species { get; set; }
    public DbSet<Pet> Pets { get; set; }
    public DbSet<Breed> Breeds { get; set; }
    public DbSet<Owner> Owners { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("Wpm");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Owner>().HasData(
                    new Owner() { Id = 1, Name = "Rodrigo" },
                    new Owner() { Id = 2, Name = "Leonardo" },
                    new Owner() { Id = 3, Name = "Alicia" },
                    new Owner() { Id = 4, Name = "Jon" },
                    new Owner() { Id = 5, Name = "Elmer" },
                    new Owner() { Id = 6, Name = "Sam" },
                    new Owner() { Id = 7, Name = "Jessica" }
                    );
        modelBuilder.Entity<Species>().HasData(
                    new Species() { Id = 1, Name = "Perro" },
                    new Species() { Id = 2, Name = "Gato" },
                    new Species() { Id = 3, Name = "Conejo" }
                    );
        modelBuilder.Entity<Breed>().HasData(
                    new Breed() { Id = 1, Name = "Beagle", IdealMaxWeight = 20, SpeciesId = 1 },
                    new Breed() { Id = 2, Name = "Pitbull", IdealMaxWeight = 25, SpeciesId = 1 },
                    new Breed() { Id = 3, Name = "British Shorthair", IdealMaxWeight = 20, SpeciesId = 2 },
                    new Breed() { Id = 4, Name = "Mixed", IdealMaxWeight = 30, SpeciesId = 2 },
                    new Breed() { Id = 5, Name = "Gray", IdealMaxWeight = 20, SpeciesId = 3 },
                    new Breed() { Id = 6, Name = "American White", IdealMaxWeight = 30, SpeciesId = 3 }
                    );
        modelBuilder.Entity<Pet>().HasData(
                    new Pet() { Id = 1, Name = "Gianni", Age = 10, Weight = 19, BreedId = 1 },
                    new Pet() { Id = 2, Name = "Nina", Age = 8, Weight = 24, BreedId = 1 },
                    new Pet() { Id = 3, Name = "Cati", Age = 8, Weight = 33.5m, BreedId = 2 },
                    new Pet() { Id = 4, Name = "Cheshire Cat", Age = 20, Weight = 12, BreedId = 3 },
                    new Pet() { Id = 5, Name = "Garfield", Age = 20, Weight = 12, BreedId = 4 },
                    new Pet() { Id = 6, Name = "Bugs Bunny", Age = 40, Weight = 25, BreedId = 5 },
                    new Pet() { Id = 7, Name = "Roger Rabbit", Age = 35, Weight = 31, BreedId = 6 }
                    );
        modelBuilder.Entity("OwnerPet").HasData(
                    new[]
                    {
                                new { PetsId = 1, OwnersId = 1 },
                                new { PetsId = 1, OwnersId = 2 },
                                new { PetsId = 2, OwnersId = 1 },
                                new { PetsId = 2, OwnersId = 2 },
                                new { PetsId = 3, OwnersId = 1 },
                                new { PetsId = 3, OwnersId = 2 },
                                new { PetsId = 4, OwnersId = 3 },
                                new { PetsId = 5, OwnersId = 4 },
                                new { PetsId = 6, OwnersId = 5 },
                                new { PetsId = 6, OwnersId = 6 },
                                new { PetsId = 7, OwnersId = 7 },
                    }
                );
    }
}
```
- Paso 2: Limimplementamos en el Program.cs -> builder.Services.AddDbContext<WpmDbContext>();

```
using demowebapi.Dal;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<WpmDbContext>();

var app = builder.Build();

var s = app.Services.CreateScope();
var db = s.ServiceProvider.GetService<WpmDbContext>()!;
db.Database.EnsureCreated();
db.Dispose();

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
``` 

## Inyección del DbContext en el controlador


## Implementación de endpoints para consultar datos del Entity Framework Core
- Esto permite que los metodos del controlador pueda recibir parametros y puedan ser enrutados 
- 


```
[ApiController]
[Route("api")] -> todos mis endpoint van a tener el prefixo api 
```

- Generar metodo 

```

    [HttpGet("breeds")]
    public async Task<ActionResult<IEnumerable<BreedViewModel>>> GetAllBreeds()
    {
        var allBreeds = await dbContext.Breeds
            .Include(b => b.Species)
            .Select(b => new BreedViewModel(b.Id, b.Name, b.Species.Name))
            .ToListAsync();
        return Ok(allBreeds);
    }


    [HttpGet("species/{id}/breeds")]
    public async Task<ActionResult<IEnumerable<BreedViewModel>>> GetBreedsBySpecies(int id)
    {
        var allBreeds = await dbContext.Breeds
            .Include(b => b.Species)
            .Where(b => b.SpeciesId == id)
            .Select(b => new BreedViewModel(b.Id, b.Name, b.Species.Name))
            .ToListAsync();
        return allBreeds.Any() ? Ok(allBreeds) : NotFound(id);
    }
```


## Proyectando a tipos concretos y dinámicos en los endpoints
- Permite realizar la consulta entre objetos concretos y dinamicos 


**Concreto** 
```
﻿using demowebapi.Dal;
using demowebapi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace demowebapi.Controllers;

[ApiController]
[Route("api")]
public class PetController : ControllerBase
{
    private readonly WpmDbContext dbContext;

    public PetController(WpmDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    [HttpGet("pets")]
    public async Task<ActionResult<IEnumerable<PetViewModel>>> GetAllPets()
    {
        var allPets = await dbContext.Pets
            .Include(p => p.Breed)
            .Select(p => new PetViewModel(p.Id, p.Name, p.Age, p.Weight, p.Breed.Name))
            .ToListAsync();
        return Ok(allPets);
    }

    [HttpGet("breeds/{id}/pets")]
    public async Task<ActionResult<IEnumerable<PetViewModel>>> GetPetsByBreed(int id)
    {
        var allPets = await dbContext.Pets
            .Include(p => p.Breed)
            .Where(p => p.BreedId == id)
            .Select(p => new PetViewModel(p.Id, p.Name, p.Age, p.Weight, p.Breed.Name))
            .ToListAsync();
        return allPets.Any() ? Ok(allPets) : NotFound(id);
    }
}

```

**Dinámicos**
```
﻿using demowebapi.Dal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace demowebapi.Controllers;

[ApiController]
[Route("api")]
public class OwnerController : ControllerBase
{
    private readonly WpmDbContext dbContext;

    public OwnerController(WpmDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    [HttpGet("pets/{id}/owners")]
    public async Task<IActionResult> GetOwnersByPet(int id) //Dinámico 
    {
        var owners = await dbContext.Pets
            .Include(p => p.Owners)
            .Where(p => p.Id == id)
            .SelectMany(p => p.Owners)
            .Select(p => new { p.Id, p.Name })
            .ToListAsync();
        return owners != null ? Ok(owners) : NotFound(id);
    }
}
```

# Modulo 8: Web API mínimas

## Creación del proyecto de Web API mínima
> el  mismo visual studio tiene para generar el proyecto con APi Minimas
- Paso 1:Buscamos la opción ASP.NET Core Web Api 
- Paso 2:Colocamos Nombre 
- Paso 3: des clickear la opcion de Use }controller para que pueda generar web ai minimas 
- Panel de bienvenida luego cerrar  


**Example**
- https://github.com/LinkedInLearning/.NET7-ASP.NET-core-esencial-2493369/tree/main/demowebapiminimas


## Implementación de nuestro primer endpoint de tipo Get en la Web API mínima

```
using demowebapiminimas.Dal;
using demowebapiminimas.Domain;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<WpmDbContext>();

var app = builder.Build();

var scope = app.Services.CreateScope();
var db = scope.ServiceProvider.GetService<WpmDbContext>()!;
db.Database.EnsureCreated();
db.Dispose();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var species = app.MapGroup("/api/species");

//endPoint 
species.MapGet("/", async (WpmDbContext dbContext) =>
{
    var species = await dbContext.Species.ToListAsync();
    return Results.Ok(species);
}).Produces<IEnumerable<Species>>()
.WithOpenApi(operation => new(operation)
{
    Summary = "Todas las especies",
    Description = "Este endpoint regresa todas las especies de la base de datos"
});


//endPoint
species.MapGet("/{speciesId}/breeds", async (int speciesId, WpmDbContext dbContext) =>
{
    var breeds = await dbContext.Breeds
    .Where(b => b.SpeciesId == speciesId)
    .ToListAsync();
    return breeds.Any() ? Results.Ok(breeds) : Results.NotFound();
}).Produces<IEnumerable<Breed>>(StatusCodes.Status200OK)
  .Produces(StatusCodes.Status404NotFound);

//endPoint
species.MapPost("/", 
    async (SpeciesModel speciesModel, WpmDbContext dbContext) =>
{
    dbContext.Species.Add(new Species() { Name = speciesModel.Name });
    await dbContext.SaveChangesAsync();
}).Produces(StatusCodes.Status200OK);

app.Run();

record SpeciesModel(string Name);
```

## Anotando el endpoint para la documentación con OpenAPI y Swagger 

- Se logra con este fragmento -> .Produces<IEnumerable<Species>>()
```
//endPoint 
species.MapGet("/api/species", async (WpmDbContext dbContext) =>
{
    var species = await dbContext.Species.ToListAsync();
    return Results.Ok(species);
}).Produces<IEnumerable<Species>>()
.WithOpenApi(operation => new(operation)// Permite describir el servicio web 
{
    Summary = "Todas las especies",
    Description = "Este endpoint regresa todas las especies de la base de datos"
});
```

## Implementación de un endpoint de tipo Get mapeado a una ruta con parámetros

-  Forma de enviar parametros 
```
//endPoint
species.MapGet("/{speciesId}/breeds", async (int speciesId, WpmDbContext dbContext) =>
{
    var breeds = await dbContext.Breeds
    .Where(b => b.SpeciesId == speciesId)
    .ToListAsync();
    return breeds.Any() ? Results.Ok(breeds) : Results.NotFound();
}).Produces<IEnumerable<Breed>>(StatusCodes.Status200OK)
  .Produces(StatusCodes.Status404NotFound);
```

## Implementación de un endpoint de tipo Post

- .MapPost nos ayuda genear post 

```
//endPoint
species.MapPost("/", 
    async (SpeciesModel speciesModel, WpmDbContext dbContext) =>
{
    dbContext.Species.Add(new Species() { Name = speciesModel.Name });
    await dbContext.SaveChangesAsync();
}).Produces(StatusCodes.Status200OK);

```


## Implementación de un grupo utilizando el método MapGroup
- Puedes mejorar la legibilidad del código usando agrupación  

```
var species = app.MapGroup("/api/species");

species.MapGet // Por cada endpoint
```

# Modulo 9. Aplicaciones web con páginas Razor

**Example**
- https://github.com/LinkedInLearning/.NET7-ASP.NET-core-esencial-2493369/tree/main/demowebapp

## Creación de un proyecto web basado en páginas Razor y una página para mostrar las mascotas

- Interfaz 
- https://github.com/LinkedInLearning/.NET7-ASP.NET-core-esencial-2493369/blob/main/demowebapp/Pages/Pets.cshtml

- clase
- https://github.com/LinkedInLearning/.NET7-ASP.NET-core-esencial-2493369/blob/main/demowebapp/Pages/Pets.cshtml.cs

## Implementación de lógica para buscar mascotas por medio de su nombre

- Interfaz buscar 
- https://github.com/LinkedInLearning/.NET7-ASP.NET-core-esencial-2493369/blob/main/demowebapp/Pages/Pets.cshtml

## Implementación de una página para mostrar el detalle de una mascota
- Interfaz 
- https://github.com/LinkedInLearning/.NET7-ASP.NET-core-esencial-2493369/blob/main/demowebapp/Pages/PetDetails.cshtml

- Clase 
- https://github.com/LinkedInLearning/.NET7-ASP.NET-core-esencial-2493369/blob/main/demowebapp/Pages/PetDetails.cshtml.cs

## Modificación de la página Pets para navegar a la página PetDetails
- Interfaz 
- https://github.com/LinkedInLearning/.NET7-ASP.NET-core-esencial-2493369/blob/main/demowebapp/Pages/Shared/_Layout.cshtml

- Clase 
- No aplica 

## Creación de una página para editar los datos de una mascota
- Interfaz 
- https://github.com/LinkedInLearning/.NET7-ASP.NET-core-esencial-2493369/blob/main/demowebapp/Pages/PetEdit.cshtml

- Clase 
- https://github.com/LinkedInLearning/.NET7-ASP.NET-core-esencial-2493369/blob/main/demowebapp/Pages/PetEdit.cshtml.cs



