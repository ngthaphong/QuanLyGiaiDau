﻿
namespace DTO_QuanLyGiaiDau
{
    public class DTO_VONG
    {
        private string _MaGiai;
        private string _TenVong;
        //set, get
        public string MaGiai
        {
            get { return _MaGiai; }
            set { _MaGiai = value; }
        }
        public string TenVong
        {
            get { return _TenVong; }
            set { _TenVong = value; }
        }

        //contructor
        public DTO_VONG() { }
        public DTO_VONG(string magiai, string tenvong)
        {
            this.MaGiai = magiai; 
            this.TenVong = tenvong;

        }
    }
}