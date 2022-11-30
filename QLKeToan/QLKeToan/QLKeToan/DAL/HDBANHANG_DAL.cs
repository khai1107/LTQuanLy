using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PUBLIC;
using System.Data;

namespace QLKeToan.DAL
{
    class HDBANHANG_DAL
    {
        KETNOI ketnoi = new KETNOI();
        public DataTable load_hdbanhang()
        {
            string sql = "LOAD_HDBANHANG";
            return ketnoi.Load_Data(sql);
        }
        public int insert_hdbanhang(HDBANHANG_PUBLIC hdbanhang_public)
        {
            int parameter = 7;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAHD";
            name[1] = "@TENSP";
            name[2] = "@SOLUONG";
            name[3] = "@NGAYBAN";
            name[4] = "@NGUOIBAN";
            name[5] = "@GIA";
            name[6] = "@TONG";
            values[0] = hdbanhang_public.MAHD;
            values[1] = hdbanhang_public.TENSP;
            values[2] = hdbanhang_public.SOLUONG;
            values[3] = hdbanhang_public.NGAYBAN;
            values[4] = hdbanhang_public.NGUOIBAN;
            values[5] = hdbanhang_public.GIA;
            values[6] = hdbanhang_public.TONG;
            string sql = "INSERT_HDBANHANG";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public int update_hdbanhang(HDBANHANG_PUBLIC hdbanhang_public)
        {
            int parameter = 7;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAHD";
            name[1] = "@TENSP";
            name[2] = "@SOLUONG";
            name[3] = "@NGAYBAN";
            name[4] = "@NGUOIBAN";
            name[5] = "@GIA";
            name[6] = "@TONG";
            values[0] = hdbanhang_public.MAHD;
            values[1] = hdbanhang_public.TENSP;
            values[2] = hdbanhang_public.SOLUONG;
            values[3] = hdbanhang_public.NGAYBAN;
            values[4] = hdbanhang_public.NGUOIBAN;
            values[5] = hdbanhang_public.GIA;
            values[6] = hdbanhang_public.TONG;
            string sql = "UPDATE_HDBANHANG";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public int delete_hdbanhang(HDBANHANG_PUBLIC hdbanhang_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAHD";
            values[0] = hdbanhang_public.MAHD;
            string sql = "DELETE_HDBANHANG";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public DataTable Tim_hdbh(HDBANHANG_PUBLIC hdbanhang_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAHD";
            values[0] = hdbanhang_public.TIMHDBH;
            string sql = "TIM_HDBH";
            return ketnoi.LoadDataWithParameter(sql, name, values, parameter);
        }
    }
}
