using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKeToan.DAL;

namespace QLKeToan.BUL
{
    class GANGIATRISQL_BUL
    {

        GANGIATRISQL_DAL gangiatri_dal = new GANGIATRISQL_DAL();
        public GANGIATRISQL_BUL(string s, string s1)
        {
            gangiatri_dal.gangiatri(s, s1);
        }
    }
}
