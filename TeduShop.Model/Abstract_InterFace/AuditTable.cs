using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstract_InterFace
{
    public abstract class AuditTable : IAuditTable//Tao 1 lop ao (Abstract)
    {
       public DateTime? CreatedDate { set; get; }
       [MaxLength(256)]
       public string CreatedBy { get; set; }
       public DateTime? UpdateDate { set; get; }
        [MaxLength(256)]
        public string UpdateBy { set; get; }

        [MaxLength(256)]
        public string MetaKeyWord { set; get; }
        [MaxLength(256)]
        public string MetaDescription { get; set; }

        public bool Status { get; set; }
    }
}
