using SquidGame.Interfaces;
using SquidGame.ProductFactories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SquidGame.Players
{
    public class ComputerPlayer : Player
    {
        public string _Name { get; set; }
        public int _Type { get; set; }
        private int _PreviousChoice { get; set; }
        private Dictionary<int, int> rules = new Dictionary<int, int>();

        public ComputerPlayer(string name, int type) : base(name, type)
        {
            BuildSelectionRules();
            _PreviousChoice = 3;
        }

        private void BuildSelectionRules()
        {
            rules.Add(1, 2);
            rules.Add(2, 3);
            rules.Add(3, 1);
        }

        public override void SetPlayerChoice(ProductFactory productFactory)
        {
            foreach (IProduct product in productFactory.GetAllProducts())
            {
                Console.WriteLine("For {0} Select {1}\n", product.GetProductName(), product.GetProductId().ToString());
            }

            _currentChoice = rules[_PreviousChoice];
            _PreviousChoice = _currentChoice;
        }

    }
}
