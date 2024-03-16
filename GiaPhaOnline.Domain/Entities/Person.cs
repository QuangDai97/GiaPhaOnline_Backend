using GiaPhaOnline.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaPhaOnline.Domain.Entities
{
    public class Person
    {
        public string Id { get; set; } = Ulid.NewUlid().ToString();
        public string FullName { get; set; }
        public DateTime Dob { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string FamilyId { get; set; }
        public string Address { get; set; }
        public string DadId { get; set; }
        public string MotherId { get; }
        public Status Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public Family Family { get; set; }
    }
}
