using MyShop.Data.Infrastructer;
using MyShop.Data.Repository;
using MyShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Service
{
    public interface IProductCategryService
    {
        ProductCategory Add(ProductCategory productCategory);
    }
    public class ProductCategoryService : IProductCategryService
    {
        private IProductCategoryRepository _productCategryRepository;
        private IUnitOfWork _unitOfWork;

        public ProductCategoryService(IProductCategoryRepository ProductCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._productCategryRepository = ProductCategoryRepository;
            this._unitOfWork = unitOfWork;
        }

        public ProductCategory Add(ProductCategory productCategory)
        {
            return _productCategryRepository.
        }
    }
}
