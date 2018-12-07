using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.QuanLyDoiTuong
{
    public class QLKhoaHoc
    {
        private BaseFunctions<KHOAHOC> baseFunctions = new BaseFunctions<KHOAHOC>();
        public List<KHOAHOC> listKHOAHOC = new List<KHOAHOC>();
        public bool Insert(KHOAHOC KHOAHOC)
        {
            if (baseFunctions.Add(KHOAHOC) > 0)
                return true;
            return false;
        }

        public bool Delete(string name)
        {
            if (baseFunctions.Delete(name) > 0)
                return true;
            return false;
        }

        public bool Update(KHOAHOC KHOAHOC)
        {
            if (baseFunctions.Update(KHOAHOC) > 0)
                return true;
            return false;
        }
        public bool GetAll()
        {
            listKHOAHOC.Clear();
            listKHOAHOC = baseFunctions.SelectAll();
            if (listKHOAHOC.Count > 0) return true;
            return false;
        }
        public List<KHOAHOC> SelectBy(object value, string name)
        {
            List<KHOAHOC> tk = baseFunctions.SelectBy(value, name);
            return tk;
        }
        public List<KHOAHOC> SelectByID(object ID)
        {
            return baseFunctions.SelectByID(ID);
        }

        public List<KHOAHOC> FindKeyWord(object item)
        {
            return baseFunctions.FindKeyWord(item);
        }
    }
}
