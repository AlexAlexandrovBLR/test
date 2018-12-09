using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DomainEntity
{
    public class Brand
    {
        public Brand()
        {
            Feedbacks=new List<Feedback>();
            AutoParts=new List<AutoPart>();
            Countries=new List<Country>();
            Models=new List<AutoModel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Logo { get; set; }
        public string Info { get; set; }
        public string ImageType { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public ICollection<Feedback> Feedbacks { get; set; }
        public ICollection<AutoPart> AutoParts { get; set; }
        public ICollection<Country> Countries { get; set; }
        public ICollection<AutoModel> Models { get; set; }
    }
}
