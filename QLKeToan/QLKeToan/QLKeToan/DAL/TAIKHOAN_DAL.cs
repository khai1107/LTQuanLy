using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PUBLIC;
using System.Data;

namespace QLKeToan.DAL
{
    public class TAIKHOAN_DAL
    {
        KETNOI ketnoi = new KETNOI();   //gọi class Kết nối
        public DataTable load_taikhoan()    //load tên tài khoản
        {
            string sql = "LOAD_TAIKHOAN"; //kết nối đến storedProcedure trong sql vs tên storedProcedure là LOAD_TAIKHOAN
            return ketnoi.Load_Data(sql); //load dữ liệu trong class kết nối đã gọi
        }
        //đọc tên và quyền của tài khoản
        public DataTable get_tenvaquyen_taikhoan(TAIKHOAN_PUBLIC taikhoan_public)
        {
            int parameter = 2; //cho giá trị parameter là 2
            string[] name = new string[parameter]; //khai báo mảng name để đọc tên tài khoản và mật khẩu
            object[] values = new object[parameter];   //khai báo mảng để đọc giá trị của tài khoản và mật khẩu
            name[0] = "@TENTK"; //truyền tham số parameter vào mảng name
            name[1] = "@MATKHAU";
            values[0] = taikhoan_public.TENTK;  //truyền biến từ class tài khoản trong project PUBLIC vào mảng giá trị
            values[1] = taikhoan_public.MATKHAU;
            string sql = "GET_TENVAQUYEN_TAIKHOAN"; //kết nối đến storedProcedure trong sql vs tên storedProcedure là GET_TENVAQUYEN_TAIKHOAN
            return ketnoi.LoadDataWithParameter(sql, name, values, parameter);
            //trả giá trị về vs đường dẫn kết nối, tên tham số, giá trị, và giá trị parameter
        }
        //Thêm tài khoản
        public int insert_taikhoan(TAIKHOAN_PUBLIC taikhoan_public)
        {
            int parameter = 4;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@TENTK";
            name[1] = "@MATKHAU";
            name[2] = "@QUYEN";
            name[3] = "@IDNV";
            values[0] = taikhoan_public.TENTK;
            values[1] = taikhoan_public.MATKHAU;
            values[2] = taikhoan_public.QUYEN;
            values[3] = taikhoan_public.IDNV;
            string sql = "INSERT_TAIKHOAN";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        //cập nhật lại tài khoản
        public int update_taikhoan(TAIKHOAN_PUBLIC taikhoan_public)
        {
            int parameter = 4;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@TENTK";
            name[1] = "@MATKHAU";
            name[2] = "@QUYEN";
            name[3] = "@IDNV";
            values[0] = taikhoan_public.TENTK;
            values[1] = taikhoan_public.MATKHAU;
            values[2] = taikhoan_public.QUYEN;
            values[3] = taikhoan_public.IDNV;
            string sql = "UPDATE_TAIKHOAN";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        //xóa tài khoản
        public int delete_taikhoan(TAIKHOAN_PUBLIC taikhoan_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@TENTK";
            values[0] = taikhoan_public.TENTK;
            string sql = "DELETE_TAIKHOAN";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public int check_taikhoan(TAIKHOAN_PUBLIC taikhoan_public)
        {
            int parameter = 2;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@TENTK";
            name[1] = "@MATKHAU";
            values[0] = taikhoan_public.TENTK;
            values[1] = taikhoan_public.MATKHAU;
            string sql = "CHECK_TAIKHOAN";
            return ketnoi.ReturnValueIntWithParameter(sql, name, values, parameter);
        }
    }
}
