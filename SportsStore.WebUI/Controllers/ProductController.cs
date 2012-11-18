using System.Linq;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;

namespace SportsStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        #region Public members

        // TODO:  Change this later.
        public int PageSize = 4;

        #endregion

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

        public ViewResult List(int page = 1)
        {
            // The Linq expression here provides us with paging.
            return View(repository.Products
                .OrderBy(p=>p.ProductId)
                .Skip((page-1)*PageSize)
                .Take(PageSize));
        }

        #endregion

    }
}
