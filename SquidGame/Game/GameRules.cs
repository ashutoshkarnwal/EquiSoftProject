using SquidGame.Enums;
using SquidGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SquidGame.Game
{
    public class GameRules
    {
        private List<Rule> rules;

        public GameRules()
        {
            rules = new List<Rule>();
        }

        public void BuildGameRules()
        {
            rules.Add(new Rule(ProductTypeEnum.Rock, ProductTypeEnum.Rock, false, false));
            rules.Add(new Rule(ProductTypeEnum.Paper, ProductTypeEnum.Paper, false, false));
            rules.Add(new Rule(ProductTypeEnum.Scissor, ProductTypeEnum.Scissor, false, false));
            rules.Add(new Rule(ProductTypeEnum.Rock, ProductTypeEnum.Paper, false, true));
            rules.Add(new Rule(ProductTypeEnum.Paper, ProductTypeEnum.Rock, true, false));
            rules.Add(new Rule(ProductTypeEnum.Scissor, ProductTypeEnum.Rock, false, true));
            rules.Add(new Rule(ProductTypeEnum.Rock, ProductTypeEnum.Scissor, true, true));
            rules.Add(new Rule(ProductTypeEnum.Paper, ProductTypeEnum.Scissor, false, true));
            rules.Add(new Rule(ProductTypeEnum.Scissor, ProductTypeEnum.Paper, true, false));
        }

        public (bool,bool) GetWinner(ProductTypeEnum player1Choice, ProductTypeEnum player2Choice)
        {
            Rule rule = rules.First(x => x._player1Choice == player1Choice && x._player2Choice == player2Choice);
            return (rule._isPlayer1Win, rule._isPlayer2Win);
        }
    }
}
