using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class QLTaiKhoan
    {
        private BaseFunctions<TAIKHOAN> baseFunctions = new BaseFunctions<TAIKHOAN>();
        public List<TAIKHOAN> listTAIKHOAN = new List<TAIKHOAN>();
        public bool Insert(TAIKHOAN TAIKHOAN)
        {
            if (baseFunctions.Add(TAIKHOAN) > 0)
                return true;
            return false;
        }
       
        public bool Delete(string name)
        {
            if (baseFunctions.Delete(name) > 0)
                return true;
            return false;
        }

        public bool Update(TAIKHOAN TAIKHOAN)
        {
            if (baseFunctions.Update(TAIKHOAN) > 0)
                return true;
            return false;
        }
        public bool GetAll()
        {
            listTAIKHOAN.Clear();
            listTAIKHOAN = baseFunctions.SelectAll();
            if (listTAIKHOAN.Count > 0) return true;
            return false;
        }
        public List<TAIKHOAN> SelectBy(object value, string name)
        {
            List<TAIKHOAN> tk= baseFunctions.SelectBy(value,name);
            return tk;
        }
        public List<TAIKHOAN> SelectByID(object ID)
        {
            return baseFunctions.SelectByID(ID);
        }

        public List<TAIKHOAN> FindKeyWord(object item)
        {
            return baseFunctions.FindKeyWord(item);
        }

    }
}
