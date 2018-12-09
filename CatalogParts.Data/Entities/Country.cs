using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DomainEntity
{
    public class Country
    {
        public Country()
        {
            AutoParts = new List<AutoPart>();
            Brands = new List<Brand>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<AutoPart> AutoParts { get; set; }
        public ICollection<Brand> Brands { get; set; }
    }
}
