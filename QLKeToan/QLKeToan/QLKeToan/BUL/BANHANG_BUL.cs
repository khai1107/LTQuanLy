using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKeToan.DAL;
using PUBLIC;
using System.Data;

namespace BUL
{
    class BANHANG_BUL
    {
        BANHANG_DAL banhang_dal = new BANHANG_DAL();
        public DataTable load_banhang()
        {
            return banhang_dal.load_banhang();
        }
        public int insert_banhang(BANHANG_PUBLIC banhang_public)
        {
            return banhang_dal.insert_banhang(banhang_public);
        }
        public int update_banhang(BANHANG_PUBLIC banhang_public)
        {
            return banhang_dal.update_banhang(banhang_public);
        }
        public int delete_banhang(BANHANG_PUBLIC banhang_public)
        {
            return banhang_dal.delete_banhang(banhang_public);
        }
    }
}
