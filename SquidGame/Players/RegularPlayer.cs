using SquidGame.Interfaces;
using SquidGame.ProductFactories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SquidGame.Players
{
    public class RegularPlayer : Player
    {
        public RegularPlayer(string name,int type) : base(name,type)
        {}
        private bool ValidateInput(List<IProduct> products,int selection)
        {
            if (products.Select(x => x.GetProductId()).Contains(selection))
                return true;
            else
                return false;
        }
        public override void SetPlayerChoice(ProductFactory productFactory)
        {
            foreach(IProduct product in productFactory.GetAllProducts())
            {
                Console.WriteLine("For {0} Select {1}\n", product.GetProductName(), product.GetProductId().ToString());
            }
            while (1 == 1)
            {
                var choice = Int32.Parse(Console.ReadLine());
                if(ValidateInput(productFactory.GetAllProducts(), choice))
                {
                    _currentChoice = choice;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Select Again\n");
                    continue;
                }

            }

        }

    }
}
