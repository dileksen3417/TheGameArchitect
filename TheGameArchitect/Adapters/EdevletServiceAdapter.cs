using System;
using System.Collections.Generic;
using System.Text;
using TheGameArchitect.Abstract;

namespace TheGameArchitect.Adapters
{
    public class EdevletServiceAdapter : IPlayerCheckService
    {
        public bool CheckIfRealPerson(IPlayer player)
        {
            if (player.FirstName == "Dilek" && player.NationalityId == "1111111")
            {
                return true;
            }
            else return false;

        }
    }
}
