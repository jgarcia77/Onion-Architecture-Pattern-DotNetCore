namespace Clients.ConsoleApplication
{
    using Autofac;
    using Utilities.DI.Modules;

    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new InfrastructureModule());

            builder.RegisterModule(new ServicesModule());

            builder.RegisterType<Application>().As<IApplication>();

            return builder.Build();
        }
    }
}
