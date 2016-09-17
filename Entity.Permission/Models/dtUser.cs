using System;
using System.Collections.Generic;

namespace Entity.Permission.Models
{
    public partial class dtUser
    {
        public int Iden { get; set; }
        public int UserID { get; set; }
        public Nullable<int> StatusID { get; set; }
        public string UserName { get; set; }
        public System.Guid GUID { get; set; }
        public int CreatedByID { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public int UpdatedByID { get; set; }
        public System.DateTime UpdatedTime { get; set; }
        public string Remark { get; set; }
        public virtual dtStatu dtStatu { get; set; }
    }
}
