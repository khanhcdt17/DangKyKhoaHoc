using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.QuanLyDoiTuong
{
    public class QLTaiNguyen
    {
        private BaseFunctions<TAINGUYEN> baseFunctions = new BaseFunctions<TAINGUYEN>();
        public List<TAINGUYEN> listTAINGUYEN = new List<TAINGUYEN>();
        public bool Insert(TAINGUYEN TAINGUYEN)
        {
            if (baseFunctions.Add(TAINGUYEN) > 0)
                return true;
            return false;
        }

        public bool Delete(string name)
        {
            if (baseFunctions.Delete(name) > 0)
                return true;
            return false;
        }

        public bool Update(TAINGUYEN TAINGUYEN)
        {
            if (baseFunctions.Update(TAINGUYEN) > 0)
                return true;
            return false;
        }
        public bool GetAll()
        {
            listTAINGUYEN.Clear();
            listTAINGUYEN = baseFunctions.SelectAll();
            if (listTAINGUYEN.Count > 0) return true;
            return false;
        }
        public List<TAINGUYEN> SelectBy(object value, string name)
        {
            List<TAINGUYEN> tk = baseFunctions.SelectBy(value, name);
            return tk;
        }
        public List<TAINGUYEN> SelectByID(object ID)
        {
            return baseFunctions.SelectByID(ID);
        }

        public List<TAINGUYEN> FindKeyWord(object item)
        {
            return baseFunctions.FindKeyWord(item);
        }
    }
}
