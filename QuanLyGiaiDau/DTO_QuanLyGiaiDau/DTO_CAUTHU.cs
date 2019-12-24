using System;

namespace DTO_QuanLyGiaiDau
{
    public class DTO_CAUTHU
    {
        private string _MaCT;
        private string _MaDoi;
        private string _HoTenCT;
        private DateTime _NgaySinh;
        private int _SoAo;
        private string _ViTri;
        //set, get
        public string MaCT
        {
            get { return _MaCT; }
            set { _MaCT = value; }
        }
        public string MaDoi
        {
            get { return _MaDoi; }
            set { _MaDoi = value; }
        }
        public string HoTenCT
        {
            get { return _HoTenCT; }
            set { _HoTenCT = value; }
        }
        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }
        public int SoAo
        {
            get { return _SoAo; }
            set { _SoAo = value; }
        }
        public string ViTri
        {
            get { return _ViTri; }
            set { _ViTri = value; }
        }
        //contructor
        public DTO_CAUTHU() { }
        public DTO_CAUTHU(string mact, string mad, string tenct, DateTime ngaysinh, int soao, string vitri)
        {
            this.MaCT = mact;
            this.MaDoi = mad;
            this.HoTenCT = tenct;
            this.NgaySinh = ngaysinh;
            this.SoAo = soao;
            this.ViTri = vitri;
        }
    }
}
