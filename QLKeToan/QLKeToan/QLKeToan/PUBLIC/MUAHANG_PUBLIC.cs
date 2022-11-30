using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBLIC
{
    public class MUAHANG_PUBLIC
    {
        private string _MASPMH;
        public string MASPMH
        {
            get { return _MASPMH; }
            set { _MASPMH = value; }
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
        private DateTime _NGAYMUA;

        public DateTime NGAYMUA
        {
            get { return _NGAYMUA; }
            set { _NGAYMUA = value; }
        }
        private string _NGUOIMUA;
        public string NGUOIMUA
        {
            get { return _NGUOIMUA; }
            set { _NGUOIMUA = value; }
        }
        private string _TIMHANG;
        public string TIMHANG
        {
            get { return _TIMHANG; }
            set { _TIMHANG = value; }
        }
    }
}
