using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PUBLIC;

namespace QLKeToan.DAL
{
    public class THUE_DAL
    {
        KETNOI ketnoi = new KETNOI();
        public DataTable load_thue()
        {
            string sql = "LOAD_THUE";
            return ketnoi.Load_Data(sql);
        }
        public int insert_thue(THUE_PUBLIC thue_public)
        {
            int parameter = 5;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MATHUE";
            name[1] = "@MAHD";
            name[2] = "@LOAITHUE";
            name[3] = "@TRANGTHAI";
            name[4] = "@TONGCHIPHI";          
            values[0] = thue_public.MATHUE;
            values[1] = thue_public.MAHD;
            values[2] = thue_public.LOAITHUE;
            values[3] = thue_public.TRANGTHAI;
            values[4] = thue_public.TONGCHIPHI;           
            string sql = "INSERT_THUE";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public int update_thue(THUE_PUBLIC thue_public)
        {
            int parameter = 5;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MATHUE";
            name[1] = "@MAHD";
            name[2] = "@LOAITHUE";
            name[3] = "@TRANGTHAI";
            name[4] = "@TONGCHIPHI";
            values[0] = thue_public.MATHUE;
            values[1] = thue_public.MAHD;
            values[2] = thue_public.LOAITHUE;
            values[3] = thue_public.TRANGTHAI;
            values[4] = thue_public.TONGCHIPHI;
            string sql = "UPDATE_THUE";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public int delete_thue(THUE_PUBLIC thue_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MATHUE";
            values[0] = thue_public.MATHUE;
            string sql = "DELETE_THUE";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public DataTable Tim_loaithue(THUE_PUBLIC thue_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@LOAITHUE";
            values[0] = thue_public.TIMLOAITHUE;
            string sql = "TIM_LOAITHUE";
            return ketnoi.LoadDataWithParameter(sql, name, values, parameter);
        }
    }
}
