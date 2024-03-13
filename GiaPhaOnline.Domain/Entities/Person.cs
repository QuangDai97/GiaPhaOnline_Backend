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
        public string Id { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public DateTime Dob { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string FamilyId { get; set; }
        public string Address { get; set; }
        public string DadId { get; set; }
        public string MotherId { get; }
        public string VcId { get; }
        public Status Status { get; set; }
        public string CreateBy { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public Family Families { get; set; }
    }
}
