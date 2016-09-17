using System;
using System.Collections.Generic;

namespace Entity.Permission.Models
{
    public partial class dtSystem
    {
        public int Iden { get; set; }
        public int SystemID { get; set; }
        public string SystemName { get; set; }
        public int StatusID { get; set; }
        public int CreatedByID { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public int UpdatedByID { get; set; }
        public System.DateTime UpdatedTime { get; set; }
        public string Remark { get; set; }
        public virtual dtStatu dtStatu { get; set; }
    }
}
