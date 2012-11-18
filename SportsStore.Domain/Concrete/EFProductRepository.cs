using System.Linq;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities; 

namespace SportsStore.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        #region Private Members

        private EFDbContext context = new EFDbContext();

        #endregion

        #region Properties

        public IQueryable<Product> Products
        {
            get
            {
                return context.Products;
            }
        }

        #endregion
    }
}
