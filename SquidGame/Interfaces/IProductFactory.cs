using System;
using System.Collections.Generic;
using System.Text;

namespace SquidGame.Interfaces
{
    public interface IProductFactory
    {
        IProduct CreateRock();
        IProduct CreatePaper();
        IProduct CreateScissor();
    }
}
