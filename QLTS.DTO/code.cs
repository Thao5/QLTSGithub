using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTS.DTO
{
    internal class code
    {
        #region 1- Attribute
        private String _id;
        private bool _valid;
        private DateTime _ngaynap;
        private String _user;
        #endregion
        #region 2- Properties
        public String Id { get { return _id; } set {  _id = value; } }
        public bool Valid { get { return _valid; } set { _valid = value; } }
        public DateTime NgayNap { get { return _ngaynap; } set { _ngaynap = value; } }
        public String User { get { return _user; } set { _user = value; } }
        #endregion
        #region 3- Constructor
        public code() { }
        #endregion
    }
}
