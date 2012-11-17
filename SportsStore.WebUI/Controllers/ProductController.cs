using System.Linq;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;

namespace SportsStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        #region Private members

        private IProductRepository repository;

        #endregion

        #region Constructors

        public ProductController(IProductRepository productRepository)
        {
            repository = productRepository;
        }

        #endregion

        #region Public Methods

        public ViewResult List()
        {
            return View(repository.Products);
        }

        #endregion

    }
}
