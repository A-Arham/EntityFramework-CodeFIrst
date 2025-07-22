using ENtityFramework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Domain
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int LeagueID { get; set; }
        public virtual League League { get; set; }

    }
}
