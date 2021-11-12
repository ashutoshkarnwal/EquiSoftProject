using SquidGame.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SquidGame.Game
{
    
    public class Rule
    {
        public ProductTypeEnum _player1Choice;
        public ProductTypeEnum _player2Choice;
        public bool _isPlayer1Win;
        public bool _isPlayer2Win;

        public Rule(ProductTypeEnum player1Choice,
                    ProductTypeEnum player2Choice,
                    bool isPlayer1Win,
                    bool isPlayer2Win)
        {
            _player1Choice = player1Choice;
            _player2Choice = player2Choice;
            _isPlayer1Win = isPlayer1Win;
            _isPlayer2Win = isPlayer2Win;
    }
    }
}
