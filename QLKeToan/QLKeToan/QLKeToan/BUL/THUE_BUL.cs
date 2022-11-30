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
    class THUE_BUL
    {
        THUE_DAL thue_dal = new THUE_DAL();
        public DataTable load_thue()
        {
            return thue_dal.load_thue();
        }
        public int insert_thue(THUE_PUBLIC thue_public)
        {
            return thue_dal.insert_thue(thue_public);
        }
        public int update_thue(THUE_PUBLIC thue_public)
        {
            return thue_dal.update_thue(thue_public);
        }
        public int delete_thue(THUE_PUBLIC thue_public)
        {
            return thue_dal.delete_thue(thue_public);
        }
        public DataTable Tim_loaithue(THUE_PUBLIC thue_public)
        {
            return thue_dal.Tim_loaithue(thue_public);
        }
    }
}
