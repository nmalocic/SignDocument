using iTextSharp.text.pdf.security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signature.Business
{
    public static class SecurityHelper
    {
        public static IEnumerable<string> GetDigestMethods()
        {
            yield return "RIPEMD160";
            yield return "SHA-1";
            yield return "SHA-256";
            yield return "SHA-384";
            yield return "SHA-512";
        }

        public static IEnumerable<string> GetCryptoStandard()
        {
            yield return CryptoStandard.CADES.ToString();
            yield return CryptoStandard.CMS.ToString();
        }


        public static CryptoStandard ParseCrypto(string value)
        {
            return (CryptoStandard)Enum.Parse(typeof(CryptoStandard), value, true);
        }
    }
}
