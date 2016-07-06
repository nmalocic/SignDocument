using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.security;
using BcX509 = Org.BouncyCastle.X509;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Crypto;
using DotNetUtils = Org.BouncyCastle.Security.DotNetUtilities;
using System.Linq;
using System.Text.RegularExpressions;

namespace PDFSignature
{
	public static class PdfSignature
	{

		public static void Sign()
		{
			// Set up the PDF IO
			PdfReader reader = new PdfReader(@"E:\FAX\Diplomski\PDFSignature\PDFSignature\Izjava.pdf");
			PdfStamper stamper = PdfStamper.CreateSignature(reader,
				new FileStream(@"E:\FAX\Diplomski\PDFSignature\PDFSignature\IzjavaSigned.pdf", FileMode.Create), '\0');
			PdfSignatureAppearance sap = stamper.SignatureAppearance;

			sap.Reason = "For no apparent raisin";
			sap.Location = "...";

			// Acquire certificate chain
			X509Store certStore = new X509Store(StoreName.Root);
			certStore.Open(OpenFlags.ReadOnly);

			//X509CertificateCollection certCollection =
			//	certStore.Certificates.Find(X509FindType.FindByIssuerName,
			//	"CN = GeoTrust CA for Adobe, O = GeoTrust Inc., C = US", true);

			//X509Certificate cert = certStore.Certificates[0];
			//X509Certificate2 signatureCert = new X509Certificate2(cert);

			CertGenerator certGen = new CertGenerator();
			var signatureCert = certGen.CreateSelfSignedCertificate("Nemanja Malocic");

			var pk = Org.BouncyCastle.Security.DotNetUtilities.GetKeyPair(signatureCert.PrivateKey).Private;


			// iTextSharp needs this cert as a BouncyCastle X509 object; this converts it.
			BcX509.X509Certificate bcCert = DotNetUtils.FromX509Certificate(signatureCert);
			var chain = new List<BcX509.X509Certificate> { bcCert };
			//certStore.Close();

			// Ok, that's the certificate chain done. Now how do I get the PKS?
			IExternalSignature signature = new PrivateKeySignature(pk, "SHA-256");

			// Sign the PDF file and finish up.
			MakeSignature.SignDetached(sap, signature, chain, // the important stuff
				null, null, null, 0, CryptoStandard.CMS);
			stamper.Close();
		}
	}
}
