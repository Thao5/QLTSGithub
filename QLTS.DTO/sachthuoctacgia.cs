using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTS.DTO
{
    public class sachthuoctacgia
    {
        #region 1- Attribute
        private int _id;
        private String _idsach;
        private String _iduser;
        #endregion
        #region 2- Properties
        public int Id { get { return _id; } set { _id = value; } }
        public String Idsach { get { return _idsach; } set { _idsach = value; } }
        public String IdUser { get {  return _iduser; } set { _iduser = value; } }
        #endregion
        #region 3- Constructors
        public sachthuoctacgia() { }
        #endregion
    }
}
