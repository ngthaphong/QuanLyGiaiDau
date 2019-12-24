
namespace DTO_QuanLyGiaiDau
{
    public class DTO_XEPHANG
    {
        private string _MaGiai;
        private string _MaDoi;
        private int _TongDiem;
        private int _HieuSo;
        private int _ViThu;
        //set, get
        public string MaGiai
        {
            get { return _MaGiai; }
            set { _MaGiai = value; }
        }
        public string MaDoi
        {
            get { return _MaDoi; }
            set { _MaDoi = value; }
        }
        public int TongDiem
        {
            get { return _TongDiem; }
            set { _TongDiem = value; }
        }
        public int HieuSo
        {
            get { return _HieuSo; }
            set { _HieuSo = value; }
        }
        public int ViThu
        {
            get { return _ViThu; }
            set { _ViThu = value; }
        }

        //contructor
        public DTO_XEPHANG() { }
        public DTO_XEPHANG(string magiai, string mad, int tongdiem, int hieuso, int vithu)
        {
            this.MaGiai = magiai;
            this.MaDoi = mad;
            this.TongDiem = tongdiem;
            this.HieuSo = hieuso;
            this.ViThu = vithu;

        }
    }
}
