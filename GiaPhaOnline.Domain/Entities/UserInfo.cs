using GiaPhaOnline.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaPhaOnline.Domain.Entities
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public DateTime Dob { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int DongHoId { get; set; }
        public string Address { get; set; }
        public int Dad_ID { get; set; }
        public int Mother_ID { get; }
        public int VC_ID { get; }
        public Status Status { get; set; }
        public DateTime ModifyDate { get; set; }
        public DateTime CreateDate { get; set; }
        public int ModifyBy { get; set; }
        public int CreateBy { get; set; }
        public DongHo DongHo { get; set; }
    }
}
