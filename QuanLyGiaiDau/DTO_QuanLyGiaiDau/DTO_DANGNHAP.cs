
namespace DTO_QuanLyGiaiDau
{
    public class DTO_DANGNHAP
    {
        private string _MaTK;
        private string _username;
        private string _password;
        //set, get
        public string MaTK
        {
            get { return _MaTK; }
            set { _MaTK = value; }
        }
        public string username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
        //contructor
        public DTO_DANGNHAP() { }
        public DTO_DANGNHAP(string matk, string user, string pass)
        {
            this.MaTK = matk;
            this.username = user;
            this.password = pass;
        }
    }
}
