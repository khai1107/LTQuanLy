using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBLIC
{
    public class HDBANHANG_PUBLIC
    {
        private string _MAHD;
        public string MAHD
        {
            get { return _MAHD; }
            set { _MAHD = value; }
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
        private int _GIA;
        public int GIA
        {
            get { return _GIA; }
            set { _GIA = value; }
        }
        private double _TONG;
        public double TONG
        {
            get { return _TONG; }
            set { _TONG = value; }
        }
        private string _TIMHDBH;

        public string TIMHDBH
        {
            get { return _TIMHDBH; }
            set { _TIMHDBH = value; }
        }
    }
}
