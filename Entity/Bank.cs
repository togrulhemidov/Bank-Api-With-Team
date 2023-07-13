using System.Collections;
using System.Collections.Generic;

namespace Bank_App_With_Team.Entity
{
    public class Bank
    {
        public int id { get; set; }
        public string Name { get; set; }

        public ICollection<Card> Cards { get; set; }

    }
}
