using System;
using System.Text;

namespace Base64
{
    public class B64
    {
        public static string Base64()
        {
            string toEncode = "Lucrezia";
            byte[] toEncodeAsBytes = ASCIIEncoding.ASCII.GetBytes(toEncode);
            string returnValue = Convert.ToBase64String(toEncodeAsBytes);

            return returnValue;
        }
    }
}
