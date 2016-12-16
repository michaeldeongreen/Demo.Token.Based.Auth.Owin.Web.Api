using StructureMap.Configuration.DSL;
using StructureMap.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Token.Based.Auth.Owin.Web.Api.Repository
{
    public class RepositoryRegistry : Registry
    {
        public RepositoryRegistry()
        {
            Scan(
                scan => {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                });
            For<AuthenticationContext>().Use<AuthenticationContext>().Ctor<string>().Is("AuthenticationContext");
            For<AuthenticationRepository>().Use<AuthenticationRepository>();
        }
    }
}
