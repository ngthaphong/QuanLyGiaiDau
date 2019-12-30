
namespace DTO_QuanLyGiaiDau
{
    public class DTO_TRANDAU
    {
        private string _MaTran;
        private string _MaVong;
        private int _SoTran;
        //set, get
        public string MaTran
        {
            get { return _MaTran; }
            set { _MaTran = value; }
        }
        public string MaVong
        {
            get { return _MaVong; }
            set { _MaVong = value; }
        }
        public int SoTran
        {
            get { return _SoTran; }
            set { _SoTran = value; }
        }
        //contructor
        public DTO_TRANDAU() { }
        public DTO_TRANDAU(string mat, int sotran, string mav)
        {
            this.MaTran = mat;
            this.MaVong = mav;
            this.SoTran = sotran;  
        }
    }
}
