using SquidGame.Interfaces;

namespace SquidGame.Products
{
    public class Scissor : IProduct
    {
        private int _id;
        private string _name;

        public Scissor(int id,string name)
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
