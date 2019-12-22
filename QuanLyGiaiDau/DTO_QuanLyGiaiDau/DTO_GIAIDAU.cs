using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyGiaiDau
{
    public class DTO_GIAIDAU
    {
        private string _MaGiai;
        private string _TenGiai;
        private DateTime _NgayBatDau;
        private DateTime _NgayKetThuc;
        //set, get
        public string MaGiai
        {
            get { return _MaGiai; }
            set { _MaGiai = value; }
        }
        public string TenGiai
        {
            get { return _TenGiai; }
            set { _TenGiai = value; }
        }
        public DateTime NgayBatDau
        {
            get { return _NgayBatDau; }
            set { _NgayBatDau = value; }
        }
        public DateTime NgayKetThuc
        {
            get { return _NgayKetThuc; }
            set { _NgayKetThuc = value; }
        }
        //contructor
        public DTO_GIAIDAU() { }
        public DTO_GIAIDAU(string mag, string teng, DateTime start, DateTime end)
        {
            this.MaGiai = mag;
            this.TenGiai = teng;
            this.NgayBatDau = start;
            this.NgayKetThuc = end;
        }
    }
}
