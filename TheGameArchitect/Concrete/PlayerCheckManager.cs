using System;
using System.Collections.Generic;
using System.Text;
using TheGameArchitect.Abstract;

namespace TheGameArchitect.Concrete
{
    public class PlayerCheckManager : IPlayerCheckService
    {
        public bool CheckIfRealPerson(IPlayer player)
        {
            return false;
        }
    }
}
