using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PUBLIC;
using System.Data;

namespace QLKeToan.DAL
{
    class HDMUAHANG_DAL
    {
        KETNOI ketnoi = new KETNOI();
        public DataTable load_hdmuahang()
        {
            string sql = "LOAD_HDMUAHANG";
            return ketnoi.Load_Data(sql);
        }
        public int insert_hdmuahang(HDMUAHANG_PUBLIC hdmuahang_public)
        {
            int parameter = 7;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAHDMH";
            name[1] = "@TENSP";
            name[2] = "@SOLUONG";
            name[3] = "@NGAYMUA";
            name[4] = "@NGUOIMUA";
            name[5] = "@GIA";
            name[6] = "@TONG";
            values[0] = hdmuahang_public.MAHDMH;
            values[1] = hdmuahang_public.TENSP;
            values[2] = hdmuahang_public.SOLUONG;
            values[3] = hdmuahang_public.NGAYMUA;
            values[4] = hdmuahang_public.NGUOIMUA;
            values[5] = hdmuahang_public.GIA;
            values[6] = hdmuahang_public.TONG;
            string sql = "INSERT_HDBMUAHANG";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public int update_hdmuahang(HDMUAHANG_PUBLIC hdmuahang_public)
        {
            int parameter = 7;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAHDMH";
            name[1] = "@TENSP";
            name[2] = "@SOLUONG";
            name[3] = "@NGAYMUA";
            name[4] = "@NGUOIMUA";
            name[5] = "@GIA";
            name[6] = "@TONG";
            values[0] = hdmuahang_public.MAHDMH;
            values[1] = hdmuahang_public.TENSP;
            values[2] = hdmuahang_public.SOLUONG;
            values[3] = hdmuahang_public.NGAYMUA;
            values[4] = hdmuahang_public.NGUOIMUA;
            values[5] = hdmuahang_public.GIA;
            values[6] = hdmuahang_public.TONG;
            string sql = "UPDATE_HDBMUAHANG";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public int delete_hdmuahang(HDMUAHANG_PUBLIC hdmuahang_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAHDMH";
            values[0] = hdmuahang_public.MAHDMH;
            string sql = "DELETE_HDMUAHANG";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public DataTable Tim_hd(HDMUAHANG_PUBLIC hdmuahang_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAHDMH";
            values[0] = hdmuahang_public.TIMHD;
            string sql = "TIM_HD";
            return ketnoi.LoadDataWithParameter(sql, name, values, parameter);
        }
    }
}
