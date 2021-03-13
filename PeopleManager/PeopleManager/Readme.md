# C# Api Application


## Inyeccion de dependencias

Se modifica el siguiente metodo en la clase StartUp

~~~~

 public void ConfigureServices(IServiceCollection services)
        {
            // Inyeccion de dependencias
            services.AddControllers();
            services.AddSingleton<PeopleService,PeopleServiceImpl>();
        }

~~~