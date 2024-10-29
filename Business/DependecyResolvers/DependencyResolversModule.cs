using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependecyResolvers
{
    public class DependencyResolversModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Admin
            builder.RegisterType<AdminService>().As<IAdminService>().SingleInstance();
            builder.RegisterType<AdminDal>().As<IAdminDal>().SingleInstance();
        }
    }
}
