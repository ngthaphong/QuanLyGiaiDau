
namespace DTO_QuanLyGiaiDau
{
    public class DTO_DOI
    {
        private string _MaDoi;
        private string _TenDoi;
        private string _TenHLV;
        private string _DoiTruong;
        private int _SoThanhVien;
        private string _MauAo;
        //set, get
        public string MaDoi
        {
            get { return _MaDoi; }
            set { _MaDoi = value; }
        }
        public string TenDoi
        {
            get { return _TenDoi; }
            set { _TenDoi = value; }
        }
        public string TenHLV
        {
            get { return _TenHLV; }
            set { _TenHLV = value; }
        }
        public string DoiTruong
        {
            get { return _DoiTruong; }
            set { _DoiTruong = value; }
        }
        public int SoThanhVien
        {
            get { return _SoThanhVien; }
            set { _SoThanhVien = value; }
        }
        public string MauAo
        {
            get { return _MauAo; }
            set { _MauAo = value; }
        }
        //contructor
        public DTO_DOI() { }
        public DTO_DOI(string mag, string teng, string tenhlv, string dt, int sotv, string mau)
        {
            this.MaDoi = mag;
            this.TenDoi = teng;
            this.TenHLV = tenhlv;
            this.DoiTruong = dt;
            this.SoThanhVien = sotv;
            this.MauAo = mau;
        }
    }
}
