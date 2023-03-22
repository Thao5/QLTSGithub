using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTS.DTO
{
    public class user
    {
        #region 1- Attribute
        private String _id;
        private String _username;
        private String _password;
        private String _lastname;
        private String _name;
        private DateTime _birth;
        private SqlMoney _sotienconlai;
        private bool _phanquyen;
        #endregion
        #region 2- Properties
        public String Id { get { return _id; } set { _id = value; } }
        public String Username { get { return _username; } set { _username = value; } }
        public String Password { get { return _password;} set { _password = value; } }
        public String Lastname { get { return _lastname; } set { _lastname = value; } }
        public String Name { get { return _name; } set { _name = value; } }
        public DateTime Birth { get { return _birth; } set { _birth = value; } }
        public SqlMoney SoTienConLai { get { return _sotienconlai; } set { _sotienconlai = value; } }
        public bool PhanQuyen { get { return _phanquyen; } set { _phanquyen = value; } }
        #endregion
        #region 3- Constructors
        public user() { }
        #endregion
    }
}
