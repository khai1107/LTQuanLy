using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PUBLIC;

namespace QLKeToan.DAL
{
    public class KETNOI
    {
        private static string tensv;
        private static string tencsdl;
        public KETNOI(string tengan, string tencsdlgan)
        {
            Tensv = tengan; //khai báo tên server
            Tencsdl = tencsdlgan;   //tên cơ sở dữ liệu
        }
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-1L9V425K\SQLExpress;Initial Catalog=QLKETOAN;Integrated Security=True");
        public static string Tensv //get set đối tượng
        {
            get
            {
                return tensv;
            }

            set
            {
                tensv = value;
            }
        }
        public static string Tencsdl
        {
            get
            {
                return tencsdl;
            }

            set
            {
                tencsdl = value;
            }
        }
        public KETNOI() //Kiểm tra tình trạng kết nối
        {
            if (connect.State == ConnectionState.Closed)    //nếu kết nối đang đóng thì mở lên
            {
                connect.Open();
            }
        }
        public DataTable Load_Data(string sql)  //load dữ liệu
        {
            SqlCommand cmd = new SqlCommand(sql, connect);  //tạo câu truy vấn trong kết nối connect
            cmd.CommandType = CommandType.StoredProcedure;  //kết nối đến storedProcedure
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);   //tạo câu lệnh đọc những câu truy vấn
            DataTable dt = new DataTable(); //tạo bảng để chứa các câu truy vấn
            adapter.Fill(dt);   //truyền những lệnh vừa đọc vào bảng
            return dt;
        }
        //load dữ liệu các tham số(Parameter là tham số)
        public DataTable LoadDataWithParameter(string sql, string[] name, object[] values, int parameter)
        {
            SqlCommand cmd = new SqlCommand(sql, connect);//tạo câu truy vấn trong kết nối connect
            cmd.CommandType = CommandType.StoredProcedure;//kết nối đến storedProcedure
            //tham số trong chuỗi sql ký hiệu là @tenthamso trong sql khi tạo storedProcedure sẽ tạo những tham số này
            for (int i = 0; i < parameter; i++) //sẽ thực hiện vòng lặp các tham số 
            {
                cmd.Parameters.AddWithValue(name[i], values[i]);
                //Tập hợp các tham số dc lưu trong thuộc tính Parameter của SqlCommand
                //Thì trong Parameter có 1 sqlParameter có tên tham số là name[i] với giá trị là values[i]
                //Lúc này SqlCommand sẽ thay thế giá trị values[i] vào tham số name[i] cỉa câu truy vấn
                //Ví dụ mình select * from NhanVien where GIOITINH = @GioiTinh
                //lúc này cmmd.Parameters.AddWithValue(@GioiTinh,N'Nam');
            }
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        //Thi hành các câu truy vấn như update, delete,.... ko trả về giá trị gì hết
        public int Excute_Data(string sql, string[] name, object[] values, int parameter)
        {
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < parameter; i++)
            {
                cmd.Parameters.AddWithValue(name[i], values[i]);
            }
            return cmd.ExecuteNonQuery();
        }
        //Thực hiện lệnh trả về giá trị vs câu lệnh ExecuteScalar(nó sẽ trả về giá trị khác vs ExecuteNonQuery)
        public int ReturnValueInt(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.CommandType = CommandType.StoredProcedure;
            return int.Parse(cmd.ExecuteScalar().ToString());
        }
        //Trả giá trị của Parameter
        public int ReturnValueIntWithParameter(string sql, string[] name, object[] values, int parameter)
        {
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < parameter; i++)
            {
                cmd.Parameters.AddWithValue(name[i], values[i]);
            }
            return int.Parse(cmd.ExecuteScalar().ToString());
        }
    }
}
