using System;
using System.Collections.Generic;

namespace Entity.Permission.Models
{
    public partial class dtStatu
    {
        public dtStatu()
        {
            this.dtSysDicts = new List<dtSysDict>();
            this.dtSystems = new List<dtSystem>();
            this.dtUsers = new List<dtUser>();
        }

        public int Iden { get; set; }
        public int StatusID { get; set; }
        public string StatusName { get; set; }
        public Nullable<int> SelfStatusID { get; set; }
        public Nullable<int> SysDictID { get; set; }
        public Nullable<int> CreatedByID { get; set; }
        public System.DateTime CreatedByTime { get; set; }
        public Nullable<int> UpdatedByID { get; set; }
        public System.DateTime UpdatedTime { get; set; }
        public string Remark { get; set; }
        public virtual ICollection<dtSysDict> dtSysDicts { get; set; }
        public virtual ICollection<dtSystem> dtSystems { get; set; }
        public virtual ICollection<dtUser> dtUsers { get; set; }
    }
}
