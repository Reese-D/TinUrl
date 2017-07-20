using Microsoft.Owin;
using Owin;
using System.Web.Mvc;
using StructureMap;
using Domain.Library.Repositories;
using Domain.Implementation.Repositories;
using DependencyInjection;
using Domain.AppData;
using Domain.Library.Services;
using Domain.Implementation.Services;

[assembly: OwinStartupAttribute(typeof(WebApplication1.Startup))]
namespace WebApplication1
{
    public partial class Startup
    {

        protected LinqToSqlDataDataContext DataContext { get; set; }
        public void Configuration(IAppBuilder app)
        {
            DataContext = new LinqToSqlDataDataContext();
            InitializeContainer();
            ConfigureAuth(app);
        }

        public void InitializeContainer()
        {
            var container = new Container(x =>
            {
                x.For<IUserRepository>().Use<UserRepository>();
                x.For<IUserService>().Use<UserService>();
                x.For<LinqToSqlDataDataContext>().Use(DataContext);
            });
            DependencyResolver.SetResolver(new TinyUrlDependencyResolver(container));
        }
    }
}
