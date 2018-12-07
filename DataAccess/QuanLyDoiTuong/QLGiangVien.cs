
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.QuanLyDoiTuong
{
    public class QLGiangVien
    {
        private BaseFunctions<GIANGVIEN> baseFunctions = new BaseFunctions<GIANGVIEN>();
        public List<GIANGVIEN> listGiangVien = new List<GIANGVIEN>();
        public bool Insert(GIANGVIEN GiangVien)
        {
            if (baseFunctions.Add(GiangVien) > 0)
                return true;
            return false;
        }

        public bool Delete(string name)
        {
            if (baseFunctions.Delete(name) > 0)
                return true;
            return false;
        }

        public bool Update(GIANGVIEN GiangVien)
        {
            if (baseFunctions.Update(GiangVien) > 0)
                return true;
            return false;
        }
        public bool GetAll()
        {
            listGiangVien.Clear();
            listGiangVien = baseFunctions.SelectAll();
            if (listGiangVien.Count > 0) return true;
            return false;
        }
        public List<GIANGVIEN> SelectBy(object value, string name)
        {
            List<GIANGVIEN> tk = baseFunctions.SelectBy(value, name);
            return tk;
        }
        public List<GIANGVIEN> SelectByID(object ID)
        {
            return baseFunctions.SelectByID(ID);
        }

        public List<GIANGVIEN> FindKeyWord(object item)
        {
            return baseFunctions.FindKeyWord(item);
        }
    }
}
