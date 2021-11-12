using SquidGame.Interfaces;
using SquidGame.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace SquidGame.Factory
{
    public class PlayerCreator : IPlayerFactory
    {
        public Player CreateRegularPlayer(string Name)
        {
            return new RegularPlayer(Name,1);
        }
        public Player CreateComputerPlayer(string Name)
        {
            return new ComputerPlayer(Name, 2);
        }
    }
}
