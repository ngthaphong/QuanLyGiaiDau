using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyGiaiDau
{
    public class DTO_DANGKY
    {
        private string _MaGiai;
        private string _MaDD;
        private DateTime _NgayDangKy;
        private string _MaTK;
        //set, get
        public string MaGiai
        {
            get { return _MaGiai; }
            set { _MaGiai = value; }
        }
        public string MaDD
        {
            get { return _MaDD; }
            set { _MaDD = value; }
        }
        public DateTime NgayDangKy
        {
            get { return _NgayDangKy; }
            set { _NgayDangKy = value; }
        }
        public string MaTK
        {
            get { return _MaTK; }
            set { _MaTK = value; }
        }
        //contructor
        public DTO_DANGKY() { }
        public DTO_DANGKY(string magiai, string madd, DateTime ngaydk, string matk)
        {
            this.MaGiai = magiai;
            this.MaDD = madd;
            this.NgayDangKy = ngaydk;
            this.MaTK = matk;
        }
    }
}
