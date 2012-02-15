using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBSSportsDotNet.Models
{
    public class Player
    {
        public long ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string ProStatus { get; set; }
        public string Fullname { get; set; }
        public string ProTeam { get; set; }

        public List<Icon> Icons { get; set; }
    }
}
