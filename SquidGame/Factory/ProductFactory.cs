using SquidGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SquidGame.ProductFactories
{
    public class ProductFactory
    {
        private IProductFactory _productFactory;
        private List<IProduct> _products = new List<IProduct>();

        public ProductFactory(IProductFactory productFactory)
        {
            _productFactory = productFactory;
        }

        public void CreateSquidGameProducts()
        {
            _products.Add(_productFactory.CreateRock());
            _products.Add(_productFactory.CreatePaper());
            _products.Add(_productFactory.CreateScissor());
        }

        public List<IProduct> GetAllProducts()
        {
            return _products;
        }
    }
}
