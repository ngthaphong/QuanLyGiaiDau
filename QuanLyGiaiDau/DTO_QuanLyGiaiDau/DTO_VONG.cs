using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyGiaiDau
{
    public class DTO_TRAN
    {
        private string _MaGiai;
        private string _TenVong;
        //set, get
        public string MaGiai
        {
            get { return _MaGiai; }
            set { _MaGiai = value; }
        }
        public string TenVong
        {
            get { return _TenVong; }
            set { _TenVong = value; }
        }

        //contructor
        public DTO_TRAN() { }
        public DTO_TRAN(string magiai, string tenvong)
        {
            this.MaGiai = magiai; 
            this.TenVong = tenvong;

        }
    }
}
