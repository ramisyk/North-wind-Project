using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IResult Add(Product product);
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id);
        List<Product> GetAllByUnitPrice(decimal min, decimal max);
        List<ProductDetailDto> GetProductDetails();
        Product GetById(int productId);
    }
}
