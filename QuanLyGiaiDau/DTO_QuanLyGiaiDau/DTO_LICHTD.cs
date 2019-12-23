using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyGiaiDau
{
    public class DTO_LICHTD
    {
        private string _MaDoi1;
        private string _MaDoi2;
        private int _SoTran;
        private string _TenSan;
        private DateTime _ThoiGianDienRa;
        private string _TrongTai;
        private int _BanThang1;
        private int _BangThang2;
        private int _TheVang1;
        private int _TheVang2;
        private int _TheDo1;
        private int _TheDo2;
        private int _SoDiem1;
        private int _SoDiem2;
        //set, get
        public string MaDoi1
        {
            get { return _MaDoi1; }
            set { _MaDoi1 = value; }
        }
        public string MaDoi2
        {
            get { return _MaDoi2; }
            set { _MaDoi2 = value; }
        }
        public string SoTran
        {
            get { return _SoTran; }
            set { _SoTran = value; }
        }
        public string TenSan
        {
            get { return _TenSan; }
            set { _TenSan = value; }
        }
        public DateTime ThoiGianDienRa
        {
            get { return _ThoiGianDienRa; }
            set { _ThoiGianDienRa = value; }
        }
        public string TrongTai
        {
            get { return _TrongTai; }
            set { _TrongTai = value; }
        }
        public int BanThang1
        {
            get { return _BanThang1; }
            set { _BanThang1 = value; }
        }
        public int BanThang2
        {
            get { return _BanThang2; }
            set { _BanThang2 = value; }
        }
        public int TheVang1
        {
            get { return _TheVang1; }
            set { _TheVang1 = value; }
        }
        public int TheVang2
        {
            get { return _TheVang2; }
            set { _TheVang2 = value; }
        }
        public int TheDo1
        {
            get { return _TheDo1; }
            set { _TheDo1 = value; }
        }
        public int TheDo2
        {
            get { return _TheDo2; }
            set { _TheDo2 = value; }
        }
        public int SoDiem1
        {
            get { return _SoDiem1; }
            set { _SoDiem1 = value; }
        }
        public int SoDiem2
        {
            get { return _SoDiem2; }
            set { _SoDiem2 = value; }
        }

        //contructor
        public DTO_LICHTD() { }
        public DTO_LICHTD(string mad1, string mad2, string sotran, string tensan, DateTime thoigiandienra, string trongtai, int bt1, int bt2, int tv1, int tv2, int td1, int td2, int sd1, int sd2)
        {
            this.MaDoi1 = mad1;
            this.MaDoi2 = mad2;
            this.SoTran = sotran;
            this.TenSan = tensan;
            this.ThoiGianDienRa = thoigiandienra;
            this.TrongTai = trongtai;
            this.BanThang1 = bt1;
            this.BanThang2 = bt2;
            this.TheVang1 = tv1;
            this.TheVang2 = tv2;
            this.TheDo1 = td1;
            this.TheDo2 = td2;
            this.SoDiem1 = sd1;
            this.SoDiem2 = sd2;
           

        }
    }
}
