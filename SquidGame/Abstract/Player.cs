using SquidGame.ProductFactories;
using System;
using System.Collections.Generic;
using System.Text;
using SquidGame.Enums;

namespace SquidGame.Interfaces
{
    public abstract class Player
    {
        private int _winningCount;
        public int _currentChoice { get; set; }
        public string _Name { get; set; }
        public int _Type { get; set; }

        public Player(string name, int type)
        {
            _Name = name;
            _Type = type;
        }

        public void UpdateWinningCount()
        {
            _winningCount++;
        }

        public int GetWinningCount()
        {
            return _winningCount;
        }

        public ProductTypeEnum GetSelectedItem()
        {
            return (ProductTypeEnum)_currentChoice;
        }

        public abstract void SetPlayerChoice(ProductFactory productFactory);

    }
}
