using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode;
using MessagingToolkit.QRCode.Codec.Data;

namespace ReadExcel
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtInputword.Text)) {
                MessageBox.Show("Please input data");
                return;
            }

            using (SaveFileDialog save = new SaveFileDialog() { Filter = "JPEG|*.jpg" })
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    MessagingToolkit.QRCode.Codec.QRCodeEncoder QREncoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder
                    {
                        QRCodeScale = 8
                    };

                    Bitmap bitmap = QREncoder.Encode(txtInputword.Text);

                    QRcodeImage.Image = bitmap;

                    QRcodeImage.SizeMode = PictureBoxSizeMode.Zoom;

                    bitmap.Save(save.FileName, ImageFormat.Jpeg);
                   
                }
            }
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })

                if (open.ShowDialog() == DialogResult.OK) {
                    ShowQRcode.Image = Image.FromFile(open.FileName);
                    MessagingToolkit.QRCode.Codec.QRCodeDecoder QRDecoder = new MessagingToolkit.QRCode.Codec.QRCodeDecoder();
                    MessageBox.Show(QRDecoder.Decode(new QRCodeBitmapImage(ShowQRcode.Image as Bitmap)));
                }                   
        }
    }
}
