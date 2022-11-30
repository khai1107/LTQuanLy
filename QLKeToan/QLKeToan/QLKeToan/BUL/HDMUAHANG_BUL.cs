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
    class HDMUAHANG_BUL
    {
        HDMUAHANG_DAL hdmuahang_dal = new HDMUAHANG_DAL();
        public DataTable load_hdmuahang()
        {
            return hdmuahang_dal.load_hdmuahang();
        }
        public int insert_hdmuahang(HDMUAHANG_PUBLIC hdmuahang_public)
        {
            return hdmuahang_dal.insert_hdmuahang(hdmuahang_public);
        }
        public int update_hdmuahang(HDMUAHANG_PUBLIC hdmuahang_public)
        {
            return hdmuahang_dal.update_hdmuahang(hdmuahang_public);
        }
        public int cancel_hdmuahang(HDMUAHANG_PUBLIC hdmuahang_public)
        {
            return hdmuahang_dal.delete_hdmuahang(hdmuahang_public);
        }
        public DataTable Tim_hd(HDMUAHANG_PUBLIC hdmuahang_public)
        {
            return hdmuahang_dal.Tim_hd(hdmuahang_public);
        }
    }
}
