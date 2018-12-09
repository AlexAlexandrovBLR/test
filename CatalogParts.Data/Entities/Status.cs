using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DomainEntity
{
    public class Status
    {
        public Status()
        {
            Brands=new List<Brand>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Brand> Brands { get; set; }
    }
}
