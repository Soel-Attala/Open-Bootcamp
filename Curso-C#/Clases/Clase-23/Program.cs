// DEPENDENCY INJECTION
/*
  We generally use a main (program.cs) to delegate all our tasks and procedures.
  With injected dependencies we will have sectioned processes and we won't need to 
  repeat our code multiple times for everything.

  We can have multiple services injected to our main.

  This is generally used in larger projects.
  For the moment we are only doing small console projects.
*/


using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

//Now we gonna create a host object and a builder
/*
 Here we add singleton, transient, scoped these are our services. 
 Or the services we are using at the moment.
    * 1. We specify the service to be used.
    * 2. It will create the object based on this service.
    * 3. We indicate the interface that we will be using in each case.
    * 4. Finally, we indicate the class on which the interface is based.

*/
using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
    services.AddTransient<ITransientOperation, DefaultOperation>()
    .AddScoped<IScopedOperation, DefaultOperation>()
    .AddSingleton<ISingletonOperation, DefaultOperation>()
    .AddTransient<OperationLogger>())
    .Build();

/*
Then we will create methods that will perform the action we need.
Each method will use a service, either: singleton, scoped, or transient.
Each service will create an object with the characteristics of the service:

    * Transient: will be the object that is used and then discarded.
    * Scoped: it is the one that lasts the longest, and as long as it remains relevant it will continue to exist.
    * Singleton: It exists during the whole execution period of our program.

*/


ScopesExamples(host.Services, "Scope 1");
ScopesExamples(host.Services, "Scope 2");

await host.StartAsync(); //async starter
static void ScopesExamples(IServiceProvider services, string scope)
{
    using IServiceScope serviceScope = services.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;
    OperationLogger logger = provider.GetRequiredService<OperationLogger>();
    logger.LogOperations($"{scope}: - Executing ... GetRequiredService<OperationLogger>()");

    Console.WriteLine();

    /*logger = provider.GetRequiredService<OperationLogger>();
      logger.LogOperations($"{scope}: - Executing ... GetRequiredService<OperationLogger>()");

      Console.WriteLine();
    */
}


