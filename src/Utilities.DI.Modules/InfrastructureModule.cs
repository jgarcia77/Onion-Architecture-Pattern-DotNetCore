using System;
using System.Collections.Generic;
using System.Linq;
namespace Utilities.DI.Modules
{
    using Autofac;
    using ApplicationCore.Domain.Models;
    using ApplicationCore.Domain.Interfaces.Repositories;
    using Infrastructure.Repositories;

    public class InfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MessageConsoleRepository>().As<IRepository<Message>>();
        }
    }
}
