using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTS.DTO
{
    public class NXB
    {
        #region 1- Attribute
        private String _id;
        private String _name;
        #endregion
        #region 2- Properties
        public String Id { get { return _id; } set { _id = value; } }
        public String Name { get { return _name; } set { _name = value; } }
        #endregion
        #region 3- Constructor
        public NXB() { }
        #endregion


    }
}
