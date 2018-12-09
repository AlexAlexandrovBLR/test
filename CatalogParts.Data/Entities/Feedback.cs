using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DomainEntity
{
    public class Feedback
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string Description { get; set; }
        public byte [] FeetbackImage { get; set; }

        public Brand Brand { get; set; }
    }
}
