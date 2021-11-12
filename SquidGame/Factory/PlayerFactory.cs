using SquidGame.Interfaces;
using SquidGame.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace SquidGame.Factory
{
    public class PlayerFactory 
    {
        private IPlayerFactory _playerFactory;
        private List<Player> _players = new List<Player>();
        public PlayerFactory(IPlayerFactory playerFactory)
        {
            _playerFactory = playerFactory;
        }

        public void BuildHumanVsHumanPlayers()
        {
            _players.Add(_playerFactory.CreateRegularPlayer("Player 1"));
            _players.Add(_playerFactory.CreateRegularPlayer("Player 2"));
        }

        public void BuildHumanVsComputerPlayers()
        {
            _players.Add(_playerFactory.CreateRegularPlayer("Player 1"));
            _players.Add(_playerFactory.CreateComputerPlayer("Computer"));
        }

        public List<Player> GetAllPlayers()
        {
            return _players;
        }
    }
}
