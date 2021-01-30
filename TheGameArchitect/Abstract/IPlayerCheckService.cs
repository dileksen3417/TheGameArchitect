using System;
using System.Collections.Generic;
using System.Text;

namespace TheGameArchitect.Abstract
{
    interface IPlayerCheckService
    {
        bool CheckIfRealPerson(IPlayer player);
    }
}
