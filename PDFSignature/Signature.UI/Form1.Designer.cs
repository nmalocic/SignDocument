namespace Signature.UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_ChoosFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_destination = new System.Windows.Forms.Button();
            this.txt_reason = new System.Windows.Forms.TextBox();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_sign = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_DigestAlgoritham = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_CryptoStandard = new System.Windows.Forms.ComboBox();
            this.btnCert = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_ChoosFile
            // 
            this.btn_ChoosFile.Location = new System.Drawing.Point(157, 32);
            this.btn_ChoosFile.Name = "btn_ChoosFile";
            this.btn_ChoosFile.Size = new System.Drawing.Size(75, 23);
            this.btn_ChoosFile.TabIndex = 0;
            this.btn_ChoosFile.Text = "Source PDF";
            this.btn_ChoosFile.UseVisualStyleBackColor = true;
            this.btn_ChoosFile.Click += new System.EventHandler(this.btn_ChoosFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Pdf to sign";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose destination pdf";
            // 
            // btn_destination
            // 
            this.btn_destination.Location = new System.Drawing.Point(157, 66);
            this.btn_destination.Name = "btn_destination";
            this.btn_destination.Size = new System.Drawing.Size(75, 23);
            this.btn_destination.TabIndex = 3;
            this.btn_destination.Text = "Destination PDF";
            this.btn_destination.UseVisualStyleBackColor = true;
            this.btn_destination.Click += new System.EventHandler(this.btn_destination_Click);
            // 
            // txt_reason
            // 
            this.txt_reason.Location = new System.Drawing.Point(157, 119);
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.Size = new System.Drawing.Size(125, 20);
            this.txt_reason.TabIndex = 4;
            // 
            // txt_location
            // 
            this.txt_location.Location = new System.Drawing.Point(157, 145);
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(125, 20);
            this.txt_location.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Signature reason";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Signature location";
            // 
            // btn_sign
            // 
            this.btn_sign.Location = new System.Drawing.Point(542, 379);
            this.btn_sign.Name = "btn_sign";
            this.btn_sign.Size = new System.Drawing.Size(75, 23);
            this.btn_sign.TabIndex = 8;
            this.btn_sign.Text = "Sign";
            this.btn_sign.UseVisualStyleBackColor = true;
            this.btn_sign.Click += new System.EventHandler(this.btn_sign_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Digest algoritham";
            // 
            // cbx_DigestAlgoritham
            // 
            this.cbx_DigestAlgoritham.FormattingEnabled = true;
            this.cbx_DigestAlgoritham.Location = new System.Drawing.Point(157, 175);
            this.cbx_DigestAlgoritham.Name = "cbx_DigestAlgoritham";
            this.cbx_DigestAlgoritham.Size = new System.Drawing.Size(121, 21);
            this.cbx_DigestAlgoritham.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Crypto Standard";
            // 
            // cbx_CryptoStandard
            // 
            this.cbx_CryptoStandard.FormattingEnabled = true;
            this.cbx_CryptoStandard.Location = new System.Drawing.Point(157, 212);
            this.cbx_CryptoStandard.Name = "cbx_CryptoStandard";
            this.cbx_CryptoStandard.Size = new System.Drawing.Size(121, 21);
            this.cbx_CryptoStandard.TabIndex = 12;
            // 
            // btnCert
            // 
            this.btnCert.Location = new System.Drawing.Point(477, 32);
            this.btnCert.Name = "btnCert";
            this.btnCert.Size = new System.Drawing.Size(140, 23);
            this.btnCert.TabIndex = 13;
            this.btnCert.Text = "Choose Certificate";
            this.btnCert.UseVisualStyleBackColor = true;
            this.btnCert.Click += new System.EventHandler(this.btnCert_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 452);
            this.Controls.Add(this.btnCert);
            this.Controls.Add(this.cbx_CryptoStandard);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbx_DigestAlgoritham);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_sign);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_location);
            this.Controls.Add(this.txt_reason);
            this.Controls.Add(this.btn_destination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ChoosFile);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_ChoosFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_destination;
        private System.Windows.Forms.TextBox txt_reason;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_sign;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_DigestAlgoritham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_CryptoStandard;
        private System.Windows.Forms.Button btnCert;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

