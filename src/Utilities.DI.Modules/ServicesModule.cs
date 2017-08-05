namespace Utilities.DI.Modules
{
    using Autofac;
    using ApplicationCore.Services.Interfaces;
    using ApplicationCore.Services;

    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MessageService>().As<IMessageService>();
        }
    }
}
