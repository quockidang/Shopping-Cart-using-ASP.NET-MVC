using MyShop.Data.Infrastructer;
using MyShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Data.Repository
{
    public interface IProductRepository
    {

    }
    public class ProductRepository : RepositoryBase<Product>
    {
        public ProductRepository(IDbFactory dbFactory): base(dbFactory)
        {

        }
    }
}
