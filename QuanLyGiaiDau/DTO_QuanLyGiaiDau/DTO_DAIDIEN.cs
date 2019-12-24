
namespace DTO_QuanLyGiaiDau
{
    public class DTO_DAIDIEN
    {
        private string _MaDD;
        private string _MaDoi;
        private string _TenNguoiDD;
        //set, get
        public string MaDD
        {
            get { return _MaDD; }
            set { _MaDD = value; }
        }
        public string MaDoi
        {
            get { return _MaDoi; }
            set { _MaDoi = value; }
        }
        public string TenNguoiDD
        {
            get { return _TenNguoiDD; }
            set { _TenNguoiDD = value; }
        }
        //contructor
        public DTO_DAIDIEN() { }
        public DTO_DAIDIEN(string madd, string mad, string nguoi)
        {
            this.MaDD = madd;
            this.MaDoi = mad;
            this.TenNguoiDD = nguoi;
        }
    }
}
