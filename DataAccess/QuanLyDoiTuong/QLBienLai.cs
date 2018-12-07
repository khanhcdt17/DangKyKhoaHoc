
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.QuanLyDoiTuong
{
    public class QLBienLai
    {
        private BaseFunctions<BIENLAI> baseFunctions = new BaseFunctions<BIENLAI>();
        public List<BIENLAI> listBienLai = new List<BIENLAI>();
        public bool Insert(BIENLAI BienLai)
        {
            if (baseFunctions.Add(BienLai) > 0)
                return true;
            return false;
        }

        public bool Delete(string name)
        {
            if (baseFunctions.Delete(name) > 0)
                return true;
            return false;
        }

        public bool Update(BIENLAI BienLai)
        {
            if (baseFunctions.Update(BienLai) > 0)
                return true;
            return false;
        }
        public bool GetAll()
        {
            listBienLai.Clear();
            listBienLai = baseFunctions.SelectAll();
            if (listBienLai.Count > 0) return true;
            return false;
        }
        public List<BIENLAI> SelectBy(object value, string name)
        {
            List<BIENLAI> tk = baseFunctions.SelectBy(value, name);
            return tk;
        }
        public List<BIENLAI> SelectByID(object ID)
        {
            return baseFunctions.SelectByID(ID);
        }

        public List<BIENLAI> FindKeyWord(object item)
        {
            return baseFunctions.FindKeyWord(item);
        }

    }
}
