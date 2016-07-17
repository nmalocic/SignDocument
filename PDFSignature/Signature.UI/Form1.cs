using System;
using System.Windows.Forms;
using Signature.Business;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace Signature.UI
{
    public partial class Form1 : Form
    {
        private PdfHelper _pdfHelper;
        private CertificateHelper _certHelper;
        

        private string _sourcePdf;
        private string _destinationPdf;
        private string _reason;
        private string _location;
        private string _digestAlgorithm;
        private string _cryptoStandard;
        private X509Certificate2 _cert;

        public Form1()
        {
            _pdfHelper = new PdfHelper();
            _certHelper = new CertificateHelper();

            InitializeComponent();

            foreach (var item in SecurityHelper.GetDigestMethods())
                cbx_DigestAlgoritham.Items.Add(item);

            
            foreach (var item in SecurityHelper.GetCryptoStandard())
                cbx_CryptoStandard.Items.Add(item);

            cbx_DigestAlgoritham.SelectedIndex = 0;
            cbx_CryptoStandard.SelectedIndex = 0;
        }

        private void btn_ChoosFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\..\"));
            openFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf";
            DialogResult result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                _sourcePdf = openFileDialog1.FileName;
            }
        }

        private void btn_destination_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\..\"));
            saveFileDialog1.Filter = "PDF File (*.pdf)|*.pdf";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                _destinationPdf = saveFileDialog1.FileName;
            }
        }

        private void btn_sign_Click(object sender, EventArgs e)
        {
            if (!IsInputValid())
            {
                return;
            }
            _reason = txt_reason.Text;
            _location = txt_location.Text;
            _digestAlgorithm = cbx_DigestAlgoritham.SelectedItem.ToString();
            _cryptoStandard = cbx_CryptoStandard.SelectedItem.ToString();

            _pdfHelper.Sign(_sourcePdf, _destinationPdf, _cert, _digestAlgorithm, _cryptoStandard, _reason, _location);
            MessageBox.Show("Document signed!");
        }

        private void btnCert_Click(object sender, EventArgs e)
        {
            _cert = _certHelper.SelectCert(StoreName.My, StoreLocation.LocalMachine, "Certificate", "Choos certificate to sign PDF");
        }

        public bool IsInputValid()
        {
            bool allOk = true;

            if (string.IsNullOrEmpty(_sourcePdf))
            {
                errorProvider1.SetError(btn_ChoosFile, "Invalid input file");
                allOk = false;
            }
            if (string.IsNullOrEmpty(_destinationPdf))
            {
                errorProvider1.SetError(btn_destination, "invalid output file");
                allOk = false;
            }
            if(_cert == null)
            {
                errorProvider1.SetError(btnCert, "Invalid certificate");
                allOk = false;
            }

            if (allOk)
            {
                errorProvider1.Clear();
            }

            return allOk;
        }
    }
}
