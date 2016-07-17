using System.Security.Cryptography.X509Certificates;

namespace Signature.Business
{
    public class CertificateHelper
    {
        //using System.Security.Cryptography.X509Certificates;
        public X509Certificate2 SelectCert(StoreName store, StoreLocation location, string windowTitle, string windowMsg)
        {

            X509Certificate2 certSelected = null;
            X509Store x509Store = new X509Store(store, location);
            x509Store.Open(OpenFlags.ReadOnly);

            X509Certificate2Collection col = x509Store.Certificates;
            X509Certificate2Collection sel = X509Certificate2UI.SelectFromCollection(col, windowTitle, windowMsg, X509SelectionFlag.SingleSelection);

            if (sel.Count > 0)
            {
                X509Certificate2Enumerator en = sel.GetEnumerator();
                en.MoveNext();
                if(en.Current.PrivateKey != null) 
                    certSelected = en.Current;
            }

            x509Store.Close();

            return certSelected;
        }
    }
}
