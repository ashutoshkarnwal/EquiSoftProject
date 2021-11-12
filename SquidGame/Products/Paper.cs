using SquidGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SquidGame.Products
{
    public class Paper : IProduct
    {
        private int _id;
        private string _name;
        
        public Paper(int id,string name)
        {
            _id = id;
            _name = name;
        }

        public string GetProductName()
        {
            return _name;
        }

        public int GetProductId()
        {
            return _id;
        }
    }
}
