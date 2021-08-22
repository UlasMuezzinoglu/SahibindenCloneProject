using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.concrete;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstact;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // IoC Yapısı Kurdum
            //For City
            builder.RegisterType<CityManager>().As<ICityService>();
            builder.RegisterType<EfCityDal>().As<ICityDal>();
            //For DeepType
            builder.RegisterType<DeedTypeManager>().As<IDeedTypeService>();
            builder.RegisterType<EfDeedTypeDal>().As<IDeedTypeDal>();
            //For FromWho
            builder.RegisterType<FromWhoManager>().As<IFromWhoService>();
            builder.RegisterType<EfFromWhoDal>().As<IFromWhoDal>();
            //For HeatingType
            builder.RegisterType<HeatingTypeManager>().As<IHeatingTypeService>();
            builder.RegisterType<EfHeatingTypeDal>().As<IHeatingTypeDal>();
            //For HouseType
            builder.RegisterType<HouseTypeManager>().As<IHouseTypeService>();
            builder.RegisterType<EfHouseTypeDal>().As<IHouseTypeDal>();
            //For House
            builder.RegisterType<HouseManager>().As<IHouseService>();
            builder.RegisterType<EfHouseDal>().As<IHouseDal>();






            // For User
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();
            // For Auth
            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();
            //


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
