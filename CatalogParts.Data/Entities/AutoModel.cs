using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DomainEntity
{
    public class AutoModel
    {
        public AutoModel()
        {
            Brands=new List<Brand>();
            AutoParts=new List<AutoPart>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Brand> Brands { get; set; }
        public ICollection<AutoPart> AutoParts { get; set; }
    }
}
