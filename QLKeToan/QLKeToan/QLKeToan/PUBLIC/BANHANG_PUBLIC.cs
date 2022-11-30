using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBLIC
{
    public class BANHANG_PUBLIC
    {
        private string _MASPBH;
        public string MASPBH
        {
            get { return _MASPBH; }
            set { _MASPBH = value; }
        }
        private string _TENSP;
        public string TENSP
        {
            get { return _TENSP; }
            set { _TENSP = value; }
        }
        private int _SOLUONG;
        public int SOLUONG
        {
            get { return _SOLUONG; }
            set { _SOLUONG = value; }
        }
        private DateTime _NGAYBAN;

        public DateTime NGAYBAN
        {
            get { return _NGAYBAN; }
            set { _NGAYBAN = value; }
        }
        private string _NGUOIBAN;
        public string NGUOIBAN
        {
            get { return _NGUOIBAN; }
            set { _NGUOIBAN = value; }
        }
    }
}
