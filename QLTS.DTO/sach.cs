using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTS.DTO
{
    public class sach
    {
        #region 1- Attribute
        private String _id;
        private String _name;
        private DateTime _ngayxuatban;
        private SqlMoney _giaban;
        private SqlMoney _giathue;
        private int _soluong;
        private String _theloai;
        private SqlMoney _gianhap;
        private String _idnxb;
        #endregion
        #region 2- Properties
        public String Id { get { return _id; } set { _id = value; } }
        public String Name { get { return _name; } set { _name = value; } }
        public DateTime Ngayxuatban { get {  return _ngayxuatban; }
            set
            {
                _ngayxuatban = value;
            } }
        public SqlMoney GiaBan { get {  return _giaban; }
            set
            {
                _giaban = value;
            } }
        public SqlMoney Giathue { get { return _giathue; }
            set
            {
                _giathue = value;
            } }
        public int Soluong { get { return _soluong; }
            set
            {
                _soluong = value;
            } }
        public String Theloai { get { return _theloai; }
            set
            {
                _theloai = value;
            } }
        public SqlMoney Gianhap { get { return _gianhap; }
            set
            {
                _gianhap = value;
            } }
        public String Idnxb { get { return _idnxb; }
            set
            {
                _idnxb = value;
            } }
        #endregion
        #region 3- Constructors
        public sach() { }
        #endregion
    }
}
