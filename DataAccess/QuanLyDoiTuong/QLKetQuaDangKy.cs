using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.QuanLyDoiTuong
{
    public class QLKetQuaDangKy
    {
        private BaseFunctions<KETQUADANGKY> baseFunctions = new BaseFunctions<KETQUADANGKY>();
        public List<KETQUADANGKY> listKETQUADANGKY = new List<KETQUADANGKY>();
        public bool Insert(KETQUADANGKY KETQUADANGKY)
        {
            if (baseFunctions.Add(KETQUADANGKY) > 0)
                return true;
            return false;
        }

        public bool Delete(string name)
        {
            if (baseFunctions.Delete(name) > 0)
                return true;
            return false;
        }

        public bool DeleteBy(string maHV,string MACTKH)
        {
            if (DataProvider.Instance.ExecuteNonQuery("KETQUADANGKY_DeleteBy", MACTKH,maHV) > 0)
                return true;
            return false;
        }

        public bool Update(KETQUADANGKY KETQUADANGKY)
        {
            if (baseFunctions.Update(KETQUADANGKY) > 0)
                return true;
            return false;
        }
        public bool GetAll()
        {
            listKETQUADANGKY.Clear();
            listKETQUADANGKY = baseFunctions.SelectAll();
            if (listKETQUADANGKY.Count > 0) return true;
            return false;
        }
        public List<KETQUADANGKY> SelectBy(object value, string name)
        {
            List<KETQUADANGKY> tk = baseFunctions.SelectBy(value, name);
            return tk;
        }
        public List<KETQUADANGKY> SelectByID(object ID)
        {
            return baseFunctions.SelectByID(ID);
        }

        public List<KETQUADANGKY> FindKeyWord(object item)
        {
            return baseFunctions.FindKeyWord(item);
        }
    }
}
