using System;

namespace DTO_QuanLyGiaiDau
{
    public class DTO_GIAIDAU
    {
        private string _MaGiai;
        private string _TenGiai;
        private DateTime _NgayBatDau;
        private DateTime _NgayKetThuc;
        private int? _SoDoi;
        private int? _SoThanhVien;
        private int? _DiemThang;
        private int? _DiemHoa;
        private int? _DiemThua;
        private int? _SoLuot;
        private int? _Loai;
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
        public int? SoDoi
        {
            get { return _SoDoi; }
            set { _SoDoi = value; }
        }
        public int? SoThanhVien
        {
            get { return _SoThanhVien; }
            set { _SoThanhVien = value; }
        }
        public int? DiemThang
        {
            get { return _DiemThang; }
            set { _DiemThang = value; }
        }
        public int? DiemHoa
        {
            get { return _DiemHoa; }
            set { _DiemHoa = value; }
        }
        public int? DiemThua
        {
            get { return _DiemThua; }
            set { _DiemThua = value; }
        }
        public int? SoLuot
        {
            get { return _SoLuot; }
            set { _SoLuot = value; }
        }
        public int? Loai
        {
            get { return _Loai; }
            set { _Loai = value; }
        }
        //contructor
        public DTO_GIAIDAU() { }
        public DTO_GIAIDAU(string mag, string teng, DateTime start, DateTime end, int? sodoi, int? stv, int? dtg, int? dh, int? dth, int? luot, int? loai)
        {
            this.MaGiai = mag;
            this.TenGiai = teng;
            this.NgayBatDau = start;
            this.NgayKetThuc = end;
            this.SoDoi = sodoi;
            this.SoThanhVien = stv;
            this.DiemThang = dtg;
            this.DiemHoa = dh;
            this.DiemThua = dth;
            this.SoLuot = luot;
            this.Loai = loai;
        }
    }
}
