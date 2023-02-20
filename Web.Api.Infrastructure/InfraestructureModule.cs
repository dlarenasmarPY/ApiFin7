using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Core.Interfaces.Gateways.Repositories;
using Web.Api.Infrastructure.Data.EntityFramework.Repositories;

namespace Web.Api.Infrastructure
{
    public class InfraestructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CuentasPorPagarRepository>().As<ICuentasPorPagarRepository>().InstancePerLifetimeScope();
        }
    }
}
