using GiaPhaOnline.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaPhaOnline.Domain.Entities
{
    public class DongHo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Address{ get; set; }
        public string Description { get; set; }
        public DateTime Dob { get; set; }
        public Status Status { get; set; }  
        public int ModifyBy { get; set; }
        public DateTime ModifyDate { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateBy { get; set; }

        public List<UserInfo> UserInfos { get; set; }

    }
}
