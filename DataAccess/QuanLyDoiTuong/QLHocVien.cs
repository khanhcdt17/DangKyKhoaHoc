using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.QuanLyDoiTuong
{
    public class QLHocVien
    {
        private BaseFunctions<HOCVIEN> baseFunctions = new BaseFunctions<HOCVIEN>();
        public List<HOCVIEN> listHOCVIEN = new List<HOCVIEN>();
        public bool Insert(HOCVIEN HOCVIEN)
        {
            if (baseFunctions.Add(HOCVIEN) > 0)
                return true;
            return false;
        }

        public bool Delete(string name)
        {
            if (baseFunctions.Delete(name) > 0)
                return true;
            return false;
        }

        public bool Update(HOCVIEN HOCVIEN)
        {
            if (baseFunctions.Update(HOCVIEN) > 0)
                return true;
            return false;
        }
        public bool GetAll()
        {
            listHOCVIEN.Clear();
            listHOCVIEN = baseFunctions.SelectAll();
            if (listHOCVIEN.Count > 0) return true;
            return false;
        }
        public List<HOCVIEN> SelectBy(object value, string name)
        {
            List<HOCVIEN> tk = baseFunctions.SelectBy(value, name);
            return tk;
        }
        public List<HOCVIEN> SelectByID(object ID)
        {
            return baseFunctions.SelectByID(ID);
        }

        public List<HOCVIEN> FindKeyWord(object item)
        {
            return baseFunctions.FindKeyWord(item);
        }
    }
}
