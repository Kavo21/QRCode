namespace ReadExcel
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.QRcodeImage = new System.Windows.Forms.PictureBox();
            this.txtInputword = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.ShowQRcode = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QRcodeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowQRcode)).BeginInit();
            this.SuspendLayout();
            // 
            // QRcodeImage
            // 
            this.QRcodeImage.Location = new System.Drawing.Point(23, 68);
            this.QRcodeImage.Name = "QRcodeImage";
            this.QRcodeImage.Size = new System.Drawing.Size(316, 281);
            this.QRcodeImage.TabIndex = 0;
            this.QRcodeImage.TabStop = false;
            // 
            // txtInputword
            // 
            this.txtInputword.Location = new System.Drawing.Point(23, 28);
            this.txtInputword.Name = "txtInputword";
            this.txtInputword.Size = new System.Drawing.Size(258, 22);
            this.txtInputword.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(287, 28);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(52, 22);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // ShowQRcode
            // 
            this.ShowQRcode.Location = new System.Drawing.Point(361, 68);
            this.ShowQRcode.Name = "ShowQRcode";
            this.ShowQRcode.Size = new System.Drawing.Size(316, 281);
            this.ShowQRcode.TabIndex = 3;
            this.ShowQRcode.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(703, 359);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowQRcode);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtInputword);
            this.Controls.Add(this.QRcodeImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.QRcodeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowQRcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox QRcodeImage;
        private System.Windows.Forms.TextBox txtInputword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox ShowQRcode;
        private System.Windows.Forms.Button button1;
    }
}

