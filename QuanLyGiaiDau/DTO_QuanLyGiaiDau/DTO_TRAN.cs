using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyGiaiDau
{
    public class DTO_TRAN
    {
        private int _SoTran;
        private string _TenVong;
        //set, get
        public int SoTran
        {
            get { return _SoTran; }
            set { _SoTran = value; }
        }
        public string TenVong
        {
            get { return _TenVong; }
            set { _TenVong = value; }
        }
       
        //contructor
        public DTO_TRAN() { }
        public DTO_TRAN(int sotran, string tenvong)
        {
            this.SoTran = sotran;
            this.TenVong = tenvong;
            
        }
    }
}
