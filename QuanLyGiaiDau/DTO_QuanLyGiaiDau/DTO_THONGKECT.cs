
namespace DTO_QuanLyGiaiDau
{
    public class DTO_THONGKECT
    {
        private string _MaGiai;
        private string _MaDoi;
        private string _HoTenCT;
        private int _SoAo;
        private int _BanThang;
        private int _TheVang;
        private int _TheDo;
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
        public string HoTenCT
        {
            get { return _HoTenCT; }
            set { _HoTenCT = value; }
        }
        public int SoAo
        {
            get { return _SoAo; }
            set { _SoAo = value; }
        }
        public int BanThang
        {
            get { return _BanThang; }
            set { _BanThang = value; }
        }
        public int TheVang
        {
            get { return _TheVang; }
            set { _TheVang = value; }
        }
        public int TheDo
        {
            get { return _TheDo; }
            set { _TheDo = value; }
        }


        //contructor
        public DTO_THONGKECT() { }
        public DTO_THONGKECT(string magiai, string mad, string tenct, int soao, int bt, int tv, int td)
        {
            this.MaGiai = magiai;
            this.MaDoi = mad;
            this.HoTenCT = tenct;
            this.SoAo = soao;
            this.BanThang = bt;
            this.TheVang = tv;
            this.TheDo = td;


        }
    }
}
