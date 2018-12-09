using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DomainEntity
{
    public class AutoPart
    {
        public AutoPart()
        {
            Countries=new List<Country>();
            Brands=new List<Brand>();
            Models=new List<AutoModel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }      
        public ICollection<Country> Countries { get; set; }
        public ICollection<Brand> Brands { get; set; }
        public ICollection<AutoModel> Models { get; set; }
    }
}
