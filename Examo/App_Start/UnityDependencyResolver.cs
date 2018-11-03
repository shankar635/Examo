using System.Web.Mvc;
using Unity;

namespace Examo
{
    internal class UnityDependencyResolver : IDependencyResolver
    {
        private UnityContainer container;

        public UnityDependencyResolver(UnityContainer container)
        {
            this.container = container;
        }
    }
}