using System;
using System.Collections.Generic;
using System.Text;

namespace TheGameArchitect
{
    public interface IPlayer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
        public int AuthorityId { get; set; }
    }
}
