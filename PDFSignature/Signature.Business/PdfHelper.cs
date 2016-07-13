using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.security;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.X509;
using System;
using System.Collections.Generic;
using System.IO;
using BcX509 = Org.BouncyCastle.X509;
using Cert = System.Security.Cryptography.X509Certificates;
using DotNetUtils = Org.BouncyCastle.Security.DotNetUtilities;

namespace Signature.Business
{
    public class PdfHelper
    {
        private Tuple<ICipherParameters, List<BcX509.X509Certificate>> GetCypherInformation(Cert.X509Certificate2 certificate)
        {
            var pk = DotNetUtils.GetKeyPair(certificate.PrivateKey).Private;

            // iTextSharp needs this cert as a BouncyCastle X509 object; this converts it.
            X509Certificate bcCert = DotNetUtils.FromX509Certificate(certificate);
            var chain = new List<X509Certificate> { bcCert };

            return new Tuple<ICipherParameters, List<BcX509.X509Certificate>>(pk, chain);
        }

        public void Sign(string src, string dest, Cert.X509Certificate2 certificate,
                         string digestAlgorithm, string cryptoStandard, string reason, string location)
        {
            var cypherInfo = GetCypherInformation(certificate);
            var subfilter = SecurityHelper.ParseCrypto(cryptoStandard);
            // Creating the reader and the stamper
            PdfReader reader = new PdfReader(src);
            FileStream os = new FileStream(dest, FileMode.Create);
            PdfStamper stamper = PdfStamper.CreateSignature(reader, os, '\0');
            // Creating the appearance
            PdfSignatureAppearance appearance = stamper.SignatureAppearance;
            appearance.Reason = reason;
            appearance.Location = location;
            appearance.SetVisibleSignature(new Rectangle(36, 748, 144, 780), 1, "sig");
            // Creating the signature
            IExternalSignature pks = new PrivateKeySignature(cypherInfo.Item1, digestAlgorithm);
            MakeSignature.SignDetached(appearance, pks, cypherInfo.Item2, null, null, null, 0, subfilter);
        }
    }
}
