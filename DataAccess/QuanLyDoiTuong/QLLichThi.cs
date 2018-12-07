using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.QuanLyDoiTuong
{
    public class QLLichThi
    {
        private BaseFunctions<LICHTHI> baseFunctions = new BaseFunctions<LICHTHI>();
        public List<LICHTHI> listLICHTHI = new List<LICHTHI>();
        public bool Insert(LICHTHI LICHTHI)
        {
            if (baseFunctions.Add(LICHTHI) > 0)
                return true;
            return false;
        }

        public bool Delete(string name)
        {
            if (baseFunctions.Delete(name) > 0)
                return true;
            return false;
        }

        public bool Update(LICHTHI LICHTHI)
        {
            if (baseFunctions.Update(LICHTHI) > 0)
                return true;
            return false;
        }
        public bool GetAll()
        {
            listLICHTHI.Clear();
            listLICHTHI = baseFunctions.SelectAll();
            if (listLICHTHI.Count > 0) return true;
            return false;
        }
        public List<LICHTHI> SelectBy(object value, string name)
        {
            List<LICHTHI> tk = baseFunctions.SelectBy(value, name);
            return tk;
        }
        public List<LICHTHI> SelectByID(object ID)
        {
            return baseFunctions.SelectByID(ID);
        }

        public List<LICHTHI> FindKeyWord(object item)
        {
            return baseFunctions.FindKeyWord(item);
        }
    }
}
