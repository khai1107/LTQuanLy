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
    class MUAHANG_BUL
    {
        MUAHANG_DAL muahang_dal = new MUAHANG_DAL();
        public DataTable load_muahang()
        {
            return muahang_dal.load_muahang();
        }
        public int insert_muahang(MUAHANG_PUBLIC muahang_public)
        {
            return muahang_dal.insert_muahang(muahang_public);
        }
        public int update_muahang(MUAHANG_PUBLIC muahang_public)
        {
            return muahang_dal.update_muahang(muahang_public);
        }
        public int delete_muahang(MUAHANG_PUBLIC muahang_public)
        {
            return muahang_dal.delete_muahang(muahang_public);
        }
        public DataTable Tim_hang(MUAHANG_PUBLIC muahang_public)
        {
            return muahang_dal.Tim_hang(muahang_public);
        }
    }
}
