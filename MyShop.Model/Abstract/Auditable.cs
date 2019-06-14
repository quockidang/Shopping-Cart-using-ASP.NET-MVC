using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Model.Abstract
{
    public abstract class Auditable :IAuditable
    {
       public DateTime? CreatedDate { set; get; }
       public string CreatedBy { set; get; }
       public DateTime? UpdateDate { set; get; }
       public string UpdateBy { set; get; }

        public string MetaKeyWord { set; get; }
        public string MetaDescription { set; get; }
        public bool Status { set; get; }
    }
}
