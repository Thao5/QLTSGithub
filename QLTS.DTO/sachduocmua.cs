using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTS.DTO
{
    public class sachduocmua
    {
        #region 1- Attribute
        private int _id;
        private SqlMoney _giaban;
        private DateTime _createddate;
        private String _idsach;
        private String _iduser;
        #endregion
        #region 2- Properties
        public int Id { get { return _id; } set {  _id = value; } }
        public SqlMoney Giaban { get { return _giaban; } set { _giaban = value; } }
        public DateTime Createddate { get { return _createddate; } set { _createddate = value; } }
        public String Idsach { get { return _idsach; }
            set
            {
                _idsach = value;
            } }
        public String IdUser { get { return _iduser; }
            set
            {
                _iduser = value;
            } }
        #endregion
        #region 3- Constructors
        public sachduocmua()
        {

        }
        #endregion
    }
}
