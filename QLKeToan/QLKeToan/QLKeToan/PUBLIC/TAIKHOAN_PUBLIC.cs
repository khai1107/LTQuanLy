using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PUBLIC
{
    public class TAIKHOAN_PUBLIC
    {
        private string _TENTK; //Khởi tạo tên tài khoản và get set 

        public string TENTK
        {
            get { return _TENTK; }
            set { _TENTK = value; }
        }
        private string _MATKHAU; //Khởi tạo Mật khẩu và get set

        public string MATKHAU
        {
            get { return _MATKHAU; }
            set { _MATKHAU = value; }
        }
        private string _QUYEN;

        public string QUYEN
        {
            get { return _QUYEN; }
            set { _QUYEN = value; }
        }
        private string _IDNV;

        public string IDNV
        {
            get { return _IDNV; }
            set { _IDNV = value; }
        }
    }
}
