using GiaPhaOnline.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaPhaOnline.Domain.Entities
{
    public class Family
    {
        public string Id { get; set; }
        public Status Status { get; set; }
        public int CreateBy { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public virtual List<Person> People { get; set; }

    }
}
