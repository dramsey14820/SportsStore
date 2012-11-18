using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using SportsStore.Domain.Abstract;
using System.Linq;
using Moq;
using System.Collections.Generic;
using SportsStore.Domain.Entities;
using SportsStore.Domain.Concrete;

namespace SportsStore.WebUI.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        #region private members

        private IKernel ninjectKernel;

        #endregion

        #region Constructors

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        #endregion

        #region Protected Methods

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
            //return base.GetControllerInstance(requestContext, controllerType);
        }

        #endregion

        #region Private Methods

        private void AddBindings()
        {
            // TODO:  Put additional bindings here!!!

            ninjectKernel.Bind<IProductRepository>().To<EFProductRepository>();

            // Mock implementation of the IProductRepository Interface
            //Mock<IProductRepository> mock = new Mock<IProductRepository>();
            //mock.Setup(m => m.Products).Returns(new List<Product>
            //    {
            //        new Product {Name="Football", Price = 25 },
            //        new Product {Name="Surf Board", Price = 179 },
            //        new Product {Name="Running Shoes", Price = 95 }
            //    }.AsQueryable());
            //ninjectKernel.Bind<IProductRepository>().ToConstant(mock.Object);
        }

        #endregion
    }
}