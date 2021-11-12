using SquidGame.Interfaces;
using SquidGame.Products;

namespace SquidGame.ProductFactories
{
    public class ProductCreator : IProductFactory
    {
        public IProduct CreateRock()
        {
            return new Rock(1,"Rock");
        }

        public IProduct CreatePaper()
        {
            return new Paper(2,"Paper");
        }

        public IProduct CreateScissor()
        {
            return new Scissor(3,"Scissor");
        }
    }
}
