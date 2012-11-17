using System.Linq;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Abstract
{
    public interface IProductRepository
    {

        #region Properties

        IQueryable<Product> Products { get; }

        #endregion
    }
}
