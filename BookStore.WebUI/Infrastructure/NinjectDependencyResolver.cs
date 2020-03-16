using BookStore.Domain.Abstract;
using BookStore.Domain.Concrete;
using BookStore.Domain.Entities;
using Moq;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel ;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            // we add binding here
            //Mock<IBookRepository> mock = new Mock<IBookRepository>();
            //mock.Setup(b => b.Books).Returns(
            //    new List<Book>{new Book{Title="SQL Server DB",Price= 50M},
            //                                new Book{Title="ASP.NET MVC5", Price=90M},
            //                                new Book{Title="Web Client",Price=87M}
            //    });
            //kernel.Bind<IBookRepository>().ToConstant(mock.Object);
            kernel.Bind<IBookRepository>().To<EFBookRepository>();

        }

    }
}