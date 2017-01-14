using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinYinHelper
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("上海：" + PinYinUtil.GetAllPinYin("上海"));

            #region 有bug
            Console.WriteLine("重庆：" + PinYinUtil.GetAllPinYin("重庆"));

            Console.WriteLine("重量：" + PinYinUtil.GetAllPinYin("重量")); 
            #endregion
        }
    }
}
