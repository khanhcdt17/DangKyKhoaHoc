using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.QuanLyDoiTuong
{
    public class QLKetQuaHoc
    {
        private BaseFunctions<KETQUAHOC> baseFunctions = new BaseFunctions<KETQUAHOC>();
        public List<KETQUAHOC> listKETQUAHOC = new List<KETQUAHOC>();
        public bool Insert(KETQUAHOC KETQUAHOC)
        {
            if (baseFunctions.Add(KETQUAHOC) > 0)
                return true;
            return false;
        }

        public bool Delete(string name)
        {
            if (baseFunctions.Delete(name) > 0)
                return true;
            return false;
        }

        public bool Update(KETQUAHOC KETQUAHOC)
        {
            if (baseFunctions.Update(KETQUAHOC) > 0)
                return true;
            return false;
        }
        public bool GetAll()
        {
            listKETQUAHOC.Clear();
            listKETQUAHOC = baseFunctions.SelectAll();
            if (listKETQUAHOC.Count > 0) return true;
            return false;
        }
        public List<KETQUAHOC> SelectBy(object value, string name)
        {
            List<KETQUAHOC> tk = baseFunctions.SelectBy(value, name);
            return tk;
        }
        public List<KETQUAHOC> SelectByID(object ID)
        {
            return baseFunctions.SelectByID(ID);
        }

        public List<KETQUAHOC> FindKeyWord(object item)
        {
            return baseFunctions.FindKeyWord(item);
        }
    }
}
