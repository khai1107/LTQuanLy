using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PUBLIC;
using System.Data;

namespace QLKeToan.DAL
{
    public class MUAHANG_DAL
    {
        KETNOI ketnoi = new KETNOI();
        public DataTable load_muahang()
        {
            string sql = "LOAD_MUAHANG";
            return ketnoi.Load_Data(sql);
        }
        public int insert_muahang(MUAHANG_PUBLIC muahang_public)
        {
            int parameter = 5;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MASPMH";
            name[1] = "@TENSP";
            name[2] = "@SOLUONG";
            name[3] = "@NGAYMUA";
            name[4] = "@NGUOIMUA";
            values[0] = muahang_public.MASPMH;
            values[1] = muahang_public.TENSP;
            values[2] = muahang_public.SOLUONG;
            values[3] = muahang_public.NGAYMUA;
            values[4] = muahang_public.NGUOIMUA;
            string sql = "INSERT_MUAHANG";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public int update_muahang(MUAHANG_PUBLIC muahang_public)
        {
            int parameter = 5;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MASPMH";
            name[1] = "@TENSP";
            name[2] = "@SOLUONG";
            name[3] = "@NGAYMUA";
            name[4] = "@NGUOIMUA";
            values[0] = muahang_public.MASPMH;
            values[1] = muahang_public.TENSP;
            values[2] = muahang_public.SOLUONG;
            values[3] = muahang_public.NGAYMUA;
            values[4] = muahang_public.NGUOIMUA;
            string sql = "UPDATE_MUAHANG";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public int delete_muahang(MUAHANG_PUBLIC muahang_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MASPMH";
            values[0] = muahang_public.MASPMH;
            string sql = "DELETE_MUAHANG";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public DataTable Tim_hang(MUAHANG_PUBLIC muahang_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@TEN";
            values[0] = muahang_public.TIMHANG;
            string sql = "TIM_HANG";
            return ketnoi.LoadDataWithParameter(sql, name, values, parameter);
        }
    }
}
