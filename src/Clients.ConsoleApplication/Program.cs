using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clients.ConsoleApplication
{
    using Autofac;

    public class Program
    {
        private static IContainer Container;

        public static void Main(string[] args)
        {
            Init();
            Start();
            End();

            Console.Read();
        }

        private static void Init()
        {
            Container = ContainerConfig.Configure();
        }

        private static void Start()
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();

                app.Run();
            }
        }

        private static void End()
        {
            Container.Dispose();
        }
    }
}
