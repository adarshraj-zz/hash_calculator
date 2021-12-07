namespace HashCalculator {
    partial class HashCompare {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HashCompare));
            this.lblSelectFile = new System.Windows.Forms.Label();
            this.txtSelectFile = new System.Windows.Forms.TextBox();
            this.btnFile = new System.Windows.Forms.Button();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.lblHash = new System.Windows.Forms.Label();
            this.btnMd5 = new System.Windows.Forms.RadioButton();
            this.btnSha1 = new System.Windows.Forms.RadioButton();
            this.btnSha256 = new System.Windows.Forms.RadioButton();
            this.btnSha384 = new System.Windows.Forms.RadioButton();
            this.btnSha512 = new System.Windows.Forms.RadioButton();
            this.btnCompare = new System.Windows.Forms.Button();
            this.ofdHC = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblSelectFile
            // 
            this.lblSelectFile.AutoSize = true;
            this.lblSelectFile.Location = new System.Drawing.Point(10, 10);
            this.lblSelectFile.Name = "lblSelectFile";
            this.lblSelectFile.Size = new System.Drawing.Size(55, 13);
            this.lblSelectFile.TabIndex = 0;
            this.lblSelectFile.Text = "Select File";
            // 
            // txtSelectFile
            // 
            this.txtSelectFile.Location = new System.Drawing.Point(73, 6);
            this.txtSelectFile.Name = "txtSelectFile";
            this.txtSelectFile.Size = new System.Drawing.Size(297, 21);
            this.txtSelectFile.TabIndex = 1;
            this.txtSelectFile.TabStop = false;
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(381, 6);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(75, 21);
            this.btnFile.TabIndex = 2;
            this.btnFile.Text = "Open";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(73, 33);
            this.txtHash.Multiline = true;
            this.txtHash.Name = "txtHash";
            this.txtHash.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHash.Size = new System.Drawing.Size(383, 32);
            this.txtHash.TabIndex = 3;
            // 
            // lblHash
            // 
            this.lblHash.AutoSize = true;
            this.lblHash.Location = new System.Drawing.Point(12, 36);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(60, 13);
            this.lblHash.TabIndex = 4;
            this.lblHash.Text = "Enter Hash";
            // 
            // btnMd5
            // 
            this.btnMd5.AutoSize = true;
            this.btnMd5.Location = new System.Drawing.Point(132, 71);
            this.btnMd5.Name = "btnMd5";
            this.btnMd5.Size = new System.Drawing.Size(46, 17);
            this.btnMd5.TabIndex = 5;
            this.btnMd5.TabStop = true;
            this.btnMd5.Text = "MD5";
            this.btnMd5.UseVisualStyleBackColor = true;
            // 
            // btnSha1
            // 
            this.btnSha1.AutoSize = true;
            this.btnSha1.Location = new System.Drawing.Point(184, 71);
            this.btnSha1.Name = "btnSha1";
            this.btnSha1.Size = new System.Drawing.Size(54, 17);
            this.btnSha1.TabIndex = 6;
            this.btnSha1.TabStop = true;
            this.btnSha1.Text = "SHA 1";
            this.btnSha1.UseVisualStyleBackColor = true;
            // 
            // btnSha256
            // 
            this.btnSha256.AutoSize = true;
            this.btnSha256.Location = new System.Drawing.Point(244, 71);
            this.btnSha256.Name = "btnSha256";
            this.btnSha256.Size = new System.Drawing.Size(66, 17);
            this.btnSha256.TabIndex = 7;
            this.btnSha256.TabStop = true;
            this.btnSha256.Text = "SHA 256";
            this.btnSha256.UseVisualStyleBackColor = true;
            // 
            // btnSha384
            // 
            this.btnSha384.AutoSize = true;
            this.btnSha384.Location = new System.Drawing.Point(316, 71);
            this.btnSha384.Name = "btnSha384";
            this.btnSha384.Size = new System.Drawing.Size(66, 17);
            this.btnSha384.TabIndex = 8;
            this.btnSha384.TabStop = true;
            this.btnSha384.Text = "SHA 384";
            this.btnSha384.UseVisualStyleBackColor = true;
            // 
            // btnSha512
            // 
            this.btnSha512.AutoSize = true;
            this.btnSha512.Location = new System.Drawing.Point(388, 71);
            this.btnSha512.Name = "btnSha512";
            this.btnSha512.Size = new System.Drawing.Size(66, 17);
            this.btnSha512.TabIndex = 9;
            this.btnSha512.TabStop = true;
            this.btnSha512.Text = "SHA 512";
            this.btnSha512.UseVisualStyleBackColor = true;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(12, 68);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(104, 23);
            this.btnCompare.TabIndex = 10;
            this.btnCompare.Text = "Check";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // ofdHC
            // 
            this.ofdHC.Filter = "All Files | *.*";
            // 
            // HashCompare
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 93);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnSha512);
            this.Controls.Add(this.btnSha384);
            this.Controls.Add(this.btnSha256);
            this.Controls.Add(this.btnSha1);
            this.Controls.Add(this.btnMd5);
            this.Controls.Add(this.lblHash);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.txtSelectFile);
            this.Controls.Add(this.lblSelectFile);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HashCompare";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hash Compare";
            this.TopMost = true;
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.HashCompare_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.HashCompare_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectFile;
        private System.Windows.Forms.TextBox txtSelectFile;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.Label lblHash;
        private System.Windows.Forms.RadioButton btnMd5;
        private System.Windows.Forms.RadioButton btnSha1;
        private System.Windows.Forms.RadioButton btnSha256;
        private System.Windows.Forms.RadioButton btnSha384;
        private System.Windows.Forms.RadioButton btnSha512;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.OpenFileDialog ofdHC;
    }
}