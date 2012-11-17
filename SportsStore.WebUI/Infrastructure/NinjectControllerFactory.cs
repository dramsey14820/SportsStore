using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;

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
        }

        #endregion
    }
}