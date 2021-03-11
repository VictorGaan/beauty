using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beauty
{
    public class Helper
    {
        public static BeautyEntities db = new BeautyEntities();
    }
    partial class Product
    {
        public string PhotoPath
        {
            get
            {
                if (MainImagePath == null)
                {
                    return "";
                }
                var length = MainImagePath.Length - 1;
                var q = MainImagePath.Substring(1, length);
                return Environment.CurrentDirectory + "\\" + q;

            }
        }
        public string Status
        {
            get
            {
                return IsActive == true ? "активен" : "неактивен";
            }
        }
    }
}
