using Microsoft.International.Converters.PinYinConverter;

namespace PinYinHelper
{
    public class PinYinUtil
    {
        //返回字符串的简拼  
        public static string GetSimplePinYin(string inputTxt)
        {
            string shortR = "";
            foreach (char c in inputTxt.Trim())
            {
                ChineseChar chineseChar = new ChineseChar(c);
                shortR += chineseChar.Pinyins[0].Substring(0, 1).ToLower();
            }
            return shortR;
        }

        //返回字符串全拼  
        public static string GetAllPinYin(string inputTxt)
        {
            string allR = "";
            foreach (char c in inputTxt.Trim())
            {
                ChineseChar chineseChar = new ChineseChar(c);
                allR += chineseChar.Pinyins[0].Substring(0, chineseChar.Pinyins[0].Length - 1).ToLower();
            }
            return allR;
        }
    }
}