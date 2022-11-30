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
    class HDBANHANG_BUL
    {
        HDBANHANG_DAL hdbanhang_dal = new HDBANHANG_DAL();
        public DataTable load_hdbanhang()
        {
            return hdbanhang_dal.load_hdbanhang();
        }
        public int insert_hdbanhang(HDBANHANG_PUBLIC hdbanhang_public)
        {
            return hdbanhang_dal.insert_hdbanhang(hdbanhang_public);
        }
        public int update_hdbanhang(HDBANHANG_PUBLIC hdbanhang_public)
        {
            return hdbanhang_dal.update_hdbanhang(hdbanhang_public);
        }
        public int cancel_hdbanhang(HDBANHANG_PUBLIC hdbanhang_public)
        {
            return hdbanhang_dal.delete_hdbanhang(hdbanhang_public);
        }
        public DataTable Tim_hdbh(HDBANHANG_PUBLIC hdbanhang_public)
        {
            return hdbanhang_dal.Tim_hdbh(hdbanhang_public);
        }
    }
}
