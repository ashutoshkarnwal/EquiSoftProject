using System;
using System.Collections.Generic;
using System.Text;

namespace SquidGame.Interfaces
{
    public interface IPlayerFactory
    {
        Player CreateRegularPlayer(string Name);
        Player CreateComputerPlayer(string Name);
    }
}
