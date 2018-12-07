
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.QuanLyDoiTuong
{
    public class QLCT_KhoaHoc
    {
        private BaseFunctions<CT_KHOAHOC> baseFunctions = new BaseFunctions<CT_KHOAHOC>();
        public List<CT_KHOAHOC> listCT_KhoaHoc = new List<CT_KHOAHOC>();
        public bool Insert(CT_KHOAHOC CT_KhoaHoc)
        {
            if (baseFunctions.Add(CT_KhoaHoc) > 0)
                return true;
            return false;
        }

        public bool Delete(string name)
        {
            if (baseFunctions.Delete(name) > 0)
                return true;
            return false;
        }

        public bool Update(CT_KHOAHOC CT_KhoaHoc)
        {
            if (baseFunctions.Update(CT_KhoaHoc) > 0)
                return true;
            return false;
        }
        public bool GetAll()
        {
            listCT_KhoaHoc.Clear();
            listCT_KhoaHoc = baseFunctions.SelectAll();
            if (listCT_KhoaHoc.Count > 0) return true;
            return false;
        }
        public List<CT_KHOAHOC> SelectBy(object value, string name)
        {
            List<CT_KHOAHOC> tk = baseFunctions.SelectBy(value, name);
            return tk;
        }
        public List<CT_KHOAHOC> SelectByID(object ID)
        {
            return baseFunctions.SelectByID(ID);
        }

        public List<CT_KHOAHOC> FindKeyWord(object item)
        {
            return baseFunctions.FindKeyWord(item);
        }

    }
}
