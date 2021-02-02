using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _producatDal;
        public ProductManager(IProductDal productDal)
        {
            _producatDal = productDal;
        }
        public List<Product> GetAll()
        {
            return _producatDal.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _producatDal.GetList(p=>p.CategoryId == categoryId);
        }
        public Product GetById(int productId)
        {
            return _producatDal.Get(p => p.ProductId == productId);
        }
    }
}
