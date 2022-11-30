using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PUBLIC;
using System.Data;

namespace QLKeToan.DAL
{
    public class BANHANG_DAL
    {
        KETNOI ketnoi = new KETNOI();
        public DataTable load_banhang()
        {
            string sql = "LOAD_BANHANG";
            return ketnoi.Load_Data(sql);
        }
        public int insert_banhang(BANHANG_PUBLIC banhang_public)
        {
            int parameter = 5;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MASPBH";
            name[1] = "@TENSP";
            name[2] = "@SOLUONG";
            name[3] = "@NGAYBAN";
            name[4] = "@NGUOIBAN";      
            values[0] = banhang_public.MASPBH;
            values[1] = banhang_public.TENSP;
            values[2] = banhang_public.SOLUONG;
            values[3] = banhang_public.NGAYBAN;
            values[4] = banhang_public.NGUOIBAN;
            string sql = "INSERT_BANHANG";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public int update_banhang(BANHANG_PUBLIC banhang_public)
        {
            int parameter = 5;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MASPBH";
            name[1] = "@TENSP";
            name[2] = "@SOLUONG";
            name[3] = "@NGAYBAN";
            name[4] = "@NGUOIBAN";
            values[0] = banhang_public.MASPBH;
            values[1] = banhang_public.TENSP;
            values[2] = banhang_public.SOLUONG;
            values[3] = banhang_public.NGAYBAN;
            values[4] = banhang_public.NGUOIBAN;
            string sql = "UPDATE_BANHANG";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public int delete_banhang(BANHANG_PUBLIC banhang_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MASPBH";
            values[0] = banhang_public.MASPBH;
            string sql = "DELETE_BANHANG";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
    }
}
