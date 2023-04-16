using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstract_InterFace
{
    public interface IAuditTable
    {
        DateTime? CreatedDate { set; get; }
        string CreatedBy { get; set; }
        DateTime? UpdateDate { set; get; }
        string UpdateBy { set; get; }

        string MetaKeyWord { set; get; }
        string MetaDescription { get; set; }

        bool Status { get; set; }
    }
}
